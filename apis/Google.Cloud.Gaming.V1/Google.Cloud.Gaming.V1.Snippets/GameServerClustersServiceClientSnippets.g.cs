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
    public sealed class AllGeneratedGameServerClustersServiceClientSnippets
    {
        /// <summary>Snippet for ListGameServerClusters</summary>
        public void ListGameServerClustersRequestObject()
        {
            // Snippet: ListGameServerClusters(ListGameServerClustersRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            ListGameServerClustersRequest request = new ListGameServerClustersRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                Filter = "",
                OrderBy = "",
                View = GameServerClusterView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListGameServerClustersResponse, GameServerCluster> response = gameServerClustersServiceClient.ListGameServerClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerClustersAsync</summary>
        public async Task ListGameServerClustersRequestObjectAsync()
        {
            // Snippet: ListGameServerClustersAsync(ListGameServerClustersRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListGameServerClustersRequest request = new ListGameServerClustersRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                Filter = "",
                OrderBy = "",
                View = GameServerClusterView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListGameServerClustersResponse, GameServerCluster> response = gameServerClustersServiceClient.ListGameServerClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerClusters</summary>
        public void ListGameServerClusters()
        {
            // Snippet: ListGameServerClusters(string, string, int?, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            // Make the request
            PagedEnumerable<ListGameServerClustersResponse, GameServerCluster> response = gameServerClustersServiceClient.ListGameServerClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerClustersAsync</summary>
        public async Task ListGameServerClustersAsync()
        {
            // Snippet: ListGameServerClustersAsync(string, string, int?, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            // Make the request
            PagedAsyncEnumerable<ListGameServerClustersResponse, GameServerCluster> response = gameServerClustersServiceClient.ListGameServerClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerClusters</summary>
        public void ListGameServerClustersResourceNames()
        {
            // Snippet: ListGameServerClusters(RealmName, string, int?, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            RealmName parent = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            // Make the request
            PagedEnumerable<ListGameServerClustersResponse, GameServerCluster> response = gameServerClustersServiceClient.ListGameServerClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GameServerCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGameServerClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGameServerClustersAsync</summary>
        public async Task ListGameServerClustersResourceNamesAsync()
        {
            // Snippet: ListGameServerClustersAsync(RealmName, string, int?, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            RealmName parent = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            // Make the request
            PagedAsyncEnumerable<ListGameServerClustersResponse, GameServerCluster> response = gameServerClustersServiceClient.ListGameServerClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GameServerCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGameServerClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GameServerCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GameServerCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GameServerCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGameServerCluster</summary>
        public void GetGameServerClusterRequestObject()
        {
            // Snippet: GetGameServerCluster(GetGameServerClusterRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                View = GameServerClusterView.Unspecified,
            };
            // Make the request
            GameServerCluster response = gameServerClustersServiceClient.GetGameServerCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerClusterAsync</summary>
        public async Task GetGameServerClusterRequestObjectAsync()
        {
            // Snippet: GetGameServerClusterAsync(GetGameServerClusterRequest, CallSettings)
            // Additional: GetGameServerClusterAsync(GetGameServerClusterRequest, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetGameServerClusterRequest request = new GetGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                View = GameServerClusterView.Unspecified,
            };
            // Make the request
            GameServerCluster response = await gameServerClustersServiceClient.GetGameServerClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerCluster</summary>
        public void GetGameServerCluster()
        {
            // Snippet: GetGameServerCluster(string, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]/gameServerClusters/[CLUSTER]";
            // Make the request
            GameServerCluster response = gameServerClustersServiceClient.GetGameServerCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerClusterAsync</summary>
        public async Task GetGameServerClusterAsync()
        {
            // Snippet: GetGameServerClusterAsync(string, CallSettings)
            // Additional: GetGameServerClusterAsync(string, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]/gameServerClusters/[CLUSTER]";
            // Make the request
            GameServerCluster response = await gameServerClustersServiceClient.GetGameServerClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerCluster</summary>
        public void GetGameServerClusterResourceNames()
        {
            // Snippet: GetGameServerCluster(GameServerClusterName, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            GameServerClusterName name = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]");
            // Make the request
            GameServerCluster response = gameServerClustersServiceClient.GetGameServerCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetGameServerClusterAsync</summary>
        public async Task GetGameServerClusterResourceNamesAsync()
        {
            // Snippet: GetGameServerClusterAsync(GameServerClusterName, CallSettings)
            // Additional: GetGameServerClusterAsync(GameServerClusterName, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerClusterName name = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]");
            // Make the request
            GameServerCluster response = await gameServerClustersServiceClient.GetGameServerClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerCluster</summary>
        public void CreateGameServerClusterRequestObject()
        {
            // Snippet: CreateGameServerCluster(CreateGameServerClusterRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            CreateGameServerClusterRequest request = new CreateGameServerClusterRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                GameServerClusterId = "",
                GameServerCluster = new GameServerCluster(),
            };
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = gameServerClustersServiceClient.CreateGameServerCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceCreateGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerClusterAsync</summary>
        public async Task CreateGameServerClusterRequestObjectAsync()
        {
            // Snippet: CreateGameServerClusterAsync(CreateGameServerClusterRequest, CallSettings)
            // Additional: CreateGameServerClusterAsync(CreateGameServerClusterRequest, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateGameServerClusterRequest request = new CreateGameServerClusterRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                GameServerClusterId = "",
                GameServerCluster = new GameServerCluster(),
            };
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = await gameServerClustersServiceClient.CreateGameServerClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceCreateGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerCluster</summary>
        public void CreateGameServerCluster()
        {
            // Snippet: CreateGameServerCluster(string, GameServerCluster, string, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            GameServerCluster gameServerCluster = new GameServerCluster();
            string gameServerClusterId = "";
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = gameServerClustersServiceClient.CreateGameServerCluster(parent, gameServerCluster, gameServerClusterId);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceCreateGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerClusterAsync</summary>
        public async Task CreateGameServerClusterAsync()
        {
            // Snippet: CreateGameServerClusterAsync(string, GameServerCluster, string, CallSettings)
            // Additional: CreateGameServerClusterAsync(string, GameServerCluster, string, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]";
            GameServerCluster gameServerCluster = new GameServerCluster();
            string gameServerClusterId = "";
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = await gameServerClustersServiceClient.CreateGameServerClusterAsync(parent, gameServerCluster, gameServerClusterId);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceCreateGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerCluster</summary>
        public void CreateGameServerClusterResourceNames()
        {
            // Snippet: CreateGameServerCluster(RealmName, GameServerCluster, string, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            RealmName parent = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            GameServerCluster gameServerCluster = new GameServerCluster();
            string gameServerClusterId = "";
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = gameServerClustersServiceClient.CreateGameServerCluster(parent, gameServerCluster, gameServerClusterId);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceCreateGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGameServerClusterAsync</summary>
        public async Task CreateGameServerClusterResourceNamesAsync()
        {
            // Snippet: CreateGameServerClusterAsync(RealmName, GameServerCluster, string, CallSettings)
            // Additional: CreateGameServerClusterAsync(RealmName, GameServerCluster, string, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            RealmName parent = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]");
            GameServerCluster gameServerCluster = new GameServerCluster();
            string gameServerClusterId = "";
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = await gameServerClustersServiceClient.CreateGameServerClusterAsync(parent, gameServerCluster, gameServerClusterId);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceCreateGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewCreateGameServerCluster</summary>
        public void PreviewCreateGameServerClusterRequestObject()
        {
            // Snippet: PreviewCreateGameServerCluster(PreviewCreateGameServerClusterRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            PreviewCreateGameServerClusterRequest request = new PreviewCreateGameServerClusterRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                GameServerClusterId = "",
                GameServerCluster = new GameServerCluster(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewCreateGameServerClusterResponse response = gameServerClustersServiceClient.PreviewCreateGameServerCluster(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewCreateGameServerClusterAsync</summary>
        public async Task PreviewCreateGameServerClusterRequestObjectAsync()
        {
            // Snippet: PreviewCreateGameServerClusterAsync(PreviewCreateGameServerClusterRequest, CallSettings)
            // Additional: PreviewCreateGameServerClusterAsync(PreviewCreateGameServerClusterRequest, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            PreviewCreateGameServerClusterRequest request = new PreviewCreateGameServerClusterRequest
            {
                ParentAsRealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                GameServerClusterId = "",
                GameServerCluster = new GameServerCluster(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewCreateGameServerClusterResponse response = await gameServerClustersServiceClient.PreviewCreateGameServerClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerCluster</summary>
        public void DeleteGameServerClusterRequestObject()
        {
            // Snippet: DeleteGameServerCluster(DeleteGameServerClusterRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            DeleteGameServerClusterRequest request = new DeleteGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerClustersServiceClient.DeleteGameServerCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceDeleteGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerClusterAsync</summary>
        public async Task DeleteGameServerClusterRequestObjectAsync()
        {
            // Snippet: DeleteGameServerClusterAsync(DeleteGameServerClusterRequest, CallSettings)
            // Additional: DeleteGameServerClusterAsync(DeleteGameServerClusterRequest, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGameServerClusterRequest request = new DeleteGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerClustersServiceClient.DeleteGameServerClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceDeleteGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerCluster</summary>
        public void DeleteGameServerCluster()
        {
            // Snippet: DeleteGameServerCluster(string, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]/gameServerClusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerClustersServiceClient.DeleteGameServerCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceDeleteGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerClusterAsync</summary>
        public async Task DeleteGameServerClusterAsync()
        {
            // Snippet: DeleteGameServerClusterAsync(string, CallSettings)
            // Additional: DeleteGameServerClusterAsync(string, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/realms/[REALM]/gameServerClusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerClustersServiceClient.DeleteGameServerClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceDeleteGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerCluster</summary>
        public void DeleteGameServerClusterResourceNames()
        {
            // Snippet: DeleteGameServerCluster(GameServerClusterName, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            GameServerClusterName name = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = gameServerClustersServiceClient.DeleteGameServerCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceDeleteGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGameServerClusterAsync</summary>
        public async Task DeleteGameServerClusterResourceNamesAsync()
        {
            // Snippet: DeleteGameServerClusterAsync(GameServerClusterName, CallSettings)
            // Additional: DeleteGameServerClusterAsync(GameServerClusterName, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerClusterName name = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await gameServerClustersServiceClient.DeleteGameServerClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceDeleteGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewDeleteGameServerCluster</summary>
        public void PreviewDeleteGameServerClusterRequestObject()
        {
            // Snippet: PreviewDeleteGameServerCluster(PreviewDeleteGameServerClusterRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            PreviewDeleteGameServerClusterRequest request = new PreviewDeleteGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewDeleteGameServerClusterResponse response = gameServerClustersServiceClient.PreviewDeleteGameServerCluster(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewDeleteGameServerClusterAsync</summary>
        public async Task PreviewDeleteGameServerClusterRequestObjectAsync()
        {
            // Snippet: PreviewDeleteGameServerClusterAsync(PreviewDeleteGameServerClusterRequest, CallSettings)
            // Additional: PreviewDeleteGameServerClusterAsync(PreviewDeleteGameServerClusterRequest, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            PreviewDeleteGameServerClusterRequest request = new PreviewDeleteGameServerClusterRequest
            {
                GameServerClusterName = GameServerClusterName.FromProjectLocationRealmCluster("[PROJECT]", "[LOCATION]", "[REALM]", "[CLUSTER]"),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewDeleteGameServerClusterResponse response = await gameServerClustersServiceClient.PreviewDeleteGameServerClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerCluster</summary>
        public void UpdateGameServerClusterRequestObject()
        {
            // Snippet: UpdateGameServerCluster(UpdateGameServerClusterRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            UpdateGameServerClusterRequest request = new UpdateGameServerClusterRequest
            {
                GameServerCluster = new GameServerCluster(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = gameServerClustersServiceClient.UpdateGameServerCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceUpdateGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerClusterAsync</summary>
        public async Task UpdateGameServerClusterRequestObjectAsync()
        {
            // Snippet: UpdateGameServerClusterAsync(UpdateGameServerClusterRequest, CallSettings)
            // Additional: UpdateGameServerClusterAsync(UpdateGameServerClusterRequest, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGameServerClusterRequest request = new UpdateGameServerClusterRequest
            {
                GameServerCluster = new GameServerCluster(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = await gameServerClustersServiceClient.UpdateGameServerClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceUpdateGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerCluster</summary>
        public void UpdateGameServerCluster()
        {
            // Snippet: UpdateGameServerCluster(GameServerCluster, FieldMask, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            GameServerCluster gameServerCluster = new GameServerCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = gameServerClustersServiceClient.UpdateGameServerCluster(gameServerCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = gameServerClustersServiceClient.PollOnceUpdateGameServerCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateGameServerClusterAsync</summary>
        public async Task UpdateGameServerClusterAsync()
        {
            // Snippet: UpdateGameServerClusterAsync(GameServerCluster, FieldMask, CallSettings)
            // Additional: UpdateGameServerClusterAsync(GameServerCluster, FieldMask, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            GameServerCluster gameServerCluster = new GameServerCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<GameServerCluster, OperationMetadata> response = await gameServerClustersServiceClient.UpdateGameServerClusterAsync(gameServerCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<GameServerCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GameServerCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GameServerCluster, OperationMetadata> retrievedResponse = await gameServerClustersServiceClient.PollOnceUpdateGameServerClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GameServerCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PreviewUpdateGameServerCluster</summary>
        public void PreviewUpdateGameServerClusterRequestObject()
        {
            // Snippet: PreviewUpdateGameServerCluster(PreviewUpdateGameServerClusterRequest, CallSettings)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = GameServerClustersServiceClient.Create();
            // Initialize request argument(s)
            PreviewUpdateGameServerClusterRequest request = new PreviewUpdateGameServerClusterRequest
            {
                GameServerCluster = new GameServerCluster(),
                UpdateMask = new FieldMask(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewUpdateGameServerClusterResponse response = gameServerClustersServiceClient.PreviewUpdateGameServerCluster(request);
            // End snippet
        }

        /// <summary>Snippet for PreviewUpdateGameServerClusterAsync</summary>
        public async Task PreviewUpdateGameServerClusterRequestObjectAsync()
        {
            // Snippet: PreviewUpdateGameServerClusterAsync(PreviewUpdateGameServerClusterRequest, CallSettings)
            // Additional: PreviewUpdateGameServerClusterAsync(PreviewUpdateGameServerClusterRequest, CancellationToken)
            // Create client
            GameServerClustersServiceClient gameServerClustersServiceClient = await GameServerClustersServiceClient.CreateAsync();
            // Initialize request argument(s)
            PreviewUpdateGameServerClusterRequest request = new PreviewUpdateGameServerClusterRequest
            {
                GameServerCluster = new GameServerCluster(),
                UpdateMask = new FieldMask(),
                PreviewTime = new Timestamp(),
            };
            // Make the request
            PreviewUpdateGameServerClusterResponse response = await gameServerClustersServiceClient.PreviewUpdateGameServerClusterAsync(request);
            // End snippet
        }
    }
}
