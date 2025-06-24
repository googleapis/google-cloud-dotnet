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
    using Google.Cloud.DeveloperConnect.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInsightsConfigServiceClientSnippets
    {
        /// <summary>Snippet for ListInsightsConfigs</summary>
        public void ListInsightsConfigsRequestObject()
        {
            // Snippet: ListInsightsConfigs(ListInsightsConfigsRequest, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            ListInsightsConfigsRequest request = new ListInsightsConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInsightsConfigsResponse, InsightsConfig> response = insightsConfigServiceClient.ListInsightsConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InsightsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInsightsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InsightsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InsightsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InsightsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInsightsConfigsAsync</summary>
        public async Task ListInsightsConfigsRequestObjectAsync()
        {
            // Snippet: ListInsightsConfigsAsync(ListInsightsConfigsRequest, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListInsightsConfigsRequest request = new ListInsightsConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInsightsConfigsResponse, InsightsConfig> response = insightsConfigServiceClient.ListInsightsConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InsightsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInsightsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InsightsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InsightsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InsightsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInsightsConfigs</summary>
        public void ListInsightsConfigs()
        {
            // Snippet: ListInsightsConfigs(string, string, int?, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInsightsConfigsResponse, InsightsConfig> response = insightsConfigServiceClient.ListInsightsConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InsightsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInsightsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InsightsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InsightsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InsightsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInsightsConfigsAsync</summary>
        public async Task ListInsightsConfigsAsync()
        {
            // Snippet: ListInsightsConfigsAsync(string, string, int?, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInsightsConfigsResponse, InsightsConfig> response = insightsConfigServiceClient.ListInsightsConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InsightsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInsightsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InsightsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InsightsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InsightsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInsightsConfigs</summary>
        public void ListInsightsConfigsResourceNames()
        {
            // Snippet: ListInsightsConfigs(LocationName, string, int?, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInsightsConfigsResponse, InsightsConfig> response = insightsConfigServiceClient.ListInsightsConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InsightsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInsightsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InsightsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InsightsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InsightsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInsightsConfigsAsync</summary>
        public async Task ListInsightsConfigsResourceNamesAsync()
        {
            // Snippet: ListInsightsConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInsightsConfigsResponse, InsightsConfig> response = insightsConfigServiceClient.ListInsightsConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InsightsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInsightsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InsightsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InsightsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InsightsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateInsightsConfig</summary>
        public void CreateInsightsConfigRequestObject()
        {
            // Snippet: CreateInsightsConfig(CreateInsightsConfigRequest, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            CreateInsightsConfigRequest request = new CreateInsightsConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InsightsConfigId = "",
                InsightsConfig = new InsightsConfig(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = insightsConfigServiceClient.CreateInsightsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = insightsConfigServiceClient.PollOnceCreateInsightsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInsightsConfigAsync</summary>
        public async Task CreateInsightsConfigRequestObjectAsync()
        {
            // Snippet: CreateInsightsConfigAsync(CreateInsightsConfigRequest, CallSettings)
            // Additional: CreateInsightsConfigAsync(CreateInsightsConfigRequest, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateInsightsConfigRequest request = new CreateInsightsConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InsightsConfigId = "",
                InsightsConfig = new InsightsConfig(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = await insightsConfigServiceClient.CreateInsightsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = await insightsConfigServiceClient.PollOnceCreateInsightsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInsightsConfig</summary>
        public void CreateInsightsConfig()
        {
            // Snippet: CreateInsightsConfig(string, InsightsConfig, string, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InsightsConfig insightsConfig = new InsightsConfig();
            string insightsConfigId = "";
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = insightsConfigServiceClient.CreateInsightsConfig(parent, insightsConfig, insightsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = insightsConfigServiceClient.PollOnceCreateInsightsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInsightsConfigAsync</summary>
        public async Task CreateInsightsConfigAsync()
        {
            // Snippet: CreateInsightsConfigAsync(string, InsightsConfig, string, CallSettings)
            // Additional: CreateInsightsConfigAsync(string, InsightsConfig, string, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InsightsConfig insightsConfig = new InsightsConfig();
            string insightsConfigId = "";
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = await insightsConfigServiceClient.CreateInsightsConfigAsync(parent, insightsConfig, insightsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = await insightsConfigServiceClient.PollOnceCreateInsightsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInsightsConfig</summary>
        public void CreateInsightsConfigResourceNames()
        {
            // Snippet: CreateInsightsConfig(LocationName, InsightsConfig, string, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InsightsConfig insightsConfig = new InsightsConfig();
            string insightsConfigId = "";
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = insightsConfigServiceClient.CreateInsightsConfig(parent, insightsConfig, insightsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = insightsConfigServiceClient.PollOnceCreateInsightsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInsightsConfigAsync</summary>
        public async Task CreateInsightsConfigResourceNamesAsync()
        {
            // Snippet: CreateInsightsConfigAsync(LocationName, InsightsConfig, string, CallSettings)
            // Additional: CreateInsightsConfigAsync(LocationName, InsightsConfig, string, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InsightsConfig insightsConfig = new InsightsConfig();
            string insightsConfigId = "";
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = await insightsConfigServiceClient.CreateInsightsConfigAsync(parent, insightsConfig, insightsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = await insightsConfigServiceClient.PollOnceCreateInsightsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetInsightsConfig</summary>
        public void GetInsightsConfigRequestObject()
        {
            // Snippet: GetInsightsConfig(GetInsightsConfigRequest, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            GetInsightsConfigRequest request = new GetInsightsConfigRequest
            {
                InsightsConfigName = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]"),
            };
            // Make the request
            InsightsConfig response = insightsConfigServiceClient.GetInsightsConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetInsightsConfigAsync</summary>
        public async Task GetInsightsConfigRequestObjectAsync()
        {
            // Snippet: GetInsightsConfigAsync(GetInsightsConfigRequest, CallSettings)
            // Additional: GetInsightsConfigAsync(GetInsightsConfigRequest, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetInsightsConfigRequest request = new GetInsightsConfigRequest
            {
                InsightsConfigName = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]"),
            };
            // Make the request
            InsightsConfig response = await insightsConfigServiceClient.GetInsightsConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInsightsConfig</summary>
        public void GetInsightsConfig()
        {
            // Snippet: GetInsightsConfig(string, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/insightsConfigs/[INSIGHTS_CONFIG]";
            // Make the request
            InsightsConfig response = insightsConfigServiceClient.GetInsightsConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetInsightsConfigAsync</summary>
        public async Task GetInsightsConfigAsync()
        {
            // Snippet: GetInsightsConfigAsync(string, CallSettings)
            // Additional: GetInsightsConfigAsync(string, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/insightsConfigs/[INSIGHTS_CONFIG]";
            // Make the request
            InsightsConfig response = await insightsConfigServiceClient.GetInsightsConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInsightsConfig</summary>
        public void GetInsightsConfigResourceNames()
        {
            // Snippet: GetInsightsConfig(InsightsConfigName, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            InsightsConfigName name = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]");
            // Make the request
            InsightsConfig response = insightsConfigServiceClient.GetInsightsConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetInsightsConfigAsync</summary>
        public async Task GetInsightsConfigResourceNamesAsync()
        {
            // Snippet: GetInsightsConfigAsync(InsightsConfigName, CallSettings)
            // Additional: GetInsightsConfigAsync(InsightsConfigName, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsightsConfigName name = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]");
            // Make the request
            InsightsConfig response = await insightsConfigServiceClient.GetInsightsConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateInsightsConfig</summary>
        public void UpdateInsightsConfigRequestObject()
        {
            // Snippet: UpdateInsightsConfig(UpdateInsightsConfigRequest, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            UpdateInsightsConfigRequest request = new UpdateInsightsConfigRequest
            {
                InsightsConfig = new InsightsConfig(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = insightsConfigServiceClient.UpdateInsightsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = insightsConfigServiceClient.PollOnceUpdateInsightsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInsightsConfigAsync</summary>
        public async Task UpdateInsightsConfigRequestObjectAsync()
        {
            // Snippet: UpdateInsightsConfigAsync(UpdateInsightsConfigRequest, CallSettings)
            // Additional: UpdateInsightsConfigAsync(UpdateInsightsConfigRequest, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInsightsConfigRequest request = new UpdateInsightsConfigRequest
            {
                InsightsConfig = new InsightsConfig(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<InsightsConfig, OperationMetadata> response = await insightsConfigServiceClient.UpdateInsightsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InsightsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InsightsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InsightsConfig, OperationMetadata> retrievedResponse = await insightsConfigServiceClient.PollOnceUpdateInsightsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InsightsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInsightsConfig</summary>
        public void DeleteInsightsConfigRequestObject()
        {
            // Snippet: DeleteInsightsConfig(DeleteInsightsConfigRequest, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            DeleteInsightsConfigRequest request = new DeleteInsightsConfigRequest
            {
                InsightsConfigName = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = insightsConfigServiceClient.DeleteInsightsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = insightsConfigServiceClient.PollOnceDeleteInsightsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInsightsConfigAsync</summary>
        public async Task DeleteInsightsConfigRequestObjectAsync()
        {
            // Snippet: DeleteInsightsConfigAsync(DeleteInsightsConfigRequest, CallSettings)
            // Additional: DeleteInsightsConfigAsync(DeleteInsightsConfigRequest, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInsightsConfigRequest request = new DeleteInsightsConfigRequest
            {
                InsightsConfigName = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await insightsConfigServiceClient.DeleteInsightsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await insightsConfigServiceClient.PollOnceDeleteInsightsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInsightsConfig</summary>
        public void DeleteInsightsConfig()
        {
            // Snippet: DeleteInsightsConfig(string, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/insightsConfigs/[INSIGHTS_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = insightsConfigServiceClient.DeleteInsightsConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = insightsConfigServiceClient.PollOnceDeleteInsightsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInsightsConfigAsync</summary>
        public async Task DeleteInsightsConfigAsync()
        {
            // Snippet: DeleteInsightsConfigAsync(string, CallSettings)
            // Additional: DeleteInsightsConfigAsync(string, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/insightsConfigs/[INSIGHTS_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await insightsConfigServiceClient.DeleteInsightsConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await insightsConfigServiceClient.PollOnceDeleteInsightsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInsightsConfig</summary>
        public void DeleteInsightsConfigResourceNames()
        {
            // Snippet: DeleteInsightsConfig(InsightsConfigName, CallSettings)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = InsightsConfigServiceClient.Create();
            // Initialize request argument(s)
            InsightsConfigName name = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = insightsConfigServiceClient.DeleteInsightsConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = insightsConfigServiceClient.PollOnceDeleteInsightsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInsightsConfigAsync</summary>
        public async Task DeleteInsightsConfigResourceNamesAsync()
        {
            // Snippet: DeleteInsightsConfigAsync(InsightsConfigName, CallSettings)
            // Additional: DeleteInsightsConfigAsync(InsightsConfigName, CancellationToken)
            // Create client
            InsightsConfigServiceClient insightsConfigServiceClient = await InsightsConfigServiceClient.CreateAsync();
            // Initialize request argument(s)
            InsightsConfigName name = InsightsConfigName.FromProjectLocationInsightsConfig("[PROJECT]", "[LOCATION]", "[INSIGHTS_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await insightsConfigServiceClient.DeleteInsightsConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await insightsConfigServiceClient.PollOnceDeleteInsightsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
