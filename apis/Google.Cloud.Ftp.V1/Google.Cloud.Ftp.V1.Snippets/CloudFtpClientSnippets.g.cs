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
    using Google.Cloud.Ftp.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudFtpClientSnippets
    {
        /// <summary>Snippet for ListServers</summary>
        public void ListServersRequestObject()
        {
            // Snippet: ListServers(ListServersRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ListServersRequest request = new ListServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = ServerView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListServersResponse, Server> response = cloudFtpClient.ListServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Server item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Server item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Server> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Server item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServersAsync</summary>
        public async Task ListServersRequestObjectAsync()
        {
            // Snippet: ListServersAsync(ListServersRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ListServersRequest request = new ListServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = ServerView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListServersResponse, Server> response = cloudFtpClient.ListServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Server item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Server item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Server> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Server item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServers</summary>
        public void ListServers()
        {
            // Snippet: ListServers(string, string, int?, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServersResponse, Server> response = cloudFtpClient.ListServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Server item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Server item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Server> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Server item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServersAsync</summary>
        public async Task ListServersAsync()
        {
            // Snippet: ListServersAsync(string, string, int?, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServersResponse, Server> response = cloudFtpClient.ListServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Server item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Server item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Server> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Server item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServers</summary>
        public void ListServersResourceNames()
        {
            // Snippet: ListServers(LocationName, string, int?, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServersResponse, Server> response = cloudFtpClient.ListServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Server item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Server item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Server> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Server item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServersAsync</summary>
        public async Task ListServersResourceNamesAsync()
        {
            // Snippet: ListServersAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServersResponse, Server> response = cloudFtpClient.ListServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Server item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Server item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Server> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Server item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServer</summary>
        public void GetServerRequestObject()
        {
            // Snippet: GetServer(GetServerRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            GetServerRequest request = new GetServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
                View = ServerView.Unspecified,
            };
            // Make the request
            Server response = cloudFtpClient.GetServer(request);
            // End snippet
        }

        /// <summary>Snippet for GetServerAsync</summary>
        public async Task GetServerRequestObjectAsync()
        {
            // Snippet: GetServerAsync(GetServerRequest, CallSettings)
            // Additional: GetServerAsync(GetServerRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            GetServerRequest request = new GetServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
                View = ServerView.Unspecified,
            };
            // Make the request
            Server response = await cloudFtpClient.GetServerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServer</summary>
        public void GetServer()
        {
            // Snippet: GetServer(string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Server response = cloudFtpClient.GetServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetServerAsync</summary>
        public async Task GetServerAsync()
        {
            // Snippet: GetServerAsync(string, CallSettings)
            // Additional: GetServerAsync(string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Server response = await cloudFtpClient.GetServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServer</summary>
        public void GetServerResourceNames()
        {
            // Snippet: GetServer(ServerName, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Server response = cloudFtpClient.GetServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetServerAsync</summary>
        public async Task GetServerResourceNamesAsync()
        {
            // Snippet: GetServerAsync(ServerName, CallSettings)
            // Additional: GetServerAsync(ServerName, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Server response = await cloudFtpClient.GetServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServer</summary>
        public void CreateServerRequestObject()
        {
            // Snippet: CreateServer(CreateServerRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            CreateServerRequest request = new CreateServerRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServerId = "",
                Server = new Server(),
                RequestId = "",
            };
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.CreateServer(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceCreateServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerAsync</summary>
        public async Task CreateServerRequestObjectAsync()
        {
            // Snippet: CreateServerAsync(CreateServerRequest, CallSettings)
            // Additional: CreateServerAsync(CreateServerRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            CreateServerRequest request = new CreateServerRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServerId = "",
                Server = new Server(),
                RequestId = "",
            };
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.CreateServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceCreateServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServer</summary>
        public void CreateServer()
        {
            // Snippet: CreateServer(string, Server, string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Server server = new Server();
            string serverId = "";
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.CreateServer(parent, server, serverId);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceCreateServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerAsync</summary>
        public async Task CreateServerAsync()
        {
            // Snippet: CreateServerAsync(string, Server, string, CallSettings)
            // Additional: CreateServerAsync(string, Server, string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Server server = new Server();
            string serverId = "";
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.CreateServerAsync(parent, server, serverId);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceCreateServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServer</summary>
        public void CreateServerResourceNames()
        {
            // Snippet: CreateServer(LocationName, Server, string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Server server = new Server();
            string serverId = "";
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.CreateServer(parent, server, serverId);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceCreateServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServerAsync</summary>
        public async Task CreateServerResourceNamesAsync()
        {
            // Snippet: CreateServerAsync(LocationName, Server, string, CallSettings)
            // Additional: CreateServerAsync(LocationName, Server, string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Server server = new Server();
            string serverId = "";
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.CreateServerAsync(parent, server, serverId);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceCreateServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServer</summary>
        public void UpdateServerRequestObject()
        {
            // Snippet: UpdateServer(UpdateServerRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            UpdateServerRequest request = new UpdateServerRequest
            {
                UpdateMask = new FieldMask(),
                Server = new Server(),
                RequestId = "",
            };
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.UpdateServer(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceUpdateServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServerAsync</summary>
        public async Task UpdateServerRequestObjectAsync()
        {
            // Snippet: UpdateServerAsync(UpdateServerRequest, CallSettings)
            // Additional: UpdateServerAsync(UpdateServerRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServerRequest request = new UpdateServerRequest
            {
                UpdateMask = new FieldMask(),
                Server = new Server(),
                RequestId = "",
            };
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.UpdateServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceUpdateServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServer</summary>
        public void UpdateServer()
        {
            // Snippet: UpdateServer(Server, FieldMask, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            Server server = new Server();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.UpdateServer(server, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceUpdateServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServerAsync</summary>
        public async Task UpdateServerAsync()
        {
            // Snippet: UpdateServerAsync(Server, FieldMask, CallSettings)
            // Additional: UpdateServerAsync(Server, FieldMask, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            Server server = new Server();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.UpdateServerAsync(server, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceUpdateServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServer</summary>
        public void DeleteServerRequestObject()
        {
            // Snippet: DeleteServer(DeleteServerRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            DeleteServerRequest request = new DeleteServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudFtpClient.DeleteServer(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceDeleteServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerAsync</summary>
        public async Task DeleteServerRequestObjectAsync()
        {
            // Snippet: DeleteServerAsync(DeleteServerRequest, CallSettings)
            // Additional: DeleteServerAsync(DeleteServerRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServerRequest request = new DeleteServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudFtpClient.DeleteServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceDeleteServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServer</summary>
        public void DeleteServer()
        {
            // Snippet: DeleteServer(string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudFtpClient.DeleteServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceDeleteServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerAsync</summary>
        public async Task DeleteServerAsync()
        {
            // Snippet: DeleteServerAsync(string, CallSettings)
            // Additional: DeleteServerAsync(string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudFtpClient.DeleteServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceDeleteServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServer</summary>
        public void DeleteServerResourceNames()
        {
            // Snippet: DeleteServer(ServerName, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudFtpClient.DeleteServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceDeleteServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServerAsync</summary>
        public async Task DeleteServerResourceNamesAsync()
        {
            // Snippet: DeleteServerAsync(ServerName, CallSettings)
            // Additional: DeleteServerAsync(ServerName, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudFtpClient.DeleteServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceDeleteServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsersRequestObject()
        {
            // Snippet: ListUsers(ListUsersRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
                Filter = "",
                OrderBy = "",
                View = UserView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = cloudFtpClient.ListUsers(request);

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
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
                Filter = "",
                OrderBy = "",
                View = UserView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = cloudFtpClient.ListUsersAsync(request);

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
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = cloudFtpClient.ListUsers(parent);

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
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = cloudFtpClient.ListUsersAsync(parent);

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
            // Snippet: ListUsers(ServerName, string, int?, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ServerName parent = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = cloudFtpClient.ListUsers(parent);

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
            // Snippet: ListUsersAsync(ServerName, string, int?, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ServerName parent = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = cloudFtpClient.ListUsersAsync(parent);

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

        /// <summary>Snippet for GetUser</summary>
        public void GetUserRequestObject()
        {
            // Snippet: GetUser(GetUserRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]"),
                View = UserView.Unspecified,
            };
            // Make the request
            User response = cloudFtpClient.GetUser(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserRequestObjectAsync()
        {
            // Snippet: GetUserAsync(GetUserRequest, CallSettings)
            // Additional: GetUserAsync(GetUserRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]"),
                View = UserView.Unspecified,
            };
            // Make the request
            User response = await cloudFtpClient.GetUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUser()
        {
            // Snippet: GetUser(string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]/users/[USER]";
            // Make the request
            User response = cloudFtpClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserAsync()
        {
            // Snippet: GetUserAsync(string, CallSettings)
            // Additional: GetUserAsync(string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]/users/[USER]";
            // Make the request
            User response = await cloudFtpClient.GetUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUserResourceNames()
        {
            // Snippet: GetUser(UserName, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]");
            // Make the request
            User response = cloudFtpClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserResourceNamesAsync()
        {
            // Snippet: GetUserAsync(UserName, CallSettings)
            // Additional: GetUserAsync(UserName, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]");
            // Make the request
            User response = await cloudFtpClient.GetUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserRequestObject()
        {
            // Snippet: CreateUser(CreateUserRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            CreateUserRequest request = new CreateUserRequest
            {
                ParentAsServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
                UserId = "",
                User = new User(),
                RequestId = "",
            };
            // Make the request
            Operation<User, OperationMetadata> response = cloudFtpClient.CreateUser(request);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceCreateUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserRequestObjectAsync()
        {
            // Snippet: CreateUserAsync(CreateUserRequest, CallSettings)
            // Additional: CreateUserAsync(CreateUserRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserRequest request = new CreateUserRequest
            {
                ParentAsServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
                UserId = "",
                User = new User(),
                RequestId = "",
            };
            // Make the request
            Operation<User, OperationMetadata> response = await cloudFtpClient.CreateUserAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceCreateUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUser()
        {
            // Snippet: CreateUser(string, User, string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            User user = new User();
            string userId = "";
            // Make the request
            Operation<User, OperationMetadata> response = cloudFtpClient.CreateUser(parent, user, userId);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceCreateUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserAsync()
        {
            // Snippet: CreateUserAsync(string, User, string, CallSettings)
            // Additional: CreateUserAsync(string, User, string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            User user = new User();
            string userId = "";
            // Make the request
            Operation<User, OperationMetadata> response = await cloudFtpClient.CreateUserAsync(parent, user, userId);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceCreateUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserResourceNames()
        {
            // Snippet: CreateUser(ServerName, User, string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ServerName parent = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            User user = new User();
            string userId = "";
            // Make the request
            Operation<User, OperationMetadata> response = cloudFtpClient.CreateUser(parent, user, userId);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceCreateUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserResourceNamesAsync()
        {
            // Snippet: CreateUserAsync(ServerName, User, string, CallSettings)
            // Additional: CreateUserAsync(ServerName, User, string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ServerName parent = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            User user = new User();
            string userId = "";
            // Make the request
            Operation<User, OperationMetadata> response = await cloudFtpClient.CreateUserAsync(parent, user, userId);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceCreateUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUser</summary>
        public void UpdateUserRequestObject()
        {
            // Snippet: UpdateUser(UpdateUserRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            UpdateUserRequest request = new UpdateUserRequest
            {
                UpdateMask = new FieldMask(),
                User = new User(),
            };
            // Make the request
            Operation<User, OperationMetadata> response = cloudFtpClient.UpdateUser(request);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceUpdateUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUserAsync</summary>
        public async Task UpdateUserRequestObjectAsync()
        {
            // Snippet: UpdateUserAsync(UpdateUserRequest, CallSettings)
            // Additional: UpdateUserAsync(UpdateUserRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserRequest request = new UpdateUserRequest
            {
                UpdateMask = new FieldMask(),
                User = new User(),
            };
            // Make the request
            Operation<User, OperationMetadata> response = await cloudFtpClient.UpdateUserAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceUpdateUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUser</summary>
        public void UpdateUser()
        {
            // Snippet: UpdateUser(User, FieldMask, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            User user = new User();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<User, OperationMetadata> response = cloudFtpClient.UpdateUser(user, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceUpdateUser(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateUserAsync</summary>
        public async Task UpdateUserAsync()
        {
            // Snippet: UpdateUserAsync(User, FieldMask, CallSettings)
            // Additional: UpdateUserAsync(User, FieldMask, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            User user = new User();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<User, OperationMetadata> response = await cloudFtpClient.UpdateUserAsync(user, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<User, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            User result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<User, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceUpdateUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                User retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUserRequestObject()
        {
            // Snippet: DeleteUser(DeleteUserRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudFtpClient.DeleteUser(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceDeleteUser(operationName);
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
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]"),
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudFtpClient.DeleteUserAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceDeleteUserAsync(operationName);
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
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]/users/[USER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudFtpClient.DeleteUser(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceDeleteUser(operationName);
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
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]/users/[USER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudFtpClient.DeleteUserAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceDeleteUserAsync(operationName);
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
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = cloudFtpClient.DeleteUser(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceDeleteUser(operationName);
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
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationServerUser("[PROJECT]", "[LOCATION]", "[SERVER]", "[USER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await cloudFtpClient.DeleteUserAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceDeleteUserAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartServer</summary>
        public void StartServerRequestObject()
        {
            // Snippet: StartServer(StartServerRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            StartServerRequest request = new StartServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
            };
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.StartServer(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceStartServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartServerAsync</summary>
        public async Task StartServerRequestObjectAsync()
        {
            // Snippet: StartServerAsync(StartServerRequest, CallSettings)
            // Additional: StartServerAsync(StartServerRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            StartServerRequest request = new StartServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
            };
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.StartServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceStartServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartServer</summary>
        public void StartServer()
        {
            // Snippet: StartServer(string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.StartServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceStartServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartServerAsync</summary>
        public async Task StartServerAsync()
        {
            // Snippet: StartServerAsync(string, CallSettings)
            // Additional: StartServerAsync(string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.StartServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceStartServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartServer</summary>
        public void StartServerResourceNames()
        {
            // Snippet: StartServer(ServerName, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.StartServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceStartServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartServerAsync</summary>
        public async Task StartServerResourceNamesAsync()
        {
            // Snippet: StartServerAsync(ServerName, CallSettings)
            // Additional: StartServerAsync(ServerName, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.StartServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceStartServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopServer</summary>
        public void StopServerRequestObject()
        {
            // Snippet: StopServer(StopServerRequest, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            StopServerRequest request = new StopServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
            };
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.StopServer(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceStopServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopServerAsync</summary>
        public async Task StopServerRequestObjectAsync()
        {
            // Snippet: StopServerAsync(StopServerRequest, CallSettings)
            // Additional: StopServerAsync(StopServerRequest, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            StopServerRequest request = new StopServerRequest
            {
                ServerName = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]"),
            };
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.StopServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceStopServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopServer</summary>
        public void StopServer()
        {
            // Snippet: StopServer(string, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.StopServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceStopServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopServerAsync</summary>
        public async Task StopServerAsync()
        {
            // Snippet: StopServerAsync(string, CallSettings)
            // Additional: StopServerAsync(string, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/servers/[SERVER]";
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.StopServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceStopServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopServer</summary>
        public void StopServerResourceNames()
        {
            // Snippet: StopServer(ServerName, CallSettings)
            // Create client
            CloudFtpClient cloudFtpClient = CloudFtpClient.Create();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Operation<Server, OperationMetadata> response = cloudFtpClient.StopServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = cloudFtpClient.PollOnceStopServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopServerAsync</summary>
        public async Task StopServerResourceNamesAsync()
        {
            // Snippet: StopServerAsync(ServerName, CallSettings)
            // Additional: StopServerAsync(ServerName, CancellationToken)
            // Create client
            CloudFtpClient cloudFtpClient = await CloudFtpClient.CreateAsync();
            // Initialize request argument(s)
            ServerName name = ServerName.FromProjectLocationServer("[PROJECT]", "[LOCATION]", "[SERVER]");
            // Make the request
            Operation<Server, OperationMetadata> response = await cloudFtpClient.StopServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Server, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Server result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Server, OperationMetadata> retrievedResponse = await cloudFtpClient.PollOnceStopServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Server retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
