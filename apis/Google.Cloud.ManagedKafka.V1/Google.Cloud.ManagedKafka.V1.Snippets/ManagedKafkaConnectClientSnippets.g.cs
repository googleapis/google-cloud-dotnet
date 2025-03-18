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
    using Google.Cloud.ManagedKafka.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedManagedKafkaConnectClientSnippets
    {
        /// <summary>Snippet for ListConnectClusters</summary>
        public void ListConnectClustersRequestObject()
        {
            // Snippet: ListConnectClusters(ListConnectClustersRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ListConnectClustersRequest request = new ListConnectClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListConnectClustersResponse, ConnectCluster> response = managedKafkaConnectClient.ListConnectClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectClustersAsync</summary>
        public async Task ListConnectClustersRequestObjectAsync()
        {
            // Snippet: ListConnectClustersAsync(ListConnectClustersRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectClustersRequest request = new ListConnectClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectClustersResponse, ConnectCluster> response = managedKafkaConnectClient.ListConnectClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectClusters</summary>
        public void ListConnectClusters()
        {
            // Snippet: ListConnectClusters(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConnectClustersResponse, ConnectCluster> response = managedKafkaConnectClient.ListConnectClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectClustersAsync</summary>
        public async Task ListConnectClustersAsync()
        {
            // Snippet: ListConnectClustersAsync(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConnectClustersResponse, ConnectCluster> response = managedKafkaConnectClient.ListConnectClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectClusters</summary>
        public void ListConnectClustersResourceNames()
        {
            // Snippet: ListConnectClusters(LocationName, string, int?, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConnectClustersResponse, ConnectCluster> response = managedKafkaConnectClient.ListConnectClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConnectCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConnectClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConnectClustersAsync</summary>
        public async Task ListConnectClustersResourceNamesAsync()
        {
            // Snippet: ListConnectClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConnectClustersResponse, ConnectCluster> response = managedKafkaConnectClient.ListConnectClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConnectCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConnectClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConnectCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConnectCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConnectCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConnectCluster</summary>
        public void GetConnectClusterRequestObject()
        {
            // Snippet: GetConnectCluster(GetConnectClusterRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            GetConnectClusterRequest request = new GetConnectClusterRequest
            {
                ConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
            };
            // Make the request
            ConnectCluster response = managedKafkaConnectClient.GetConnectCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectClusterAsync</summary>
        public async Task GetConnectClusterRequestObjectAsync()
        {
            // Snippet: GetConnectClusterAsync(GetConnectClusterRequest, CallSettings)
            // Additional: GetConnectClusterAsync(GetConnectClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectClusterRequest request = new GetConnectClusterRequest
            {
                ConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
            };
            // Make the request
            ConnectCluster response = await managedKafkaConnectClient.GetConnectClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectCluster</summary>
        public void GetConnectCluster()
        {
            // Snippet: GetConnectCluster(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            // Make the request
            ConnectCluster response = managedKafkaConnectClient.GetConnectCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectClusterAsync</summary>
        public async Task GetConnectClusterAsync()
        {
            // Snippet: GetConnectClusterAsync(string, CallSettings)
            // Additional: GetConnectClusterAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            // Make the request
            ConnectCluster response = await managedKafkaConnectClient.GetConnectClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectCluster</summary>
        public void GetConnectClusterResourceNames()
        {
            // Snippet: GetConnectCluster(ConnectClusterName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectClusterName name = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            // Make the request
            ConnectCluster response = managedKafkaConnectClient.GetConnectCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectClusterAsync</summary>
        public async Task GetConnectClusterResourceNamesAsync()
        {
            // Snippet: GetConnectClusterAsync(ConnectClusterName, CallSettings)
            // Additional: GetConnectClusterAsync(ConnectClusterName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectClusterName name = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            // Make the request
            ConnectCluster response = await managedKafkaConnectClient.GetConnectClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectCluster</summary>
        public void CreateConnectClusterRequestObject()
        {
            // Snippet: CreateConnectCluster(CreateConnectClusterRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            CreateConnectClusterRequest request = new CreateConnectClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectClusterId = "",
                ConnectCluster = new ConnectCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = managedKafkaConnectClient.CreateConnectCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceCreateConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectClusterAsync</summary>
        public async Task CreateConnectClusterRequestObjectAsync()
        {
            // Snippet: CreateConnectClusterAsync(CreateConnectClusterRequest, CallSettings)
            // Additional: CreateConnectClusterAsync(CreateConnectClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectClusterRequest request = new CreateConnectClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ConnectClusterId = "",
                ConnectCluster = new ConnectCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = await managedKafkaConnectClient.CreateConnectClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceCreateConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectCluster</summary>
        public void CreateConnectCluster()
        {
            // Snippet: CreateConnectCluster(string, ConnectCluster, string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConnectCluster connectCluster = new ConnectCluster();
            string connectClusterId = "";
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = managedKafkaConnectClient.CreateConnectCluster(parent, connectCluster, connectClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceCreateConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectClusterAsync</summary>
        public async Task CreateConnectClusterAsync()
        {
            // Snippet: CreateConnectClusterAsync(string, ConnectCluster, string, CallSettings)
            // Additional: CreateConnectClusterAsync(string, ConnectCluster, string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ConnectCluster connectCluster = new ConnectCluster();
            string connectClusterId = "";
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = await managedKafkaConnectClient.CreateConnectClusterAsync(parent, connectCluster, connectClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceCreateConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectCluster</summary>
        public void CreateConnectClusterResourceNames()
        {
            // Snippet: CreateConnectCluster(LocationName, ConnectCluster, string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConnectCluster connectCluster = new ConnectCluster();
            string connectClusterId = "";
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = managedKafkaConnectClient.CreateConnectCluster(parent, connectCluster, connectClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceCreateConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConnectClusterAsync</summary>
        public async Task CreateConnectClusterResourceNamesAsync()
        {
            // Snippet: CreateConnectClusterAsync(LocationName, ConnectCluster, string, CallSettings)
            // Additional: CreateConnectClusterAsync(LocationName, ConnectCluster, string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConnectCluster connectCluster = new ConnectCluster();
            string connectClusterId = "";
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = await managedKafkaConnectClient.CreateConnectClusterAsync(parent, connectCluster, connectClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceCreateConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectCluster</summary>
        public void UpdateConnectClusterRequestObject()
        {
            // Snippet: UpdateConnectCluster(UpdateConnectClusterRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            UpdateConnectClusterRequest request = new UpdateConnectClusterRequest
            {
                UpdateMask = new FieldMask(),
                ConnectCluster = new ConnectCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = managedKafkaConnectClient.UpdateConnectCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceUpdateConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectClusterAsync</summary>
        public async Task UpdateConnectClusterRequestObjectAsync()
        {
            // Snippet: UpdateConnectClusterAsync(UpdateConnectClusterRequest, CallSettings)
            // Additional: UpdateConnectClusterAsync(UpdateConnectClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectClusterRequest request = new UpdateConnectClusterRequest
            {
                UpdateMask = new FieldMask(),
                ConnectCluster = new ConnectCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = await managedKafkaConnectClient.UpdateConnectClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceUpdateConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectCluster</summary>
        public void UpdateConnectCluster()
        {
            // Snippet: UpdateConnectCluster(ConnectCluster, FieldMask, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectCluster connectCluster = new ConnectCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = managedKafkaConnectClient.UpdateConnectCluster(connectCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceUpdateConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectClusterAsync</summary>
        public async Task UpdateConnectClusterAsync()
        {
            // Snippet: UpdateConnectClusterAsync(ConnectCluster, FieldMask, CallSettings)
            // Additional: UpdateConnectClusterAsync(ConnectCluster, FieldMask, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectCluster connectCluster = new ConnectCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ConnectCluster, OperationMetadata> response = await managedKafkaConnectClient.UpdateConnectClusterAsync(connectCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ConnectCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConnectCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConnectCluster, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceUpdateConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConnectCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectCluster</summary>
        public void DeleteConnectClusterRequestObject()
        {
            // Snippet: DeleteConnectCluster(DeleteConnectClusterRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            DeleteConnectClusterRequest request = new DeleteConnectClusterRequest
            {
                ConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = managedKafkaConnectClient.DeleteConnectCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceDeleteConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectClusterAsync</summary>
        public async Task DeleteConnectClusterRequestObjectAsync()
        {
            // Snippet: DeleteConnectClusterAsync(DeleteConnectClusterRequest, CallSettings)
            // Additional: DeleteConnectClusterAsync(DeleteConnectClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectClusterRequest request = new DeleteConnectClusterRequest
            {
                ConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedKafkaConnectClient.DeleteConnectClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceDeleteConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectCluster</summary>
        public void DeleteConnectCluster()
        {
            // Snippet: DeleteConnectCluster(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = managedKafkaConnectClient.DeleteConnectCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceDeleteConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectClusterAsync</summary>
        public async Task DeleteConnectClusterAsync()
        {
            // Snippet: DeleteConnectClusterAsync(string, CallSettings)
            // Additional: DeleteConnectClusterAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedKafkaConnectClient.DeleteConnectClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceDeleteConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectCluster</summary>
        public void DeleteConnectClusterResourceNames()
        {
            // Snippet: DeleteConnectCluster(ConnectClusterName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectClusterName name = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = managedKafkaConnectClient.DeleteConnectCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedKafkaConnectClient.PollOnceDeleteConnectCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectClusterAsync</summary>
        public async Task DeleteConnectClusterResourceNamesAsync()
        {
            // Snippet: DeleteConnectClusterAsync(ConnectClusterName, CallSettings)
            // Additional: DeleteConnectClusterAsync(ConnectClusterName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectClusterName name = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedKafkaConnectClient.DeleteConnectClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedKafkaConnectClient.PollOnceDeleteConnectClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListConnectors</summary>
        public void ListConnectorsRequestObject()
        {
            // Snippet: ListConnectors(ListConnectorsRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = managedKafkaConnectClient.ListConnectors(request);

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
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = managedKafkaConnectClient.ListConnectorsAsync(request);

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
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = managedKafkaConnectClient.ListConnectors(parent);

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
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = managedKafkaConnectClient.ListConnectorsAsync(parent);

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
            // Snippet: ListConnectors(ConnectClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectClusterName parent = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            // Make the request
            PagedEnumerable<ListConnectorsResponse, Connector> response = managedKafkaConnectClient.ListConnectors(parent);

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
            // Snippet: ListConnectorsAsync(ConnectClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectClusterName parent = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListConnectorsResponse, Connector> response = managedKafkaConnectClient.ListConnectorsAsync(parent);

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
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            Connector response = managedKafkaConnectClient.GetConnector(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorRequestObjectAsync()
        {
            // Snippet: GetConnectorAsync(GetConnectorRequest, CallSettings)
            // Additional: GetConnectorAsync(GetConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectorRequest request = new GetConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            Connector response = await managedKafkaConnectClient.GetConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnector()
        {
            // Snippet: GetConnector(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            Connector response = managedKafkaConnectClient.GetConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorAsync()
        {
            // Snippet: GetConnectorAsync(string, CallSettings)
            // Additional: GetConnectorAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            Connector response = await managedKafkaConnectClient.GetConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnector</summary>
        public void GetConnectorResourceNames()
        {
            // Snippet: GetConnector(ConnectorName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            Connector response = managedKafkaConnectClient.GetConnector(name);
            // End snippet
        }

        /// <summary>Snippet for GetConnectorAsync</summary>
        public async Task GetConnectorResourceNamesAsync()
        {
            // Snippet: GetConnectorAsync(ConnectorName, CallSettings)
            // Additional: GetConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            Connector response = await managedKafkaConnectClient.GetConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConnector</summary>
        public void CreateConnectorRequestObject()
        {
            // Snippet: CreateConnector(CreateConnectorRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            CreateConnectorRequest request = new CreateConnectorRequest
            {
                ParentAsConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
                ConnectorId = "",
                Connector = new Connector(),
            };
            // Make the request
            Connector response = managedKafkaConnectClient.CreateConnector(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectorAsync</summary>
        public async Task CreateConnectorRequestObjectAsync()
        {
            // Snippet: CreateConnectorAsync(CreateConnectorRequest, CallSettings)
            // Additional: CreateConnectorAsync(CreateConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            CreateConnectorRequest request = new CreateConnectorRequest
            {
                ParentAsConnectClusterName = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]"),
                ConnectorId = "",
                Connector = new Connector(),
            };
            // Make the request
            Connector response = await managedKafkaConnectClient.CreateConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConnector</summary>
        public void CreateConnector()
        {
            // Snippet: CreateConnector(string, Connector, string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            Connector connector = new Connector();
            string connectorId = "";
            // Make the request
            Connector response = managedKafkaConnectClient.CreateConnector(parent, connector, connectorId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectorAsync</summary>
        public async Task CreateConnectorAsync()
        {
            // Snippet: CreateConnectorAsync(string, Connector, string, CallSettings)
            // Additional: CreateConnectorAsync(string, Connector, string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]";
            Connector connector = new Connector();
            string connectorId = "";
            // Make the request
            Connector response = await managedKafkaConnectClient.CreateConnectorAsync(parent, connector, connectorId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnector</summary>
        public void CreateConnectorResourceNames()
        {
            // Snippet: CreateConnector(ConnectClusterName, Connector, string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectClusterName parent = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            Connector connector = new Connector();
            string connectorId = "";
            // Make the request
            Connector response = managedKafkaConnectClient.CreateConnector(parent, connector, connectorId);
            // End snippet
        }

        /// <summary>Snippet for CreateConnectorAsync</summary>
        public async Task CreateConnectorResourceNamesAsync()
        {
            // Snippet: CreateConnectorAsync(ConnectClusterName, Connector, string, CallSettings)
            // Additional: CreateConnectorAsync(ConnectClusterName, Connector, string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectClusterName parent = ConnectClusterName.FromProjectLocationConnectCluster("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]");
            Connector connector = new Connector();
            string connectorId = "";
            // Make the request
            Connector response = await managedKafkaConnectClient.CreateConnectorAsync(parent, connector, connectorId);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnector</summary>
        public void UpdateConnectorRequestObject()
        {
            // Snippet: UpdateConnector(UpdateConnectorRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            UpdateConnectorRequest request = new UpdateConnectorRequest
            {
                UpdateMask = new FieldMask(),
                Connector = new Connector(),
            };
            // Make the request
            Connector response = managedKafkaConnectClient.UpdateConnector(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectorAsync</summary>
        public async Task UpdateConnectorRequestObjectAsync()
        {
            // Snippet: UpdateConnectorAsync(UpdateConnectorRequest, CallSettings)
            // Additional: UpdateConnectorAsync(UpdateConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConnectorRequest request = new UpdateConnectorRequest
            {
                UpdateMask = new FieldMask(),
                Connector = new Connector(),
            };
            // Make the request
            Connector response = await managedKafkaConnectClient.UpdateConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnector</summary>
        public void UpdateConnector()
        {
            // Snippet: UpdateConnector(Connector, FieldMask, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            Connector connector = new Connector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connector response = managedKafkaConnectClient.UpdateConnector(connector, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConnectorAsync</summary>
        public async Task UpdateConnectorAsync()
        {
            // Snippet: UpdateConnectorAsync(Connector, FieldMask, CallSettings)
            // Additional: UpdateConnectorAsync(Connector, FieldMask, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            Connector connector = new Connector();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Connector response = await managedKafkaConnectClient.UpdateConnectorAsync(connector, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnector</summary>
        public void DeleteConnectorRequestObject()
        {
            // Snippet: DeleteConnector(DeleteConnectorRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            DeleteConnectorRequest request = new DeleteConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            managedKafkaConnectClient.DeleteConnector(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectorAsync</summary>
        public async Task DeleteConnectorRequestObjectAsync()
        {
            // Snippet: DeleteConnectorAsync(DeleteConnectorRequest, CallSettings)
            // Additional: DeleteConnectorAsync(DeleteConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConnectorRequest request = new DeleteConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            await managedKafkaConnectClient.DeleteConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnector</summary>
        public void DeleteConnector()
        {
            // Snippet: DeleteConnector(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            managedKafkaConnectClient.DeleteConnector(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectorAsync</summary>
        public async Task DeleteConnectorAsync()
        {
            // Snippet: DeleteConnectorAsync(string, CallSettings)
            // Additional: DeleteConnectorAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            await managedKafkaConnectClient.DeleteConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnector</summary>
        public void DeleteConnectorResourceNames()
        {
            // Snippet: DeleteConnector(ConnectorName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            managedKafkaConnectClient.DeleteConnector(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConnectorAsync</summary>
        public async Task DeleteConnectorResourceNamesAsync()
        {
            // Snippet: DeleteConnectorAsync(ConnectorName, CallSettings)
            // Additional: DeleteConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            await managedKafkaConnectClient.DeleteConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseConnector</summary>
        public void PauseConnectorRequestObject()
        {
            // Snippet: PauseConnector(PauseConnectorRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            PauseConnectorRequest request = new PauseConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            PauseConnectorResponse response = managedKafkaConnectClient.PauseConnector(request);
            // End snippet
        }

        /// <summary>Snippet for PauseConnectorAsync</summary>
        public async Task PauseConnectorRequestObjectAsync()
        {
            // Snippet: PauseConnectorAsync(PauseConnectorRequest, CallSettings)
            // Additional: PauseConnectorAsync(PauseConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            PauseConnectorRequest request = new PauseConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            PauseConnectorResponse response = await managedKafkaConnectClient.PauseConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PauseConnector</summary>
        public void PauseConnector()
        {
            // Snippet: PauseConnector(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            PauseConnectorResponse response = managedKafkaConnectClient.PauseConnector(name);
            // End snippet
        }

        /// <summary>Snippet for PauseConnectorAsync</summary>
        public async Task PauseConnectorAsync()
        {
            // Snippet: PauseConnectorAsync(string, CallSettings)
            // Additional: PauseConnectorAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            PauseConnectorResponse response = await managedKafkaConnectClient.PauseConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for PauseConnector</summary>
        public void PauseConnectorResourceNames()
        {
            // Snippet: PauseConnector(ConnectorName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            PauseConnectorResponse response = managedKafkaConnectClient.PauseConnector(name);
            // End snippet
        }

        /// <summary>Snippet for PauseConnectorAsync</summary>
        public async Task PauseConnectorResourceNamesAsync()
        {
            // Snippet: PauseConnectorAsync(ConnectorName, CallSettings)
            // Additional: PauseConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            PauseConnectorResponse response = await managedKafkaConnectClient.PauseConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeConnector</summary>
        public void ResumeConnectorRequestObject()
        {
            // Snippet: ResumeConnector(ResumeConnectorRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ResumeConnectorRequest request = new ResumeConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            ResumeConnectorResponse response = managedKafkaConnectClient.ResumeConnector(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeConnectorAsync</summary>
        public async Task ResumeConnectorRequestObjectAsync()
        {
            // Snippet: ResumeConnectorAsync(ResumeConnectorRequest, CallSettings)
            // Additional: ResumeConnectorAsync(ResumeConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ResumeConnectorRequest request = new ResumeConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            ResumeConnectorResponse response = await managedKafkaConnectClient.ResumeConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResumeConnector</summary>
        public void ResumeConnector()
        {
            // Snippet: ResumeConnector(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            ResumeConnectorResponse response = managedKafkaConnectClient.ResumeConnector(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeConnectorAsync</summary>
        public async Task ResumeConnectorAsync()
        {
            // Snippet: ResumeConnectorAsync(string, CallSettings)
            // Additional: ResumeConnectorAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            ResumeConnectorResponse response = await managedKafkaConnectClient.ResumeConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeConnector</summary>
        public void ResumeConnectorResourceNames()
        {
            // Snippet: ResumeConnector(ConnectorName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            ResumeConnectorResponse response = managedKafkaConnectClient.ResumeConnector(name);
            // End snippet
        }

        /// <summary>Snippet for ResumeConnectorAsync</summary>
        public async Task ResumeConnectorResourceNamesAsync()
        {
            // Snippet: ResumeConnectorAsync(ConnectorName, CallSettings)
            // Additional: ResumeConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            ResumeConnectorResponse response = await managedKafkaConnectClient.ResumeConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestartConnector</summary>
        public void RestartConnectorRequestObject()
        {
            // Snippet: RestartConnector(RestartConnectorRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            RestartConnectorRequest request = new RestartConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            RestartConnectorResponse response = managedKafkaConnectClient.RestartConnector(request);
            // End snippet
        }

        /// <summary>Snippet for RestartConnectorAsync</summary>
        public async Task RestartConnectorRequestObjectAsync()
        {
            // Snippet: RestartConnectorAsync(RestartConnectorRequest, CallSettings)
            // Additional: RestartConnectorAsync(RestartConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            RestartConnectorRequest request = new RestartConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            RestartConnectorResponse response = await managedKafkaConnectClient.RestartConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestartConnector</summary>
        public void RestartConnector()
        {
            // Snippet: RestartConnector(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            RestartConnectorResponse response = managedKafkaConnectClient.RestartConnector(name);
            // End snippet
        }

        /// <summary>Snippet for RestartConnectorAsync</summary>
        public async Task RestartConnectorAsync()
        {
            // Snippet: RestartConnectorAsync(string, CallSettings)
            // Additional: RestartConnectorAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            RestartConnectorResponse response = await managedKafkaConnectClient.RestartConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RestartConnector</summary>
        public void RestartConnectorResourceNames()
        {
            // Snippet: RestartConnector(ConnectorName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            RestartConnectorResponse response = managedKafkaConnectClient.RestartConnector(name);
            // End snippet
        }

        /// <summary>Snippet for RestartConnectorAsync</summary>
        public async Task RestartConnectorResourceNamesAsync()
        {
            // Snippet: RestartConnectorAsync(ConnectorName, CallSettings)
            // Additional: RestartConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            RestartConnectorResponse response = await managedKafkaConnectClient.RestartConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StopConnector</summary>
        public void StopConnectorRequestObject()
        {
            // Snippet: StopConnector(StopConnectorRequest, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            StopConnectorRequest request = new StopConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            StopConnectorResponse response = managedKafkaConnectClient.StopConnector(request);
            // End snippet
        }

        /// <summary>Snippet for StopConnectorAsync</summary>
        public async Task StopConnectorRequestObjectAsync()
        {
            // Snippet: StopConnectorAsync(StopConnectorRequest, CallSettings)
            // Additional: StopConnectorAsync(StopConnectorRequest, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            StopConnectorRequest request = new StopConnectorRequest
            {
                ConnectorName = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]"),
            };
            // Make the request
            StopConnectorResponse response = await managedKafkaConnectClient.StopConnectorAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StopConnector</summary>
        public void StopConnector()
        {
            // Snippet: StopConnector(string, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            StopConnectorResponse response = managedKafkaConnectClient.StopConnector(name);
            // End snippet
        }

        /// <summary>Snippet for StopConnectorAsync</summary>
        public async Task StopConnectorAsync()
        {
            // Snippet: StopConnectorAsync(string, CallSettings)
            // Additional: StopConnectorAsync(string, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/connectClusters/[CONNECT_CLUSTER]/connectors/[CONNECTOR]";
            // Make the request
            StopConnectorResponse response = await managedKafkaConnectClient.StopConnectorAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StopConnector</summary>
        public void StopConnectorResourceNames()
        {
            // Snippet: StopConnector(ConnectorName, CallSettings)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = ManagedKafkaConnectClient.Create();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            StopConnectorResponse response = managedKafkaConnectClient.StopConnector(name);
            // End snippet
        }

        /// <summary>Snippet for StopConnectorAsync</summary>
        public async Task StopConnectorResourceNamesAsync()
        {
            // Snippet: StopConnectorAsync(ConnectorName, CallSettings)
            // Additional: StopConnectorAsync(ConnectorName, CancellationToken)
            // Create client
            ManagedKafkaConnectClient managedKafkaConnectClient = await ManagedKafkaConnectClient.CreateAsync();
            // Initialize request argument(s)
            ConnectorName name = ConnectorName.FromProjectLocationConnectClusterConnector("[PROJECT]", "[LOCATION]", "[CONNECT_CLUSTER]", "[CONNECTOR]");
            // Make the request
            StopConnectorResponse response = await managedKafkaConnectClient.StopConnectorAsync(name);
            // End snippet
        }
    }
}
