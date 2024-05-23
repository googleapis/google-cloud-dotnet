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
    using Google.Cloud.DeveloperConnect.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDeveloperConnectClientSnippets
    {
        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsRequestObject()
        {
            // Snippet: ListConnections(ListConnectionsRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = developerConnectClient.ListConnections(request);

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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = developerConnectClient.ListConnectionsAsync(request);

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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = developerConnectClient.ListConnections(parent);

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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = developerConnectClient.ListConnectionsAsync(parent);

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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = developerConnectClient.ListConnections(parent);

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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = developerConnectClient.ListConnectionsAsync(parent);

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

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionRequestObject()
        {
            // Snippet: GetConnection(GetConnectionRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = developerConnectClient.GetConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionRequestObjectAsync()
        {
            // Snippet: GetConnectionAsync(GetConnectionRequest, CallSettings)
            // Additional: GetConnectionAsync(GetConnectionRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Connection response = await developerConnectClient.GetConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnection()
        {
            // Snippet: GetConnection(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = developerConnectClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionAsync()
        {
            // Snippet: GetConnectionAsync(string, CallSettings)
            // Additional: GetConnectionAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = await developerConnectClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionResourceNames()
        {
            // Snippet: GetConnection(ConnectionName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = developerConnectClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionResourceNamesAsync()
        {
            // Snippet: GetConnectionAsync(ConnectionName, CallSettings)
            // Additional: GetConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = await developerConnectClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionRequestObject()
        {
            // Snippet: CreateConnection(CreateConnectionRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "",
                Connection = new Connection(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = developerConnectClient.CreateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "",
                Connection = new Connection(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = await developerConnectClient.CreateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateConnectionAsync(operationName);
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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = developerConnectClient.CreateConnection(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = await developerConnectClient.CreateConnectionAsync(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateConnectionAsync(operationName);
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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = developerConnectClient.CreateConnection(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = await developerConnectClient.CreateConnectionAsync(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Connection retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnection</summary>
        public void UpdateConnectionRequestObject()
        {
            // Snippet: UpdateConnection(UpdateConnectionRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                UpdateMask = new FieldMask(),
                Connection = new Connection(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = developerConnectClient.UpdateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceUpdateConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                UpdateMask = new FieldMask(),
                Connection = new Connection(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = await developerConnectClient.UpdateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceUpdateConnectionAsync(operationName);
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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Connection, OperationMetadata> response = developerConnectClient.UpdateConnection(connection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceUpdateConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Connection, OperationMetadata> response = await developerConnectClient.UpdateConnectionAsync(connection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceUpdateConnectionAsync(operationName);
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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteConnectionAsync(operationName);
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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteConnectionAsync(operationName);
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
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteConnection(operationName);
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
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGitRepositoryLink</summary>
        public void CreateGitRepositoryLinkRequestObject()
        {
            // Snippet: CreateGitRepositoryLink(CreateGitRepositoryLinkRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            CreateGitRepositoryLinkRequest request = new CreateGitRepositoryLinkRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                GitRepositoryLink = new GitRepositoryLink(),
                GitRepositoryLinkId = "",
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<GitRepositoryLink, OperationMetadata> response = developerConnectClient.CreateGitRepositoryLink(request);

            // Poll until the returned long-running operation is complete
            Operation<GitRepositoryLink, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GitRepositoryLink result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GitRepositoryLink, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateGitRepositoryLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GitRepositoryLink retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGitRepositoryLinkAsync</summary>
        public async Task CreateGitRepositoryLinkRequestObjectAsync()
        {
            // Snippet: CreateGitRepositoryLinkAsync(CreateGitRepositoryLinkRequest, CallSettings)
            // Additional: CreateGitRepositoryLinkAsync(CreateGitRepositoryLinkRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            CreateGitRepositoryLinkRequest request = new CreateGitRepositoryLinkRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                GitRepositoryLink = new GitRepositoryLink(),
                GitRepositoryLinkId = "",
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<GitRepositoryLink, OperationMetadata> response = await developerConnectClient.CreateGitRepositoryLinkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GitRepositoryLink, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GitRepositoryLink result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GitRepositoryLink, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateGitRepositoryLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GitRepositoryLink retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGitRepositoryLink</summary>
        public void CreateGitRepositoryLink()
        {
            // Snippet: CreateGitRepositoryLink(string, GitRepositoryLink, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            GitRepositoryLink gitRepositoryLink = new GitRepositoryLink();
            string gitRepositoryLinkId = "";
            // Make the request
            Operation<GitRepositoryLink, OperationMetadata> response = developerConnectClient.CreateGitRepositoryLink(parent, gitRepositoryLink, gitRepositoryLinkId);

            // Poll until the returned long-running operation is complete
            Operation<GitRepositoryLink, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GitRepositoryLink result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GitRepositoryLink, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateGitRepositoryLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GitRepositoryLink retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGitRepositoryLinkAsync</summary>
        public async Task CreateGitRepositoryLinkAsync()
        {
            // Snippet: CreateGitRepositoryLinkAsync(string, GitRepositoryLink, string, CallSettings)
            // Additional: CreateGitRepositoryLinkAsync(string, GitRepositoryLink, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            GitRepositoryLink gitRepositoryLink = new GitRepositoryLink();
            string gitRepositoryLinkId = "";
            // Make the request
            Operation<GitRepositoryLink, OperationMetadata> response = await developerConnectClient.CreateGitRepositoryLinkAsync(parent, gitRepositoryLink, gitRepositoryLinkId);

            // Poll until the returned long-running operation is complete
            Operation<GitRepositoryLink, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GitRepositoryLink result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GitRepositoryLink, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateGitRepositoryLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GitRepositoryLink retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGitRepositoryLink</summary>
        public void CreateGitRepositoryLinkResourceNames()
        {
            // Snippet: CreateGitRepositoryLink(ConnectionName, GitRepositoryLink, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            GitRepositoryLink gitRepositoryLink = new GitRepositoryLink();
            string gitRepositoryLinkId = "";
            // Make the request
            Operation<GitRepositoryLink, OperationMetadata> response = developerConnectClient.CreateGitRepositoryLink(parent, gitRepositoryLink, gitRepositoryLinkId);

            // Poll until the returned long-running operation is complete
            Operation<GitRepositoryLink, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GitRepositoryLink result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GitRepositoryLink, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateGitRepositoryLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GitRepositoryLink retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateGitRepositoryLinkAsync</summary>
        public async Task CreateGitRepositoryLinkResourceNamesAsync()
        {
            // Snippet: CreateGitRepositoryLinkAsync(ConnectionName, GitRepositoryLink, string, CallSettings)
            // Additional: CreateGitRepositoryLinkAsync(ConnectionName, GitRepositoryLink, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            GitRepositoryLink gitRepositoryLink = new GitRepositoryLink();
            string gitRepositoryLinkId = "";
            // Make the request
            Operation<GitRepositoryLink, OperationMetadata> response = await developerConnectClient.CreateGitRepositoryLinkAsync(parent, gitRepositoryLink, gitRepositoryLinkId);

            // Poll until the returned long-running operation is complete
            Operation<GitRepositoryLink, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GitRepositoryLink result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GitRepositoryLink, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateGitRepositoryLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GitRepositoryLink retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGitRepositoryLink</summary>
        public void DeleteGitRepositoryLinkRequestObject()
        {
            // Snippet: DeleteGitRepositoryLink(DeleteGitRepositoryLinkRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            DeleteGitRepositoryLinkRequest request = new DeleteGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteGitRepositoryLink(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteGitRepositoryLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGitRepositoryLinkAsync</summary>
        public async Task DeleteGitRepositoryLinkRequestObjectAsync()
        {
            // Snippet: DeleteGitRepositoryLinkAsync(DeleteGitRepositoryLinkRequest, CallSettings)
            // Additional: DeleteGitRepositoryLinkAsync(DeleteGitRepositoryLinkRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGitRepositoryLinkRequest request = new DeleteGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteGitRepositoryLinkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteGitRepositoryLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGitRepositoryLink</summary>
        public void DeleteGitRepositoryLink()
        {
            // Snippet: DeleteGitRepositoryLink(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteGitRepositoryLink(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteGitRepositoryLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGitRepositoryLinkAsync</summary>
        public async Task DeleteGitRepositoryLinkAsync()
        {
            // Snippet: DeleteGitRepositoryLinkAsync(string, CallSettings)
            // Additional: DeleteGitRepositoryLinkAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteGitRepositoryLinkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteGitRepositoryLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGitRepositoryLink</summary>
        public void DeleteGitRepositoryLinkResourceNames()
        {
            // Snippet: DeleteGitRepositoryLink(GitRepositoryLinkName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteGitRepositoryLink(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteGitRepositoryLink(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteGitRepositoryLinkAsync</summary>
        public async Task DeleteGitRepositoryLinkResourceNamesAsync()
        {
            // Snippet: DeleteGitRepositoryLinkAsync(GitRepositoryLinkName, CallSettings)
            // Additional: DeleteGitRepositoryLinkAsync(GitRepositoryLinkName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteGitRepositoryLinkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteGitRepositoryLinkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGitRepositoryLinks</summary>
        public void ListGitRepositoryLinksRequestObject()
        {
            // Snippet: ListGitRepositoryLinks(ListGitRepositoryLinksRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ListGitRepositoryLinksRequest request = new ListGitRepositoryLinksRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> response = developerConnectClient.ListGitRepositoryLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GitRepositoryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGitRepositoryLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GitRepositoryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GitRepositoryLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GitRepositoryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGitRepositoryLinksAsync</summary>
        public async Task ListGitRepositoryLinksRequestObjectAsync()
        {
            // Snippet: ListGitRepositoryLinksAsync(ListGitRepositoryLinksRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ListGitRepositoryLinksRequest request = new ListGitRepositoryLinksRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> response = developerConnectClient.ListGitRepositoryLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GitRepositoryLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGitRepositoryLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GitRepositoryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GitRepositoryLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GitRepositoryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGitRepositoryLinks</summary>
        public void ListGitRepositoryLinks()
        {
            // Snippet: ListGitRepositoryLinks(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> response = developerConnectClient.ListGitRepositoryLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GitRepositoryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGitRepositoryLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GitRepositoryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GitRepositoryLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GitRepositoryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGitRepositoryLinksAsync</summary>
        public async Task ListGitRepositoryLinksAsync()
        {
            // Snippet: ListGitRepositoryLinksAsync(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedAsyncEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> response = developerConnectClient.ListGitRepositoryLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GitRepositoryLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGitRepositoryLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GitRepositoryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GitRepositoryLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GitRepositoryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGitRepositoryLinks</summary>
        public void ListGitRepositoryLinksResourceNames()
        {
            // Snippet: ListGitRepositoryLinks(ConnectionName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> response = developerConnectClient.ListGitRepositoryLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GitRepositoryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGitRepositoryLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GitRepositoryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GitRepositoryLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GitRepositoryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGitRepositoryLinksAsync</summary>
        public async Task ListGitRepositoryLinksResourceNamesAsync()
        {
            // Snippet: ListGitRepositoryLinksAsync(ConnectionName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedAsyncEnumerable<ListGitRepositoryLinksResponse, GitRepositoryLink> response = developerConnectClient.ListGitRepositoryLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GitRepositoryLink item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGitRepositoryLinksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GitRepositoryLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GitRepositoryLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GitRepositoryLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGitRepositoryLink</summary>
        public void GetGitRepositoryLinkRequestObject()
        {
            // Snippet: GetGitRepositoryLink(GetGitRepositoryLinkRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GetGitRepositoryLinkRequest request = new GetGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
            };
            // Make the request
            GitRepositoryLink response = developerConnectClient.GetGitRepositoryLink(request);
            // End snippet
        }

        /// <summary>Snippet for GetGitRepositoryLinkAsync</summary>
        public async Task GetGitRepositoryLinkRequestObjectAsync()
        {
            // Snippet: GetGitRepositoryLinkAsync(GetGitRepositoryLinkRequest, CallSettings)
            // Additional: GetGitRepositoryLinkAsync(GetGitRepositoryLinkRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GetGitRepositoryLinkRequest request = new GetGitRepositoryLinkRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
            };
            // Make the request
            GitRepositoryLink response = await developerConnectClient.GetGitRepositoryLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGitRepositoryLink</summary>
        public void GetGitRepositoryLink()
        {
            // Snippet: GetGitRepositoryLink(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            GitRepositoryLink response = developerConnectClient.GetGitRepositoryLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetGitRepositoryLinkAsync</summary>
        public async Task GetGitRepositoryLinkAsync()
        {
            // Snippet: GetGitRepositoryLinkAsync(string, CallSettings)
            // Additional: GetGitRepositoryLinkAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            GitRepositoryLink response = await developerConnectClient.GetGitRepositoryLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGitRepositoryLink</summary>
        public void GetGitRepositoryLinkResourceNames()
        {
            // Snippet: GetGitRepositoryLink(GitRepositoryLinkName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            GitRepositoryLink response = developerConnectClient.GetGitRepositoryLink(name);
            // End snippet
        }

        /// <summary>Snippet for GetGitRepositoryLinkAsync</summary>
        public async Task GetGitRepositoryLinkResourceNamesAsync()
        {
            // Snippet: GetGitRepositoryLinkAsync(GitRepositoryLinkName, CallSettings)
            // Additional: GetGitRepositoryLinkAsync(GitRepositoryLinkName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            GitRepositoryLink response = await developerConnectClient.GetGitRepositoryLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteToken</summary>
        public void FetchReadWriteTokenRequestObject()
        {
            // Snippet: FetchReadWriteToken(FetchReadWriteTokenRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchReadWriteTokenRequest request = new FetchReadWriteTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
            };
            // Make the request
            FetchReadWriteTokenResponse response = developerConnectClient.FetchReadWriteToken(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteTokenAsync</summary>
        public async Task FetchReadWriteTokenRequestObjectAsync()
        {
            // Snippet: FetchReadWriteTokenAsync(FetchReadWriteTokenRequest, CallSettings)
            // Additional: FetchReadWriteTokenAsync(FetchReadWriteTokenRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchReadWriteTokenRequest request = new FetchReadWriteTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
            };
            // Make the request
            FetchReadWriteTokenResponse response = await developerConnectClient.FetchReadWriteTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteToken</summary>
        public void FetchReadWriteToken()
        {
            // Snippet: FetchReadWriteToken(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string gitRepositoryLink = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            FetchReadWriteTokenResponse response = developerConnectClient.FetchReadWriteToken(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteTokenAsync</summary>
        public async Task FetchReadWriteTokenAsync()
        {
            // Snippet: FetchReadWriteTokenAsync(string, CallSettings)
            // Additional: FetchReadWriteTokenAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string gitRepositoryLink = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            FetchReadWriteTokenResponse response = await developerConnectClient.FetchReadWriteTokenAsync(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteToken</summary>
        public void FetchReadWriteTokenResourceNames()
        {
            // Snippet: FetchReadWriteToken(GitRepositoryLinkName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName gitRepositoryLink = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            FetchReadWriteTokenResponse response = developerConnectClient.FetchReadWriteToken(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchReadWriteTokenAsync</summary>
        public async Task FetchReadWriteTokenResourceNamesAsync()
        {
            // Snippet: FetchReadWriteTokenAsync(GitRepositoryLinkName, CallSettings)
            // Additional: FetchReadWriteTokenAsync(GitRepositoryLinkName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName gitRepositoryLink = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            FetchReadWriteTokenResponse response = await developerConnectClient.FetchReadWriteTokenAsync(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchReadToken</summary>
        public void FetchReadTokenRequestObject()
        {
            // Snippet: FetchReadToken(FetchReadTokenRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchReadTokenRequest request = new FetchReadTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
            };
            // Make the request
            FetchReadTokenResponse response = developerConnectClient.FetchReadToken(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadTokenAsync</summary>
        public async Task FetchReadTokenRequestObjectAsync()
        {
            // Snippet: FetchReadTokenAsync(FetchReadTokenRequest, CallSettings)
            // Additional: FetchReadTokenAsync(FetchReadTokenRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchReadTokenRequest request = new FetchReadTokenRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
            };
            // Make the request
            FetchReadTokenResponse response = await developerConnectClient.FetchReadTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchReadToken</summary>
        public void FetchReadToken()
        {
            // Snippet: FetchReadToken(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string gitRepositoryLink = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            FetchReadTokenResponse response = developerConnectClient.FetchReadToken(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchReadTokenAsync</summary>
        public async Task FetchReadTokenAsync()
        {
            // Snippet: FetchReadTokenAsync(string, CallSettings)
            // Additional: FetchReadTokenAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string gitRepositoryLink = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            FetchReadTokenResponse response = await developerConnectClient.FetchReadTokenAsync(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchReadToken</summary>
        public void FetchReadTokenResourceNames()
        {
            // Snippet: FetchReadToken(GitRepositoryLinkName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName gitRepositoryLink = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            FetchReadTokenResponse response = developerConnectClient.FetchReadToken(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchReadTokenAsync</summary>
        public async Task FetchReadTokenResourceNamesAsync()
        {
            // Snippet: FetchReadTokenAsync(GitRepositoryLinkName, CallSettings)
            // Additional: FetchReadTokenAsync(GitRepositoryLinkName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName gitRepositoryLink = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            FetchReadTokenResponse response = await developerConnectClient.FetchReadTokenAsync(gitRepositoryLink);
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableGitRepositories</summary>
        public void FetchLinkableGitRepositoriesRequestObject()
        {
            // Snippet: FetchLinkableGitRepositories(FetchLinkableGitRepositoriesRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchLinkableGitRepositoriesRequest request = new FetchLinkableGitRepositoriesRequest
            {
                ConnectionAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            PagedEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> response = developerConnectClient.FetchLinkableGitRepositories(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LinkableGitRepository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchLinkableGitRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkableGitRepository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkableGitRepository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkableGitRepository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableGitRepositoriesAsync</summary>
        public async Task FetchLinkableGitRepositoriesRequestObjectAsync()
        {
            // Snippet: FetchLinkableGitRepositoriesAsync(FetchLinkableGitRepositoriesRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchLinkableGitRepositoriesRequest request = new FetchLinkableGitRepositoriesRequest
            {
                ConnectionAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            PagedAsyncEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> response = developerConnectClient.FetchLinkableGitRepositoriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LinkableGitRepository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchLinkableGitRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkableGitRepository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkableGitRepository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkableGitRepository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableGitRepositories</summary>
        public void FetchLinkableGitRepositories()
        {
            // Snippet: FetchLinkableGitRepositories(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string connection = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> response = developerConnectClient.FetchLinkableGitRepositories(connection);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LinkableGitRepository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchLinkableGitRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkableGitRepository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkableGitRepository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkableGitRepository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableGitRepositoriesAsync</summary>
        public async Task FetchLinkableGitRepositoriesAsync()
        {
            // Snippet: FetchLinkableGitRepositoriesAsync(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string connection = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedAsyncEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> response = developerConnectClient.FetchLinkableGitRepositoriesAsync(connection);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LinkableGitRepository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchLinkableGitRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkableGitRepository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkableGitRepository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkableGitRepository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableGitRepositories</summary>
        public void FetchLinkableGitRepositoriesResourceNames()
        {
            // Snippet: FetchLinkableGitRepositories(ConnectionName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ConnectionName connection = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> response = developerConnectClient.FetchLinkableGitRepositories(connection);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (LinkableGitRepository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchLinkableGitRepositoriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkableGitRepository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkableGitRepository> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkableGitRepository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchLinkableGitRepositoriesAsync</summary>
        public async Task FetchLinkableGitRepositoriesResourceNamesAsync()
        {
            // Snippet: FetchLinkableGitRepositoriesAsync(ConnectionName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName connection = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedAsyncEnumerable<FetchLinkableGitRepositoriesResponse, LinkableGitRepository> response = developerConnectClient.FetchLinkableGitRepositoriesAsync(connection);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((LinkableGitRepository item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchLinkableGitRepositoriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (LinkableGitRepository item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<LinkableGitRepository> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (LinkableGitRepository item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitHubInstallations</summary>
        public void FetchGitHubInstallationsRequestObject()
        {
            // Snippet: FetchGitHubInstallations(FetchGitHubInstallationsRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchGitHubInstallationsRequest request = new FetchGitHubInstallationsRequest
            {
                ConnectionAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            FetchGitHubInstallationsResponse response = developerConnectClient.FetchGitHubInstallations(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitHubInstallationsAsync</summary>
        public async Task FetchGitHubInstallationsRequestObjectAsync()
        {
            // Snippet: FetchGitHubInstallationsAsync(FetchGitHubInstallationsRequest, CallSettings)
            // Additional: FetchGitHubInstallationsAsync(FetchGitHubInstallationsRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitHubInstallationsRequest request = new FetchGitHubInstallationsRequest
            {
                ConnectionAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            FetchGitHubInstallationsResponse response = await developerConnectClient.FetchGitHubInstallationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitHubInstallations</summary>
        public void FetchGitHubInstallations()
        {
            // Snippet: FetchGitHubInstallations(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string connection = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            FetchGitHubInstallationsResponse response = developerConnectClient.FetchGitHubInstallations(connection);
            // End snippet
        }

        /// <summary>Snippet for FetchGitHubInstallationsAsync</summary>
        public async Task FetchGitHubInstallationsAsync()
        {
            // Snippet: FetchGitHubInstallationsAsync(string, CallSettings)
            // Additional: FetchGitHubInstallationsAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string connection = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            FetchGitHubInstallationsResponse response = await developerConnectClient.FetchGitHubInstallationsAsync(connection);
            // End snippet
        }

        /// <summary>Snippet for FetchGitHubInstallations</summary>
        public void FetchGitHubInstallationsResourceNames()
        {
            // Snippet: FetchGitHubInstallations(ConnectionName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ConnectionName connection = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            FetchGitHubInstallationsResponse response = developerConnectClient.FetchGitHubInstallations(connection);
            // End snippet
        }

        /// <summary>Snippet for FetchGitHubInstallationsAsync</summary>
        public async Task FetchGitHubInstallationsResourceNamesAsync()
        {
            // Snippet: FetchGitHubInstallationsAsync(ConnectionName, CallSettings)
            // Additional: FetchGitHubInstallationsAsync(ConnectionName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName connection = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            FetchGitHubInstallationsResponse response = await developerConnectClient.FetchGitHubInstallationsAsync(connection);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefs</summary>
        public void FetchGitRefsRequestObject()
        {
            // Snippet: FetchGitRefs(FetchGitRefsRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                RefType = FetchGitRefsRequest.Types.RefType.Unspecified,
            };
            // Make the request
            PagedEnumerable<FetchGitRefsResponse, string> response = developerConnectClient.FetchGitRefs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRefsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefsAsync</summary>
        public async Task FetchGitRefsRequestObjectAsync()
        {
            // Snippet: FetchGitRefsAsync(FetchGitRefsRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitRefsRequest request = new FetchGitRefsRequest
            {
                GitRepositoryLinkAsGitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                RefType = FetchGitRefsRequest.Types.RefType.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<FetchGitRefsResponse, string> response = developerConnectClient.FetchGitRefsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchGitRefsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefs</summary>
        public void FetchGitRefs()
        {
            // Snippet: FetchGitRefs(string, FetchGitRefsRequest.Types.RefType, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string gitRepositoryLink = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            FetchGitRefsRequest.Types.RefType refType = FetchGitRefsRequest.Types.RefType.Unspecified;
            // Make the request
            PagedEnumerable<FetchGitRefsResponse, string> response = developerConnectClient.FetchGitRefs(gitRepositoryLink, refType);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRefsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefsAsync</summary>
        public async Task FetchGitRefsAsync()
        {
            // Snippet: FetchGitRefsAsync(string, FetchGitRefsRequest.Types.RefType, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string gitRepositoryLink = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            FetchGitRefsRequest.Types.RefType refType = FetchGitRefsRequest.Types.RefType.Unspecified;
            // Make the request
            PagedAsyncEnumerable<FetchGitRefsResponse, string> response = developerConnectClient.FetchGitRefsAsync(gitRepositoryLink, refType);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchGitRefsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefs</summary>
        public void FetchGitRefsResourceNames()
        {
            // Snippet: FetchGitRefs(GitRepositoryLinkName, FetchGitRefsRequest.Types.RefType, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName gitRepositoryLink = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            FetchGitRefsRequest.Types.RefType refType = FetchGitRefsRequest.Types.RefType.Unspecified;
            // Make the request
            PagedEnumerable<FetchGitRefsResponse, string> response = developerConnectClient.FetchGitRefs(gitRepositoryLink, refType);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRefsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRefsAsync</summary>
        public async Task FetchGitRefsResourceNamesAsync()
        {
            // Snippet: FetchGitRefsAsync(GitRepositoryLinkName, FetchGitRefsRequest.Types.RefType, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName gitRepositoryLink = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            FetchGitRefsRequest.Types.RefType refType = FetchGitRefsRequest.Types.RefType.Unspecified;
            // Make the request
            PagedAsyncEnumerable<FetchGitRefsResponse, string> response = developerConnectClient.FetchGitRefsAsync(gitRepositoryLink, refType);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((string item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchGitRefsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (string item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<string> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (string item in singlePage)
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
