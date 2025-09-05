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
    using Google.Cloud.NetworkConnectivity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataTransferServiceClientSnippets
    {
        /// <summary>Snippet for ListMulticloudDataTransferConfigs</summary>
        public void ListMulticloudDataTransferConfigsRequestObject()
        {
            // Snippet: ListMulticloudDataTransferConfigs(ListMulticloudDataTransferConfigsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListMulticloudDataTransferConfigsRequest request = new ListMulticloudDataTransferConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> response = dataTransferServiceClient.ListMulticloudDataTransferConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MulticloudDataTransferConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMulticloudDataTransferConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferConfigsAsync</summary>
        public async Task ListMulticloudDataTransferConfigsRequestObjectAsync()
        {
            // Snippet: ListMulticloudDataTransferConfigsAsync(ListMulticloudDataTransferConfigsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMulticloudDataTransferConfigsRequest request = new ListMulticloudDataTransferConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> response = dataTransferServiceClient.ListMulticloudDataTransferConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MulticloudDataTransferConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMulticloudDataTransferConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferConfigs</summary>
        public void ListMulticloudDataTransferConfigs()
        {
            // Snippet: ListMulticloudDataTransferConfigs(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> response = dataTransferServiceClient.ListMulticloudDataTransferConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MulticloudDataTransferConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMulticloudDataTransferConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferConfigsAsync</summary>
        public async Task ListMulticloudDataTransferConfigsAsync()
        {
            // Snippet: ListMulticloudDataTransferConfigsAsync(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> response = dataTransferServiceClient.ListMulticloudDataTransferConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MulticloudDataTransferConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMulticloudDataTransferConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferConfigs</summary>
        public void ListMulticloudDataTransferConfigsResourceNames()
        {
            // Snippet: ListMulticloudDataTransferConfigs(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> response = dataTransferServiceClient.ListMulticloudDataTransferConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MulticloudDataTransferConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMulticloudDataTransferConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferConfigsAsync</summary>
        public async Task ListMulticloudDataTransferConfigsResourceNamesAsync()
        {
            // Snippet: ListMulticloudDataTransferConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMulticloudDataTransferConfigsResponse, MulticloudDataTransferConfig> response = dataTransferServiceClient.ListMulticloudDataTransferConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MulticloudDataTransferConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMulticloudDataTransferConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferConfig</summary>
        public void GetMulticloudDataTransferConfigRequestObject()
        {
            // Snippet: GetMulticloudDataTransferConfig(GetMulticloudDataTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetMulticloudDataTransferConfigRequest request = new GetMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
            };
            // Make the request
            MulticloudDataTransferConfig response = dataTransferServiceClient.GetMulticloudDataTransferConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferConfigAsync</summary>
        public async Task GetMulticloudDataTransferConfigRequestObjectAsync()
        {
            // Snippet: GetMulticloudDataTransferConfigAsync(GetMulticloudDataTransferConfigRequest, CallSettings)
            // Additional: GetMulticloudDataTransferConfigAsync(GetMulticloudDataTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMulticloudDataTransferConfigRequest request = new GetMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
            };
            // Make the request
            MulticloudDataTransferConfig response = await dataTransferServiceClient.GetMulticloudDataTransferConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferConfig</summary>
        public void GetMulticloudDataTransferConfig()
        {
            // Snippet: GetMulticloudDataTransferConfig(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            // Make the request
            MulticloudDataTransferConfig response = dataTransferServiceClient.GetMulticloudDataTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferConfigAsync</summary>
        public async Task GetMulticloudDataTransferConfigAsync()
        {
            // Snippet: GetMulticloudDataTransferConfigAsync(string, CallSettings)
            // Additional: GetMulticloudDataTransferConfigAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            // Make the request
            MulticloudDataTransferConfig response = await dataTransferServiceClient.GetMulticloudDataTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferConfig</summary>
        public void GetMulticloudDataTransferConfigResourceNames()
        {
            // Snippet: GetMulticloudDataTransferConfig(MulticloudDataTransferConfigName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName name = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            // Make the request
            MulticloudDataTransferConfig response = dataTransferServiceClient.GetMulticloudDataTransferConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferConfigAsync</summary>
        public async Task GetMulticloudDataTransferConfigResourceNamesAsync()
        {
            // Snippet: GetMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName, CallSettings)
            // Additional: GetMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName name = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            // Make the request
            MulticloudDataTransferConfig response = await dataTransferServiceClient.GetMulticloudDataTransferConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMulticloudDataTransferConfig</summary>
        public void CreateMulticloudDataTransferConfigRequestObject()
        {
            // Snippet: CreateMulticloudDataTransferConfig(CreateMulticloudDataTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CreateMulticloudDataTransferConfigRequest request = new CreateMulticloudDataTransferConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MulticloudDataTransferConfigId = "",
                MulticloudDataTransferConfig = new MulticloudDataTransferConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = dataTransferServiceClient.CreateMulticloudDataTransferConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceCreateMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMulticloudDataTransferConfigAsync</summary>
        public async Task CreateMulticloudDataTransferConfigRequestObjectAsync()
        {
            // Snippet: CreateMulticloudDataTransferConfigAsync(CreateMulticloudDataTransferConfigRequest, CallSettings)
            // Additional: CreateMulticloudDataTransferConfigAsync(CreateMulticloudDataTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMulticloudDataTransferConfigRequest request = new CreateMulticloudDataTransferConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MulticloudDataTransferConfigId = "",
                MulticloudDataTransferConfig = new MulticloudDataTransferConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = await dataTransferServiceClient.CreateMulticloudDataTransferConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceCreateMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMulticloudDataTransferConfig</summary>
        public void CreateMulticloudDataTransferConfig()
        {
            // Snippet: CreateMulticloudDataTransferConfig(string, MulticloudDataTransferConfig, string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MulticloudDataTransferConfig multicloudDataTransferConfig = new MulticloudDataTransferConfig();
            string multicloudDataTransferConfigId = "";
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = dataTransferServiceClient.CreateMulticloudDataTransferConfig(parent, multicloudDataTransferConfig, multicloudDataTransferConfigId);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceCreateMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMulticloudDataTransferConfigAsync</summary>
        public async Task CreateMulticloudDataTransferConfigAsync()
        {
            // Snippet: CreateMulticloudDataTransferConfigAsync(string, MulticloudDataTransferConfig, string, CallSettings)
            // Additional: CreateMulticloudDataTransferConfigAsync(string, MulticloudDataTransferConfig, string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MulticloudDataTransferConfig multicloudDataTransferConfig = new MulticloudDataTransferConfig();
            string multicloudDataTransferConfigId = "";
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = await dataTransferServiceClient.CreateMulticloudDataTransferConfigAsync(parent, multicloudDataTransferConfig, multicloudDataTransferConfigId);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceCreateMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMulticloudDataTransferConfig</summary>
        public void CreateMulticloudDataTransferConfigResourceNames()
        {
            // Snippet: CreateMulticloudDataTransferConfig(LocationName, MulticloudDataTransferConfig, string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MulticloudDataTransferConfig multicloudDataTransferConfig = new MulticloudDataTransferConfig();
            string multicloudDataTransferConfigId = "";
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = dataTransferServiceClient.CreateMulticloudDataTransferConfig(parent, multicloudDataTransferConfig, multicloudDataTransferConfigId);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceCreateMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMulticloudDataTransferConfigAsync</summary>
        public async Task CreateMulticloudDataTransferConfigResourceNamesAsync()
        {
            // Snippet: CreateMulticloudDataTransferConfigAsync(LocationName, MulticloudDataTransferConfig, string, CallSettings)
            // Additional: CreateMulticloudDataTransferConfigAsync(LocationName, MulticloudDataTransferConfig, string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MulticloudDataTransferConfig multicloudDataTransferConfig = new MulticloudDataTransferConfig();
            string multicloudDataTransferConfigId = "";
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = await dataTransferServiceClient.CreateMulticloudDataTransferConfigAsync(parent, multicloudDataTransferConfig, multicloudDataTransferConfigId);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceCreateMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMulticloudDataTransferConfig</summary>
        public void UpdateMulticloudDataTransferConfigRequestObject()
        {
            // Snippet: UpdateMulticloudDataTransferConfig(UpdateMulticloudDataTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            UpdateMulticloudDataTransferConfigRequest request = new UpdateMulticloudDataTransferConfigRequest
            {
                UpdateMask = new FieldMask(),
                MulticloudDataTransferConfig = new MulticloudDataTransferConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = dataTransferServiceClient.UpdateMulticloudDataTransferConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceUpdateMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMulticloudDataTransferConfigAsync</summary>
        public async Task UpdateMulticloudDataTransferConfigRequestObjectAsync()
        {
            // Snippet: UpdateMulticloudDataTransferConfigAsync(UpdateMulticloudDataTransferConfigRequest, CallSettings)
            // Additional: UpdateMulticloudDataTransferConfigAsync(UpdateMulticloudDataTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMulticloudDataTransferConfigRequest request = new UpdateMulticloudDataTransferConfigRequest
            {
                UpdateMask = new FieldMask(),
                MulticloudDataTransferConfig = new MulticloudDataTransferConfig(),
                RequestId = "",
            };
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = await dataTransferServiceClient.UpdateMulticloudDataTransferConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceUpdateMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMulticloudDataTransferConfig</summary>
        public void UpdateMulticloudDataTransferConfig()
        {
            // Snippet: UpdateMulticloudDataTransferConfig(MulticloudDataTransferConfig, FieldMask, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            MulticloudDataTransferConfig multicloudDataTransferConfig = new MulticloudDataTransferConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = dataTransferServiceClient.UpdateMulticloudDataTransferConfig(multicloudDataTransferConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceUpdateMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMulticloudDataTransferConfigAsync</summary>
        public async Task UpdateMulticloudDataTransferConfigAsync()
        {
            // Snippet: UpdateMulticloudDataTransferConfigAsync(MulticloudDataTransferConfig, FieldMask, CallSettings)
            // Additional: UpdateMulticloudDataTransferConfigAsync(MulticloudDataTransferConfig, FieldMask, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            MulticloudDataTransferConfig multicloudDataTransferConfig = new MulticloudDataTransferConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MulticloudDataTransferConfig, OperationMetadata> response = await dataTransferServiceClient.UpdateMulticloudDataTransferConfigAsync(multicloudDataTransferConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MulticloudDataTransferConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MulticloudDataTransferConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MulticloudDataTransferConfig, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceUpdateMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MulticloudDataTransferConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMulticloudDataTransferConfig</summary>
        public void DeleteMulticloudDataTransferConfigRequestObject()
        {
            // Snippet: DeleteMulticloudDataTransferConfig(DeleteMulticloudDataTransferConfigRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteMulticloudDataTransferConfigRequest request = new DeleteMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataTransferServiceClient.DeleteMulticloudDataTransferConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceDeleteMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMulticloudDataTransferConfigAsync</summary>
        public async Task DeleteMulticloudDataTransferConfigRequestObjectAsync()
        {
            // Snippet: DeleteMulticloudDataTransferConfigAsync(DeleteMulticloudDataTransferConfigRequest, CallSettings)
            // Additional: DeleteMulticloudDataTransferConfigAsync(DeleteMulticloudDataTransferConfigRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMulticloudDataTransferConfigRequest request = new DeleteMulticloudDataTransferConfigRequest
            {
                MulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataTransferServiceClient.DeleteMulticloudDataTransferConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceDeleteMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMulticloudDataTransferConfig</summary>
        public void DeleteMulticloudDataTransferConfig()
        {
            // Snippet: DeleteMulticloudDataTransferConfig(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataTransferServiceClient.DeleteMulticloudDataTransferConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceDeleteMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMulticloudDataTransferConfigAsync</summary>
        public async Task DeleteMulticloudDataTransferConfigAsync()
        {
            // Snippet: DeleteMulticloudDataTransferConfigAsync(string, CallSettings)
            // Additional: DeleteMulticloudDataTransferConfigAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataTransferServiceClient.DeleteMulticloudDataTransferConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceDeleteMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMulticloudDataTransferConfig</summary>
        public void DeleteMulticloudDataTransferConfigResourceNames()
        {
            // Snippet: DeleteMulticloudDataTransferConfig(MulticloudDataTransferConfigName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName name = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataTransferServiceClient.DeleteMulticloudDataTransferConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceDeleteMulticloudDataTransferConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMulticloudDataTransferConfigAsync</summary>
        public async Task DeleteMulticloudDataTransferConfigResourceNamesAsync()
        {
            // Snippet: DeleteMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName, CallSettings)
            // Additional: DeleteMulticloudDataTransferConfigAsync(MulticloudDataTransferConfigName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName name = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataTransferServiceClient.DeleteMulticloudDataTransferConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceDeleteMulticloudDataTransferConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDestinations</summary>
        public void ListDestinationsRequestObject()
        {
            // Snippet: ListDestinations(ListDestinationsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListDestinationsRequest request = new ListDestinationsRequest
            {
                ParentAsMulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
                Filter = "",
                OrderBy = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListDestinationsResponse, Destination> response = dataTransferServiceClient.ListDestinations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Destination item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDestinationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Destination item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Destination> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Destination item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDestinationsAsync</summary>
        public async Task ListDestinationsRequestObjectAsync()
        {
            // Snippet: ListDestinationsAsync(ListDestinationsRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDestinationsRequest request = new ListDestinationsRequest
            {
                ParentAsMulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
                Filter = "",
                OrderBy = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListDestinationsResponse, Destination> response = dataTransferServiceClient.ListDestinationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Destination item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDestinationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Destination item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Destination> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Destination item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDestinations</summary>
        public void ListDestinations()
        {
            // Snippet: ListDestinations(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            // Make the request
            PagedEnumerable<ListDestinationsResponse, Destination> response = dataTransferServiceClient.ListDestinations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Destination item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDestinationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Destination item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Destination> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Destination item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDestinationsAsync</summary>
        public async Task ListDestinationsAsync()
        {
            // Snippet: ListDestinationsAsync(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListDestinationsResponse, Destination> response = dataTransferServiceClient.ListDestinationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Destination item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDestinationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Destination item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Destination> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Destination item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDestinations</summary>
        public void ListDestinationsResourceNames()
        {
            // Snippet: ListDestinations(MulticloudDataTransferConfigName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName parent = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            // Make the request
            PagedEnumerable<ListDestinationsResponse, Destination> response = dataTransferServiceClient.ListDestinations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Destination item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDestinationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Destination item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Destination> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Destination item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDestinationsAsync</summary>
        public async Task ListDestinationsResourceNamesAsync()
        {
            // Snippet: ListDestinationsAsync(MulticloudDataTransferConfigName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName parent = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListDestinationsResponse, Destination> response = dataTransferServiceClient.ListDestinationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Destination item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDestinationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Destination item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Destination> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Destination item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDestination</summary>
        public void GetDestinationRequestObject()
        {
            // Snippet: GetDestination(GetDestinationRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetDestinationRequest request = new GetDestinationRequest
            {
                DestinationName = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]"),
            };
            // Make the request
            Destination response = dataTransferServiceClient.GetDestination(request);
            // End snippet
        }

        /// <summary>Snippet for GetDestinationAsync</summary>
        public async Task GetDestinationRequestObjectAsync()
        {
            // Snippet: GetDestinationAsync(GetDestinationRequest, CallSettings)
            // Additional: GetDestinationAsync(GetDestinationRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDestinationRequest request = new GetDestinationRequest
            {
                DestinationName = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]"),
            };
            // Make the request
            Destination response = await dataTransferServiceClient.GetDestinationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDestination</summary>
        public void GetDestination()
        {
            // Snippet: GetDestination(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]/destinations/[DESTINATION]";
            // Make the request
            Destination response = dataTransferServiceClient.GetDestination(name);
            // End snippet
        }

        /// <summary>Snippet for GetDestinationAsync</summary>
        public async Task GetDestinationAsync()
        {
            // Snippet: GetDestinationAsync(string, CallSettings)
            // Additional: GetDestinationAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]/destinations/[DESTINATION]";
            // Make the request
            Destination response = await dataTransferServiceClient.GetDestinationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDestination</summary>
        public void GetDestinationResourceNames()
        {
            // Snippet: GetDestination(DestinationName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DestinationName name = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]");
            // Make the request
            Destination response = dataTransferServiceClient.GetDestination(name);
            // End snippet
        }

        /// <summary>Snippet for GetDestinationAsync</summary>
        public async Task GetDestinationResourceNamesAsync()
        {
            // Snippet: GetDestinationAsync(DestinationName, CallSettings)
            // Additional: GetDestinationAsync(DestinationName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DestinationName name = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]");
            // Make the request
            Destination response = await dataTransferServiceClient.GetDestinationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDestination</summary>
        public void CreateDestinationRequestObject()
        {
            // Snippet: CreateDestination(CreateDestinationRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            CreateDestinationRequest request = new CreateDestinationRequest
            {
                ParentAsMulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
                DestinationId = "",
                Destination = new Destination(),
                RequestId = "",
            };
            // Make the request
            Operation<Destination, OperationMetadata> response = dataTransferServiceClient.CreateDestination(request);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceCreateDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDestinationAsync</summary>
        public async Task CreateDestinationRequestObjectAsync()
        {
            // Snippet: CreateDestinationAsync(CreateDestinationRequest, CallSettings)
            // Additional: CreateDestinationAsync(CreateDestinationRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDestinationRequest request = new CreateDestinationRequest
            {
                ParentAsMulticloudDataTransferConfigName = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]"),
                DestinationId = "",
                Destination = new Destination(),
                RequestId = "",
            };
            // Make the request
            Operation<Destination, OperationMetadata> response = await dataTransferServiceClient.CreateDestinationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceCreateDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDestination</summary>
        public void CreateDestination()
        {
            // Snippet: CreateDestination(string, Destination, string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            Destination destination = new Destination();
            string destinationId = "";
            // Make the request
            Operation<Destination, OperationMetadata> response = dataTransferServiceClient.CreateDestination(parent, destination, destinationId);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceCreateDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDestinationAsync</summary>
        public async Task CreateDestinationAsync()
        {
            // Snippet: CreateDestinationAsync(string, Destination, string, CallSettings)
            // Additional: CreateDestinationAsync(string, Destination, string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]";
            Destination destination = new Destination();
            string destinationId = "";
            // Make the request
            Operation<Destination, OperationMetadata> response = await dataTransferServiceClient.CreateDestinationAsync(parent, destination, destinationId);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceCreateDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDestination</summary>
        public void CreateDestinationResourceNames()
        {
            // Snippet: CreateDestination(MulticloudDataTransferConfigName, Destination, string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName parent = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            Destination destination = new Destination();
            string destinationId = "";
            // Make the request
            Operation<Destination, OperationMetadata> response = dataTransferServiceClient.CreateDestination(parent, destination, destinationId);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceCreateDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDestinationAsync</summary>
        public async Task CreateDestinationResourceNamesAsync()
        {
            // Snippet: CreateDestinationAsync(MulticloudDataTransferConfigName, Destination, string, CallSettings)
            // Additional: CreateDestinationAsync(MulticloudDataTransferConfigName, Destination, string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            MulticloudDataTransferConfigName parent = MulticloudDataTransferConfigName.FromProjectLocationMulticloudDataTransferConfig("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]");
            Destination destination = new Destination();
            string destinationId = "";
            // Make the request
            Operation<Destination, OperationMetadata> response = await dataTransferServiceClient.CreateDestinationAsync(parent, destination, destinationId);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceCreateDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDestination</summary>
        public void UpdateDestinationRequestObject()
        {
            // Snippet: UpdateDestination(UpdateDestinationRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            UpdateDestinationRequest request = new UpdateDestinationRequest
            {
                UpdateMask = new FieldMask(),
                Destination = new Destination(),
                RequestId = "",
            };
            // Make the request
            Operation<Destination, OperationMetadata> response = dataTransferServiceClient.UpdateDestination(request);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceUpdateDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDestinationAsync</summary>
        public async Task UpdateDestinationRequestObjectAsync()
        {
            // Snippet: UpdateDestinationAsync(UpdateDestinationRequest, CallSettings)
            // Additional: UpdateDestinationAsync(UpdateDestinationRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDestinationRequest request = new UpdateDestinationRequest
            {
                UpdateMask = new FieldMask(),
                Destination = new Destination(),
                RequestId = "",
            };
            // Make the request
            Operation<Destination, OperationMetadata> response = await dataTransferServiceClient.UpdateDestinationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceUpdateDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDestination</summary>
        public void UpdateDestination()
        {
            // Snippet: UpdateDestination(Destination, FieldMask, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            Destination destination = new Destination();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Destination, OperationMetadata> response = dataTransferServiceClient.UpdateDestination(destination, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceUpdateDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDestinationAsync</summary>
        public async Task UpdateDestinationAsync()
        {
            // Snippet: UpdateDestinationAsync(Destination, FieldMask, CallSettings)
            // Additional: UpdateDestinationAsync(Destination, FieldMask, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            Destination destination = new Destination();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Destination, OperationMetadata> response = await dataTransferServiceClient.UpdateDestinationAsync(destination, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Destination, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Destination result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Destination, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceUpdateDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Destination retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDestination</summary>
        public void DeleteDestinationRequestObject()
        {
            // Snippet: DeleteDestination(DeleteDestinationRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DeleteDestinationRequest request = new DeleteDestinationRequest
            {
                DestinationName = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataTransferServiceClient.DeleteDestination(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceDeleteDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDestinationAsync</summary>
        public async Task DeleteDestinationRequestObjectAsync()
        {
            // Snippet: DeleteDestinationAsync(DeleteDestinationRequest, CallSettings)
            // Additional: DeleteDestinationAsync(DeleteDestinationRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDestinationRequest request = new DeleteDestinationRequest
            {
                DestinationName = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataTransferServiceClient.DeleteDestinationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceDeleteDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDestination</summary>
        public void DeleteDestination()
        {
            // Snippet: DeleteDestination(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]/destinations/[DESTINATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataTransferServiceClient.DeleteDestination(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceDeleteDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDestinationAsync</summary>
        public async Task DeleteDestinationAsync()
        {
            // Snippet: DeleteDestinationAsync(string, CallSettings)
            // Additional: DeleteDestinationAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferConfigs/[MULTICLOUD_DATA_TRANSFER_CONFIG]/destinations/[DESTINATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataTransferServiceClient.DeleteDestinationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceDeleteDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDestination</summary>
        public void DeleteDestinationResourceNames()
        {
            // Snippet: DeleteDestination(DestinationName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            DestinationName name = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataTransferServiceClient.DeleteDestination(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataTransferServiceClient.PollOnceDeleteDestination(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDestinationAsync</summary>
        public async Task DeleteDestinationResourceNamesAsync()
        {
            // Snippet: DeleteDestinationAsync(DestinationName, CallSettings)
            // Additional: DeleteDestinationAsync(DestinationName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            DestinationName name = DestinationName.FromProjectLocationMulticloudDataTransferConfigDestination("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_CONFIG]", "[DESTINATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataTransferServiceClient.DeleteDestinationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataTransferServiceClient.PollOnceDeleteDestinationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferSupportedService</summary>
        public void GetMulticloudDataTransferSupportedServiceRequestObject()
        {
            // Snippet: GetMulticloudDataTransferSupportedService(GetMulticloudDataTransferSupportedServiceRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            GetMulticloudDataTransferSupportedServiceRequest request = new GetMulticloudDataTransferSupportedServiceRequest
            {
                MulticloudDataTransferSupportedServiceName = MulticloudDataTransferSupportedServiceName.FromProjectLocationMulticloudDataTransferSupportedService("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_SUPPORTED_SERVICE]"),
            };
            // Make the request
            MulticloudDataTransferSupportedService response = dataTransferServiceClient.GetMulticloudDataTransferSupportedService(request);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferSupportedServiceAsync</summary>
        public async Task GetMulticloudDataTransferSupportedServiceRequestObjectAsync()
        {
            // Snippet: GetMulticloudDataTransferSupportedServiceAsync(GetMulticloudDataTransferSupportedServiceRequest, CallSettings)
            // Additional: GetMulticloudDataTransferSupportedServiceAsync(GetMulticloudDataTransferSupportedServiceRequest, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMulticloudDataTransferSupportedServiceRequest request = new GetMulticloudDataTransferSupportedServiceRequest
            {
                MulticloudDataTransferSupportedServiceName = MulticloudDataTransferSupportedServiceName.FromProjectLocationMulticloudDataTransferSupportedService("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_SUPPORTED_SERVICE]"),
            };
            // Make the request
            MulticloudDataTransferSupportedService response = await dataTransferServiceClient.GetMulticloudDataTransferSupportedServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferSupportedService</summary>
        public void GetMulticloudDataTransferSupportedService()
        {
            // Snippet: GetMulticloudDataTransferSupportedService(string, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferSupportedServices/[MULTICLOUD_DATA_TRANSFER_SUPPORTED_SERVICE]";
            // Make the request
            MulticloudDataTransferSupportedService response = dataTransferServiceClient.GetMulticloudDataTransferSupportedService(name);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferSupportedServiceAsync</summary>
        public async Task GetMulticloudDataTransferSupportedServiceAsync()
        {
            // Snippet: GetMulticloudDataTransferSupportedServiceAsync(string, CallSettings)
            // Additional: GetMulticloudDataTransferSupportedServiceAsync(string, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/multicloudDataTransferSupportedServices/[MULTICLOUD_DATA_TRANSFER_SUPPORTED_SERVICE]";
            // Make the request
            MulticloudDataTransferSupportedService response = await dataTransferServiceClient.GetMulticloudDataTransferSupportedServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferSupportedService</summary>
        public void GetMulticloudDataTransferSupportedServiceResourceNames()
        {
            // Snippet: GetMulticloudDataTransferSupportedService(MulticloudDataTransferSupportedServiceName, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            MulticloudDataTransferSupportedServiceName name = MulticloudDataTransferSupportedServiceName.FromProjectLocationMulticloudDataTransferSupportedService("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_SUPPORTED_SERVICE]");
            // Make the request
            MulticloudDataTransferSupportedService response = dataTransferServiceClient.GetMulticloudDataTransferSupportedService(name);
            // End snippet
        }

        /// <summary>Snippet for GetMulticloudDataTransferSupportedServiceAsync</summary>
        public async Task GetMulticloudDataTransferSupportedServiceResourceNamesAsync()
        {
            // Snippet: GetMulticloudDataTransferSupportedServiceAsync(MulticloudDataTransferSupportedServiceName, CallSettings)
            // Additional: GetMulticloudDataTransferSupportedServiceAsync(MulticloudDataTransferSupportedServiceName, CancellationToken)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            MulticloudDataTransferSupportedServiceName name = MulticloudDataTransferSupportedServiceName.FromProjectLocationMulticloudDataTransferSupportedService("[PROJECT]", "[LOCATION]", "[MULTICLOUD_DATA_TRANSFER_SUPPORTED_SERVICE]");
            // Make the request
            MulticloudDataTransferSupportedService response = await dataTransferServiceClient.GetMulticloudDataTransferSupportedServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferSupportedServices</summary>
        public void ListMulticloudDataTransferSupportedServicesRequestObject()
        {
            // Snippet: ListMulticloudDataTransferSupportedServices(ListMulticloudDataTransferSupportedServicesRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            ListMulticloudDataTransferSupportedServicesRequest request = new ListMulticloudDataTransferSupportedServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> response = dataTransferServiceClient.ListMulticloudDataTransferSupportedServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MulticloudDataTransferSupportedService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMulticloudDataTransferSupportedServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferSupportedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferSupportedService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferSupportedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferSupportedServicesAsync</summary>
        public async Task ListMulticloudDataTransferSupportedServicesRequestObjectAsync()
        {
            // Snippet: ListMulticloudDataTransferSupportedServicesAsync(ListMulticloudDataTransferSupportedServicesRequest, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMulticloudDataTransferSupportedServicesRequest request = new ListMulticloudDataTransferSupportedServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> response = dataTransferServiceClient.ListMulticloudDataTransferSupportedServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MulticloudDataTransferSupportedService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMulticloudDataTransferSupportedServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferSupportedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferSupportedService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferSupportedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferSupportedServices</summary>
        public void ListMulticloudDataTransferSupportedServices()
        {
            // Snippet: ListMulticloudDataTransferSupportedServices(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> response = dataTransferServiceClient.ListMulticloudDataTransferSupportedServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MulticloudDataTransferSupportedService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMulticloudDataTransferSupportedServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferSupportedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferSupportedService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferSupportedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferSupportedServicesAsync</summary>
        public async Task ListMulticloudDataTransferSupportedServicesAsync()
        {
            // Snippet: ListMulticloudDataTransferSupportedServicesAsync(string, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> response = dataTransferServiceClient.ListMulticloudDataTransferSupportedServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MulticloudDataTransferSupportedService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMulticloudDataTransferSupportedServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferSupportedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferSupportedService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferSupportedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferSupportedServices</summary>
        public void ListMulticloudDataTransferSupportedServicesResourceNames()
        {
            // Snippet: ListMulticloudDataTransferSupportedServices(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = DataTransferServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> response = dataTransferServiceClient.ListMulticloudDataTransferSupportedServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MulticloudDataTransferSupportedService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMulticloudDataTransferSupportedServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferSupportedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferSupportedService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferSupportedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMulticloudDataTransferSupportedServicesAsync</summary>
        public async Task ListMulticloudDataTransferSupportedServicesResourceNamesAsync()
        {
            // Snippet: ListMulticloudDataTransferSupportedServicesAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataTransferServiceClient dataTransferServiceClient = await DataTransferServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMulticloudDataTransferSupportedServicesResponse, MulticloudDataTransferSupportedService> response = dataTransferServiceClient.ListMulticloudDataTransferSupportedServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MulticloudDataTransferSupportedService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMulticloudDataTransferSupportedServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MulticloudDataTransferSupportedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MulticloudDataTransferSupportedService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MulticloudDataTransferSupportedService item in singlePage)
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
