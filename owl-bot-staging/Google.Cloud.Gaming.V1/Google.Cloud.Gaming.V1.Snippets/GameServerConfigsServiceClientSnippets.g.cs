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

namespace Google.Cloud.Gaming.V1.Snippets
{
    using Google.Api.Gax;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedGameServerConfigsServiceClientSnippets
    {
        /// <summary>Snippet for ListGameServerConfigs</summary>
        public void ListGameServerConfigsRequestObject()
        {
            // Snippet: ListGameServerConfigs(ListGameServerConfigsRequest, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            ListGameServerConfigsRequest request = new ListGameServerConfigsRequest
            {
                ParentAsGameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGameServerConfigsResponse, GameServerConfig> response = gameServerConfigsServiceClient.ListGameServerConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerConfigsAsync</summary>
        public async Task ListGameServerConfigsRequestObjectAsync()
        {
            // Snippet: ListGameServerConfigsAsync(ListGameServerConfigsRequest, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGameServerConfigsRequest request = new ListGameServerConfigsRequest
            {
                ParentAsGameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGameServerConfigsResponse, GameServerConfig> response = gameServerConfigsServiceClient.ListGameServerConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerConfigs</summary>
        public void ListGameServerConfigs()
        {
            // Snippet: ListGameServerConfigs(string, string, int?, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            PagedEnumerable<ListGameServerConfigsResponse, GameServerConfig> response = gameServerConfigsServiceClient.ListGameServerConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerConfigsAsync</summary>
        public async Task ListGameServerConfigsAsync()
        {
            // Snippet: ListGameServerConfigsAsync(string, string, int?, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            PagedAsyncEnumerable<ListGameServerConfigsResponse, GameServerConfig> response = gameServerConfigsServiceClient.ListGameServerConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerConfigs</summary>
        public void ListGameServerConfigsResourceNames()
        {
            // Snippet: ListGameServerConfigs(GameServerDeploymentName, string, int?, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            GameServerDeploymentName parent = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            PagedEnumerable<ListGameServerConfigsResponse, GameServerConfig> response = gameServerConfigsServiceClient.ListGameServerConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerConfigsAsync</summary>
        public async Task ListGameServerConfigsResourceNamesAsync()
        {
            // Snippet: ListGameServerConfigsAsync(GameServerDeploymentName, string, int?, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerDeploymentName parent = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            PagedAsyncEnumerable<ListGameServerConfigsResponse, GameServerConfig> response = gameServerConfigsServiceClient.ListGameServerConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGameServerConfig</summary>
        public void GetGameServerConfigRequestObject()
        {
            // Snippet: GetGameServerConfig(GetGameServerConfigRequest, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            // Make the request
            GameServerConfig response = gameServerConfigsServiceClient.GetGameServerConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerConfigAsync</summary>
        public async Task GetGameServerConfigRequestObjectAsync()
        {
            // Snippet: GetGameServerConfigAsync(GetGameServerConfigRequest, CallSettings)
            // Additional: GetGameServerConfigAsync(GetGameServerConfigRequest, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGameServerConfigRequest request = new GetGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            // Make the request
            GameServerConfig response = await gameServerConfigsServiceClient.GetGameServerConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerConfig</summary>
        public void GetGameServerConfig()
        {
            // Snippet: GetGameServerConfig(string, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]/configs/[CONFIG]";
            // Make the request
            GameServerConfig response = gameServerConfigsServiceClient.GetGameServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerConfigAsync</summary>
        public async Task GetGameServerConfigAsync()
        {
            // Snippet: GetGameServerConfigAsync(string, CallSettings)
            // Additional: GetGameServerConfigAsync(string, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]/configs/[CONFIG]";
            // Make the request
            GameServerConfig response = await gameServerConfigsServiceClient.GetGameServerConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerConfig</summary>
        public void GetGameServerConfigResourceNames()
        {
            // Snippet: GetGameServerConfig(GameServerConfigName, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            GameServerConfigName name = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]");
            // Make the request
            GameServerConfig response = gameServerConfigsServiceClient.GetGameServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerConfigAsync</summary>
        public async Task GetGameServerConfigResourceNamesAsync()
        {
            // Snippet: GetGameServerConfigAsync(GameServerConfigName, CallSettings)
            // Additional: GetGameServerConfigAsync(GameServerConfigName, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerConfigName name = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]");
            // Make the request
            GameServerConfig response = await gameServerConfigsServiceClient.GetGameServerConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerConfig</summary>
        public void CreateGameServerConfigRequestObject()
        {
            // Snippet: CreateGameServerConfig(CreateGameServerConfigRequest, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            CreateGameServerConfigRequest request = new CreateGameServerConfigRequest
            {
                ParentAsGameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                ConfigId = "",
                GameServerConfig = new GameServerConfig(),
            };
            // Make the request
            Operation<GameServerConfig, OperationMetadata> response = gameServerConfigsServiceClient.CreateGameServerConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerConfig, OperationMetadata> retrievedResponse = gameServerConfigsServiceClient.PollOnceCreateGameServerConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerConfigAsync</summary>
        public async Task CreateGameServerConfigRequestObjectAsync()
        {
            // Snippet: CreateGameServerConfigAsync(CreateGameServerConfigRequest, CallSettings)
            // Additional: CreateGameServerConfigAsync(CreateGameServerConfigRequest, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGameServerConfigRequest request = new CreateGameServerConfigRequest
            {
                ParentAsGameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
                ConfigId = "",
                GameServerConfig = new GameServerConfig(),
            };
            // Make the request
            Operation<GameServerConfig, OperationMetadata> response = await gameServerConfigsServiceClient.CreateGameServerConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerConfig, OperationMetadata> retrievedResponse = await gameServerConfigsServiceClient.PollOnceCreateGameServerConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerConfig</summary>
        public void CreateGameServerConfig()
        {
            // Snippet: CreateGameServerConfig(string, GameServerConfig, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            GameServerConfig gameServerConfig = new GameServerConfig();
            // Make the request
            Operation<GameServerConfig, OperationMetadata> response = gameServerConfigsServiceClient.CreateGameServerConfig(parent, gameServerConfig);

            // Poll until the returned long-running operation is complete
            Operation<GameServerConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerConfig, OperationMetadata> retrievedResponse = gameServerConfigsServiceClient.PollOnceCreateGameServerConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerConfigAsync</summary>
        public async Task CreateGameServerConfigAsync()
        {
            // Snippet: CreateGameServerConfigAsync(string, GameServerConfig, CallSettings)
            // Additional: CreateGameServerConfigAsync(string, GameServerConfig, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            GameServerConfig gameServerConfig = new GameServerConfig();
            // Make the request
            Operation<GameServerConfig, OperationMetadata> response = await gameServerConfigsServiceClient.CreateGameServerConfigAsync(parent, gameServerConfig);

            // Poll until the returned long-running operation is complete
            Operation<GameServerConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerConfig, OperationMetadata> retrievedResponse = await gameServerConfigsServiceClient.PollOnceCreateGameServerConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerConfig</summary>
        public void CreateGameServerConfigResourceNames()
        {
            // Snippet: CreateGameServerConfig(GameServerDeploymentName, GameServerConfig, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            GameServerDeploymentName parent = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            GameServerConfig gameServerConfig = new GameServerConfig();
            // Make the request
            Operation<GameServerConfig, OperationMetadata> response = gameServerConfigsServiceClient.CreateGameServerConfig(parent, gameServerConfig);

            // Poll until the returned long-running operation is complete
            Operation<GameServerConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerConfig, OperationMetadata> retrievedResponse = gameServerConfigsServiceClient.PollOnceCreateGameServerConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerConfigAsync</summary>
        public async Task CreateGameServerConfigResourceNamesAsync()
        {
            // Snippet: CreateGameServerConfigAsync(GameServerDeploymentName, GameServerConfig, CallSettings)
            // Additional: CreateGameServerConfigAsync(GameServerDeploymentName, GameServerConfig, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerDeploymentName parent = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            GameServerConfig gameServerConfig = new GameServerConfig();
            // Make the request
            Operation<GameServerConfig, OperationMetadata> response = await gameServerConfigsServiceClient.CreateGameServerConfigAsync(parent, gameServerConfig);

            // Poll until the returned long-running operation is complete
            Operation<GameServerConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerConfig, OperationMetadata> retrievedResponse = await gameServerConfigsServiceClient.PollOnceCreateGameServerConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerConfig</summary>
        public void DeleteGameServerConfigRequestObject()
        {
            // Snippet: DeleteGameServerConfig(DeleteGameServerConfigRequest, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            DeleteGameServerConfigRequest request = new DeleteGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerConfigsServiceClient.DeleteGameServerConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerConfigsServiceClient.PollOnceDeleteGameServerConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerConfigAsync</summary>
        public async Task DeleteGameServerConfigRequestObjectAsync()
        {
            // Snippet: DeleteGameServerConfigAsync(DeleteGameServerConfigRequest, CallSettings)
            // Additional: DeleteGameServerConfigAsync(DeleteGameServerConfigRequest, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGameServerConfigRequest request = new DeleteGameServerConfigRequest
            {
                GameServerConfigName = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerConfigsServiceClient.DeleteGameServerConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerConfigsServiceClient.PollOnceDeleteGameServerConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerConfig</summary>
        public void DeleteGameServerConfig()
        {
            // Snippet: DeleteGameServerConfig(string, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]/configs/[CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerConfigsServiceClient.DeleteGameServerConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerConfigsServiceClient.PollOnceDeleteGameServerConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerConfigAsync</summary>
        public async Task DeleteGameServerConfigAsync()
        {
            // Snippet: DeleteGameServerConfigAsync(string, CallSettings)
            // Additional: DeleteGameServerConfigAsync(string, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]/configs/[CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerConfigsServiceClient.DeleteGameServerConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerConfigsServiceClient.PollOnceDeleteGameServerConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerConfig</summary>
        public void DeleteGameServerConfigResourceNames()
        {
            // Snippet: DeleteGameServerConfig(GameServerConfigName, CallSettings)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = GameServerConfigsServiceClient.Create();
            // Initialize request argument(s)
            GameServerConfigName name = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerConfigsServiceClient.DeleteGameServerConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerConfigsServiceClient.PollOnceDeleteGameServerConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerConfigAsync</summary>
        public async Task DeleteGameServerConfigResourceNamesAsync()
        {
            // Snippet: DeleteGameServerConfigAsync(GameServerConfigName, CallSettings)
            // Additional: DeleteGameServerConfigAsync(GameServerConfigName, CancellationToken)
            // Create client
            GameServerConfigsServiceClient gameServerConfigsServiceClient = await GameServerConfigsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerConfigName name = GameServerConfigName.FromProjectLocationDeploymentConfig("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]", "[CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerConfigsServiceClient.DeleteGameServerConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerConfigsServiceClient.PollOnceDeleteGameServerConfigAsync(operationName);
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
