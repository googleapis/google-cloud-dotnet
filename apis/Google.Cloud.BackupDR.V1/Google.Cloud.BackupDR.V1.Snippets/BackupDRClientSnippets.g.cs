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
    using Google.Cloud.BackupDR.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBackupDRClientSnippets
    {
        /// <summary>Snippet for ListManagementServers</summary>
        public void ListManagementServersRequestObject()
        {
            // Snippet: ListManagementServers(ListManagementServersRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ListManagementServersRequest request = new ListManagementServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListManagementServersResponse, ManagementServer> response = backupDRClient.ListManagementServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagementServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagementServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementServersAsync</summary>
        public async Task ListManagementServersRequestObjectAsync()
        {
            // Snippet: ListManagementServersAsync(ListManagementServersRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ListManagementServersRequest request = new ListManagementServersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> response = backupDRClient.ListManagementServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagementServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagementServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementServers</summary>
        public void ListManagementServers()
        {
            // Snippet: ListManagementServers(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListManagementServersResponse, ManagementServer> response = backupDRClient.ListManagementServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagementServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagementServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementServersAsync</summary>
        public async Task ListManagementServersAsync()
        {
            // Snippet: ListManagementServersAsync(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> response = backupDRClient.ListManagementServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagementServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagementServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementServers</summary>
        public void ListManagementServersResourceNames()
        {
            // Snippet: ListManagementServers(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListManagementServersResponse, ManagementServer> response = backupDRClient.ListManagementServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagementServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListManagementServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListManagementServersAsync</summary>
        public async Task ListManagementServersResourceNamesAsync()
        {
            // Snippet: ListManagementServersAsync(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListManagementServersResponse, ManagementServer> response = backupDRClient.ListManagementServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagementServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListManagementServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagementServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagementServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagementServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetManagementServer</summary>
        public void GetManagementServerRequestObject()
        {
            // Snippet: GetManagementServer(GetManagementServerRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            GetManagementServerRequest request = new GetManagementServerRequest
            {
                ManagementServerName = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]"),
            };
            // Make the request
            ManagementServer response = backupDRClient.GetManagementServer(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagementServerAsync</summary>
        public async Task GetManagementServerRequestObjectAsync()
        {
            // Snippet: GetManagementServerAsync(GetManagementServerRequest, CallSettings)
            // Additional: GetManagementServerAsync(GetManagementServerRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            GetManagementServerRequest request = new GetManagementServerRequest
            {
                ManagementServerName = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]"),
            };
            // Make the request
            ManagementServer response = await backupDRClient.GetManagementServerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetManagementServer</summary>
        public void GetManagementServer()
        {
            // Snippet: GetManagementServer(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/managementServers/[MANAGEMENTSERVER]";
            // Make the request
            ManagementServer response = backupDRClient.GetManagementServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagementServerAsync</summary>
        public async Task GetManagementServerAsync()
        {
            // Snippet: GetManagementServerAsync(string, CallSettings)
            // Additional: GetManagementServerAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/managementServers/[MANAGEMENTSERVER]";
            // Make the request
            ManagementServer response = await backupDRClient.GetManagementServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagementServer</summary>
        public void GetManagementServerResourceNames()
        {
            // Snippet: GetManagementServer(ManagementServerName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ManagementServerName name = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]");
            // Make the request
            ManagementServer response = backupDRClient.GetManagementServer(name);
            // End snippet
        }

        /// <summary>Snippet for GetManagementServerAsync</summary>
        public async Task GetManagementServerResourceNamesAsync()
        {
            // Snippet: GetManagementServerAsync(ManagementServerName, CallSettings)
            // Additional: GetManagementServerAsync(ManagementServerName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ManagementServerName name = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]");
            // Make the request
            ManagementServer response = await backupDRClient.GetManagementServerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateManagementServer</summary>
        public void CreateManagementServerRequestObject()
        {
            // Snippet: CreateManagementServer(CreateManagementServerRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            CreateManagementServerRequest request = new CreateManagementServerRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ManagementServerId = "",
                ManagementServer = new ManagementServer(),
                RequestId = "",
            };
            // Make the request
            Operation<ManagementServer, OperationMetadata> response = backupDRClient.CreateManagementServer(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementServer, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateManagementServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementServerAsync</summary>
        public async Task CreateManagementServerRequestObjectAsync()
        {
            // Snippet: CreateManagementServerAsync(CreateManagementServerRequest, CallSettings)
            // Additional: CreateManagementServerAsync(CreateManagementServerRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            CreateManagementServerRequest request = new CreateManagementServerRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ManagementServerId = "",
                ManagementServer = new ManagementServer(),
                RequestId = "",
            };
            // Make the request
            Operation<ManagementServer, OperationMetadata> response = await backupDRClient.CreateManagementServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagementServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementServer, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateManagementServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementServer</summary>
        public void CreateManagementServer()
        {
            // Snippet: CreateManagementServer(string, ManagementServer, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ManagementServer managementServer = new ManagementServer();
            string managementServerId = "";
            // Make the request
            Operation<ManagementServer, OperationMetadata> response = backupDRClient.CreateManagementServer(parent, managementServer, managementServerId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementServer, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateManagementServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementServerAsync</summary>
        public async Task CreateManagementServerAsync()
        {
            // Snippet: CreateManagementServerAsync(string, ManagementServer, string, CallSettings)
            // Additional: CreateManagementServerAsync(string, ManagementServer, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ManagementServer managementServer = new ManagementServer();
            string managementServerId = "";
            // Make the request
            Operation<ManagementServer, OperationMetadata> response = await backupDRClient.CreateManagementServerAsync(parent, managementServer, managementServerId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementServer, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateManagementServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementServer</summary>
        public void CreateManagementServerResourceNames()
        {
            // Snippet: CreateManagementServer(LocationName, ManagementServer, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ManagementServer managementServer = new ManagementServer();
            string managementServerId = "";
            // Make the request
            Operation<ManagementServer, OperationMetadata> response = backupDRClient.CreateManagementServer(parent, managementServer, managementServerId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementServer, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagementServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementServer, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateManagementServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateManagementServerAsync</summary>
        public async Task CreateManagementServerResourceNamesAsync()
        {
            // Snippet: CreateManagementServerAsync(LocationName, ManagementServer, string, CallSettings)
            // Additional: CreateManagementServerAsync(LocationName, ManagementServer, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ManagementServer managementServer = new ManagementServer();
            string managementServerId = "";
            // Make the request
            Operation<ManagementServer, OperationMetadata> response = await backupDRClient.CreateManagementServerAsync(parent, managementServer, managementServerId);

            // Poll until the returned long-running operation is complete
            Operation<ManagementServer, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagementServer result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagementServer, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateManagementServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagementServer retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementServer</summary>
        public void DeleteManagementServerRequestObject()
        {
            // Snippet: DeleteManagementServer(DeleteManagementServerRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DeleteManagementServerRequest request = new DeleteManagementServerRequest
            {
                ManagementServerName = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteManagementServer(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteManagementServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementServerAsync</summary>
        public async Task DeleteManagementServerRequestObjectAsync()
        {
            // Snippet: DeleteManagementServerAsync(DeleteManagementServerRequest, CallSettings)
            // Additional: DeleteManagementServerAsync(DeleteManagementServerRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DeleteManagementServerRequest request = new DeleteManagementServerRequest
            {
                ManagementServerName = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteManagementServerAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteManagementServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementServer</summary>
        public void DeleteManagementServer()
        {
            // Snippet: DeleteManagementServer(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/managementServers/[MANAGEMENTSERVER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteManagementServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteManagementServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementServerAsync</summary>
        public async Task DeleteManagementServerAsync()
        {
            // Snippet: DeleteManagementServerAsync(string, CallSettings)
            // Additional: DeleteManagementServerAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/managementServers/[MANAGEMENTSERVER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteManagementServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteManagementServerAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementServer</summary>
        public void DeleteManagementServerResourceNames()
        {
            // Snippet: DeleteManagementServer(ManagementServerName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ManagementServerName name = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteManagementServer(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteManagementServer(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteManagementServerAsync</summary>
        public async Task DeleteManagementServerResourceNamesAsync()
        {
            // Snippet: DeleteManagementServerAsync(ManagementServerName, CallSettings)
            // Additional: DeleteManagementServerAsync(ManagementServerName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ManagementServerName name = ManagementServerName.FromProjectLocationManagementserver("[PROJECT]", "[LOCATION]", "[MANAGEMENTSERVER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteManagementServerAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteManagementServerAsync(operationName);
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
