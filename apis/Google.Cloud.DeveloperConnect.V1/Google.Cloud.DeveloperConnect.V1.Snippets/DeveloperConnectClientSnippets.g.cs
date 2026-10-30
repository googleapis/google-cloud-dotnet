// Copyright 2026 Google LLC
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
            await foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConnectionsResponse page in response.AsRawResponses())
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
            await foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConnectionsResponse page in response.AsRawResponses())
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
            await foreach (Connection item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListConnectionsResponse page in response.AsRawResponses())
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
            await foreach (GitRepositoryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGitRepositoryLinksResponse page in response.AsRawResponses())
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
            await foreach (GitRepositoryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGitRepositoryLinksResponse page in response.AsRawResponses())
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
            await foreach (GitRepositoryLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListGitRepositoryLinksResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for OpenGitRepositoryLinkPullRequest</summary>
        public void OpenGitRepositoryLinkPullRequestRequestObject()
        {
            // Snippet: OpenGitRepositoryLinkPullRequest(OpenGitRepositoryLinkPullRequestRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            OpenGitRepositoryLinkPullRequestRequest request = new OpenGitRepositoryLinkPullRequestRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequest = new PullRequest(),
            };
            // Make the request
            PullRequest response = developerConnectClient.OpenGitRepositoryLinkPullRequest(request);
            // End snippet
        }

        /// <summary>Snippet for OpenGitRepositoryLinkPullRequestAsync</summary>
        public async Task OpenGitRepositoryLinkPullRequestRequestObjectAsync()
        {
            // Snippet: OpenGitRepositoryLinkPullRequestAsync(OpenGitRepositoryLinkPullRequestRequest, CallSettings)
            // Additional: OpenGitRepositoryLinkPullRequestAsync(OpenGitRepositoryLinkPullRequestRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            OpenGitRepositoryLinkPullRequestRequest request = new OpenGitRepositoryLinkPullRequestRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequest = new PullRequest(),
            };
            // Make the request
            PullRequest response = await developerConnectClient.OpenGitRepositoryLinkPullRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for OpenGitRepositoryLinkPullRequest</summary>
        public void OpenGitRepositoryLinkPullRequest()
        {
            // Snippet: OpenGitRepositoryLinkPullRequest(string, PullRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            PullRequest pullRequest = new PullRequest();
            // Make the request
            PullRequest response = developerConnectClient.OpenGitRepositoryLinkPullRequest(name, pullRequest);
            // End snippet
        }

        /// <summary>Snippet for OpenGitRepositoryLinkPullRequestAsync</summary>
        public async Task OpenGitRepositoryLinkPullRequestAsync()
        {
            // Snippet: OpenGitRepositoryLinkPullRequestAsync(string, PullRequest, CallSettings)
            // Additional: OpenGitRepositoryLinkPullRequestAsync(string, PullRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            PullRequest pullRequest = new PullRequest();
            // Make the request
            PullRequest response = await developerConnectClient.OpenGitRepositoryLinkPullRequestAsync(name, pullRequest);
            // End snippet
        }

        /// <summary>Snippet for OpenGitRepositoryLinkPullRequest</summary>
        public void OpenGitRepositoryLinkPullRequestResourceNames()
        {
            // Snippet: OpenGitRepositoryLinkPullRequest(GitRepositoryLinkName, PullRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            PullRequest pullRequest = new PullRequest();
            // Make the request
            PullRequest response = developerConnectClient.OpenGitRepositoryLinkPullRequest(name, pullRequest);
            // End snippet
        }

        /// <summary>Snippet for OpenGitRepositoryLinkPullRequestAsync</summary>
        public async Task OpenGitRepositoryLinkPullRequestResourceNamesAsync()
        {
            // Snippet: OpenGitRepositoryLinkPullRequestAsync(GitRepositoryLinkName, PullRequest, CallSettings)
            // Additional: OpenGitRepositoryLinkPullRequestAsync(GitRepositoryLinkName, PullRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            PullRequest pullRequest = new PullRequest();
            // Make the request
            PullRequest response = await developerConnectClient.OpenGitRepositoryLinkPullRequestAsync(name, pullRequest);
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
            await foreach (LinkableGitRepository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchLinkableGitRepositoriesResponse page in response.AsRawResponses())
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
            await foreach (LinkableGitRepository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchLinkableGitRepositoriesResponse page in response.AsRawResponses())
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
            await foreach (LinkableGitRepository item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchLinkableGitRepositoriesResponse page in response.AsRawResponses())
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
            await foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRefsResponse page in response.AsRawResponses())
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
            await foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRefsResponse page in response.AsRawResponses())
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
            await foreach (string item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRefsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for DiffGitRepositoryLinkCommit</summary>
        public void DiffGitRepositoryLinkCommitRequestObject()
        {
            // Snippet: DiffGitRepositoryLinkCommit(DiffGitRepositoryLinkCommitRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            DiffGitRepositoryLinkCommitRequest request = new DiffGitRepositoryLinkCommitRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                BaseSha = "",
                HeadSha = "",
                PathFilters = { "", },
            };
            // Make the request
            DiffGitRepositoryLinkCommitResponse response = developerConnectClient.DiffGitRepositoryLinkCommit(request);
            // End snippet
        }

        /// <summary>Snippet for DiffGitRepositoryLinkCommitAsync</summary>
        public async Task DiffGitRepositoryLinkCommitRequestObjectAsync()
        {
            // Snippet: DiffGitRepositoryLinkCommitAsync(DiffGitRepositoryLinkCommitRequest, CallSettings)
            // Additional: DiffGitRepositoryLinkCommitAsync(DiffGitRepositoryLinkCommitRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            DiffGitRepositoryLinkCommitRequest request = new DiffGitRepositoryLinkCommitRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                BaseSha = "",
                HeadSha = "",
                PathFilters = { "", },
            };
            // Make the request
            DiffGitRepositoryLinkCommitResponse response = await developerConnectClient.DiffGitRepositoryLinkCommitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DiffGitRepositoryLinkCommit</summary>
        public void DiffGitRepositoryLinkCommit()
        {
            // Snippet: DiffGitRepositoryLinkCommit(string, string, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string baseSha = "";
            string headSha = "";
            // Make the request
            DiffGitRepositoryLinkCommitResponse response = developerConnectClient.DiffGitRepositoryLinkCommit(name, baseSha, headSha);
            // End snippet
        }

        /// <summary>Snippet for DiffGitRepositoryLinkCommitAsync</summary>
        public async Task DiffGitRepositoryLinkCommitAsync()
        {
            // Snippet: DiffGitRepositoryLinkCommitAsync(string, string, string, CallSettings)
            // Additional: DiffGitRepositoryLinkCommitAsync(string, string, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string baseSha = "";
            string headSha = "";
            // Make the request
            DiffGitRepositoryLinkCommitResponse response = await developerConnectClient.DiffGitRepositoryLinkCommitAsync(name, baseSha, headSha);
            // End snippet
        }

        /// <summary>Snippet for DiffGitRepositoryLinkCommit</summary>
        public void DiffGitRepositoryLinkCommitResourceNames()
        {
            // Snippet: DiffGitRepositoryLinkCommit(GitRepositoryLinkName, string, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string baseSha = "";
            string headSha = "";
            // Make the request
            DiffGitRepositoryLinkCommitResponse response = developerConnectClient.DiffGitRepositoryLinkCommit(name, baseSha, headSha);
            // End snippet
        }

        /// <summary>Snippet for DiffGitRepositoryLinkCommitAsync</summary>
        public async Task DiffGitRepositoryLinkCommitResourceNamesAsync()
        {
            // Snippet: DiffGitRepositoryLinkCommitAsync(GitRepositoryLinkName, string, string, CallSettings)
            // Additional: DiffGitRepositoryLinkCommitAsync(GitRepositoryLinkName, string, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string baseSha = "";
            string headSha = "";
            // Make the request
            DiffGitRepositoryLinkCommitResponse response = await developerConnectClient.DiffGitRepositoryLinkCommitAsync(name, baseSha, headSha);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommit</summary>
        public void FetchGitRepositoryLinkCommitRequestObject()
        {
            // Snippet: FetchGitRepositoryLinkCommit(FetchGitRepositoryLinkCommitRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchGitRepositoryLinkCommitRequest request = new FetchGitRepositoryLinkCommitRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                CommitSha = "",
                View = CommitView.Unspecified,
                PathFilters = { "", },
            };
            // Make the request
            FetchGitRepositoryLinkCommitResponse response = developerConnectClient.FetchGitRepositoryLinkCommit(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitAsync</summary>
        public async Task FetchGitRepositoryLinkCommitRequestObjectAsync()
        {
            // Snippet: FetchGitRepositoryLinkCommitAsync(FetchGitRepositoryLinkCommitRequest, CallSettings)
            // Additional: FetchGitRepositoryLinkCommitAsync(FetchGitRepositoryLinkCommitRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitRepositoryLinkCommitRequest request = new FetchGitRepositoryLinkCommitRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                CommitSha = "",
                View = CommitView.Unspecified,
                PathFilters = { "", },
            };
            // Make the request
            FetchGitRepositoryLinkCommitResponse response = await developerConnectClient.FetchGitRepositoryLinkCommitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommit</summary>
        public void FetchGitRepositoryLinkCommit()
        {
            // Snippet: FetchGitRepositoryLinkCommit(string, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string commitSha = "";
            // Make the request
            FetchGitRepositoryLinkCommitResponse response = developerConnectClient.FetchGitRepositoryLinkCommit(name, commitSha);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitAsync</summary>
        public async Task FetchGitRepositoryLinkCommitAsync()
        {
            // Snippet: FetchGitRepositoryLinkCommitAsync(string, string, CallSettings)
            // Additional: FetchGitRepositoryLinkCommitAsync(string, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string commitSha = "";
            // Make the request
            FetchGitRepositoryLinkCommitResponse response = await developerConnectClient.FetchGitRepositoryLinkCommitAsync(name, commitSha);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommit</summary>
        public void FetchGitRepositoryLinkCommitResourceNames()
        {
            // Snippet: FetchGitRepositoryLinkCommit(GitRepositoryLinkName, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string commitSha = "";
            // Make the request
            FetchGitRepositoryLinkCommitResponse response = developerConnectClient.FetchGitRepositoryLinkCommit(name, commitSha);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitAsync</summary>
        public async Task FetchGitRepositoryLinkCommitResourceNamesAsync()
        {
            // Snippet: FetchGitRepositoryLinkCommitAsync(GitRepositoryLinkName, string, CallSettings)
            // Additional: FetchGitRepositoryLinkCommitAsync(GitRepositoryLinkName, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string commitSha = "";
            // Make the request
            FetchGitRepositoryLinkCommitResponse response = await developerConnectClient.FetchGitRepositoryLinkCommitAsync(name, commitSha);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitList</summary>
        public void FetchGitRepositoryLinkCommitListRequestObject()
        {
            // Snippet: FetchGitRepositoryLinkCommitList(FetchGitRepositoryLinkCommitListRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchGitRepositoryLinkCommitListRequest request = new FetchGitRepositoryLinkCommitListRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                Ref = "",
                View = CommitView.Unspecified,
            };
            // Make the request
            PagedEnumerable<FetchGitRepositoryLinkCommitListResponse, SCMCommit> response = developerConnectClient.FetchGitRepositoryLinkCommitList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SCMCommit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRepositoryLinkCommitListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SCMCommit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SCMCommit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SCMCommit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitListAsync</summary>
        public async Task FetchGitRepositoryLinkCommitListRequestObjectAsync()
        {
            // Snippet: FetchGitRepositoryLinkCommitListAsync(FetchGitRepositoryLinkCommitListRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitRepositoryLinkCommitListRequest request = new FetchGitRepositoryLinkCommitListRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                Ref = "",
                View = CommitView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<FetchGitRepositoryLinkCommitListResponse, SCMCommit> response = developerConnectClient.FetchGitRepositoryLinkCommitListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SCMCommit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRepositoryLinkCommitListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SCMCommit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SCMCommit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SCMCommit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitList</summary>
        public void FetchGitRepositoryLinkCommitList()
        {
            // Snippet: FetchGitRepositoryLinkCommitList(string, string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string @ref = "";
            // Make the request
            PagedEnumerable<FetchGitRepositoryLinkCommitListResponse, SCMCommit> response = developerConnectClient.FetchGitRepositoryLinkCommitList(name, @ref);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SCMCommit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRepositoryLinkCommitListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SCMCommit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SCMCommit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SCMCommit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitListAsync</summary>
        public async Task FetchGitRepositoryLinkCommitListAsync()
        {
            // Snippet: FetchGitRepositoryLinkCommitListAsync(string, string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string @ref = "";
            // Make the request
            PagedAsyncEnumerable<FetchGitRepositoryLinkCommitListResponse, SCMCommit> response = developerConnectClient.FetchGitRepositoryLinkCommitListAsync(name, @ref);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SCMCommit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRepositoryLinkCommitListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SCMCommit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SCMCommit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SCMCommit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitList</summary>
        public void FetchGitRepositoryLinkCommitListResourceNames()
        {
            // Snippet: FetchGitRepositoryLinkCommitList(GitRepositoryLinkName, string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string @ref = "";
            // Make the request
            PagedEnumerable<FetchGitRepositoryLinkCommitListResponse, SCMCommit> response = developerConnectClient.FetchGitRepositoryLinkCommitList(name, @ref);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SCMCommit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRepositoryLinkCommitListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SCMCommit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SCMCommit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SCMCommit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkCommitListAsync</summary>
        public async Task FetchGitRepositoryLinkCommitListResourceNamesAsync()
        {
            // Snippet: FetchGitRepositoryLinkCommitListAsync(GitRepositoryLinkName, string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string @ref = "";
            // Make the request
            PagedAsyncEnumerable<FetchGitRepositoryLinkCommitListResponse, SCMCommit> response = developerConnectClient.FetchGitRepositoryLinkCommitListAsync(name, @ref);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SCMCommit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRepositoryLinkCommitListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SCMCommit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SCMCommit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SCMCommit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkFileBlame</summary>
        public void FetchGitRepositoryLinkFileBlameRequestObject()
        {
            // Snippet: FetchGitRepositoryLinkFileBlame(FetchGitRepositoryLinkFileBlameRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchGitRepositoryLinkFileBlameRequest request = new FetchGitRepositoryLinkFileBlameRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                Ref = "",
                Path = "",
                FirstLine = 0,
                LastLine = 0,
            };
            // Make the request
            FetchGitRepositoryLinkFileBlameResponse response = developerConnectClient.FetchGitRepositoryLinkFileBlame(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkFileBlameAsync</summary>
        public async Task FetchGitRepositoryLinkFileBlameRequestObjectAsync()
        {
            // Snippet: FetchGitRepositoryLinkFileBlameAsync(FetchGitRepositoryLinkFileBlameRequest, CallSettings)
            // Additional: FetchGitRepositoryLinkFileBlameAsync(FetchGitRepositoryLinkFileBlameRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitRepositoryLinkFileBlameRequest request = new FetchGitRepositoryLinkFileBlameRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                Ref = "",
                Path = "",
                FirstLine = 0,
                LastLine = 0,
            };
            // Make the request
            FetchGitRepositoryLinkFileBlameResponse response = await developerConnectClient.FetchGitRepositoryLinkFileBlameAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkFileBlame</summary>
        public void FetchGitRepositoryLinkFileBlame()
        {
            // Snippet: FetchGitRepositoryLinkFileBlame(string, string, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string @ref = "";
            string path = "";
            // Make the request
            FetchGitRepositoryLinkFileBlameResponse response = developerConnectClient.FetchGitRepositoryLinkFileBlame(name, @ref, path);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkFileBlameAsync</summary>
        public async Task FetchGitRepositoryLinkFileBlameAsync()
        {
            // Snippet: FetchGitRepositoryLinkFileBlameAsync(string, string, string, CallSettings)
            // Additional: FetchGitRepositoryLinkFileBlameAsync(string, string, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string @ref = "";
            string path = "";
            // Make the request
            FetchGitRepositoryLinkFileBlameResponse response = await developerConnectClient.FetchGitRepositoryLinkFileBlameAsync(name, @ref, path);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkFileBlame</summary>
        public void FetchGitRepositoryLinkFileBlameResourceNames()
        {
            // Snippet: FetchGitRepositoryLinkFileBlame(GitRepositoryLinkName, string, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string @ref = "";
            string path = "";
            // Make the request
            FetchGitRepositoryLinkFileBlameResponse response = developerConnectClient.FetchGitRepositoryLinkFileBlame(name, @ref, path);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkFileBlameAsync</summary>
        public async Task FetchGitRepositoryLinkFileBlameResourceNamesAsync()
        {
            // Snippet: FetchGitRepositoryLinkFileBlameAsync(GitRepositoryLinkName, string, string, CallSettings)
            // Additional: FetchGitRepositoryLinkFileBlameAsync(GitRepositoryLinkName, string, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string @ref = "";
            string path = "";
            // Make the request
            FetchGitRepositoryLinkFileBlameResponse response = await developerConnectClient.FetchGitRepositoryLinkFileBlameAsync(name, @ref, path);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequest</summary>
        public void FetchGitRepositoryLinkPullRequestRequestObject()
        {
            // Snippet: FetchGitRepositoryLinkPullRequest(FetchGitRepositoryLinkPullRequestRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchGitRepositoryLinkPullRequestRequest request = new FetchGitRepositoryLinkPullRequestRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
            };
            // Make the request
            PullRequest response = developerConnectClient.FetchGitRepositoryLinkPullRequest(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestAsync</summary>
        public async Task FetchGitRepositoryLinkPullRequestRequestObjectAsync()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestAsync(FetchGitRepositoryLinkPullRequestRequest, CallSettings)
            // Additional: FetchGitRepositoryLinkPullRequestAsync(FetchGitRepositoryLinkPullRequestRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitRepositoryLinkPullRequestRequest request = new FetchGitRepositoryLinkPullRequestRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
            };
            // Make the request
            PullRequest response = await developerConnectClient.FetchGitRepositoryLinkPullRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequest</summary>
        public void FetchGitRepositoryLinkPullRequest()
        {
            // Snippet: FetchGitRepositoryLinkPullRequest(string, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            // Make the request
            PullRequest response = developerConnectClient.FetchGitRepositoryLinkPullRequest(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestAsync</summary>
        public async Task FetchGitRepositoryLinkPullRequestAsync()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestAsync(string, string, CallSettings)
            // Additional: FetchGitRepositoryLinkPullRequestAsync(string, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            // Make the request
            PullRequest response = await developerConnectClient.FetchGitRepositoryLinkPullRequestAsync(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequest</summary>
        public void FetchGitRepositoryLinkPullRequestResourceNames()
        {
            // Snippet: FetchGitRepositoryLinkPullRequest(GitRepositoryLinkName, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            // Make the request
            PullRequest response = developerConnectClient.FetchGitRepositoryLinkPullRequest(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestAsync</summary>
        public async Task FetchGitRepositoryLinkPullRequestResourceNamesAsync()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestAsync(GitRepositoryLinkName, string, CallSettings)
            // Additional: FetchGitRepositoryLinkPullRequestAsync(GitRepositoryLinkName, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            // Make the request
            PullRequest response = await developerConnectClient.FetchGitRepositoryLinkPullRequestAsync(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestComment</summary>
        public void AddGitRepositoryLinkPullRequestCommentRequestObject()
        {
            // Snippet: AddGitRepositoryLinkPullRequestComment(AddGitRepositoryLinkPullRequestCommentRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AddGitRepositoryLinkPullRequestCommentRequest request = new AddGitRepositoryLinkPullRequestCommentRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
                Comment = new PullRequestComment(),
            };
            // Make the request
            PullRequestComment response = developerConnectClient.AddGitRepositoryLinkPullRequestComment(request);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestCommentAsync</summary>
        public async Task AddGitRepositoryLinkPullRequestCommentRequestObjectAsync()
        {
            // Snippet: AddGitRepositoryLinkPullRequestCommentAsync(AddGitRepositoryLinkPullRequestCommentRequest, CallSettings)
            // Additional: AddGitRepositoryLinkPullRequestCommentAsync(AddGitRepositoryLinkPullRequestCommentRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AddGitRepositoryLinkPullRequestCommentRequest request = new AddGitRepositoryLinkPullRequestCommentRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
                Comment = new PullRequestComment(),
            };
            // Make the request
            PullRequestComment response = await developerConnectClient.AddGitRepositoryLinkPullRequestCommentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestComment</summary>
        public void AddGitRepositoryLinkPullRequestComment()
        {
            // Snippet: AddGitRepositoryLinkPullRequestComment(string, string, PullRequestComment, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            PullRequestComment comment = new PullRequestComment();
            // Make the request
            PullRequestComment response = developerConnectClient.AddGitRepositoryLinkPullRequestComment(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestCommentAsync</summary>
        public async Task AddGitRepositoryLinkPullRequestCommentAsync()
        {
            // Snippet: AddGitRepositoryLinkPullRequestCommentAsync(string, string, PullRequestComment, CallSettings)
            // Additional: AddGitRepositoryLinkPullRequestCommentAsync(string, string, PullRequestComment, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            PullRequestComment comment = new PullRequestComment();
            // Make the request
            PullRequestComment response = await developerConnectClient.AddGitRepositoryLinkPullRequestCommentAsync(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestComment</summary>
        public void AddGitRepositoryLinkPullRequestCommentResourceNames()
        {
            // Snippet: AddGitRepositoryLinkPullRequestComment(GitRepositoryLinkName, string, PullRequestComment, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            PullRequestComment comment = new PullRequestComment();
            // Make the request
            PullRequestComment response = developerConnectClient.AddGitRepositoryLinkPullRequestComment(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestCommentAsync</summary>
        public async Task AddGitRepositoryLinkPullRequestCommentResourceNamesAsync()
        {
            // Snippet: AddGitRepositoryLinkPullRequestCommentAsync(GitRepositoryLinkName, string, PullRequestComment, CallSettings)
            // Additional: AddGitRepositoryLinkPullRequestCommentAsync(GitRepositoryLinkName, string, PullRequestComment, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            PullRequestComment comment = new PullRequestComment();
            // Make the request
            PullRequestComment response = await developerConnectClient.AddGitRepositoryLinkPullRequestCommentAsync(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestReviewComment</summary>
        public void AddGitRepositoryLinkPullRequestReviewCommentRequestObject()
        {
            // Snippet: AddGitRepositoryLinkPullRequestReviewComment(AddGitRepositoryLinkPullRequestReviewCommentRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AddGitRepositoryLinkPullRequestReviewCommentRequest request = new AddGitRepositoryLinkPullRequestReviewCommentRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
                Comment = new PullRequestReviewComment(),
                CommitId = "",
            };
            // Make the request
            PullRequestReviewComment response = developerConnectClient.AddGitRepositoryLinkPullRequestReviewComment(request);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestReviewCommentAsync</summary>
        public async Task AddGitRepositoryLinkPullRequestReviewCommentRequestObjectAsync()
        {
            // Snippet: AddGitRepositoryLinkPullRequestReviewCommentAsync(AddGitRepositoryLinkPullRequestReviewCommentRequest, CallSettings)
            // Additional: AddGitRepositoryLinkPullRequestReviewCommentAsync(AddGitRepositoryLinkPullRequestReviewCommentRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AddGitRepositoryLinkPullRequestReviewCommentRequest request = new AddGitRepositoryLinkPullRequestReviewCommentRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
                Comment = new PullRequestReviewComment(),
                CommitId = "",
            };
            // Make the request
            PullRequestReviewComment response = await developerConnectClient.AddGitRepositoryLinkPullRequestReviewCommentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestReviewComment</summary>
        public void AddGitRepositoryLinkPullRequestReviewComment()
        {
            // Snippet: AddGitRepositoryLinkPullRequestReviewComment(string, string, PullRequestReviewComment, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            PullRequestReviewComment comment = new PullRequestReviewComment();
            // Make the request
            PullRequestReviewComment response = developerConnectClient.AddGitRepositoryLinkPullRequestReviewComment(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestReviewCommentAsync</summary>
        public async Task AddGitRepositoryLinkPullRequestReviewCommentAsync()
        {
            // Snippet: AddGitRepositoryLinkPullRequestReviewCommentAsync(string, string, PullRequestReviewComment, CallSettings)
            // Additional: AddGitRepositoryLinkPullRequestReviewCommentAsync(string, string, PullRequestReviewComment, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            PullRequestReviewComment comment = new PullRequestReviewComment();
            // Make the request
            PullRequestReviewComment response = await developerConnectClient.AddGitRepositoryLinkPullRequestReviewCommentAsync(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestReviewComment</summary>
        public void AddGitRepositoryLinkPullRequestReviewCommentResourceNames()
        {
            // Snippet: AddGitRepositoryLinkPullRequestReviewComment(GitRepositoryLinkName, string, PullRequestReviewComment, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            PullRequestReviewComment comment = new PullRequestReviewComment();
            // Make the request
            PullRequestReviewComment response = developerConnectClient.AddGitRepositoryLinkPullRequestReviewComment(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for AddGitRepositoryLinkPullRequestReviewCommentAsync</summary>
        public async Task AddGitRepositoryLinkPullRequestReviewCommentResourceNamesAsync()
        {
            // Snippet: AddGitRepositoryLinkPullRequestReviewCommentAsync(GitRepositoryLinkName, string, PullRequestReviewComment, CallSettings)
            // Additional: AddGitRepositoryLinkPullRequestReviewCommentAsync(GitRepositoryLinkName, string, PullRequestReviewComment, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            PullRequestReviewComment comment = new PullRequestReviewComment();
            // Make the request
            PullRequestReviewComment response = await developerConnectClient.AddGitRepositoryLinkPullRequestReviewCommentAsync(name, pullRequestId, comment);
            // End snippet
        }

        /// <summary>Snippet for ModifyGitRepositoryLinkPullRequest</summary>
        public void ModifyGitRepositoryLinkPullRequestRequestObject()
        {
            // Snippet: ModifyGitRepositoryLinkPullRequest(ModifyGitRepositoryLinkPullRequestRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ModifyGitRepositoryLinkPullRequestRequest request = new ModifyGitRepositoryLinkPullRequestRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
                Title = "",
                Body = "",
                BaseRef = "",
                State = ModifyGitRepositoryLinkPullRequestRequest.Types.State.Unspecified,
            };
            // Make the request
            PullRequest response = developerConnectClient.ModifyGitRepositoryLinkPullRequest(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyGitRepositoryLinkPullRequestAsync</summary>
        public async Task ModifyGitRepositoryLinkPullRequestRequestObjectAsync()
        {
            // Snippet: ModifyGitRepositoryLinkPullRequestAsync(ModifyGitRepositoryLinkPullRequestRequest, CallSettings)
            // Additional: ModifyGitRepositoryLinkPullRequestAsync(ModifyGitRepositoryLinkPullRequestRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ModifyGitRepositoryLinkPullRequestRequest request = new ModifyGitRepositoryLinkPullRequestRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                PullRequestId = "",
                Title = "",
                Body = "",
                BaseRef = "",
                State = ModifyGitRepositoryLinkPullRequestRequest.Types.State.Unspecified,
            };
            // Make the request
            PullRequest response = await developerConnectClient.ModifyGitRepositoryLinkPullRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyGitRepositoryLinkPullRequest</summary>
        public void ModifyGitRepositoryLinkPullRequest()
        {
            // Snippet: ModifyGitRepositoryLinkPullRequest(string, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            // Make the request
            PullRequest response = developerConnectClient.ModifyGitRepositoryLinkPullRequest(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for ModifyGitRepositoryLinkPullRequestAsync</summary>
        public async Task ModifyGitRepositoryLinkPullRequestAsync()
        {
            // Snippet: ModifyGitRepositoryLinkPullRequestAsync(string, string, CallSettings)
            // Additional: ModifyGitRepositoryLinkPullRequestAsync(string, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            string pullRequestId = "";
            // Make the request
            PullRequest response = await developerConnectClient.ModifyGitRepositoryLinkPullRequestAsync(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for ModifyGitRepositoryLinkPullRequest</summary>
        public void ModifyGitRepositoryLinkPullRequestResourceNames()
        {
            // Snippet: ModifyGitRepositoryLinkPullRequest(GitRepositoryLinkName, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            // Make the request
            PullRequest response = developerConnectClient.ModifyGitRepositoryLinkPullRequest(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for ModifyGitRepositoryLinkPullRequestAsync</summary>
        public async Task ModifyGitRepositoryLinkPullRequestResourceNamesAsync()
        {
            // Snippet: ModifyGitRepositoryLinkPullRequestAsync(GitRepositoryLinkName, string, CallSettings)
            // Additional: ModifyGitRepositoryLinkPullRequestAsync(GitRepositoryLinkName, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            string pullRequestId = "";
            // Make the request
            PullRequest response = await developerConnectClient.ModifyGitRepositoryLinkPullRequestAsync(name, pullRequestId);
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestList</summary>
        public void FetchGitRepositoryLinkPullRequestListRequestObject()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestList(FetchGitRepositoryLinkPullRequestListRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchGitRepositoryLinkPullRequestListRequest request = new FetchGitRepositoryLinkPullRequestListRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<FetchGitRepositoryLinkPullRequestListResponse, PullRequest> response = developerConnectClient.FetchGitRepositoryLinkPullRequestList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRepositoryLinkPullRequestListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestListAsync</summary>
        public async Task FetchGitRepositoryLinkPullRequestListRequestObjectAsync()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestListAsync(FetchGitRepositoryLinkPullRequestListRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchGitRepositoryLinkPullRequestListRequest request = new FetchGitRepositoryLinkPullRequestListRequest
            {
                GitRepositoryLinkName = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<FetchGitRepositoryLinkPullRequestListResponse, PullRequest> response = developerConnectClient.FetchGitRepositoryLinkPullRequestListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRepositoryLinkPullRequestListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestList</summary>
        public void FetchGitRepositoryLinkPullRequestList()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestList(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            PagedEnumerable<FetchGitRepositoryLinkPullRequestListResponse, PullRequest> response = developerConnectClient.FetchGitRepositoryLinkPullRequestList(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRepositoryLinkPullRequestListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestListAsync</summary>
        public async Task FetchGitRepositoryLinkPullRequestListAsync()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestListAsync(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connections/[CONNECTION]/gitRepositoryLinks/[GIT_REPOSITORY_LINK]";
            // Make the request
            PagedAsyncEnumerable<FetchGitRepositoryLinkPullRequestListResponse, PullRequest> response = developerConnectClient.FetchGitRepositoryLinkPullRequestListAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRepositoryLinkPullRequestListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestList</summary>
        public void FetchGitRepositoryLinkPullRequestListResourceNames()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestList(GitRepositoryLinkName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            PagedEnumerable<FetchGitRepositoryLinkPullRequestListResponse, PullRequest> response = developerConnectClient.FetchGitRepositoryLinkPullRequestList(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchGitRepositoryLinkPullRequestListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchGitRepositoryLinkPullRequestListAsync</summary>
        public async Task FetchGitRepositoryLinkPullRequestListResourceNamesAsync()
        {
            // Snippet: FetchGitRepositoryLinkPullRequestListAsync(GitRepositoryLinkName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GitRepositoryLinkName name = GitRepositoryLinkName.FromProjectLocationConnectionGitRepositoryLink("[PROJECT]", "[LOCATION]", "[CONNECTION]", "[GIT_REPOSITORY_LINK]");
            // Make the request
            PagedAsyncEnumerable<FetchGitRepositoryLinkPullRequestListResponse, PullRequest> response = developerConnectClient.FetchGitRepositoryLinkPullRequestListAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PullRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (FetchGitRepositoryLinkPullRequestListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PullRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PullRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PullRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountConnectors</summary>
        public void ListAccountConnectorsRequestObject()
        {
            // Snippet: ListAccountConnectors(ListAccountConnectorsRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ListAccountConnectorsRequest request = new ListAccountConnectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAccountConnectorsResponse, AccountConnector> response = developerConnectClient.ListAccountConnectors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountConnectorsAsync</summary>
        public async Task ListAccountConnectorsRequestObjectAsync()
        {
            // Snippet: ListAccountConnectorsAsync(ListAccountConnectorsRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountConnectorsRequest request = new ListAccountConnectorsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAccountConnectorsResponse, AccountConnector> response = developerConnectClient.ListAccountConnectorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccountConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccountConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountConnectors</summary>
        public void ListAccountConnectors()
        {
            // Snippet: ListAccountConnectors(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAccountConnectorsResponse, AccountConnector> response = developerConnectClient.ListAccountConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountConnectorsAsync</summary>
        public async Task ListAccountConnectorsAsync()
        {
            // Snippet: ListAccountConnectorsAsync(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAccountConnectorsResponse, AccountConnector> response = developerConnectClient.ListAccountConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccountConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccountConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountConnectors</summary>
        public void ListAccountConnectorsResourceNames()
        {
            // Snippet: ListAccountConnectors(LocationName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAccountConnectorsResponse, AccountConnector> response = developerConnectClient.ListAccountConnectors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountConnector> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountConnectorsAsync</summary>
        public async Task ListAccountConnectorsResourceNamesAsync()
        {
            // Snippet: ListAccountConnectorsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAccountConnectorsResponse, AccountConnector> response = developerConnectClient.ListAccountConnectorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AccountConnector item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAccountConnectorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountConnector item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountConnector> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountConnector item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAccountConnector</summary>
        public void GetAccountConnectorRequestObject()
        {
            // Snippet: GetAccountConnector(GetAccountConnectorRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            GetAccountConnectorRequest request = new GetAccountConnectorRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            AccountConnector response = developerConnectClient.GetAccountConnector(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountConnectorAsync</summary>
        public async Task GetAccountConnectorRequestObjectAsync()
        {
            // Snippet: GetAccountConnectorAsync(GetAccountConnectorRequest, CallSettings)
            // Additional: GetAccountConnectorAsync(GetAccountConnectorRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountConnectorRequest request = new GetAccountConnectorRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            AccountConnector response = await developerConnectClient.GetAccountConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountConnector</summary>
        public void GetAccountConnector()
        {
            // Snippet: GetAccountConnector(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            AccountConnector response = developerConnectClient.GetAccountConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountConnectorAsync</summary>
        public async Task GetAccountConnectorAsync()
        {
            // Snippet: GetAccountConnectorAsync(string, CallSettings)
            // Additional: GetAccountConnectorAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            AccountConnector response = await developerConnectClient.GetAccountConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountConnector</summary>
        public void GetAccountConnectorResourceNames()
        {
            // Snippet: GetAccountConnector(AccountConnectorName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            AccountConnector response = developerConnectClient.GetAccountConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountConnectorAsync</summary>
        public async Task GetAccountConnectorResourceNamesAsync()
        {
            // Snippet: GetAccountConnectorAsync(AccountConnectorName, CallSettings)
            // Additional: GetAccountConnectorAsync(AccountConnectorName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            AccountConnector response = await developerConnectClient.GetAccountConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountConnector</summary>
        public void CreateAccountConnectorRequestObject()
        {
            // Snippet: CreateAccountConnector(CreateAccountConnectorRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            CreateAccountConnectorRequest request = new CreateAccountConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AccountConnectorId = "",
                AccountConnector = new AccountConnector(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = developerConnectClient.CreateAccountConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccountConnectorAsync</summary>
        public async Task CreateAccountConnectorRequestObjectAsync()
        {
            // Snippet: CreateAccountConnectorAsync(CreateAccountConnectorRequest, CallSettings)
            // Additional: CreateAccountConnectorAsync(CreateAccountConnectorRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            CreateAccountConnectorRequest request = new CreateAccountConnectorRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AccountConnectorId = "",
                AccountConnector = new AccountConnector(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = await developerConnectClient.CreateAccountConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccountConnector</summary>
        public void CreateAccountConnector()
        {
            // Snippet: CreateAccountConnector(string, AccountConnector, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AccountConnector accountConnector = new AccountConnector();
            string accountConnectorId = "";
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = developerConnectClient.CreateAccountConnector(parent, accountConnector, accountConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccountConnectorAsync</summary>
        public async Task CreateAccountConnectorAsync()
        {
            // Snippet: CreateAccountConnectorAsync(string, AccountConnector, string, CallSettings)
            // Additional: CreateAccountConnectorAsync(string, AccountConnector, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AccountConnector accountConnector = new AccountConnector();
            string accountConnectorId = "";
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = await developerConnectClient.CreateAccountConnectorAsync(parent, accountConnector, accountConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccountConnector</summary>
        public void CreateAccountConnectorResourceNames()
        {
            // Snippet: CreateAccountConnector(LocationName, AccountConnector, string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AccountConnector accountConnector = new AccountConnector();
            string accountConnectorId = "";
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = developerConnectClient.CreateAccountConnector(parent, accountConnector, accountConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceCreateAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAccountConnectorAsync</summary>
        public async Task CreateAccountConnectorResourceNamesAsync()
        {
            // Snippet: CreateAccountConnectorAsync(LocationName, AccountConnector, string, CallSettings)
            // Additional: CreateAccountConnectorAsync(LocationName, AccountConnector, string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AccountConnector accountConnector = new AccountConnector();
            string accountConnectorId = "";
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = await developerConnectClient.CreateAccountConnectorAsync(parent, accountConnector, accountConnectorId);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceCreateAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountConnector</summary>
        public void UpdateAccountConnectorRequestObject()
        {
            // Snippet: UpdateAccountConnector(UpdateAccountConnectorRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            UpdateAccountConnectorRequest request = new UpdateAccountConnectorRequest
            {
                UpdateMask = new FieldMask(),
                AccountConnector = new AccountConnector(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = developerConnectClient.UpdateAccountConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceUpdateAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountConnectorAsync</summary>
        public async Task UpdateAccountConnectorRequestObjectAsync()
        {
            // Snippet: UpdateAccountConnectorAsync(UpdateAccountConnectorRequest, CallSettings)
            // Additional: UpdateAccountConnectorAsync(UpdateAccountConnectorRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccountConnectorRequest request = new UpdateAccountConnectorRequest
            {
                UpdateMask = new FieldMask(),
                AccountConnector = new AccountConnector(),
                RequestId = "",
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = await developerConnectClient.UpdateAccountConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceUpdateAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountConnector</summary>
        public void UpdateAccountConnector()
        {
            // Snippet: UpdateAccountConnector(AccountConnector, FieldMask, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnector accountConnector = new AccountConnector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = developerConnectClient.UpdateAccountConnector(accountConnector, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceUpdateAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountConnectorAsync</summary>
        public async Task UpdateAccountConnectorAsync()
        {
            // Snippet: UpdateAccountConnectorAsync(AccountConnector, FieldMask, CallSettings)
            // Additional: UpdateAccountConnectorAsync(AccountConnector, FieldMask, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnector accountConnector = new AccountConnector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AccountConnector, OperationMetadata> response = await developerConnectClient.UpdateAccountConnectorAsync(accountConnector, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AccountConnector, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AccountConnector result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AccountConnector, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceUpdateAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AccountConnector retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountConnector</summary>
        public void DeleteAccountConnectorRequestObject()
        {
            // Snippet: DeleteAccountConnector(DeleteAccountConnectorRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            DeleteAccountConnectorRequest request = new DeleteAccountConnectorRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteAccountConnector(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountConnectorAsync</summary>
        public async Task DeleteAccountConnectorRequestObjectAsync()
        {
            // Snippet: DeleteAccountConnectorAsync(DeleteAccountConnectorRequest, CallSettings)
            // Additional: DeleteAccountConnectorAsync(DeleteAccountConnectorRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccountConnectorRequest request = new DeleteAccountConnectorRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteAccountConnectorAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountConnector</summary>
        public void DeleteAccountConnector()
        {
            // Snippet: DeleteAccountConnector(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteAccountConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountConnectorAsync</summary>
        public async Task DeleteAccountConnectorAsync()
        {
            // Snippet: DeleteAccountConnectorAsync(string, CallSettings)
            // Additional: DeleteAccountConnectorAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteAccountConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountConnector</summary>
        public void DeleteAccountConnectorResourceNames()
        {
            // Snippet: DeleteAccountConnector(AccountConnectorName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteAccountConnector(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteAccountConnector(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountConnectorAsync</summary>
        public async Task DeleteAccountConnectorResourceNamesAsync()
        {
            // Snippet: DeleteAccountConnectorAsync(AccountConnectorName, CallSettings)
            // Additional: DeleteAccountConnectorAsync(AccountConnectorName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteAccountConnectorAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteAccountConnectorAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchAccessToken</summary>
        public void FetchAccessTokenRequestObject()
        {
            // Snippet: FetchAccessToken(FetchAccessTokenRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchAccessTokenRequest request = new FetchAccessTokenRequest
            {
                AccountConnectorAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            FetchAccessTokenResponse response = developerConnectClient.FetchAccessToken(request);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessTokenAsync</summary>
        public async Task FetchAccessTokenRequestObjectAsync()
        {
            // Snippet: FetchAccessTokenAsync(FetchAccessTokenRequest, CallSettings)
            // Additional: FetchAccessTokenAsync(FetchAccessTokenRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchAccessTokenRequest request = new FetchAccessTokenRequest
            {
                AccountConnectorAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            FetchAccessTokenResponse response = await developerConnectClient.FetchAccessTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessToken</summary>
        public void FetchAccessToken()
        {
            // Snippet: FetchAccessToken(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string accountConnector = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            FetchAccessTokenResponse response = developerConnectClient.FetchAccessToken(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessTokenAsync</summary>
        public async Task FetchAccessTokenAsync()
        {
            // Snippet: FetchAccessTokenAsync(string, CallSettings)
            // Additional: FetchAccessTokenAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string accountConnector = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            FetchAccessTokenResponse response = await developerConnectClient.FetchAccessTokenAsync(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessToken</summary>
        public void FetchAccessTokenResourceNames()
        {
            // Snippet: FetchAccessToken(AccountConnectorName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName accountConnector = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            FetchAccessTokenResponse response = developerConnectClient.FetchAccessToken(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessTokenAsync</summary>
        public async Task FetchAccessTokenResourceNamesAsync()
        {
            // Snippet: FetchAccessTokenAsync(AccountConnectorName, CallSettings)
            // Additional: FetchAccessTokenAsync(AccountConnectorName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName accountConnector = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            FetchAccessTokenResponse response = await developerConnectClient.FetchAccessTokenAsync(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsersRequestObject()
        {
            // Snippet: ListUsers(ListUsersRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = developerConnectClient.ListUsers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsersAsync</summary>
        public async Task ListUsersRequestObjectAsync()
        {
            // Snippet: ListUsersAsync(ListUsersRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = developerConnectClient.ListUsersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsers()
        {
            // Snippet: ListUsers(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = developerConnectClient.ListUsers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsersAsync</summary>
        public async Task ListUsersAsync()
        {
            // Snippet: ListUsersAsync(string, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = developerConnectClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsersResourceNames()
        {
            // Snippet: ListUsers(AccountConnectorName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName parent = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = developerConnectClient.ListUsers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsersAsync</summary>
        public async Task ListUsersResourceNamesAsync()
        {
            // Snippet: ListUsersAsync(AccountConnectorName, string, int?, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName parent = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = developerConnectClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (User item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListUsersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<User> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (User item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUserRequestObject()
        {
            // Snippet: DeleteUser(DeleteUserRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromProjectLocationAccountConnectorUser("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]", "[USER]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteUser(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserRequestObjectAsync()
        {
            // Snippet: DeleteUserAsync(DeleteUserRequest, CallSettings)
            // Additional: DeleteUserAsync(DeleteUserRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromProjectLocationAccountConnectorUser("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]", "[USER]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteUserAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUser()
        {
            // Snippet: DeleteUser(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]/users/[USER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteUser(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserAsync()
        {
            // Snippet: DeleteUserAsync(string, CallSettings)
            // Additional: DeleteUserAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]/users/[USER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteUserAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUserResourceNames()
        {
            // Snippet: DeleteUser(UserName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationAccountConnectorUser("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]", "[USER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteUser(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserResourceNamesAsync()
        {
            // Snippet: DeleteUserAsync(UserName, CallSettings)
            // Additional: DeleteUserAsync(UserName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationAccountConnectorUser("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]", "[USER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteUserAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchSelf</summary>
        public void FetchSelfRequestObject()
        {
            // Snippet: FetchSelf(FetchSelfRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FetchSelfRequest request = new FetchSelfRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            User response = developerConnectClient.FetchSelf(request);
            // End snippet
        }

        /// <summary>Snippet for FetchSelfAsync</summary>
        public async Task FetchSelfRequestObjectAsync()
        {
            // Snippet: FetchSelfAsync(FetchSelfRequest, CallSettings)
            // Additional: FetchSelfAsync(FetchSelfRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FetchSelfRequest request = new FetchSelfRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            User response = await developerConnectClient.FetchSelfAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchSelf</summary>
        public void FetchSelf()
        {
            // Snippet: FetchSelf(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            User response = developerConnectClient.FetchSelf(name);
            // End snippet
        }

        /// <summary>Snippet for FetchSelfAsync</summary>
        public async Task FetchSelfAsync()
        {
            // Snippet: FetchSelfAsync(string, CallSettings)
            // Additional: FetchSelfAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            User response = await developerConnectClient.FetchSelfAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchSelf</summary>
        public void FetchSelfResourceNames()
        {
            // Snippet: FetchSelf(AccountConnectorName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            User response = developerConnectClient.FetchSelf(name);
            // End snippet
        }

        /// <summary>Snippet for FetchSelfAsync</summary>
        public async Task FetchSelfResourceNamesAsync()
        {
            // Snippet: FetchSelfAsync(AccountConnectorName, CallSettings)
            // Additional: FetchSelfAsync(AccountConnectorName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            User response = await developerConnectClient.FetchSelfAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSelf</summary>
        public void DeleteSelfRequestObject()
        {
            // Snippet: DeleteSelf(DeleteSelfRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            DeleteSelfRequest request = new DeleteSelfRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteSelf(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteSelf(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSelfAsync</summary>
        public async Task DeleteSelfRequestObjectAsync()
        {
            // Snippet: DeleteSelfAsync(DeleteSelfRequest, CallSettings)
            // Additional: DeleteSelfAsync(DeleteSelfRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSelfRequest request = new DeleteSelfRequest
            {
                AccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteSelfAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteSelfAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSelf</summary>
        public void DeleteSelf()
        {
            // Snippet: DeleteSelf(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteSelf(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteSelf(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSelfAsync</summary>
        public async Task DeleteSelfAsync()
        {
            // Snippet: DeleteSelfAsync(string, CallSettings)
            // Additional: DeleteSelfAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteSelfAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteSelfAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSelf</summary>
        public void DeleteSelfResourceNames()
        {
            // Snippet: DeleteSelf(AccountConnectorName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = developerConnectClient.DeleteSelf(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = developerConnectClient.PollOnceDeleteSelf(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSelfAsync</summary>
        public async Task DeleteSelfResourceNamesAsync()
        {
            // Snippet: DeleteSelfAsync(AccountConnectorName, CallSettings)
            // Additional: DeleteSelfAsync(AccountConnectorName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName name = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await developerConnectClient.DeleteSelfAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await developerConnectClient.PollOnceDeleteSelfAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartOAuth</summary>
        public void StartOAuthRequestObject()
        {
            // Snippet: StartOAuth(StartOAuthRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            StartOAuthRequest request = new StartOAuthRequest
            {
                AccountConnectorAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            StartOAuthResponse response = developerConnectClient.StartOAuth(request);
            // End snippet
        }

        /// <summary>Snippet for StartOAuthAsync</summary>
        public async Task StartOAuthRequestObjectAsync()
        {
            // Snippet: StartOAuthAsync(StartOAuthRequest, CallSettings)
            // Additional: StartOAuthAsync(StartOAuthRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            StartOAuthRequest request = new StartOAuthRequest
            {
                AccountConnectorAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
            };
            // Make the request
            StartOAuthResponse response = await developerConnectClient.StartOAuthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartOAuth</summary>
        public void StartOAuth()
        {
            // Snippet: StartOAuth(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string accountConnector = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            StartOAuthResponse response = developerConnectClient.StartOAuth(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for StartOAuthAsync</summary>
        public async Task StartOAuthAsync()
        {
            // Snippet: StartOAuthAsync(string, CallSettings)
            // Additional: StartOAuthAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string accountConnector = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            StartOAuthResponse response = await developerConnectClient.StartOAuthAsync(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for StartOAuth</summary>
        public void StartOAuthResourceNames()
        {
            // Snippet: StartOAuth(AccountConnectorName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName accountConnector = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            StartOAuthResponse response = developerConnectClient.StartOAuth(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for StartOAuthAsync</summary>
        public async Task StartOAuthResourceNamesAsync()
        {
            // Snippet: StartOAuthAsync(AccountConnectorName, CallSettings)
            // Additional: StartOAuthAsync(AccountConnectorName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName accountConnector = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            StartOAuthResponse response = await developerConnectClient.StartOAuthAsync(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for FinishOAuth</summary>
        public void FinishOAuthRequestObject()
        {
            // Snippet: FinishOAuth(FinishOAuthRequest, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            FinishOAuthRequest request = new FinishOAuthRequest
            {
                AccountConnectorAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
                OauthParams = new FinishOAuthRequest.Types.OAuthParams(),
            };
            // Make the request
            FinishOAuthResponse response = developerConnectClient.FinishOAuth(request);
            // End snippet
        }

        /// <summary>Snippet for FinishOAuthAsync</summary>
        public async Task FinishOAuthRequestObjectAsync()
        {
            // Snippet: FinishOAuthAsync(FinishOAuthRequest, CallSettings)
            // Additional: FinishOAuthAsync(FinishOAuthRequest, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            FinishOAuthRequest request = new FinishOAuthRequest
            {
                AccountConnectorAsAccountConnectorName = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]"),
                OauthParams = new FinishOAuthRequest.Types.OAuthParams(),
            };
            // Make the request
            FinishOAuthResponse response = await developerConnectClient.FinishOAuthAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FinishOAuth</summary>
        public void FinishOAuth()
        {
            // Snippet: FinishOAuth(string, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            string accountConnector = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            FinishOAuthResponse response = developerConnectClient.FinishOAuth(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for FinishOAuthAsync</summary>
        public async Task FinishOAuthAsync()
        {
            // Snippet: FinishOAuthAsync(string, CallSettings)
            // Additional: FinishOAuthAsync(string, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            string accountConnector = "projects/[PROJECT]/locations/[LOCATION]/accountConnectors/[ACCOUNT_CONNECTOR]";
            // Make the request
            FinishOAuthResponse response = await developerConnectClient.FinishOAuthAsync(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for FinishOAuth</summary>
        public void FinishOAuthResourceNames()
        {
            // Snippet: FinishOAuth(AccountConnectorName, CallSettings)
            // Create client
            DeveloperConnectClient developerConnectClient = DeveloperConnectClient.Create();
            // Initialize request argument(s)
            AccountConnectorName accountConnector = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            FinishOAuthResponse response = developerConnectClient.FinishOAuth(accountConnector);
            // End snippet
        }

        /// <summary>Snippet for FinishOAuthAsync</summary>
        public async Task FinishOAuthResourceNamesAsync()
        {
            // Snippet: FinishOAuthAsync(AccountConnectorName, CallSettings)
            // Additional: FinishOAuthAsync(AccountConnectorName, CancellationToken)
            // Create client
            DeveloperConnectClient developerConnectClient = await DeveloperConnectClient.CreateAsync();
            // Initialize request argument(s)
            AccountConnectorName accountConnector = AccountConnectorName.FromProjectLocationAccountConnector("[PROJECT]", "[LOCATION]", "[ACCOUNT_CONNECTOR]");
            // Make the request
            FinishOAuthResponse response = await developerConnectClient.FinishOAuthAsync(accountConnector);
            // End snippet
        }
    }
}
