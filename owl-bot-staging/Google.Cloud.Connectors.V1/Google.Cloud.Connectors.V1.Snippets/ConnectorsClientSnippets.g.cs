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
    using Google.Cloud.Connectors.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConnectorsClientSnippets
    {
        /// <summary>Snippet for ListConnections</summary>
        public void ListConnectionsRequestObject()
        {
            // Snippet: ListConnections(ListConnectionsRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = ConnectionView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = connectorsClient.ListConnections(request);

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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = ConnectionView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = connectorsClient.ListConnectionsAsync(request);

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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = connectorsClient.ListConnections(parent);

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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = connectorsClient.ListConnectionsAsync(parent);

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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectionsResponse, Connection> response = connectorsClient.ListConnections(parent);

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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectionsResponse, Connection> response = connectorsClient.ListConnectionsAsync(parent);

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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                View = ConnectionView.Unspecified,
            };
            // Make the request
            Connection response = connectorsClient.GetConnection(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionRequestObjectAsync()
        {
            // Snippet: GetConnectionAsync(GetConnectionRequest, CallSettings)
            // Additional: GetConnectionAsync(GetConnectionRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionRequest request = new GetConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                View = ConnectionView.Unspecified,
            };
            // Make the request
            Connection response = await connectorsClient.GetConnectionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnection()
        {
            // Snippet: GetConnection(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = connectorsClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionAsync()
        {
            // Snippet: GetConnectionAsync(string, CallSettings)
            // Additional: GetConnectionAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Connection response = await connectorsClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnection</summary>
        public void GetConnectionResourceNames()
        {
            // Snippet: GetConnection(ConnectionName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = connectorsClient.GetConnection(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionAsync</summary>
        public async Task GetConnectionResourceNamesAsync()
        {
            // Snippet: GetConnectionAsync(ConnectionName, CallSettings)
            // Additional: GetConnectionAsync(ConnectionName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Connection response = await connectorsClient.GetConnectionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConnection</summary>
        public void CreateConnectionRequestObject()
        {
            // Snippet: CreateConnection(CreateConnectionRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "",
                Connection = new Connection(),
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = connectorsClient.CreateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = connectorsClient.PollOnceCreateConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectionRequest request = new CreateConnectionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectionId = "",
                Connection = new Connection(),
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = await connectorsClient.CreateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceCreateConnectionAsync(operationName);
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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = connectorsClient.CreateConnection(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = connectorsClient.PollOnceCreateConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = await connectorsClient.CreateConnectionAsync(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceCreateConnectionAsync(operationName);
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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = connectorsClient.CreateConnection(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = connectorsClient.PollOnceCreateConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Connection connection = new Connection();
            string connectionId = "";
            // Make the request
            Operation<Connection, OperationMetadata> response = await connectorsClient.CreateConnectionAsync(parent, connection, connectionId);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceCreateConnectionAsync(operationName);
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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = connectorsClient.UpdateConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = connectorsClient.PollOnceUpdateConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectionRequest request = new UpdateConnectionRequest
            {
                Connection = new Connection(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Connection, OperationMetadata> response = await connectorsClient.UpdateConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceUpdateConnectionAsync(operationName);
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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Connection, OperationMetadata> response = connectorsClient.UpdateConnection(connection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = connectorsClient.PollOnceUpdateConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            Connection connection = new Connection();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Connection, OperationMetadata> response = await connectorsClient.UpdateConnectionAsync(connection, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Connection, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Connection result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Connection, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceUpdateConnectionAsync(operationName);
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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = connectorsClient.DeleteConnection(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = connectorsClient.PollOnceDeleteConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectionRequest request = new DeleteConnectionRequest
            {
                ConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await connectorsClient.DeleteConnectionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceDeleteConnectionAsync(operationName);
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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = connectorsClient.DeleteConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = connectorsClient.PollOnceDeleteConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await connectorsClient.DeleteConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceDeleteConnectionAsync(operationName);
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
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = connectorsClient.DeleteConnection(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = connectorsClient.PollOnceDeleteConnection(operationName);
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
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName name = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await connectorsClient.DeleteConnectionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceDeleteConnectionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListProviders</summary>
        public void ListProvidersRequestObject()
        {
            // Snippet: ListProviders(ListProvidersRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ListProvidersRequest request = new ListProvidersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListProvidersResponse, Provider> response = connectorsClient.ListProviders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Provider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvidersAsync</summary>
        public async Task ListProvidersRequestObjectAsync()
        {
            // Snippet: ListProvidersAsync(ListProvidersRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ListProvidersRequest request = new ListProvidersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListProvidersResponse, Provider> response = connectorsClient.ListProvidersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Provider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProviders</summary>
        public void ListProviders()
        {
            // Snippet: ListProviders(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListProvidersResponse, Provider> response = connectorsClient.ListProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Provider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvidersAsync</summary>
        public async Task ListProvidersAsync()
        {
            // Snippet: ListProvidersAsync(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListProvidersResponse, Provider> response = connectorsClient.ListProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Provider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProviders</summary>
        public void ListProvidersResourceNames()
        {
            // Snippet: ListProviders(LocationName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListProvidersResponse, Provider> response = connectorsClient.ListProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Provider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListProvidersAsync</summary>
        public async Task ListProvidersResourceNamesAsync()
        {
            // Snippet: ListProvidersAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListProvidersResponse, Provider> response = connectorsClient.ListProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Provider item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListProvidersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Provider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Provider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Provider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetProvider</summary>
        public void GetProviderRequestObject()
        {
            // Snippet: GetProvider(GetProviderRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            GetProviderRequest request = new GetProviderRequest
            {
                ProviderName = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]"),
            };
            // Make the request
            Provider response = connectorsClient.GetProvider(request);
            // End snippet
        }

        /// <summary>Snippet for GetProviderAsync</summary>
        public async Task GetProviderRequestObjectAsync()
        {
            // Snippet: GetProviderAsync(GetProviderRequest, CallSettings)
            // Additional: GetProviderAsync(GetProviderRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            GetProviderRequest request = new GetProviderRequest
            {
                ProviderName = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]"),
            };
            // Make the request
            Provider response = await connectorsClient.GetProviderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetProvider</summary>
        public void GetProvider()
        {
            // Snippet: GetProvider(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]";
            // Make the request
            Provider response = connectorsClient.GetProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetProviderAsync</summary>
        public async Task GetProviderAsync()
        {
            // Snippet: GetProviderAsync(string, CallSettings)
            // Additional: GetProviderAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]";
            // Make the request
            Provider response = await connectorsClient.GetProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetProvider</summary>
        public void GetProviderResourceNames()
        {
            // Snippet: GetProvider(ProviderName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ProviderName name = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]");
            // Make the request
            Provider response = connectorsClient.GetProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetProviderAsync</summary>
        public async Task GetProviderResourceNamesAsync()
        {
            // Snippet: GetProviderAsync(ProviderName, CallSettings)
            // Additional: GetProviderAsync(ProviderName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ProviderName name = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]");
            // Make the request
            Provider response = await connectorsClient.GetProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConnectors</summary>
        public void ListConnectorsRequestObject()
        {
            // Snippet: ListConnectors(ListConnectorsRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsProviderName = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]"),
            };
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = connectorsClient.ListConnectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorsAsync</summary>
        public async Task ListConnectorsRequestObjectAsync()
        {
            // Snippet: ListConnectorsAsync(ListConnectorsRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsProviderName = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = connectorsClient.ListConnectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectors</summary>
        public void ListConnectors()
        {
            // Snippet: ListConnectors(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]";
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = connectorsClient.ListConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorsAsync</summary>
        public async Task ListConnectorsAsync()
        {
            // Snippet: ListConnectorsAsync(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]";
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = connectorsClient.ListConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectors</summary>
        public void ListConnectorsResourceNames()
        {
            // Snippet: ListConnectors(ProviderName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ProviderName parent = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]");
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = connectorsClient.ListConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Connector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorsAsync</summary>
        public async Task ListConnectorsResourceNamesAsync()
        {
            // Snippet: ListConnectorsAsync(ProviderName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ProviderName parent = ProviderName.FromProjectLocationProvider("[PROJECT]", "[LOCATION]", "[PROVIDER]");
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = connectorsClient.ListConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Connector item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Connector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Connector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Connector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnectorRequestObject()
        {
            // Snippet: GetConnector(GetConnectorRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]"),
            };
            // Make the request
            Connector response = connectorsClient.GetConnector(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorRequestObjectAsync()
        {
            // Snippet: GetConnectorAsync(GetConnectorRequest, CallSettings)
            // Additional: GetConnectorAsync(GetConnectorRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]"),
            };
            // Make the request
            Connector response = await connectorsClient.GetConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnector()
        {
            // Snippet: GetConnector(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]/connectors/[CONNECTOR]";
            // Make the request
            Connector response = connectorsClient.GetConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorAsync()
        {
            // Snippet: GetConnectorAsync(string, CallSettings)
            // Additional: GetConnectorAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]/connectors/[CONNECTOR]";
            // Make the request
            Connector response = await connectorsClient.GetConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnectorResourceNames()
        {
            // Snippet: GetConnector(ConnectorName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]");
            // Make the request
            Connector response = connectorsClient.GetConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorResourceNamesAsync()
        {
            // Snippet: GetConnectorAsync(ConnectorName, CallSettings)
            // Additional: GetConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]");
            // Make the request
            Connector response = await connectorsClient.GetConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConnectorVersions</summary>
        public void ListConnectorVersionsRequestObject()
        {
            // Snippet: ListConnectorVersions(ListConnectorVersionsRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ListConnectorVersionsRequest request = new ListConnectorVersionsRequest
            {
                ParentAsConnectorName = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]"),
                View = ConnectorVersionView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListConnectorVersionsResponse, ConnectorVersion> response = connectorsClient.ListConnectorVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorVersionsAsync</summary>
        public async Task ListConnectorVersionsRequestObjectAsync()
        {
            // Snippet: ListConnectorVersionsAsync(ListConnectorVersionsRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectorVersionsRequest request = new ListConnectorVersionsRequest
            {
                ParentAsConnectorName = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]"),
                View = ConnectorVersionView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectorVersionsResponse, ConnectorVersion> response = connectorsClient.ListConnectorVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorVersions</summary>
        public void ListConnectorVersions()
        {
            // Snippet: ListConnectorVersions(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]/connectors/[CONNECTOR]";
            // Make the request
            PagedEnumerable<ListConnectorVersionsResponse, ConnectorVersion> response = connectorsClient.ListConnectorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorVersionsAsync</summary>
        public async Task ListConnectorVersionsAsync()
        {
            // Snippet: ListConnectorVersionsAsync(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]/connectors/[CONNECTOR]";
            // Make the request
            PagedAsyncEnumerable<ListConnectorVersionsResponse, ConnectorVersion> response = connectorsClient.ListConnectorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorVersions</summary>
        public void ListConnectorVersionsResourceNames()
        {
            // Snippet: ListConnectorVersions(ConnectorName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectorName parent = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]");
            // Make the request
            PagedEnumerable<ListConnectorVersionsResponse, ConnectorVersion> response = connectorsClient.ListConnectorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectorVersionsAsync</summary>
        public async Task ListConnectorVersionsResourceNamesAsync()
        {
            // Snippet: ListConnectorVersionsAsync(ConnectorName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName parent = ConnectorName.FromProjectLocationProviderConnector("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]");
            // Make the request
            PagedAsyncEnumerable<ListConnectorVersionsResponse, ConnectorVersion> response = connectorsClient.ListConnectorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConnectorVersion</summary>
        public void GetConnectorVersionRequestObject()
        {
            // Snippet: GetConnectorVersion(GetConnectorVersionRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            GetConnectorVersionRequest request = new GetConnectorVersionRequest
            {
                ConnectorVersionName = ConnectorVersionName.FromProjectLocationProviderConnectorVersion("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]", "[VERSION]"),
                View = ConnectorVersionView.Unspecified,
            };
            // Make the request
            ConnectorVersion response = connectorsClient.GetConnectorVersion(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorVersionAsync</summary>
        public async Task GetConnectorVersionRequestObjectAsync()
        {
            // Snippet: GetConnectorVersionAsync(GetConnectorVersionRequest, CallSettings)
            // Additional: GetConnectorVersionAsync(GetConnectorVersionRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectorVersionRequest request = new GetConnectorVersionRequest
            {
                ConnectorVersionName = ConnectorVersionName.FromProjectLocationProviderConnectorVersion("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]", "[VERSION]"),
                View = ConnectorVersionView.Unspecified,
            };
            // Make the request
            ConnectorVersion response = await connectorsClient.GetConnectorVersionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorVersion</summary>
        public void GetConnectorVersion()
        {
            // Snippet: GetConnectorVersion(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]/connectors/[CONNECTOR]/versions/[VERSION]";
            // Make the request
            ConnectorVersion response = connectorsClient.GetConnectorVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorVersionAsync</summary>
        public async Task GetConnectorVersionAsync()
        {
            // Snippet: GetConnectorVersionAsync(string, CallSettings)
            // Additional: GetConnectorVersionAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/providers/[PROVIDER]/connectors/[CONNECTOR]/versions/[VERSION]";
            // Make the request
            ConnectorVersion response = await connectorsClient.GetConnectorVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorVersion</summary>
        public void GetConnectorVersionResourceNames()
        {
            // Snippet: GetConnectorVersion(ConnectorVersionName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectorVersionName name = ConnectorVersionName.FromProjectLocationProviderConnectorVersion("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]", "[VERSION]");
            // Make the request
            ConnectorVersion response = connectorsClient.GetConnectorVersion(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorVersionAsync</summary>
        public async Task GetConnectorVersionResourceNamesAsync()
        {
            // Snippet: GetConnectorVersionAsync(ConnectorVersionName, CallSettings)
            // Additional: GetConnectorVersionAsync(ConnectorVersionName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorVersionName name = ConnectorVersionName.FromProjectLocationProviderConnectorVersion("[PROJECT]", "[LOCATION]", "[PROVIDER]", "[CONNECTOR]", "[VERSION]");
            // Make the request
            ConnectorVersion response = await connectorsClient.GetConnectorVersionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionSchemaMetadata</summary>
        public void GetConnectionSchemaMetadataRequestObject()
        {
            // Snippet: GetConnectionSchemaMetadata(GetConnectionSchemaMetadataRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            GetConnectionSchemaMetadataRequest request = new GetConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            ConnectionSchemaMetadata response = connectorsClient.GetConnectionSchemaMetadata(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionSchemaMetadataAsync</summary>
        public async Task GetConnectionSchemaMetadataRequestObjectAsync()
        {
            // Snippet: GetConnectionSchemaMetadataAsync(GetConnectionSchemaMetadataRequest, CallSettings)
            // Additional: GetConnectionSchemaMetadataAsync(GetConnectionSchemaMetadataRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionSchemaMetadataRequest request = new GetConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            ConnectionSchemaMetadata response = await connectorsClient.GetConnectionSchemaMetadataAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionSchemaMetadata</summary>
        public void GetConnectionSchemaMetadata()
        {
            // Snippet: GetConnectionSchemaMetadata(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/connectionSchemaMetadata";
            // Make the request
            ConnectionSchemaMetadata response = connectorsClient.GetConnectionSchemaMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionSchemaMetadataAsync</summary>
        public async Task GetConnectionSchemaMetadataAsync()
        {
            // Snippet: GetConnectionSchemaMetadataAsync(string, CallSettings)
            // Additional: GetConnectionSchemaMetadataAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/connectionSchemaMetadata";
            // Make the request
            ConnectionSchemaMetadata response = await connectorsClient.GetConnectionSchemaMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionSchemaMetadata</summary>
        public void GetConnectionSchemaMetadataResourceNames()
        {
            // Snippet: GetConnectionSchemaMetadata(ConnectionSchemaMetadataName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectionSchemaMetadataName name = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            ConnectionSchemaMetadata response = connectorsClient.GetConnectionSchemaMetadata(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionSchemaMetadataAsync</summary>
        public async Task GetConnectionSchemaMetadataResourceNamesAsync()
        {
            // Snippet: GetConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName, CallSettings)
            // Additional: GetConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionSchemaMetadataName name = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            ConnectionSchemaMetadata response = await connectorsClient.GetConnectionSchemaMetadataAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RefreshConnectionSchemaMetadata</summary>
        public void RefreshConnectionSchemaMetadataRequestObject()
        {
            // Snippet: RefreshConnectionSchemaMetadata(RefreshConnectionSchemaMetadataRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            RefreshConnectionSchemaMetadataRequest request = new RefreshConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Operation<ConnectionSchemaMetadata, OperationMetadata> response = connectorsClient.RefreshConnectionSchemaMetadata(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionSchemaMetadata, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionSchemaMetadata result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionSchemaMetadata, OperationMetadata> retrievedResponse = connectorsClient.PollOnceRefreshConnectionSchemaMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionSchemaMetadata retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RefreshConnectionSchemaMetadataAsync</summary>
        public async Task RefreshConnectionSchemaMetadataRequestObjectAsync()
        {
            // Snippet: RefreshConnectionSchemaMetadataAsync(RefreshConnectionSchemaMetadataRequest, CallSettings)
            // Additional: RefreshConnectionSchemaMetadataAsync(RefreshConnectionSchemaMetadataRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            RefreshConnectionSchemaMetadataRequest request = new RefreshConnectionSchemaMetadataRequest
            {
                ConnectionSchemaMetadataName = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
            };
            // Make the request
            Operation<ConnectionSchemaMetadata, OperationMetadata> response = await connectorsClient.RefreshConnectionSchemaMetadataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionSchemaMetadata, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionSchemaMetadata result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionSchemaMetadata, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceRefreshConnectionSchemaMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionSchemaMetadata retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RefreshConnectionSchemaMetadata</summary>
        public void RefreshConnectionSchemaMetadata()
        {
            // Snippet: RefreshConnectionSchemaMetadata(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/connectionSchemaMetadata";
            // Make the request
            Operation<ConnectionSchemaMetadata, OperationMetadata> response = connectorsClient.RefreshConnectionSchemaMetadata(name);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionSchemaMetadata, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionSchemaMetadata result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionSchemaMetadata, OperationMetadata> retrievedResponse = connectorsClient.PollOnceRefreshConnectionSchemaMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionSchemaMetadata retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RefreshConnectionSchemaMetadataAsync</summary>
        public async Task RefreshConnectionSchemaMetadataAsync()
        {
            // Snippet: RefreshConnectionSchemaMetadataAsync(string, CallSettings)
            // Additional: RefreshConnectionSchemaMetadataAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/connectionSchemaMetadata";
            // Make the request
            Operation<ConnectionSchemaMetadata, OperationMetadata> response = await connectorsClient.RefreshConnectionSchemaMetadataAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionSchemaMetadata, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionSchemaMetadata result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionSchemaMetadata, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceRefreshConnectionSchemaMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionSchemaMetadata retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RefreshConnectionSchemaMetadata</summary>
        public void RefreshConnectionSchemaMetadataResourceNames()
        {
            // Snippet: RefreshConnectionSchemaMetadata(ConnectionSchemaMetadataName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectionSchemaMetadataName name = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<ConnectionSchemaMetadata, OperationMetadata> response = connectorsClient.RefreshConnectionSchemaMetadata(name);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionSchemaMetadata, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectionSchemaMetadata result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionSchemaMetadata, OperationMetadata> retrievedResponse = connectorsClient.PollOnceRefreshConnectionSchemaMetadata(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionSchemaMetadata retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RefreshConnectionSchemaMetadataAsync</summary>
        public async Task RefreshConnectionSchemaMetadataResourceNamesAsync()
        {
            // Snippet: RefreshConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName, CallSettings)
            // Additional: RefreshConnectionSchemaMetadataAsync(ConnectionSchemaMetadataName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionSchemaMetadataName name = ConnectionSchemaMetadataName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            Operation<ConnectionSchemaMetadata, OperationMetadata> response = await connectorsClient.RefreshConnectionSchemaMetadataAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ConnectionSchemaMetadata, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectionSchemaMetadata result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectionSchemaMetadata, OperationMetadata> retrievedResponse = await connectorsClient.PollOnceRefreshConnectionSchemaMetadataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectionSchemaMetadata retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeEntitySchemas</summary>
        public void ListRuntimeEntitySchemasRequestObject()
        {
            // Snippet: ListRuntimeEntitySchemas(ListRuntimeEntitySchemasRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ListRuntimeEntitySchemasRequest request = new ListRuntimeEntitySchemasRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> response = connectorsClient.ListRuntimeEntitySchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeEntitySchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeEntitySchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeEntitySchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeEntitySchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeEntitySchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeEntitySchemasAsync</summary>
        public async Task ListRuntimeEntitySchemasRequestObjectAsync()
        {
            // Snippet: ListRuntimeEntitySchemasAsync(ListRuntimeEntitySchemasRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ListRuntimeEntitySchemasRequest request = new ListRuntimeEntitySchemasRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> response = connectorsClient.ListRuntimeEntitySchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeEntitySchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeEntitySchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeEntitySchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeEntitySchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeEntitySchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeEntitySchemas</summary>
        public void ListRuntimeEntitySchemas()
        {
            // Snippet: ListRuntimeEntitySchemas(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> response = connectorsClient.ListRuntimeEntitySchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeEntitySchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeEntitySchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeEntitySchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeEntitySchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeEntitySchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeEntitySchemasAsync</summary>
        public async Task ListRuntimeEntitySchemasAsync()
        {
            // Snippet: ListRuntimeEntitySchemasAsync(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedAsyncEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> response = connectorsClient.ListRuntimeEntitySchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeEntitySchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeEntitySchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeEntitySchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeEntitySchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeEntitySchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeEntitySchemas</summary>
        public void ListRuntimeEntitySchemasResourceNames()
        {
            // Snippet: ListRuntimeEntitySchemas(ConnectionName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> response = connectorsClient.ListRuntimeEntitySchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeEntitySchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeEntitySchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeEntitySchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeEntitySchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeEntitySchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeEntitySchemasAsync</summary>
        public async Task ListRuntimeEntitySchemasResourceNamesAsync()
        {
            // Snippet: ListRuntimeEntitySchemasAsync(ConnectionName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedAsyncEnumerable<ListRuntimeEntitySchemasResponse, RuntimeEntitySchema> response = connectorsClient.ListRuntimeEntitySchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeEntitySchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeEntitySchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeEntitySchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeEntitySchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeEntitySchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeActionSchemas</summary>
        public void ListRuntimeActionSchemasRequestObject()
        {
            // Snippet: ListRuntimeActionSchemas(ListRuntimeActionSchemasRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ListRuntimeActionSchemasRequest request = new ListRuntimeActionSchemasRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> response = connectorsClient.ListRuntimeActionSchemas(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeActionSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeActionSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeActionSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeActionSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeActionSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeActionSchemasAsync</summary>
        public async Task ListRuntimeActionSchemasRequestObjectAsync()
        {
            // Snippet: ListRuntimeActionSchemasAsync(ListRuntimeActionSchemasRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ListRuntimeActionSchemasRequest request = new ListRuntimeActionSchemasRequest
            {
                ParentAsConnectionName = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> response = connectorsClient.ListRuntimeActionSchemasAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeActionSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeActionSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeActionSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeActionSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeActionSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeActionSchemas</summary>
        public void ListRuntimeActionSchemas()
        {
            // Snippet: ListRuntimeActionSchemas(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> response = connectorsClient.ListRuntimeActionSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeActionSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeActionSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeActionSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeActionSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeActionSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeActionSchemasAsync</summary>
        public async Task ListRuntimeActionSchemasAsync()
        {
            // Snippet: ListRuntimeActionSchemasAsync(string, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]";
            // Make the request
            PagedAsyncEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> response = connectorsClient.ListRuntimeActionSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeActionSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeActionSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeActionSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeActionSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeActionSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeActionSchemas</summary>
        public void ListRuntimeActionSchemasResourceNames()
        {
            // Snippet: ListRuntimeActionSchemas(ConnectionName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> response = connectorsClient.ListRuntimeActionSchemas(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuntimeActionSchema item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuntimeActionSchemasResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeActionSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeActionSchema> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeActionSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuntimeActionSchemasAsync</summary>
        public async Task ListRuntimeActionSchemasResourceNamesAsync()
        {
            // Snippet: ListRuntimeActionSchemasAsync(ConnectionName, string, int?, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            ConnectionName parent = ConnectionName.FromProjectLocationConnection("[PROJECT]", "[LOCATION]", "[CONNECTION]");
            // Make the request
            PagedAsyncEnumerable<ListRuntimeActionSchemasResponse, RuntimeActionSchema> response = connectorsClient.ListRuntimeActionSchemasAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((RuntimeActionSchema item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRuntimeActionSchemasResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuntimeActionSchema item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuntimeActionSchema> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuntimeActionSchema item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeConfig</summary>
        public void GetRuntimeConfigRequestObject()
        {
            // Snippet: GetRuntimeConfig(GetRuntimeConfigRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            GetRuntimeConfigRequest request = new GetRuntimeConfigRequest
            {
                RuntimeConfigName = RuntimeConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RuntimeConfig response = connectorsClient.GetRuntimeConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeConfigAsync</summary>
        public async Task GetRuntimeConfigRequestObjectAsync()
        {
            // Snippet: GetRuntimeConfigAsync(GetRuntimeConfigRequest, CallSettings)
            // Additional: GetRuntimeConfigAsync(GetRuntimeConfigRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            GetRuntimeConfigRequest request = new GetRuntimeConfigRequest
            {
                RuntimeConfigName = RuntimeConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            RuntimeConfig response = await connectorsClient.GetRuntimeConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeConfig</summary>
        public void GetRuntimeConfig()
        {
            // Snippet: GetRuntimeConfig(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimeConfig";
            // Make the request
            RuntimeConfig response = connectorsClient.GetRuntimeConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeConfigAsync</summary>
        public async Task GetRuntimeConfigAsync()
        {
            // Snippet: GetRuntimeConfigAsync(string, CallSettings)
            // Additional: GetRuntimeConfigAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/runtimeConfig";
            // Make the request
            RuntimeConfig response = await connectorsClient.GetRuntimeConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeConfig</summary>
        public void GetRuntimeConfigResourceNames()
        {
            // Snippet: GetRuntimeConfig(RuntimeConfigName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            RuntimeConfigName name = RuntimeConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            RuntimeConfig response = connectorsClient.GetRuntimeConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetRuntimeConfigAsync</summary>
        public async Task GetRuntimeConfigResourceNamesAsync()
        {
            // Snippet: GetRuntimeConfigAsync(RuntimeConfigName, CallSettings)
            // Additional: GetRuntimeConfigAsync(RuntimeConfigName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            RuntimeConfigName name = RuntimeConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            RuntimeConfig response = await connectorsClient.GetRuntimeConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSettings</summary>
        public void GetGlobalSettingsRequestObject()
        {
            // Snippet: GetGlobalSettings(GetGlobalSettingsRequest, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            GetGlobalSettingsRequest request = new GetGlobalSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            Settings response = connectorsClient.GetGlobalSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSettingsAsync</summary>
        public async Task GetGlobalSettingsRequestObjectAsync()
        {
            // Snippet: GetGlobalSettingsAsync(GetGlobalSettingsRequest, CallSettings)
            // Additional: GetGlobalSettingsAsync(GetGlobalSettingsRequest, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalSettingsRequest request = new GetGlobalSettingsRequest
            {
                SettingsName = SettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            Settings response = await connectorsClient.GetGlobalSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSettings</summary>
        public void GetGlobalSettings()
        {
            // Snippet: GetGlobalSettings(string, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/settings";
            // Make the request
            Settings response = connectorsClient.GetGlobalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSettingsAsync</summary>
        public async Task GetGlobalSettingsAsync()
        {
            // Snippet: GetGlobalSettingsAsync(string, CallSettings)
            // Additional: GetGlobalSettingsAsync(string, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/global/settings";
            // Make the request
            Settings response = await connectorsClient.GetGlobalSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSettings</summary>
        public void GetGlobalSettingsResourceNames()
        {
            // Snippet: GetGlobalSettings(SettingsName, CallSettings)
            // Create client
            ConnectorsClient connectorsClient = ConnectorsClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProject("[PROJECT]");
            // Make the request
            Settings response = connectorsClient.GetGlobalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetGlobalSettingsAsync</summary>
        public async Task GetGlobalSettingsResourceNamesAsync()
        {
            // Snippet: GetGlobalSettingsAsync(SettingsName, CallSettings)
            // Additional: GetGlobalSettingsAsync(SettingsName, CancellationToken)
            // Create client
            ConnectorsClient connectorsClient = await ConnectorsClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProject("[PROJECT]");
            // Make the request
            Settings response = await connectorsClient.GetGlobalSettingsAsync(name);
            // End snippet
        }
    }
}
