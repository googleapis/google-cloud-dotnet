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
    using Google.Cloud.CloudBuild.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRepositoryManagerClientSnippets
    {
        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionRequestObject()
        {
            // Snippet: CreateConnection(CreateConnectionRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Connection = new Connection(),
                ConnectionId = "",
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = repositoryManagerClient.CreateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceCreateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionRequestObjectAsync()
        {
            // Snippet: CreateConnectionAsync(CreateConnectionRequest, CallSettings)
            // Additional: CreateConnectionAsync(CreateConnectionRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Connection = new Connection(),
                ConnectionId = "",
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = await repositoryManagerClient.CreateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceCreateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnection()
        {
            // Snippet: CreateConnection(string, Connection, string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = repositoryManagerClient.CreateConnection(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceCreateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionAsync()
        {
            // Snippet: CreateConnectionAsync(string, Connection, string, CallSettings)
            // Additional: CreateConnectionAsync(string, Connection, string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = await repositoryManagerClient.CreateConnectionAsync(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceCreateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionResourceNames()
        {
            // Snippet: CreateConnection(LocationName, Connection, string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = repositoryManagerClient.CreateConnection(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceCreateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectionAsync</summary>
        public async Task CreateConnectionResourceNamesAsync()
        {
            // Snippet: CreateConnectionAsync(LocationName, Connection, string, CallSettings)
            // Additional: CreateConnectionAsync(LocationName, Connection, string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = await repositoryManagerClient.CreateConnectionAsync(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceCreateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionRequestObject()
        {
            // Snippet: GetConnection(GetConnectionRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = repositoryManagerClient.GetConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionRequestObjectAsync()
        {
            // Snippet: GetConnectionAsync(GetConnectionRequest, CallSettings)
            // Additional: GetConnectionAsync(GetConnectionRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = await repositoryManagerClient.GetConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnection()
        {
            // Snippet: GetConnection(string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = repositoryManagerClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionAsync()
        {
            // Snippet: GetConnectionAsync(string, CallSettings)
            // Additional: GetConnectionAsync(string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = await repositoryManagerClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionResourceNames()
        {
            // Snippet: GetConnection(ConnectionName, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = repositoryManagerClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionResourceNamesAsync()
        {
            // Snippet: GetConnectionAsync(ConnectionName, CallSettings)
            // Additional: GetConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = await repositoryManagerClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsRequestObject()
        {
            // Snippet: ListConnections(ListConnectionsRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = repositoryManagerClient.ListConnections(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsRequestObjectAsync()
        {
            // Snippet: ListConnectionsAsync(ListConnectionsRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = repositoryManagerClient.ListConnectionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnections()
        {
            // Snippet: ListConnections(string, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = repositoryManagerClient.ListConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsAsync()
        {
            // Snippet: ListConnectionsAsync(string, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = repositoryManagerClient.ListConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsResourceNames()
        {
            // Snippet: ListConnections(LocationName, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = repositoryManagerClient.ListConnections(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectionsAsync</summary>
        public async Task ListConnectionsResourceNamesAsync()
        {
            // Snippet: ListConnectionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = repositoryManagerClient.ListConnectionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connection item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connection item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connection> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connection item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnectionRequestObject()
        {
            // Snippet: UpdateConnection(UpdateConnectionRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                Etag = "",
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = repositoryManagerClient.UpdateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceUpdateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionRequestObjectAsync()
        {
            // Snippet: UpdateConnectionAsync(UpdateConnectionRequest, CallSettings)
            // Additional: UpdateConnectionAsync(UpdateConnectionRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
                Etag = "",
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = await repositoryManagerClient.UpdateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceUpdateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnection()
        {
            // Snippet: UpdateConnection(Connection, FieldMask, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Connection, OperationMetadata> response = repositoryManagerClient.UpdateConnection(connection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceUpdateConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectionAsync</summary>
        public async Task UpdateConnectionAsync()
        {
            // Snippet: UpdateConnectionAsync(Connection, FieldMask, CallSettings)
            // Additional: UpdateConnectionAsync(Connection, FieldMask, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Connection, OperationMetadata> response = await repositoryManagerClient.UpdateConnectionAsync(connection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceUpdateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionRequestObject()
        {
            // Snippet: DeleteConnection(DeleteConnectionRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = repositoryManagerClient.DeleteConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceDeleteConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionRequestObjectAsync()
        {
            // Snippet: DeleteConnectionAsync(DeleteConnectionRequest, CallSettings)
            // Additional: DeleteConnectionAsync(DeleteConnectionRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await repositoryManagerClient.DeleteConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceDeleteConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnection()
        {
            // Snippet: DeleteConnection(string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = repositoryManagerClient.DeleteConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceDeleteConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionAsync()
        {
            // Snippet: DeleteConnectionAsync(string, CallSettings)
            // Additional: DeleteConnectionAsync(string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await repositoryManagerClient.DeleteConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceDeleteConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnection</summary>
        public void DeleteConnectionResourceNames()
        {
            // Snippet: DeleteConnection(ConnectionName, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = repositoryManagerClient.DeleteConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceDeleteConnection(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectionAsync</summary>
        public async Task DeleteConnectionResourceNamesAsync()
        {
            // Snippet: DeleteConnectionAsync(ConnectionName, CallSettings)
            // Additional: DeleteConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await repositoryManagerClient.DeleteConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceDeleteConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryRequestObject()
        {
            // Snippet: CreateRepository(CreateRepositoryRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Repository = new Repository(),
                RepositoryId = "",
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = repositoryManagerClient.CreateRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryRequestObjectAsync()
        {
            // Snippet: CreateRepositoryAsync(CreateRepositoryRequest, CallSettings)
            // Additional: CreateRepositoryAsync(CreateRepositoryRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Repository = new Repository(),
                RepositoryId = "",
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = await repositoryManagerClient.CreateRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepository()
        {
            // Snippet: CreateRepository(string, Repository, string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = repositoryManagerClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryAsync()
        {
            // Snippet: CreateRepositoryAsync(string, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(string, Repository, string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = await repositoryManagerClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepository</summary>
        public void CreateRepositoryResourceNames()
        {
            // Snippet: CreateRepository(ConnectionName, Repository, string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = repositoryManagerClient.CreateRepository(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateRepositoryAsync</summary>
        public async Task CreateRepositoryResourceNamesAsync()
        {
            // Snippet: CreateRepositoryAsync(ConnectionName, Repository, string, CallSettings)
            // Additional: CreateRepositoryAsync(ConnectionName, Repository, string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            Repository repository = new Repository();
            string repositoryId = "";
            // Make the request
            Operation<Repository, OperationMetadata> response = await repositoryManagerClient.CreateRepositoryAsync(parent, repository, repositoryId);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceCreateRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRepositories</summary>
        public void BatchCreateRepositoriesRequestObject()
        {
            // Snippet: BatchCreateRepositories(BatchCreateRepositoriesRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            BatchCreateRepositoriesRequest request = new BatchCreateRepositoriesRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Requests =
                {
                    new CreateRepositoryRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> response = repositoryManagerClient.BatchCreateRepositories(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateRepositoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceBatchCreateRepositories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRepositoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRepositoriesAsync</summary>
        public async Task BatchCreateRepositoriesRequestObjectAsync()
        {
            // Snippet: BatchCreateRepositoriesAsync(BatchCreateRepositoriesRequest, CallSettings)
            // Additional: BatchCreateRepositoriesAsync(BatchCreateRepositoriesRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateRepositoriesRequest request = new BatchCreateRepositoriesRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Requests =
                {
                    new CreateRepositoryRequest(),
                },
            };
            // Make the request
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> response = await repositoryManagerClient.BatchCreateRepositoriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateRepositoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceBatchCreateRepositoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRepositoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRepositories</summary>
        public void BatchCreateRepositories()
        {
            // Snippet: BatchCreateRepositories(string, IEnumerable<CreateRepositoryRequest>, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            IEnumerable<CreateRepositoryRequest> requests = new CreateRepositoryRequest[]
            {
                new CreateRepositoryRequest(),
            };
            // Make the request
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> response = repositoryManagerClient.BatchCreateRepositories(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateRepositoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceBatchCreateRepositories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRepositoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRepositoriesAsync</summary>
        public async Task BatchCreateRepositoriesAsync()
        {
            // Snippet: BatchCreateRepositoriesAsync(string, IEnumerable<CreateRepositoryRequest>, CallSettings)
            // Additional: BatchCreateRepositoriesAsync(string, IEnumerable<CreateRepositoryRequest>, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            IEnumerable<CreateRepositoryRequest> requests = new CreateRepositoryRequest[]
            {
                new CreateRepositoryRequest(),
            };
            // Make the request
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> response = await repositoryManagerClient.BatchCreateRepositoriesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateRepositoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceBatchCreateRepositoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRepositoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRepositories</summary>
        public void BatchCreateRepositoriesResourceNames()
        {
            // Snippet: BatchCreateRepositories(ConnectionName, IEnumerable<CreateRepositoryRequest>, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            IEnumerable<CreateRepositoryRequest> requests = new CreateRepositoryRequest[]
            {
                new CreateRepositoryRequest(),
            };
            // Make the request
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> response = repositoryManagerClient.BatchCreateRepositories(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateRepositoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceBatchCreateRepositories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRepositoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRepositoriesAsync</summary>
        public async Task BatchCreateRepositoriesResourceNamesAsync()
        {
            // Snippet: BatchCreateRepositoriesAsync(ConnectionName, IEnumerable<CreateRepositoryRequest>, CallSettings)
            // Additional: BatchCreateRepositoriesAsync(ConnectionName, IEnumerable<CreateRepositoryRequest>, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            IEnumerable<CreateRepositoryRequest> requests = new CreateRepositoryRequest[]
            {
                new CreateRepositoryRequest(),
            };
            // Make the request
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> response = await repositoryManagerClient.BatchCreateRepositoriesAsync(parent, requests);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateRepositoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateRepositoriesResponse, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceBatchCreateRepositoriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateRepositoriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryRequestObject()
        {
            // Snippet: GetRepository(GetRepositoryRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = repositoryManagerClient.GetRepository(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryRequestObjectAsync()
        {
            // Snippet: GetRepositoryAsync(GetRepositoryRequest, CallSettings)
            // Additional: GetRepositoryAsync(GetRepositoryRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetRepositoryRequest request = new GetRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
            };
            // Make the request
            Repository response = await repositoryManagerClient.GetRepositoryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepository()
        {
            // Snippet: GetRepository(string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = repositoryManagerClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryAsync()
        {
            // Snippet: GetRepositoryAsync(string, CallSettings)
            // Additional: GetRepositoryAsync(string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = await repositoryManagerClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepository</summary>
        public void GetRepositoryResourceNames()
        {
            // Snippet: GetRepository(RepositoryName, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            Repository response = repositoryManagerClient.GetRepository(name);
            // End snippet
        }

        /// <summary>Snippet for GetRepositoryAsync</summary>
        public async Task GetRepositoryResourceNamesAsync()
        {
            // Snippet: GetRepositoryAsync(RepositoryName, CallSettings)
            // Additional: GetRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            Repository response = await repositoryManagerClient.GetRepositoryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesRequestObject()
        {
            // Snippet: ListRepositories(ListRepositoriesRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = repositoryManagerClient.ListRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesRequestObjectAsync()
        {
            // Snippet: ListRepositoriesAsync(ListRepositoriesRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListRepositoriesRequest request = new ListRepositoriesRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = repositoryManagerClient.ListRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositories()
        {
            // Snippet: ListRepositories(string, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = repositoryManagerClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesAsync()
        {
            // Snippet: ListRepositoriesAsync(string, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = repositoryManagerClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositories</summary>
        public void ListRepositoriesResourceNames()
        {
            // Snippet: ListRepositories(ConnectionName, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedEnumerable<ListRepositoriesResponse, Repository> response = repositoryManagerClient.ListRepositories(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRepositoriesAsync</summary>
        public async Task ListRepositoriesResourceNamesAsync()
        {
            // Snippet: ListRepositoriesAsync(ConnectionName, string, int?, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedAsyncEnumerable<ListRepositoriesResponse, Repository> response = repositoryManagerClient.ListRepositoriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryRequestObject()
        {
            // Snippet: DeleteRepository(DeleteRepositoryRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = repositoryManagerClient.DeleteRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryRequestObjectAsync()
        {
            // Snippet: DeleteRepositoryAsync(DeleteRepositoryRequest, CallSettings)
            // Additional: DeleteRepositoryAsync(DeleteRepositoryRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRepositoryRequest request = new DeleteRepositoryRequest
            {
                RepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await repositoryManagerClient.DeleteRepositoryAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepository()
        {
            // Snippet: DeleteRepository(string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = repositoryManagerClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryAsync()
        {
            // Snippet: DeleteRepositoryAsync(string, CallSettings)
            // Additional: DeleteRepositoryAsync(string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await repositoryManagerClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepository</summary>
        public void DeleteRepositoryResourceNames()
        {
            // Snippet: DeleteRepository(RepositoryName, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = repositoryManagerClient.DeleteRepository(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = repositoryManagerClient.PollOnceDeleteRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteRepositoryAsync</summary>
        public async Task DeleteRepositoryResourceNamesAsync()
        {
            // Snippet: DeleteRepositoryAsync(RepositoryName, CallSettings)
            // Additional: DeleteRepositoryAsync(RepositoryName, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName name = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await repositoryManagerClient.DeleteRepositoryAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await repositoryManagerClient.PollOnceDeleteRepositoryAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteToken</summary>
        public void FetchReadWriteTokenRequestObject()
        {
            // Snippet: FetchReadWriteToken(FetchReadWriteTokenRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            FetchReadWriteTokenRequest request = new FetchReadWriteTokenRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
            };
            // Make the request
            FetchReadWriteTokenResponse response = repositoryManagerClient.FetchReadWriteToken(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteTokenAsync</summary>
        public async Task FetchReadWriteTokenRequestObjectAsync()
        {
            // Snippet: FetchReadWriteTokenAsync(FetchReadWriteTokenRequest, CallSettings)
            // Additional: FetchReadWriteTokenAsync(FetchReadWriteTokenRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            FetchReadWriteTokenRequest request = new FetchReadWriteTokenRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
            };
            // Make the request
            FetchReadWriteTokenResponse response = await repositoryManagerClient.FetchReadWriteTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteToken</summary>
        public void FetchReadWriteToken()
        {
            // Snippet: FetchReadWriteToken(string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string repository = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            FetchReadWriteTokenResponse response = repositoryManagerClient.FetchReadWriteToken(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteTokenAsync</summary>
        public async Task FetchReadWriteTokenAsync()
        {
            // Snippet: FetchReadWriteTokenAsync(string, CallSettings)
            // Additional: FetchReadWriteTokenAsync(string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string repository = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            FetchReadWriteTokenResponse response = await repositoryManagerClient.FetchReadWriteTokenAsync(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteToken</summary>
        public void FetchReadWriteTokenResourceNames()
        {
            // Snippet: FetchReadWriteToken(RepositoryName, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName repository = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            FetchReadWriteTokenResponse response = repositoryManagerClient.FetchReadWriteToken(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteTokenAsync</summary>
        public async Task FetchReadWriteTokenResourceNamesAsync()
        {
            // Snippet: FetchReadWriteTokenAsync(RepositoryName, CallSettings)
            // Additional: FetchReadWriteTokenAsync(RepositoryName, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName repository = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            FetchReadWriteTokenResponse response = await repositoryManagerClient.FetchReadWriteTokenAsync(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchReadToken</summary>
        public void FetchReadTokenRequestObject()
        {
            // Snippet: FetchReadToken(FetchReadTokenRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            FetchReadTokenRequest request = new FetchReadTokenRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
            };
            // Make the request
            FetchReadTokenResponse response = repositoryManagerClient.FetchReadToken(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadTokenAsync</summary>
        public async Task FetchReadTokenRequestObjectAsync()
        {
            // Snippet: FetchReadTokenAsync(FetchReadTokenRequest, CallSettings)
            // Additional: FetchReadTokenAsync(FetchReadTokenRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            FetchReadTokenRequest request = new FetchReadTokenRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
            };
            // Make the request
            FetchReadTokenResponse response = await repositoryManagerClient.FetchReadTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadToken</summary>
        public void FetchReadToken()
        {
            // Snippet: FetchReadToken(string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string repository = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            FetchReadTokenResponse response = repositoryManagerClient.FetchReadToken(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchReadTokenAsync</summary>
        public async Task FetchReadTokenAsync()
        {
            // Snippet: FetchReadTokenAsync(string, CallSettings)
            // Additional: FetchReadTokenAsync(string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string repository = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            FetchReadTokenResponse response = await repositoryManagerClient.FetchReadTokenAsync(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchReadToken</summary>
        public void FetchReadTokenResourceNames()
        {
            // Snippet: FetchReadToken(RepositoryName, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName repository = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            FetchReadTokenResponse response = repositoryManagerClient.FetchReadToken(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchReadTokenAsync</summary>
        public async Task FetchReadTokenResourceNamesAsync()
        {
            // Snippet: FetchReadTokenAsync(RepositoryName, CallSettings)
            // Additional: FetchReadTokenAsync(RepositoryName, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName repository = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            FetchReadTokenResponse response = await repositoryManagerClient.FetchReadTokenAsync(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableRepositories</summary>
        public void FetchLinkableRepositoriesRequestObject()
        {
            // Snippet: FetchLinkableRepositories(FetchLinkableRepositoriesRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            FetchLinkableRepositoriesRequest request = new FetchLinkableRepositoriesRequest
            {
                ConnectionAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            PagedEnumerable<FetchLinkableRepositoriesResponse, Repository> response = repositoryManagerClient.FetchLinkableRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Repository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchLinkableRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableRepositoriesAsync</summary>
        public async Task FetchLinkableRepositoriesRequestObjectAsync()
        {
            // Snippet: FetchLinkableRepositoriesAsync(FetchLinkableRepositoriesRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            FetchLinkableRepositoriesRequest request = new FetchLinkableRepositoriesRequest
            {
                ConnectionAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchLinkableRepositoriesResponse, Repository> response = repositoryManagerClient.FetchLinkableRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Repository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchLinkableRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Repository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Repository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Repository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefs</summary>
        public void FetchGitRefsRequestObject()
        {
            // Snippet: FetchGitRefs(FetchGitRefsRequest, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
                RefType = FetchGitRefsRequest.Types.RefType.Unspecified,
            };
            // Make the request
            FetchGitRefsResponse response = repositoryManagerClient.FetchGitRefs(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefsAsync</summary>
        public async Task FetchGitRefsRequestObjectAsync()
        {
            // Snippet: FetchGitRefsAsync(FetchGitRefsRequest, CallSettings)
            // Additional: FetchGitRefsAsync(FetchGitRefsRequest, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                RepositoryAsRepositoryName = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]"),
                RefType = FetchGitRefsRequest.Types.RefType.Unspecified,
            };
            // Make the request
            FetchGitRefsResponse response = await repositoryManagerClient.FetchGitRefsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefs</summary>
        public void FetchGitRefs()
        {
            // Snippet: FetchGitRefs(string, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            string repository = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            FetchGitRefsResponse response = repositoryManagerClient.FetchGitRefs(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefsAsync</summary>
        public async Task FetchGitRefsAsync()
        {
            // Snippet: FetchGitRefsAsync(string, CallSettings)
            // Additional: FetchGitRefsAsync(string, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            string repository = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/repositories/[REPOSITORY]";
            // Make the request
            FetchGitRefsResponse response = await repositoryManagerClient.FetchGitRefsAsync(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefs</summary>
        public void FetchGitRefsResourceNames()
        {
            // Snippet: FetchGitRefs(RepositoryName, CallSettings)
            // Create client
            RepositoryManagerClient repositoryManagerClient = RepositoryManagerClient.Create();
            // Initialize request argument(s)
            RepositoryName repository = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            FetchGitRefsResponse response = repositoryManagerClient.FetchGitRefs(repository);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefsAsync</summary>
        public async Task FetchGitRefsResourceNamesAsync()
        {
            // Snippet: FetchGitRefsAsync(RepositoryName, CallSettings)
            // Additional: FetchGitRefsAsync(RepositoryName, CancellationToken)
            // Create client
            RepositoryManagerClient repositoryManagerClient = await RepositoryManagerClient.CreateAsync();
            // Initialize request argument(s)
            RepositoryName repository = RepositoryName.FromProjectLocationConnectionRepository("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[REPOSITORY]");
            // Make the request
            FetchGitRefsResponse response = await repositoryManagerClient.FetchGitRefsAsync(repository);
            // End snippet
        }
    }
}
