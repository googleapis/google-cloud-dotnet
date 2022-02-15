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
    using Google.Api.Gax.ResourceNames;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGameServerDeploymentsServiceClientSnippets
    {
        /// <summary>Snippet for ListGameServerDeployments</summary>
        public void ListGameServerDeploymentsRequestObject()
        {
            // Snippet: ListGameServerDeployments(ListGameServerDeploymentsRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            ListGameServerDeploymentsRequest request = new ListGameServerDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> response = gameServerDeploymentsServiceClient.ListGameServerDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerDeploymentsAsync</summary>
        public async Task ListGameServerDeploymentsRequestObjectAsync()
        {
            // Snippet: ListGameServerDeploymentsAsync(ListGameServerDeploymentsRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGameServerDeploymentsRequest request = new ListGameServerDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> response = gameServerDeploymentsServiceClient.ListGameServerDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerDeployments</summary>
        public void ListGameServerDeployments()
        {
            // Snippet: ListGameServerDeployments(string, string, int?, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> response = gameServerDeploymentsServiceClient.ListGameServerDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerDeploymentsAsync</summary>
        public async Task ListGameServerDeploymentsAsync()
        {
            // Snippet: ListGameServerDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> response = gameServerDeploymentsServiceClient.ListGameServerDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerDeployments</summary>
        public void ListGameServerDeploymentsResourceNames()
        {
            // Snippet: ListGameServerDeployments(LocationName, string, int?, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> response = gameServerDeploymentsServiceClient.ListGameServerDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerDeploymentsAsync</summary>
        public async Task ListGameServerDeploymentsResourceNamesAsync()
        {
            // Snippet: ListGameServerDeploymentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGameServerDeploymentsResponse, GameServerDeployment> response = gameServerDeploymentsServiceClient.ListGameServerDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeployment</summary>
        public void GetGameServerDeploymentRequestObject()
        {
            // Snippet: GetGameServerDeployment(GetGameServerDeploymentRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            GameServerDeployment response = gameServerDeploymentsServiceClient.GetGameServerDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentAsync</summary>
        public async Task GetGameServerDeploymentRequestObjectAsync()
        {
            // Snippet: GetGameServerDeploymentAsync(GetGameServerDeploymentRequest, CallSettings)
            // Additional: GetGameServerDeploymentAsync(GetGameServerDeploymentRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGameServerDeploymentRequest request = new GetGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            GameServerDeployment response = await gameServerDeploymentsServiceClient.GetGameServerDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeployment</summary>
        public void GetGameServerDeployment()
        {
            // Snippet: GetGameServerDeployment(string, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            GameServerDeployment response = gameServerDeploymentsServiceClient.GetGameServerDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentAsync</summary>
        public async Task GetGameServerDeploymentAsync()
        {
            // Snippet: GetGameServerDeploymentAsync(string, CallSettings)
            // Additional: GetGameServerDeploymentAsync(string, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            GameServerDeployment response = await gameServerDeploymentsServiceClient.GetGameServerDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeployment</summary>
        public void GetGameServerDeploymentResourceNames()
        {
            // Snippet: GetGameServerDeployment(GameServerDeploymentName, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GameServerDeploymentName name = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            GameServerDeployment response = gameServerDeploymentsServiceClient.GetGameServerDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentAsync</summary>
        public async Task GetGameServerDeploymentResourceNamesAsync()
        {
            // Snippet: GetGameServerDeploymentAsync(GameServerDeploymentName, CallSettings)
            // Additional: GetGameServerDeploymentAsync(GameServerDeploymentName, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerDeploymentName name = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            GameServerDeployment response = await gameServerDeploymentsServiceClient.GetGameServerDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerDeployment</summary>
        public void CreateGameServerDeploymentRequestObject()
        {
            // Snippet: CreateGameServerDeployment(CreateGameServerDeploymentRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            CreateGameServerDeploymentRequest request = new CreateGameServerDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentId = "",
                GameServerDeployment = new GameServerDeployment(),
            };
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = gameServerDeploymentsServiceClient.CreateGameServerDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceCreateGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerDeploymentAsync</summary>
        public async Task CreateGameServerDeploymentRequestObjectAsync()
        {
            // Snippet: CreateGameServerDeploymentAsync(CreateGameServerDeploymentRequest, CallSettings)
            // Additional: CreateGameServerDeploymentAsync(CreateGameServerDeploymentRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGameServerDeploymentRequest request = new CreateGameServerDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DeploymentId = "",
                GameServerDeployment = new GameServerDeployment(),
            };
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.CreateGameServerDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceCreateGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerDeployment</summary>
        public void CreateGameServerDeployment()
        {
            // Snippet: CreateGameServerDeployment(string, GameServerDeployment, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GameServerDeployment gameServerDeployment = new GameServerDeployment();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = gameServerDeploymentsServiceClient.CreateGameServerDeployment(parent, gameServerDeployment);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceCreateGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerDeploymentAsync</summary>
        public async Task CreateGameServerDeploymentAsync()
        {
            // Snippet: CreateGameServerDeploymentAsync(string, GameServerDeployment, CallSettings)
            // Additional: CreateGameServerDeploymentAsync(string, GameServerDeployment, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            GameServerDeployment gameServerDeployment = new GameServerDeployment();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.CreateGameServerDeploymentAsync(parent, gameServerDeployment);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceCreateGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerDeployment</summary>
        public void CreateGameServerDeploymentResourceNames()
        {
            // Snippet: CreateGameServerDeployment(LocationName, GameServerDeployment, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GameServerDeployment gameServerDeployment = new GameServerDeployment();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = gameServerDeploymentsServiceClient.CreateGameServerDeployment(parent, gameServerDeployment);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceCreateGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerDeploymentAsync</summary>
        public async Task CreateGameServerDeploymentResourceNamesAsync()
        {
            // Snippet: CreateGameServerDeploymentAsync(LocationName, GameServerDeployment, CallSettings)
            // Additional: CreateGameServerDeploymentAsync(LocationName, GameServerDeployment, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            GameServerDeployment gameServerDeployment = new GameServerDeployment();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.CreateGameServerDeploymentAsync(parent, gameServerDeployment);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceCreateGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerDeployment</summary>
        public void DeleteGameServerDeploymentRequestObject()
        {
            // Snippet: DeleteGameServerDeployment(DeleteGameServerDeploymentRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            DeleteGameServerDeploymentRequest request = new DeleteGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerDeploymentsServiceClient.DeleteGameServerDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceDeleteGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerDeploymentAsync</summary>
        public async Task DeleteGameServerDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteGameServerDeploymentAsync(DeleteGameServerDeploymentRequest, CallSettings)
            // Additional: DeleteGameServerDeploymentAsync(DeleteGameServerDeploymentRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGameServerDeploymentRequest request = new DeleteGameServerDeploymentRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerDeploymentsServiceClient.DeleteGameServerDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceDeleteGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerDeployment</summary>
        public void DeleteGameServerDeployment()
        {
            // Snippet: DeleteGameServerDeployment(string, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerDeploymentsServiceClient.DeleteGameServerDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceDeleteGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerDeploymentAsync</summary>
        public async Task DeleteGameServerDeploymentAsync()
        {
            // Snippet: DeleteGameServerDeploymentAsync(string, CallSettings)
            // Additional: DeleteGameServerDeploymentAsync(string, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerDeploymentsServiceClient.DeleteGameServerDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceDeleteGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerDeployment</summary>
        public void DeleteGameServerDeploymentResourceNames()
        {
            // Snippet: DeleteGameServerDeployment(GameServerDeploymentName, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GameServerDeploymentName name = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerDeploymentsServiceClient.DeleteGameServerDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceDeleteGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerDeploymentAsync</summary>
        public async Task DeleteGameServerDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteGameServerDeploymentAsync(GameServerDeploymentName, CallSettings)
            // Additional: DeleteGameServerDeploymentAsync(GameServerDeploymentName, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerDeploymentName name = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerDeploymentsServiceClient.DeleteGameServerDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceDeleteGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeployment</summary>
        public void UpdateGameServerDeploymentRequestObject()
        {
            // Snippet: UpdateGameServerDeployment(UpdateGameServerDeploymentRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            UpdateGameServerDeploymentRequest request = new UpdateGameServerDeploymentRequest
            {
                GameServerDeployment = new GameServerDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = gameServerDeploymentsServiceClient.UpdateGameServerDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeploymentAsync</summary>
        public async Task UpdateGameServerDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateGameServerDeploymentAsync(UpdateGameServerDeploymentRequest, CallSettings)
            // Additional: UpdateGameServerDeploymentAsync(UpdateGameServerDeploymentRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGameServerDeploymentRequest request = new UpdateGameServerDeploymentRequest
            {
                GameServerDeployment = new GameServerDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.UpdateGameServerDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeployment</summary>
        public void UpdateGameServerDeployment()
        {
            // Snippet: UpdateGameServerDeployment(GameServerDeployment, FieldMask, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GameServerDeployment gameServerDeployment = new GameServerDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = gameServerDeploymentsServiceClient.UpdateGameServerDeployment(gameServerDeployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeploymentAsync</summary>
        public async Task UpdateGameServerDeploymentAsync()
        {
            // Snippet: UpdateGameServerDeploymentAsync(GameServerDeployment, FieldMask, CallSettings)
            // Additional: UpdateGameServerDeploymentAsync(GameServerDeployment, FieldMask, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerDeployment gameServerDeployment = new GameServerDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.UpdateGameServerDeploymentAsync(gameServerDeployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentRollout</summary>
        public void GetGameServerDeploymentRolloutRequestObject()
        {
            // Snippet: GetGameServerDeploymentRollout(GetGameServerDeploymentRolloutRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            GameServerDeploymentRollout response = gameServerDeploymentsServiceClient.GetGameServerDeploymentRollout(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentRolloutAsync</summary>
        public async Task GetGameServerDeploymentRolloutRequestObjectAsync()
        {
            // Snippet: GetGameServerDeploymentRolloutAsync(GetGameServerDeploymentRolloutRequest, CallSettings)
            // Additional: GetGameServerDeploymentRolloutAsync(GetGameServerDeploymentRolloutRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGameServerDeploymentRolloutRequest request = new GetGameServerDeploymentRolloutRequest
            {
                GameServerDeploymentName = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]"),
            };
            // Make the request
            GameServerDeploymentRollout response = await gameServerDeploymentsServiceClient.GetGameServerDeploymentRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentRollout</summary>
        public void GetGameServerDeploymentRollout()
        {
            // Snippet: GetGameServerDeploymentRollout(string, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            GameServerDeploymentRollout response = gameServerDeploymentsServiceClient.GetGameServerDeploymentRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentRolloutAsync</summary>
        public async Task GetGameServerDeploymentRolloutAsync()
        {
            // Snippet: GetGameServerDeploymentRolloutAsync(string, CallSettings)
            // Additional: GetGameServerDeploymentRolloutAsync(string, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/gameServerDeployments/[DEPLOYMENT]";
            // Make the request
            GameServerDeploymentRollout response = await gameServerDeploymentsServiceClient.GetGameServerDeploymentRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentRollout</summary>
        public void GetGameServerDeploymentRolloutResourceNames()
        {
            // Snippet: GetGameServerDeploymentRollout(GameServerDeploymentName, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GameServerDeploymentName name = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            GameServerDeploymentRollout response = gameServerDeploymentsServiceClient.GetGameServerDeploymentRollout(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerDeploymentRolloutAsync</summary>
        public async Task GetGameServerDeploymentRolloutResourceNamesAsync()
        {
            // Snippet: GetGameServerDeploymentRolloutAsync(GameServerDeploymentName, CallSettings)
            // Additional: GetGameServerDeploymentRolloutAsync(GameServerDeploymentName, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerDeploymentName name = GameServerDeploymentName.FromProjectLocationDeployment("[PROJECT]", "[LOCATION]", "[DEPLOYMENT]");
            // Make the request
            GameServerDeploymentRollout response = await gameServerDeploymentsServiceClient.GetGameServerDeploymentRolloutAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeploymentRollout</summary>
        public void UpdateGameServerDeploymentRolloutRequestObject()
        {
            // Snippet: UpdateGameServerDeploymentRollout(UpdateGameServerDeploymentRolloutRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            UpdateGameServerDeploymentRolloutRequest request = new UpdateGameServerDeploymentRolloutRequest
            {
                Rollout = new GameServerDeploymentRollout(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = gameServerDeploymentsServiceClient.UpdateGameServerDeploymentRollout(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeploymentRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeploymentRolloutAsync</summary>
        public async Task UpdateGameServerDeploymentRolloutRequestObjectAsync()
        {
            // Snippet: UpdateGameServerDeploymentRolloutAsync(UpdateGameServerDeploymentRolloutRequest, CallSettings)
            // Additional: UpdateGameServerDeploymentRolloutAsync(UpdateGameServerDeploymentRolloutRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGameServerDeploymentRolloutRequest request = new UpdateGameServerDeploymentRolloutRequest
            {
                Rollout = new GameServerDeploymentRollout(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.UpdateGameServerDeploymentRolloutAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeploymentRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeploymentRollout</summary>
        public void UpdateGameServerDeploymentRollout()
        {
            // Snippet: UpdateGameServerDeploymentRollout(GameServerDeploymentRollout, FieldMask, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            GameServerDeploymentRollout rollout = new GameServerDeploymentRollout();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = gameServerDeploymentsServiceClient.UpdateGameServerDeploymentRollout(rollout, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeploymentRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerDeploymentRolloutAsync</summary>
        public async Task UpdateGameServerDeploymentRolloutAsync()
        {
            // Snippet: UpdateGameServerDeploymentRolloutAsync(GameServerDeploymentRollout, FieldMask, CallSettings)
            // Additional: UpdateGameServerDeploymentRolloutAsync(GameServerDeploymentRollout, FieldMask, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerDeploymentRollout rollout = new GameServerDeploymentRollout();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GameServerDeployment, OperationMetadata> response = await gameServerDeploymentsServiceClient.UpdateGameServerDeploymentRolloutAsync(rollout, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GameServerDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerDeployment, OperationMetadata> retrievedResponse = await gameServerDeploymentsServiceClient.PollOnceUpdateGameServerDeploymentRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewGameServerDeploymentRollout</summary>
        public void PreviewGameServerDeploymentRolloutRequestObject()
        {
            // Snippet: PreviewGameServerDeploymentRollout(PreviewGameServerDeploymentRolloutRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            PreviewGameServerDeploymentRolloutRequest request = new PreviewGameServerDeploymentRolloutRequest
            {
                Rollout = new GameServerDeploymentRollout(),
                UpdateMask = new FieldMask(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewGameServerDeploymentRolloutResponse response = gameServerDeploymentsServiceClient.PreviewGameServerDeploymentRollout(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewGameServerDeploymentRolloutAsync</summary>
        public async Task PreviewGameServerDeploymentRolloutRequestObjectAsync()
        {
            // Snippet: PreviewGameServerDeploymentRolloutAsync(PreviewGameServerDeploymentRolloutRequest, CallSettings)
            // Additional: PreviewGameServerDeploymentRolloutAsync(PreviewGameServerDeploymentRolloutRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            PreviewGameServerDeploymentRolloutRequest request = new PreviewGameServerDeploymentRolloutRequest
            {
                Rollout = new GameServerDeploymentRollout(),
                UpdateMask = new FieldMask(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewGameServerDeploymentRolloutResponse response = await gameServerDeploymentsServiceClient.PreviewGameServerDeploymentRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchDeploymentState</summary>
        public void FetchDeploymentStateRequestObject()
        {
            // Snippet: FetchDeploymentState(FetchDeploymentStateRequest, CallSettings)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = GameServerDeploymentsServiceClient.Create();
            // Initialize request argument(s)
            FetchDeploymentStateRequest request = new FetchDeploymentStateRequest { Name = "", };
            // Make the request
            FetchDeploymentStateResponse response = gameServerDeploymentsServiceClient.FetchDeploymentState(request);
            // End snippet
        }

        /// <summary>Snippet for FetchDeploymentStateAsync</summary>
        public async Task FetchDeploymentStateRequestObjectAsync()
        {
            // Snippet: FetchDeploymentStateAsync(FetchDeploymentStateRequest, CallSettings)
            // Additional: FetchDeploymentStateAsync(FetchDeploymentStateRequest, CancellationToken)
            // Create client
            GameServerDeploymentsServiceClient gameServerDeploymentsServiceClient = await GameServerDeploymentsServiceClient.CreateAsync();
            // Initialize request argument(s)
            FetchDeploymentStateRequest request = new FetchDeploymentStateRequest { Name = "", };
            // Make the request
            FetchDeploymentStateResponse response = await gameServerDeploymentsServiceClient.FetchDeploymentStateAsync(request);
            // End snippet
        }
    }
}
