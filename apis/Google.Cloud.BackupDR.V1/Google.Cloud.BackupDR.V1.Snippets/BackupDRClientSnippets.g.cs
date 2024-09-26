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
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
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

        /// <summary>Snippet for CreateBackupVault</summary>
        public void CreateBackupVaultRequestObject()
        {
            // Snippet: CreateBackupVault(CreateBackupVaultRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            CreateBackupVaultRequest request = new CreateBackupVaultRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupVaultId = "",
                BackupVault = new BackupVault(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = backupDRClient.CreateBackupVault(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVaultAsync</summary>
        public async Task CreateBackupVaultRequestObjectAsync()
        {
            // Snippet: CreateBackupVaultAsync(CreateBackupVaultRequest, CallSettings)
            // Additional: CreateBackupVaultAsync(CreateBackupVaultRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupVaultRequest request = new CreateBackupVaultRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupVaultId = "",
                BackupVault = new BackupVault(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await backupDRClient.CreateBackupVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVault</summary>
        public void CreateBackupVault()
        {
            // Snippet: CreateBackupVault(string, BackupVault, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = backupDRClient.CreateBackupVault(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVaultAsync</summary>
        public async Task CreateBackupVaultAsync()
        {
            // Snippet: CreateBackupVaultAsync(string, BackupVault, string, CallSettings)
            // Additional: CreateBackupVaultAsync(string, BackupVault, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await backupDRClient.CreateBackupVaultAsync(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVault</summary>
        public void CreateBackupVaultResourceNames()
        {
            // Snippet: CreateBackupVault(LocationName, BackupVault, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = backupDRClient.CreateBackupVault(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupVaultAsync</summary>
        public async Task CreateBackupVaultResourceNamesAsync()
        {
            // Snippet: CreateBackupVaultAsync(LocationName, BackupVault, string, CallSettings)
            // Additional: CreateBackupVaultAsync(LocationName, BackupVault, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupVault backupVault = new BackupVault();
            string backupVaultId = "";
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await backupDRClient.CreateBackupVaultAsync(parent, backupVault, backupVaultId);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaults</summary>
        public void ListBackupVaultsRequestObject()
        {
            // Snippet: ListBackupVaults(ListBackupVaultsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = BackupVaultView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListBackupVaultsResponse, BackupVault> response = backupDRClient.ListBackupVaults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaultsAsync</summary>
        public async Task ListBackupVaultsRequestObjectAsync()
        {
            // Snippet: ListBackupVaultsAsync(ListBackupVaultsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupVaultsRequest request = new ListBackupVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                View = BackupVaultView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> response = backupDRClient.ListBackupVaultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaults</summary>
        public void ListBackupVaults()
        {
            // Snippet: ListBackupVaults(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupVaultsResponse, BackupVault> response = backupDRClient.ListBackupVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaultsAsync</summary>
        public async Task ListBackupVaultsAsync()
        {
            // Snippet: ListBackupVaultsAsync(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> response = backupDRClient.ListBackupVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaults</summary>
        public void ListBackupVaultsResourceNames()
        {
            // Snippet: ListBackupVaults(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupVaultsResponse, BackupVault> response = backupDRClient.ListBackupVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupVaultsAsync</summary>
        public async Task ListBackupVaultsResourceNamesAsync()
        {
            // Snippet: ListBackupVaultsAsync(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupVaultsResponse, BackupVault> response = backupDRClient.ListBackupVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchUsableBackupVaults</summary>
        public void FetchUsableBackupVaultsRequestObject()
        {
            // Snippet: FetchUsableBackupVaults(FetchUsableBackupVaultsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            FetchUsableBackupVaultsRequest request = new FetchUsableBackupVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<FetchUsableBackupVaultsResponse, BackupVault> response = backupDRClient.FetchUsableBackupVaults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchUsableBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchUsableBackupVaultsAsync</summary>
        public async Task FetchUsableBackupVaultsRequestObjectAsync()
        {
            // Snippet: FetchUsableBackupVaultsAsync(FetchUsableBackupVaultsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            FetchUsableBackupVaultsRequest request = new FetchUsableBackupVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<FetchUsableBackupVaultsResponse, BackupVault> response = backupDRClient.FetchUsableBackupVaultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchUsableBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchUsableBackupVaults</summary>
        public void FetchUsableBackupVaults()
        {
            // Snippet: FetchUsableBackupVaults(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<FetchUsableBackupVaultsResponse, BackupVault> response = backupDRClient.FetchUsableBackupVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchUsableBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchUsableBackupVaultsAsync</summary>
        public async Task FetchUsableBackupVaultsAsync()
        {
            // Snippet: FetchUsableBackupVaultsAsync(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<FetchUsableBackupVaultsResponse, BackupVault> response = backupDRClient.FetchUsableBackupVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchUsableBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchUsableBackupVaults</summary>
        public void FetchUsableBackupVaultsResourceNames()
        {
            // Snippet: FetchUsableBackupVaults(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<FetchUsableBackupVaultsResponse, BackupVault> response = backupDRClient.FetchUsableBackupVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FetchUsableBackupVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for FetchUsableBackupVaultsAsync</summary>
        public async Task FetchUsableBackupVaultsResourceNamesAsync()
        {
            // Snippet: FetchUsableBackupVaultsAsync(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<FetchUsableBackupVaultsResponse, BackupVault> response = backupDRClient.FetchUsableBackupVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FetchUsableBackupVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBackupVault</summary>
        public void GetBackupVaultRequestObject()
        {
            // Snippet: GetBackupVault(GetBackupVaultRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            GetBackupVaultRequest request = new GetBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]"),
                View = BackupVaultView.Unspecified,
            };
            // Make the request
            BackupVault response = backupDRClient.GetBackupVault(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVaultAsync</summary>
        public async Task GetBackupVaultRequestObjectAsync()
        {
            // Snippet: GetBackupVaultAsync(GetBackupVaultRequest, CallSettings)
            // Additional: GetBackupVaultAsync(GetBackupVaultRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupVaultRequest request = new GetBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]"),
                View = BackupVaultView.Unspecified,
            };
            // Make the request
            BackupVault response = await backupDRClient.GetBackupVaultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVault</summary>
        public void GetBackupVault()
        {
            // Snippet: GetBackupVault(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]";
            // Make the request
            BackupVault response = backupDRClient.GetBackupVault(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVaultAsync</summary>
        public async Task GetBackupVaultAsync()
        {
            // Snippet: GetBackupVaultAsync(string, CallSettings)
            // Additional: GetBackupVaultAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]";
            // Make the request
            BackupVault response = await backupDRClient.GetBackupVaultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVault</summary>
        public void GetBackupVaultResourceNames()
        {
            // Snippet: GetBackupVault(BackupVaultName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]");
            // Make the request
            BackupVault response = backupDRClient.GetBackupVault(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupVaultAsync</summary>
        public async Task GetBackupVaultResourceNamesAsync()
        {
            // Snippet: GetBackupVaultAsync(BackupVaultName, CallSettings)
            // Additional: GetBackupVaultAsync(BackupVaultName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]");
            // Make the request
            BackupVault response = await backupDRClient.GetBackupVaultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVault</summary>
        public void UpdateBackupVaultRequestObject()
        {
            // Snippet: UpdateBackupVault(UpdateBackupVaultRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            UpdateBackupVaultRequest request = new UpdateBackupVaultRequest
            {
                UpdateMask = new FieldMask(),
                BackupVault = new BackupVault(),
                RequestId = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = backupDRClient.UpdateBackupVault(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = backupDRClient.PollOnceUpdateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVaultAsync</summary>
        public async Task UpdateBackupVaultRequestObjectAsync()
        {
            // Snippet: UpdateBackupVaultAsync(UpdateBackupVaultRequest, CallSettings)
            // Additional: UpdateBackupVaultAsync(UpdateBackupVaultRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupVaultRequest request = new UpdateBackupVaultRequest
            {
                UpdateMask = new FieldMask(),
                BackupVault = new BackupVault(),
                RequestId = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await backupDRClient.UpdateBackupVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceUpdateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVault</summary>
        public void UpdateBackupVault()
        {
            // Snippet: UpdateBackupVault(BackupVault, FieldMask, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupVault backupVault = new BackupVault();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupVault, OperationMetadata> response = backupDRClient.UpdateBackupVault(backupVault, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = backupDRClient.PollOnceUpdateBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupVaultAsync</summary>
        public async Task UpdateBackupVaultAsync()
        {
            // Snippet: UpdateBackupVaultAsync(BackupVault, FieldMask, CallSettings)
            // Additional: UpdateBackupVaultAsync(BackupVault, FieldMask, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupVault backupVault = new BackupVault();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<BackupVault, OperationMetadata> response = await backupDRClient.UpdateBackupVaultAsync(backupVault, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<BackupVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupVault, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceUpdateBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVault</summary>
        public void DeleteBackupVaultRequestObject()
        {
            // Snippet: DeleteBackupVault(DeleteBackupVaultRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DeleteBackupVaultRequest request = new DeleteBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]"),
                RequestId = "",
                Force = false,
                Etag = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupVault(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVaultAsync</summary>
        public async Task DeleteBackupVaultRequestObjectAsync()
        {
            // Snippet: DeleteBackupVaultAsync(DeleteBackupVaultRequest, CallSettings)
            // Additional: DeleteBackupVaultAsync(DeleteBackupVaultRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupVaultRequest request = new DeleteBackupVaultRequest
            {
                BackupVaultName = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]"),
                RequestId = "",
                Force = false,
                Etag = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVault</summary>
        public void DeleteBackupVault()
        {
            // Snippet: DeleteBackupVault(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupVault(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVaultAsync</summary>
        public async Task DeleteBackupVaultAsync()
        {
            // Snippet: DeleteBackupVaultAsync(string, CallSettings)
            // Additional: DeleteBackupVaultAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupVaultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVault</summary>
        public void DeleteBackupVaultResourceNames()
        {
            // Snippet: DeleteBackupVault(BackupVaultName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupVault(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupVaultAsync</summary>
        public async Task DeleteBackupVaultResourceNamesAsync()
        {
            // Snippet: DeleteBackupVaultAsync(BackupVaultName, CallSettings)
            // Additional: DeleteBackupVaultAsync(BackupVaultName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupVaultName name = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupVaultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = backupDRClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await backupDRClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = backupDRClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await backupDRClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = backupDRClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await backupDRClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSourcesRequestObject()
        {
            // Snippet: ListDataSources(ListDataSourcesRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsBackupVaultName = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = backupDRClient.ListDataSources(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesRequestObjectAsync()
        {
            // Snippet: ListDataSourcesAsync(ListDataSourcesRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ListDataSourcesRequest request = new ListDataSourcesRequest
            {
                ParentAsBackupVaultName = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = backupDRClient.ListDataSourcesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSources()
        {
            // Snippet: ListDataSources(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]";
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = backupDRClient.ListDataSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesAsync()
        {
            // Snippet: ListDataSourcesAsync(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]";
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = backupDRClient.ListDataSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSources</summary>
        public void ListDataSourcesResourceNames()
        {
            // Snippet: ListDataSources(BackupVaultName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupVaultName parent = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]");
            // Make the request
            PagedEnumerable<ListDataSourcesResponse, DataSource> response = backupDRClient.ListDataSources(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataSource item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataSourcesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataSourcesAsync</summary>
        public async Task ListDataSourcesResourceNamesAsync()
        {
            // Snippet: ListDataSourcesAsync(BackupVaultName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupVaultName parent = BackupVaultName.FromProjectLocationBackupvault("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]");
            // Make the request
            PagedAsyncEnumerable<ListDataSourcesResponse, DataSource> response = backupDRClient.ListDataSourcesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataSource item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataSourcesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataSource item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataSource> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataSource item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSourceRequestObject()
        {
            // Snippet: GetDataSource(GetDataSourceRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
            };
            // Make the request
            DataSource response = backupDRClient.GetDataSource(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceRequestObjectAsync()
        {
            // Snippet: GetDataSourceAsync(GetDataSourceRequest, CallSettings)
            // Additional: GetDataSourceAsync(GetDataSourceRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            GetDataSourceRequest request = new GetDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
            };
            // Make the request
            DataSource response = await backupDRClient.GetDataSourceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSource()
        {
            // Snippet: GetDataSource(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            DataSource response = backupDRClient.GetDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceAsync()
        {
            // Snippet: GetDataSourceAsync(string, CallSettings)
            // Additional: GetDataSourceAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            DataSource response = await backupDRClient.GetDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSource</summary>
        public void GetDataSourceResourceNames()
        {
            // Snippet: GetDataSource(DataSourceName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            DataSource response = backupDRClient.GetDataSource(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataSourceAsync</summary>
        public async Task GetDataSourceResourceNamesAsync()
        {
            // Snippet: GetDataSourceAsync(DataSourceName, CallSettings)
            // Additional: GetDataSourceAsync(DataSourceName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            DataSource response = await backupDRClient.GetDataSourceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSource</summary>
        public void UpdateDataSourceRequestObject()
        {
            // Snippet: UpdateDataSource(UpdateDataSourceRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            UpdateDataSourceRequest request = new UpdateDataSourceRequest
            {
                UpdateMask = new FieldMask(),
                DataSource = new DataSource(),
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<DataSource, OperationMetadata> response = backupDRClient.UpdateDataSource(request);

            // Poll until the returned long-running operation is complete
            Operation<DataSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataSource, OperationMetadata> retrievedResponse = backupDRClient.PollOnceUpdateDataSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSourceAsync</summary>
        public async Task UpdateDataSourceRequestObjectAsync()
        {
            // Snippet: UpdateDataSourceAsync(UpdateDataSourceRequest, CallSettings)
            // Additional: UpdateDataSourceAsync(UpdateDataSourceRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataSourceRequest request = new UpdateDataSourceRequest
            {
                UpdateMask = new FieldMask(),
                DataSource = new DataSource(),
                RequestId = "",
                AllowMissing = false,
            };
            // Make the request
            Operation<DataSource, OperationMetadata> response = await backupDRClient.UpdateDataSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataSource, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceUpdateDataSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSource</summary>
        public void UpdateDataSource()
        {
            // Snippet: UpdateDataSource(DataSource, FieldMask, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSource dataSource = new DataSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DataSource, OperationMetadata> response = backupDRClient.UpdateDataSource(dataSource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DataSource, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataSource, OperationMetadata> retrievedResponse = backupDRClient.PollOnceUpdateDataSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataSourceAsync</summary>
        public async Task UpdateDataSourceAsync()
        {
            // Snippet: UpdateDataSourceAsync(DataSource, FieldMask, CallSettings)
            // Additional: UpdateDataSourceAsync(DataSource, FieldMask, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSource dataSource = new DataSource();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DataSource, OperationMetadata> response = await backupDRClient.UpdateDataSourceAsync(dataSource, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DataSource, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataSource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataSource, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceUpdateDataSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataSource retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveDataSource</summary>
        public void RemoveDataSourceRequestObject()
        {
            // Snippet: RemoveDataSource(RemoveDataSourceRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            RemoveDataSourceRequest request = new RemoveDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.RemoveDataSource(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceRemoveDataSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveDataSourceAsync</summary>
        public async Task RemoveDataSourceRequestObjectAsync()
        {
            // Snippet: RemoveDataSourceAsync(RemoveDataSourceRequest, CallSettings)
            // Additional: RemoveDataSourceAsync(RemoveDataSourceRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            RemoveDataSourceRequest request = new RemoveDataSourceRequest
            {
                DataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.RemoveDataSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceRemoveDataSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveDataSource</summary>
        public void RemoveDataSource()
        {
            // Snippet: RemoveDataSource(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.RemoveDataSource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceRemoveDataSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveDataSourceAsync</summary>
        public async Task RemoveDataSourceAsync()
        {
            // Snippet: RemoveDataSourceAsync(string, CallSettings)
            // Additional: RemoveDataSourceAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.RemoveDataSourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceRemoveDataSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveDataSource</summary>
        public void RemoveDataSourceResourceNames()
        {
            // Snippet: RemoveDataSource(DataSourceName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.RemoveDataSource(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceRemoveDataSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveDataSourceAsync</summary>
        public async Task RemoveDataSourceResourceNamesAsync()
        {
            // Snippet: RemoveDataSourceAsync(DataSourceName, CallSettings)
            // Additional: RemoveDataSourceAsync(DataSourceName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.RemoveDataSourceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceRemoveDataSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInternalStatus</summary>
        public void SetInternalStatusRequestObject()
        {
            // Snippet: SetInternalStatus(SetInternalStatusRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            SetInternalStatusRequest request = new SetInternalStatusRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                Value = ByteString.Empty,
                BackupConfigState = BackupConfigState.Unspecified,
                RequestId = "",
            };
            // Make the request
            Operation<SetInternalStatusResponse, OperationMetadata> response = backupDRClient.SetInternalStatus(request);

            // Poll until the returned long-running operation is complete
            Operation<SetInternalStatusResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SetInternalStatusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInternalStatusResponse, OperationMetadata> retrievedResponse = backupDRClient.PollOnceSetInternalStatus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInternalStatusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInternalStatusAsync</summary>
        public async Task SetInternalStatusRequestObjectAsync()
        {
            // Snippet: SetInternalStatusAsync(SetInternalStatusRequest, CallSettings)
            // Additional: SetInternalStatusAsync(SetInternalStatusRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            SetInternalStatusRequest request = new SetInternalStatusRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                Value = ByteString.Empty,
                BackupConfigState = BackupConfigState.Unspecified,
                RequestId = "",
            };
            // Make the request
            Operation<SetInternalStatusResponse, OperationMetadata> response = await backupDRClient.SetInternalStatusAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SetInternalStatusResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SetInternalStatusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInternalStatusResponse, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceSetInternalStatusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInternalStatusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInternalStatus</summary>
        public void SetInternalStatus()
        {
            // Snippet: SetInternalStatus(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<SetInternalStatusResponse, OperationMetadata> response = backupDRClient.SetInternalStatus(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<SetInternalStatusResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SetInternalStatusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInternalStatusResponse, OperationMetadata> retrievedResponse = backupDRClient.PollOnceSetInternalStatus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInternalStatusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInternalStatusAsync</summary>
        public async Task SetInternalStatusAsync()
        {
            // Snippet: SetInternalStatusAsync(string, CallSettings)
            // Additional: SetInternalStatusAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<SetInternalStatusResponse, OperationMetadata> response = await backupDRClient.SetInternalStatusAsync(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<SetInternalStatusResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SetInternalStatusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInternalStatusResponse, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceSetInternalStatusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInternalStatusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInternalStatus</summary>
        public void SetInternalStatusResourceNames()
        {
            // Snippet: SetInternalStatus(DataSourceName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<SetInternalStatusResponse, OperationMetadata> response = backupDRClient.SetInternalStatus(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<SetInternalStatusResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SetInternalStatusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInternalStatusResponse, OperationMetadata> retrievedResponse = backupDRClient.PollOnceSetInternalStatus(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInternalStatusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetInternalStatusAsync</summary>
        public async Task SetInternalStatusResourceNamesAsync()
        {
            // Snippet: SetInternalStatusAsync(DataSourceName, CallSettings)
            // Additional: SetInternalStatusAsync(DataSourceName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<SetInternalStatusResponse, OperationMetadata> response = await backupDRClient.SetInternalStatusAsync(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<SetInternalStatusResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SetInternalStatusResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SetInternalStatusResponse, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceSetInternalStatusAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SetInternalStatusResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InitiateBackup</summary>
        public void InitiateBackupRequestObject()
        {
            // Snippet: InitiateBackup(InitiateBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            InitiateBackupRequest request = new InitiateBackupRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                RequestId = "",
                BackupId = "",
            };
            // Make the request
            InitiateBackupResponse response = backupDRClient.InitiateBackup(request);
            // End snippet
        }

        /// <summary>Snippet for InitiateBackupAsync</summary>
        public async Task InitiateBackupRequestObjectAsync()
        {
            // Snippet: InitiateBackupAsync(InitiateBackupRequest, CallSettings)
            // Additional: InitiateBackupAsync(InitiateBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            InitiateBackupRequest request = new InitiateBackupRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                RequestId = "",
                BackupId = "",
            };
            // Make the request
            InitiateBackupResponse response = await backupDRClient.InitiateBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for InitiateBackup</summary>
        public void InitiateBackup()
        {
            // Snippet: InitiateBackup(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            InitiateBackupResponse response = backupDRClient.InitiateBackup(dataSource);
            // End snippet
        }

        /// <summary>Snippet for InitiateBackupAsync</summary>
        public async Task InitiateBackupAsync()
        {
            // Snippet: InitiateBackupAsync(string, CallSettings)
            // Additional: InitiateBackupAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            InitiateBackupResponse response = await backupDRClient.InitiateBackupAsync(dataSource);
            // End snippet
        }

        /// <summary>Snippet for InitiateBackup</summary>
        public void InitiateBackupResourceNames()
        {
            // Snippet: InitiateBackup(DataSourceName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            InitiateBackupResponse response = backupDRClient.InitiateBackup(dataSource);
            // End snippet
        }

        /// <summary>Snippet for InitiateBackupAsync</summary>
        public async Task InitiateBackupResourceNamesAsync()
        {
            // Snippet: InitiateBackupAsync(DataSourceName, CallSettings)
            // Additional: InitiateBackupAsync(DataSourceName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            InitiateBackupResponse response = await backupDRClient.InitiateBackupAsync(dataSource);
            // End snippet
        }

        /// <summary>Snippet for AbandonBackup</summary>
        public void AbandonBackupRequestObject()
        {
            // Snippet: AbandonBackup(AbandonBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            AbandonBackupRequest request = new AbandonBackupRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.AbandonBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceAbandonBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonBackupAsync</summary>
        public async Task AbandonBackupRequestObjectAsync()
        {
            // Snippet: AbandonBackupAsync(AbandonBackupRequest, CallSettings)
            // Additional: AbandonBackupAsync(AbandonBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            AbandonBackupRequest request = new AbandonBackupRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.AbandonBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceAbandonBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonBackup</summary>
        public void AbandonBackup()
        {
            // Snippet: AbandonBackup(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.AbandonBackup(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceAbandonBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonBackupAsync</summary>
        public async Task AbandonBackupAsync()
        {
            // Snippet: AbandonBackupAsync(string, CallSettings)
            // Additional: AbandonBackupAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.AbandonBackupAsync(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceAbandonBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonBackup</summary>
        public void AbandonBackupResourceNames()
        {
            // Snippet: AbandonBackup(DataSourceName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.AbandonBackup(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceAbandonBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AbandonBackupAsync</summary>
        public async Task AbandonBackupResourceNamesAsync()
        {
            // Snippet: AbandonBackupAsync(DataSourceName, CallSettings)
            // Additional: AbandonBackupAsync(DataSourceName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.AbandonBackupAsync(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceAbandonBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeBackup</summary>
        public void FinalizeBackupRequestObject()
        {
            // Snippet: FinalizeBackup(FinalizeBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            FinalizeBackupRequest request = new FinalizeBackupRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                Description = "",
                ConsistencyTime = new Timestamp(),
                RequestId = "",
                BackupId = "",
                RecoveryRangeStartTime = new Timestamp(),
                RecoveryRangeEndTime = new Timestamp(),
                RetentionDuration = new Duration(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.FinalizeBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceFinalizeBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeBackupAsync</summary>
        public async Task FinalizeBackupRequestObjectAsync()
        {
            // Snippet: FinalizeBackupAsync(FinalizeBackupRequest, CallSettings)
            // Additional: FinalizeBackupAsync(FinalizeBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            FinalizeBackupRequest request = new FinalizeBackupRequest
            {
                DataSourceAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                Description = "",
                ConsistencyTime = new Timestamp(),
                RequestId = "",
                BackupId = "",
                RecoveryRangeStartTime = new Timestamp(),
                RecoveryRangeEndTime = new Timestamp(),
                RetentionDuration = new Duration(),
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.FinalizeBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceFinalizeBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeBackup</summary>
        public void FinalizeBackup()
        {
            // Snippet: FinalizeBackup(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.FinalizeBackup(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceFinalizeBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeBackupAsync</summary>
        public async Task FinalizeBackupAsync()
        {
            // Snippet: FinalizeBackupAsync(string, CallSettings)
            // Additional: FinalizeBackupAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string dataSource = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.FinalizeBackupAsync(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceFinalizeBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeBackup</summary>
        public void FinalizeBackupResourceNames()
        {
            // Snippet: FinalizeBackup(DataSourceName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.FinalizeBackup(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceFinalizeBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FinalizeBackupAsync</summary>
        public async Task FinalizeBackupResourceNamesAsync()
        {
            // Snippet: FinalizeBackupAsync(DataSourceName, CallSettings)
            // Additional: FinalizeBackupAsync(DataSourceName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName dataSource = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.FinalizeBackupAsync(dataSource);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceFinalizeBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FetchAccessToken</summary>
        public void FetchAccessTokenRequestObject()
        {
            // Snippet: FetchAccessToken(FetchAccessTokenRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            FetchAccessTokenRequest request = new FetchAccessTokenRequest
            {
                DataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                GenerationId = 0,
            };
            // Make the request
            FetchAccessTokenResponse response = backupDRClient.FetchAccessToken(request);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessTokenAsync</summary>
        public async Task FetchAccessTokenRequestObjectAsync()
        {
            // Snippet: FetchAccessTokenAsync(FetchAccessTokenRequest, CallSettings)
            // Additional: FetchAccessTokenAsync(FetchAccessTokenRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            FetchAccessTokenRequest request = new FetchAccessTokenRequest
            {
                DataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                GenerationId = 0,
            };
            // Make the request
            FetchAccessTokenResponse response = await backupDRClient.FetchAccessTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessToken</summary>
        public void FetchAccessToken()
        {
            // Snippet: FetchAccessToken(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            FetchAccessTokenResponse response = backupDRClient.FetchAccessToken(name);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessTokenAsync</summary>
        public async Task FetchAccessTokenAsync()
        {
            // Snippet: FetchAccessTokenAsync(string, CallSettings)
            // Additional: FetchAccessTokenAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            FetchAccessTokenResponse response = await backupDRClient.FetchAccessTokenAsync(name);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessToken</summary>
        public void FetchAccessTokenResourceNames()
        {
            // Snippet: FetchAccessToken(DataSourceName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            FetchAccessTokenResponse response = backupDRClient.FetchAccessToken(name);
            // End snippet
        }

        /// <summary>Snippet for FetchAccessTokenAsync</summary>
        public async Task FetchAccessTokenResourceNamesAsync()
        {
            // Snippet: FetchAccessTokenAsync(DataSourceName, CallSettings)
            // Additional: FetchAccessTokenAsync(DataSourceName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName name = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            FetchAccessTokenResponse response = await backupDRClient.FetchAccessTokenAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                Filter = "",
                OrderBy = "",
                View = BackupView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = backupDRClient.ListBackups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsRequestObjectAsync()
        {
            // Snippet: ListBackupsAsync(ListBackupsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsDataSourceName = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]"),
                Filter = "",
                OrderBy = "",
                View = BackupView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = backupDRClient.ListBackupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackups()
        {
            // Snippet: ListBackups(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = backupDRClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsAsync()
        {
            // Snippet: ListBackupsAsync(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = backupDRClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsResourceNames()
        {
            // Snippet: ListBackups(DataSourceName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DataSourceName parent = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = backupDRClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsResourceNamesAsync()
        {
            // Snippet: ListBackupsAsync(DataSourceName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DataSourceName parent = DataSourceName.FromProjectLocationBackupvaultDatasource("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = backupDRClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupRequestObject()
        {
            // Snippet: GetBackup(GetBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]"),
                View = BackupView.Unspecified,
            };
            // Make the request
            Backup response = backupDRClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]"),
                View = BackupView.Unspecified,
            };
            // Make the request
            Backup response = await backupDRClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]/backups/[BACKUP]";
            // Make the request
            Backup response = backupDRClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]/backups/[BACKUP]";
            // Make the request
            Backup response = await backupDRClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]");
            // Make the request
            Backup response = backupDRClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]");
            // Make the request
            Backup response = await backupDRClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackupRequestObject()
        {
            // Snippet: UpdateBackup(UpdateBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
                RequestId = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.UpdateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceUpdateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupRequestObjectAsync()
        {
            // Snippet: UpdateBackupAsync(UpdateBackupRequest, CallSettings)
            // Additional: UpdateBackupAsync(UpdateBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
                RequestId = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.UpdateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceUpdateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackup()
        {
            // Snippet: UpdateBackup(Backup, FieldMask, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.UpdateBackup(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceUpdateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupAsync()
        {
            // Snippet: UpdateBackupAsync(Backup, FieldMask, CallSettings)
            // Additional: UpdateBackupAsync(Backup, FieldMask, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.UpdateBackupAsync(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceUpdateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupRequestObject()
        {
            // Snippet: DeleteBackup(DeleteBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.DeleteBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupRequestObjectAsync()
        {
            // Snippet: DeleteBackupAsync(DeleteBackupRequest, CallSettings)
            // Additional: DeleteBackupAsync(DeleteBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.DeleteBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackup()
        {
            // Snippet: DeleteBackup(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]/backups/[BACKUP]";
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupAsync()
        {
            // Snippet: DeleteBackupAsync(string, CallSettings)
            // Additional: DeleteBackupAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]/backups/[BACKUP]";
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupResourceNames()
        {
            // Snippet: DeleteBackup(BackupName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]");
            // Make the request
            Operation<Backup, OperationMetadata> response = backupDRClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupResourceNamesAsync()
        {
            // Snippet: DeleteBackupAsync(BackupName, CallSettings)
            // Additional: DeleteBackupAsync(BackupName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]");
            // Make the request
            Operation<Backup, OperationMetadata> response = await backupDRClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackupRequestObject()
        {
            // Snippet: RestoreBackup(RestoreBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            RestoreBackupRequest request = new RestoreBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]"),
                RequestId = "",
                ComputeInstanceTargetEnvironment = new ComputeInstanceTargetEnvironment(),
                ComputeInstanceRestoreProperties = new ComputeInstanceRestoreProperties(),
            };
            // Make the request
            Operation<RestoreBackupResponse, OperationMetadata> response = backupDRClient.RestoreBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<RestoreBackupResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestoreBackupResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreBackupResponse, OperationMetadata> retrievedResponse = backupDRClient.PollOnceRestoreBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreBackupResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupRequestObjectAsync()
        {
            // Snippet: RestoreBackupAsync(RestoreBackupRequest, CallSettings)
            // Additional: RestoreBackupAsync(RestoreBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            RestoreBackupRequest request = new RestoreBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]"),
                RequestId = "",
                ComputeInstanceTargetEnvironment = new ComputeInstanceTargetEnvironment(),
                ComputeInstanceRestoreProperties = new ComputeInstanceRestoreProperties(),
            };
            // Make the request
            Operation<RestoreBackupResponse, OperationMetadata> response = await backupDRClient.RestoreBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<RestoreBackupResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestoreBackupResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreBackupResponse, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceRestoreBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreBackupResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackup()
        {
            // Snippet: RestoreBackup(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]/backups/[BACKUP]";
            // Make the request
            Operation<RestoreBackupResponse, OperationMetadata> response = backupDRClient.RestoreBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreBackupResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestoreBackupResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreBackupResponse, OperationMetadata> retrievedResponse = backupDRClient.PollOnceRestoreBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreBackupResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupAsync()
        {
            // Snippet: RestoreBackupAsync(string, CallSettings)
            // Additional: RestoreBackupAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupVaults/[BACKUPVAULT]/dataSources/[DATASOURCE]/backups/[BACKUP]";
            // Make the request
            Operation<RestoreBackupResponse, OperationMetadata> response = await backupDRClient.RestoreBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreBackupResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestoreBackupResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreBackupResponse, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceRestoreBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreBackupResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackupResourceNames()
        {
            // Snippet: RestoreBackup(BackupName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]");
            // Make the request
            Operation<RestoreBackupResponse, OperationMetadata> response = backupDRClient.RestoreBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreBackupResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RestoreBackupResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreBackupResponse, OperationMetadata> retrievedResponse = backupDRClient.PollOnceRestoreBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreBackupResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupResourceNamesAsync()
        {
            // Snippet: RestoreBackupAsync(BackupName, CallSettings)
            // Additional: RestoreBackupAsync(BackupName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackupvaultDatasourceBackup("[PROJECT]", "[LOCATION]", "[BACKUPVAULT]", "[DATASOURCE]", "[BACKUP]");
            // Make the request
            Operation<RestoreBackupResponse, OperationMetadata> response = await backupDRClient.RestoreBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<RestoreBackupResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            RestoreBackupResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RestoreBackupResponse, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceRestoreBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RestoreBackupResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlan</summary>
        public void CreateBackupPlanRequestObject()
        {
            // Snippet: CreateBackupPlan(CreateBackupPlanRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            CreateBackupPlanRequest request = new CreateBackupPlanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPlanId = "",
                BackupPlan = new BackupPlan(),
                RequestId = "",
            };
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupDRClient.CreateBackupPlan(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAsync</summary>
        public async Task CreateBackupPlanRequestObjectAsync()
        {
            // Snippet: CreateBackupPlanAsync(CreateBackupPlanRequest, CallSettings)
            // Additional: CreateBackupPlanAsync(CreateBackupPlanRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupPlanRequest request = new CreateBackupPlanRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPlanId = "",
                BackupPlan = new BackupPlan(),
                RequestId = "",
            };
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupDRClient.CreateBackupPlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlan</summary>
        public void CreateBackupPlan()
        {
            // Snippet: CreateBackupPlan(string, BackupPlan, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupDRClient.CreateBackupPlan(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAsync</summary>
        public async Task CreateBackupPlanAsync()
        {
            // Snippet: CreateBackupPlanAsync(string, BackupPlan, string, CallSettings)
            // Additional: CreateBackupPlanAsync(string, BackupPlan, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupDRClient.CreateBackupPlanAsync(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlan</summary>
        public void CreateBackupPlanResourceNames()
        {
            // Snippet: CreateBackupPlan(LocationName, BackupPlan, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = backupDRClient.CreateBackupPlan(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAsync</summary>
        public async Task CreateBackupPlanResourceNamesAsync()
        {
            // Snippet: CreateBackupPlanAsync(LocationName, BackupPlan, string, CallSettings)
            // Additional: CreateBackupPlanAsync(LocationName, BackupPlan, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPlan backupPlan = new BackupPlan();
            string backupPlanId = "";
            // Make the request
            Operation<BackupPlan, OperationMetadata> response = await backupDRClient.CreateBackupPlanAsync(parent, backupPlan, backupPlanId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlan, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlan result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlan, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlan retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlan</summary>
        public void GetBackupPlanRequestObject()
        {
            // Snippet: GetBackupPlan(GetBackupPlanRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            // Make the request
            BackupPlan response = backupDRClient.GetBackupPlan(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAsync</summary>
        public async Task GetBackupPlanRequestObjectAsync()
        {
            // Snippet: GetBackupPlanAsync(GetBackupPlanRequest, CallSettings)
            // Additional: GetBackupPlanAsync(GetBackupPlanRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupPlanRequest request = new GetBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
            };
            // Make the request
            BackupPlan response = await backupDRClient.GetBackupPlanAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlan</summary>
        public void GetBackupPlan()
        {
            // Snippet: GetBackupPlan(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            BackupPlan response = backupDRClient.GetBackupPlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAsync</summary>
        public async Task GetBackupPlanAsync()
        {
            // Snippet: GetBackupPlanAsync(string, CallSettings)
            // Additional: GetBackupPlanAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            BackupPlan response = await backupDRClient.GetBackupPlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlan</summary>
        public void GetBackupPlanResourceNames()
        {
            // Snippet: GetBackupPlan(BackupPlanName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            BackupPlan response = backupDRClient.GetBackupPlan(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAsync</summary>
        public async Task GetBackupPlanResourceNamesAsync()
        {
            // Snippet: GetBackupPlanAsync(BackupPlanName, CallSettings)
            // Additional: GetBackupPlanAsync(BackupPlanName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            BackupPlan response = await backupDRClient.GetBackupPlanAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlans</summary>
        public void ListBackupPlansRequestObject()
        {
            // Snippet: ListBackupPlans(ListBackupPlansRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ListBackupPlansRequest request = new ListBackupPlansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBackupPlansResponse, BackupPlan> response = backupDRClient.ListBackupPlans(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlansAsync</summary>
        public async Task ListBackupPlansRequestObjectAsync()
        {
            // Snippet: ListBackupPlansAsync(ListBackupPlansRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupPlansRequest request = new ListBackupPlansRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> response = backupDRClient.ListBackupPlansAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlans</summary>
        public void ListBackupPlans()
        {
            // Snippet: ListBackupPlans(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupPlansResponse, BackupPlan> response = backupDRClient.ListBackupPlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlansAsync</summary>
        public async Task ListBackupPlansAsync()
        {
            // Snippet: ListBackupPlansAsync(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> response = backupDRClient.ListBackupPlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlans</summary>
        public void ListBackupPlansResourceNames()
        {
            // Snippet: ListBackupPlans(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupPlansResponse, BackupPlan> response = backupDRClient.ListBackupPlans(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlan item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlansResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlansAsync</summary>
        public async Task ListBackupPlansResourceNamesAsync()
        {
            // Snippet: ListBackupPlansAsync(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupPlansResponse, BackupPlan> response = backupDRClient.ListBackupPlansAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlan item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlansResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlan item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlan> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlan item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlan</summary>
        public void DeleteBackupPlanRequestObject()
        {
            // Snippet: DeleteBackupPlan(DeleteBackupPlanRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DeleteBackupPlanRequest request = new DeleteBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupPlan(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAsync</summary>
        public async Task DeleteBackupPlanRequestObjectAsync()
        {
            // Snippet: DeleteBackupPlanAsync(DeleteBackupPlanRequest, CallSettings)
            // Additional: DeleteBackupPlanAsync(DeleteBackupPlanRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupPlanRequest request = new DeleteBackupPlanRequest
            {
                BackupPlanName = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupPlanAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlan</summary>
        public void DeleteBackupPlan()
        {
            // Snippet: DeleteBackupPlan(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupPlan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAsync</summary>
        public async Task DeleteBackupPlanAsync()
        {
            // Snippet: DeleteBackupPlanAsync(string, CallSettings)
            // Additional: DeleteBackupPlanAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlans/[BACKUP_PLAN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupPlanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlan</summary>
        public void DeleteBackupPlanResourceNames()
        {
            // Snippet: DeleteBackupPlan(BackupPlanName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupPlan(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupPlan(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAsync</summary>
        public async Task DeleteBackupPlanResourceNamesAsync()
        {
            // Snippet: DeleteBackupPlanAsync(BackupPlanName, CallSettings)
            // Additional: DeleteBackupPlanAsync(BackupPlanName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanName name = BackupPlanName.FromProjectLocationBackupPlan("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupPlanAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupPlanAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAssociation</summary>
        public void CreateBackupPlanAssociationRequestObject()
        {
            // Snippet: CreateBackupPlanAssociation(CreateBackupPlanAssociationRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            CreateBackupPlanAssociationRequest request = new CreateBackupPlanAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPlanAssociationId = "",
                BackupPlanAssociation = new BackupPlanAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = backupDRClient.CreateBackupPlanAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupPlanAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAssociationAsync</summary>
        public async Task CreateBackupPlanAssociationRequestObjectAsync()
        {
            // Snippet: CreateBackupPlanAssociationAsync(CreateBackupPlanAssociationRequest, CallSettings)
            // Additional: CreateBackupPlanAssociationAsync(CreateBackupPlanAssociationRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupPlanAssociationRequest request = new CreateBackupPlanAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupPlanAssociationId = "",
                BackupPlanAssociation = new BackupPlanAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = await backupDRClient.CreateBackupPlanAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupPlanAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAssociation</summary>
        public void CreateBackupPlanAssociation()
        {
            // Snippet: CreateBackupPlanAssociation(string, BackupPlanAssociation, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPlanAssociation backupPlanAssociation = new BackupPlanAssociation();
            string backupPlanAssociationId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = backupDRClient.CreateBackupPlanAssociation(parent, backupPlanAssociation, backupPlanAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupPlanAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAssociationAsync</summary>
        public async Task CreateBackupPlanAssociationAsync()
        {
            // Snippet: CreateBackupPlanAssociationAsync(string, BackupPlanAssociation, string, CallSettings)
            // Additional: CreateBackupPlanAssociationAsync(string, BackupPlanAssociation, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            BackupPlanAssociation backupPlanAssociation = new BackupPlanAssociation();
            string backupPlanAssociationId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = await backupDRClient.CreateBackupPlanAssociationAsync(parent, backupPlanAssociation, backupPlanAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupPlanAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAssociation</summary>
        public void CreateBackupPlanAssociationResourceNames()
        {
            // Snippet: CreateBackupPlanAssociation(LocationName, BackupPlanAssociation, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPlanAssociation backupPlanAssociation = new BackupPlanAssociation();
            string backupPlanAssociationId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = backupDRClient.CreateBackupPlanAssociation(parent, backupPlanAssociation, backupPlanAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = backupDRClient.PollOnceCreateBackupPlanAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupPlanAssociationAsync</summary>
        public async Task CreateBackupPlanAssociationResourceNamesAsync()
        {
            // Snippet: CreateBackupPlanAssociationAsync(LocationName, BackupPlanAssociation, string, CallSettings)
            // Additional: CreateBackupPlanAssociationAsync(LocationName, BackupPlanAssociation, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            BackupPlanAssociation backupPlanAssociation = new BackupPlanAssociation();
            string backupPlanAssociationId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = await backupDRClient.CreateBackupPlanAssociationAsync(parent, backupPlanAssociation, backupPlanAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceCreateBackupPlanAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAssociation</summary>
        public void GetBackupPlanAssociationRequestObject()
        {
            // Snippet: GetBackupPlanAssociation(GetBackupPlanAssociationRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            GetBackupPlanAssociationRequest request = new GetBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]"),
            };
            // Make the request
            BackupPlanAssociation response = backupDRClient.GetBackupPlanAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAssociationAsync</summary>
        public async Task GetBackupPlanAssociationRequestObjectAsync()
        {
            // Snippet: GetBackupPlanAssociationAsync(GetBackupPlanAssociationRequest, CallSettings)
            // Additional: GetBackupPlanAssociationAsync(GetBackupPlanAssociationRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupPlanAssociationRequest request = new GetBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]"),
            };
            // Make the request
            BackupPlanAssociation response = await backupDRClient.GetBackupPlanAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAssociation</summary>
        public void GetBackupPlanAssociation()
        {
            // Snippet: GetBackupPlanAssociation(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlanAssociations/[BACKUP_PLAN_ASSOCIATION]";
            // Make the request
            BackupPlanAssociation response = backupDRClient.GetBackupPlanAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAssociationAsync</summary>
        public async Task GetBackupPlanAssociationAsync()
        {
            // Snippet: GetBackupPlanAssociationAsync(string, CallSettings)
            // Additional: GetBackupPlanAssociationAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlanAssociations/[BACKUP_PLAN_ASSOCIATION]";
            // Make the request
            BackupPlanAssociation response = await backupDRClient.GetBackupPlanAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAssociation</summary>
        public void GetBackupPlanAssociationResourceNames()
        {
            // Snippet: GetBackupPlanAssociation(BackupPlanAssociationName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupPlanAssociationName name = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]");
            // Make the request
            BackupPlanAssociation response = backupDRClient.GetBackupPlanAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupPlanAssociationAsync</summary>
        public async Task GetBackupPlanAssociationResourceNamesAsync()
        {
            // Snippet: GetBackupPlanAssociationAsync(BackupPlanAssociationName, CallSettings)
            // Additional: GetBackupPlanAssociationAsync(BackupPlanAssociationName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanAssociationName name = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]");
            // Make the request
            BackupPlanAssociation response = await backupDRClient.GetBackupPlanAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlanAssociations</summary>
        public void ListBackupPlanAssociationsRequestObject()
        {
            // Snippet: ListBackupPlanAssociations(ListBackupPlanAssociationsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            ListBackupPlanAssociationsRequest request = new ListBackupPlanAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> response = backupDRClient.ListBackupPlanAssociations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlanAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlanAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlanAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlanAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlanAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlanAssociationsAsync</summary>
        public async Task ListBackupPlanAssociationsRequestObjectAsync()
        {
            // Snippet: ListBackupPlanAssociationsAsync(ListBackupPlanAssociationsRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupPlanAssociationsRequest request = new ListBackupPlanAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> response = backupDRClient.ListBackupPlanAssociationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlanAssociation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlanAssociationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlanAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlanAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlanAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlanAssociations</summary>
        public void ListBackupPlanAssociations()
        {
            // Snippet: ListBackupPlanAssociations(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> response = backupDRClient.ListBackupPlanAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlanAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlanAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlanAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlanAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlanAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlanAssociationsAsync</summary>
        public async Task ListBackupPlanAssociationsAsync()
        {
            // Snippet: ListBackupPlanAssociationsAsync(string, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> response = backupDRClient.ListBackupPlanAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlanAssociation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlanAssociationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlanAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlanAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlanAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlanAssociations</summary>
        public void ListBackupPlanAssociationsResourceNames()
        {
            // Snippet: ListBackupPlanAssociations(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> response = backupDRClient.ListBackupPlanAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupPlanAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupPlanAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlanAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlanAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlanAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupPlanAssociationsAsync</summary>
        public async Task ListBackupPlanAssociationsResourceNamesAsync()
        {
            // Snippet: ListBackupPlanAssociationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupPlanAssociationsResponse, BackupPlanAssociation> response = backupDRClient.ListBackupPlanAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((BackupPlanAssociation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupPlanAssociationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupPlanAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupPlanAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupPlanAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAssociation</summary>
        public void DeleteBackupPlanAssociationRequestObject()
        {
            // Snippet: DeleteBackupPlanAssociation(DeleteBackupPlanAssociationRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            DeleteBackupPlanAssociationRequest request = new DeleteBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupPlanAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupPlanAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAssociationAsync</summary>
        public async Task DeleteBackupPlanAssociationRequestObjectAsync()
        {
            // Snippet: DeleteBackupPlanAssociationAsync(DeleteBackupPlanAssociationRequest, CallSettings)
            // Additional: DeleteBackupPlanAssociationAsync(DeleteBackupPlanAssociationRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupPlanAssociationRequest request = new DeleteBackupPlanAssociationRequest
            {
                BackupPlanAssociationName = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupPlanAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupPlanAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAssociation</summary>
        public void DeleteBackupPlanAssociation()
        {
            // Snippet: DeleteBackupPlanAssociation(string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlanAssociations/[BACKUP_PLAN_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupPlanAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupPlanAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAssociationAsync</summary>
        public async Task DeleteBackupPlanAssociationAsync()
        {
            // Snippet: DeleteBackupPlanAssociationAsync(string, CallSettings)
            // Additional: DeleteBackupPlanAssociationAsync(string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlanAssociations/[BACKUP_PLAN_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupPlanAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupPlanAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAssociation</summary>
        public void DeleteBackupPlanAssociationResourceNames()
        {
            // Snippet: DeleteBackupPlanAssociation(BackupPlanAssociationName, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupPlanAssociationName name = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = backupDRClient.DeleteBackupPlanAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = backupDRClient.PollOnceDeleteBackupPlanAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupPlanAssociationAsync</summary>
        public async Task DeleteBackupPlanAssociationResourceNamesAsync()
        {
            // Snippet: DeleteBackupPlanAssociationAsync(BackupPlanAssociationName, CallSettings)
            // Additional: DeleteBackupPlanAssociationAsync(BackupPlanAssociationName, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanAssociationName name = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await backupDRClient.DeleteBackupPlanAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceDeleteBackupPlanAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerBackup</summary>
        public void TriggerBackupRequestObject()
        {
            // Snippet: TriggerBackup(TriggerBackupRequest, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            TriggerBackupRequest request = new TriggerBackupRequest
            {
                BackupPlanAssociationName = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]"),
                RuleId = "",
                RequestId = "",
            };
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = backupDRClient.TriggerBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = backupDRClient.PollOnceTriggerBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerBackupAsync</summary>
        public async Task TriggerBackupRequestObjectAsync()
        {
            // Snippet: TriggerBackupAsync(TriggerBackupRequest, CallSettings)
            // Additional: TriggerBackupAsync(TriggerBackupRequest, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            TriggerBackupRequest request = new TriggerBackupRequest
            {
                BackupPlanAssociationName = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]"),
                RuleId = "",
                RequestId = "",
            };
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = await backupDRClient.TriggerBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceTriggerBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerBackup</summary>
        public void TriggerBackup()
        {
            // Snippet: TriggerBackup(string, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlanAssociations/[BACKUP_PLAN_ASSOCIATION]";
            string ruleId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = backupDRClient.TriggerBackup(name, ruleId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = backupDRClient.PollOnceTriggerBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerBackupAsync</summary>
        public async Task TriggerBackupAsync()
        {
            // Snippet: TriggerBackupAsync(string, string, CallSettings)
            // Additional: TriggerBackupAsync(string, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backupPlanAssociations/[BACKUP_PLAN_ASSOCIATION]";
            string ruleId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = await backupDRClient.TriggerBackupAsync(name, ruleId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceTriggerBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerBackup</summary>
        public void TriggerBackupResourceNames()
        {
            // Snippet: TriggerBackup(BackupPlanAssociationName, string, CallSettings)
            // Create client
            BackupDRClient backupDRClient = BackupDRClient.Create();
            // Initialize request argument(s)
            BackupPlanAssociationName name = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]");
            string ruleId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = backupDRClient.TriggerBackup(name, ruleId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = backupDRClient.PollOnceTriggerBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TriggerBackupAsync</summary>
        public async Task TriggerBackupResourceNamesAsync()
        {
            // Snippet: TriggerBackupAsync(BackupPlanAssociationName, string, CallSettings)
            // Additional: TriggerBackupAsync(BackupPlanAssociationName, string, CancellationToken)
            // Create client
            BackupDRClient backupDRClient = await BackupDRClient.CreateAsync();
            // Initialize request argument(s)
            BackupPlanAssociationName name = BackupPlanAssociationName.FromProjectLocationBackupPlanAssociation("[PROJECT]", "[LOCATION]", "[BACKUP_PLAN_ASSOCIATION]");
            string ruleId = "";
            // Make the request
            Operation<BackupPlanAssociation, OperationMetadata> response = await backupDRClient.TriggerBackupAsync(name, ruleId);

            // Poll until the returned long-running operation is complete
            Operation<BackupPlanAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BackupPlanAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BackupPlanAssociation, OperationMetadata> retrievedResponse = await backupDRClient.PollOnceTriggerBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BackupPlanAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
