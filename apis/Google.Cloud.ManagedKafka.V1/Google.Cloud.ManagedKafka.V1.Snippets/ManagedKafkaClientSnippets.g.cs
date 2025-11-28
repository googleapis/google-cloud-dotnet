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
    public sealed class AllGeneratedManagedKafkaClientSnippets
    {
        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = managedKafkaClient.ListClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Cluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersRequestObjectAsync()
        {
            // Snippet: ListClustersAsync(ListClustersRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = managedKafkaClient.ListClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Cluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters()
        {
            // Snippet: ListClusters(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = managedKafkaClient.ListClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Cluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync()
        {
            // Snippet: ListClustersAsync(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = managedKafkaClient.ListClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Cluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersResourceNames()
        {
            // Snippet: ListClusters(LocationName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = managedKafkaClient.ListClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Cluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersResourceNamesAsync()
        {
            // Snippet: ListClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = managedKafkaClient.ListClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Cluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Cluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Cluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Cluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterRequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = managedKafkaClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = await managedKafkaClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = managedKafkaClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, CallSettings)
            // Additional: GetClusterAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = await managedKafkaClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterResourceNames()
        {
            // Snippet: GetCluster(ClusterName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = managedKafkaClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterResourceNamesAsync()
        {
            // Snippet: GetClusterAsync(ClusterName, CallSettings)
            // Additional: GetClusterAsync(ClusterName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = await managedKafkaClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = managedKafkaClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterRequestObjectAsync()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest, CallSettings)
            // Additional: CreateClusterAsync(CreateClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await managedKafkaClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster()
        {
            // Snippet: CreateCluster(string, Cluster, string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = managedKafkaClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync()
        {
            // Snippet: CreateClusterAsync(string, Cluster, string, CallSettings)
            // Additional: CreateClusterAsync(string, Cluster, string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await managedKafkaClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterResourceNames()
        {
            // Snippet: CreateCluster(LocationName, Cluster, string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = managedKafkaClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterResourceNamesAsync()
        {
            // Snippet: CreateClusterAsync(LocationName, Cluster, string, CallSettings)
            // Additional: CreateClusterAsync(LocationName, Cluster, string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await managedKafkaClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateClusterRequestObject()
        {
            // Snippet: UpdateCluster(UpdateClusterRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = managedKafkaClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterRequestObjectAsync()
        {
            // Snippet: UpdateClusterAsync(UpdateClusterRequest, CallSettings)
            // Additional: UpdateClusterAsync(UpdateClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await managedKafkaClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster()
        {
            // Snippet: UpdateCluster(Cluster, FieldMask, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = managedKafkaClient.UpdateCluster(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync()
        {
            // Snippet: UpdateClusterAsync(Cluster, FieldMask, CallSettings)
            // Additional: UpdateClusterAsync(Cluster, FieldMask, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = await managedKafkaClient.UpdateClusterAsync(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterRequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = managedKafkaClient.DeleteCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterRequestObjectAsync()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest, CallSettings)
            // Additional: DeleteClusterAsync(DeleteClusterRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedKafkaClient.DeleteClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster()
        {
            // Snippet: DeleteCluster(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = managedKafkaClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync()
        {
            // Snippet: DeleteClusterAsync(string, CallSettings)
            // Additional: DeleteClusterAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedKafkaClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterResourceNames()
        {
            // Snippet: DeleteCluster(ClusterName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = managedKafkaClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = managedKafkaClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterResourceNamesAsync()
        {
            // Snippet: DeleteClusterAsync(ClusterName, CallSettings)
            // Additional: DeleteClusterAsync(ClusterName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await managedKafkaClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await managedKafkaClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopicsRequestObject()
        {
            // Snippet: ListTopics(ListTopicsRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = managedKafkaClient.ListTopics(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsRequestObjectAsync()
        {
            // Snippet: ListTopicsAsync(ListTopicsRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ListTopicsRequest request = new ListTopicsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = managedKafkaClient.ListTopicsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopics()
        {
            // Snippet: ListTopics(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = managedKafkaClient.ListTopics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsAsync()
        {
            // Snippet: ListTopicsAsync(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = managedKafkaClient.ListTopicsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopics</summary>
        public void ListTopicsResourceNames()
        {
            // Snippet: ListTopics(ClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListTopicsResponse, Topic> response = managedKafkaClient.ListTopics(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Topic item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTopicsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTopicsAsync</summary>
        public async Task ListTopicsResourceNamesAsync()
        {
            // Snippet: ListTopicsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListTopicsResponse, Topic> response = managedKafkaClient.ListTopicsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Topic item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTopicsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Topic item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Topic> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Topic item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopicRequestObject()
        {
            // Snippet: GetTopic(GetTopicRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]"),
            };
            // Make the request
            Topic response = managedKafkaClient.GetTopic(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicRequestObjectAsync()
        {
            // Snippet: GetTopicAsync(GetTopicRequest, CallSettings)
            // Additional: GetTopicAsync(GetTopicRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            GetTopicRequest request = new GetTopicRequest
            {
                TopicName = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]"),
            };
            // Make the request
            Topic response = await managedKafkaClient.GetTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopic()
        {
            // Snippet: GetTopic(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/topics/[TOPIC]";
            // Make the request
            Topic response = managedKafkaClient.GetTopic(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicAsync()
        {
            // Snippet: GetTopicAsync(string, CallSettings)
            // Additional: GetTopicAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/topics/[TOPIC]";
            // Make the request
            Topic response = await managedKafkaClient.GetTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopic</summary>
        public void GetTopicResourceNames()
        {
            // Snippet: GetTopic(TopicName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]");
            // Make the request
            Topic response = managedKafkaClient.GetTopic(name);
            // End snippet
        }

        /// <summary>Snippet for GetTopicAsync</summary>
        public async Task GetTopicResourceNamesAsync()
        {
            // Snippet: GetTopicAsync(TopicName, CallSettings)
            // Additional: GetTopicAsync(TopicName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]");
            // Make the request
            Topic response = await managedKafkaClient.GetTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopicRequestObject()
        {
            // Snippet: CreateTopic(CreateTopicRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                TopicId = "",
                Topic = new Topic(),
            };
            // Make the request
            Topic response = managedKafkaClient.CreateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicRequestObjectAsync()
        {
            // Snippet: CreateTopicAsync(CreateTopicRequest, CallSettings)
            // Additional: CreateTopicAsync(CreateTopicRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            CreateTopicRequest request = new CreateTopicRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                TopicId = "",
                Topic = new Topic(),
            };
            // Make the request
            Topic response = await managedKafkaClient.CreateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopic()
        {
            // Snippet: CreateTopic(string, Topic, string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = managedKafkaClient.CreateTopic(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicAsync()
        {
            // Snippet: CreateTopicAsync(string, Topic, string, CallSettings)
            // Additional: CreateTopicAsync(string, Topic, string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = await managedKafkaClient.CreateTopicAsync(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for CreateTopic</summary>
        public void CreateTopicResourceNames()
        {
            // Snippet: CreateTopic(ClusterName, Topic, string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = managedKafkaClient.CreateTopic(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for CreateTopicAsync</summary>
        public async Task CreateTopicResourceNamesAsync()
        {
            // Snippet: CreateTopicAsync(ClusterName, Topic, string, CallSettings)
            // Additional: CreateTopicAsync(ClusterName, Topic, string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Topic topic = new Topic();
            string topicId = "";
            // Make the request
            Topic response = await managedKafkaClient.CreateTopicAsync(parent, topic, topicId);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopic</summary>
        public void UpdateTopicRequestObject()
        {
            // Snippet: UpdateTopic(UpdateTopicRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                UpdateMask = new FieldMask(),
                Topic = new Topic(),
            };
            // Make the request
            Topic response = managedKafkaClient.UpdateTopic(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopicAsync</summary>
        public async Task UpdateTopicRequestObjectAsync()
        {
            // Snippet: UpdateTopicAsync(UpdateTopicRequest, CallSettings)
            // Additional: UpdateTopicAsync(UpdateTopicRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTopicRequest request = new UpdateTopicRequest
            {
                UpdateMask = new FieldMask(),
                Topic = new Topic(),
            };
            // Make the request
            Topic response = await managedKafkaClient.UpdateTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopic</summary>
        public void UpdateTopic()
        {
            // Snippet: UpdateTopic(Topic, FieldMask, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            Topic topic = new Topic();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Topic response = managedKafkaClient.UpdateTopic(topic, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTopicAsync</summary>
        public async Task UpdateTopicAsync()
        {
            // Snippet: UpdateTopicAsync(Topic, FieldMask, CallSettings)
            // Additional: UpdateTopicAsync(Topic, FieldMask, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            Topic topic = new Topic();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Topic response = await managedKafkaClient.UpdateTopicAsync(topic, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopicRequestObject()
        {
            // Snippet: DeleteTopic(DeleteTopicRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]"),
            };
            // Make the request
            managedKafkaClient.DeleteTopic(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicRequestObjectAsync()
        {
            // Snippet: DeleteTopicAsync(DeleteTopicRequest, CallSettings)
            // Additional: DeleteTopicAsync(DeleteTopicRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTopicRequest request = new DeleteTopicRequest
            {
                TopicName = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]"),
            };
            // Make the request
            await managedKafkaClient.DeleteTopicAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopic()
        {
            // Snippet: DeleteTopic(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/topics/[TOPIC]";
            // Make the request
            managedKafkaClient.DeleteTopic(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicAsync()
        {
            // Snippet: DeleteTopicAsync(string, CallSettings)
            // Additional: DeleteTopicAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/topics/[TOPIC]";
            // Make the request
            await managedKafkaClient.DeleteTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopic</summary>
        public void DeleteTopicResourceNames()
        {
            // Snippet: DeleteTopic(TopicName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]");
            // Make the request
            managedKafkaClient.DeleteTopic(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTopicAsync</summary>
        public async Task DeleteTopicResourceNamesAsync()
        {
            // Snippet: DeleteTopicAsync(TopicName, CallSettings)
            // Additional: DeleteTopicAsync(TopicName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            TopicName name = TopicName.FromProjectLocationClusterTopic("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[TOPIC]");
            // Make the request
            await managedKafkaClient.DeleteTopicAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConsumerGroups</summary>
        public void ListConsumerGroupsRequestObject()
        {
            // Snippet: ListConsumerGroups(ListConsumerGroupsRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ListConsumerGroupsRequest request = new ListConsumerGroupsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListConsumerGroupsResponse, ConsumerGroup> response = managedKafkaClient.ListConsumerGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConsumerGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConsumerGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConsumerGroupsAsync</summary>
        public async Task ListConsumerGroupsRequestObjectAsync()
        {
            // Snippet: ListConsumerGroupsAsync(ListConsumerGroupsRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ListConsumerGroupsRequest request = new ListConsumerGroupsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConsumerGroupsResponse, ConsumerGroup> response = managedKafkaClient.ListConsumerGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConsumerGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConsumerGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConsumerGroups</summary>
        public void ListConsumerGroups()
        {
            // Snippet: ListConsumerGroups(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListConsumerGroupsResponse, ConsumerGroup> response = managedKafkaClient.ListConsumerGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConsumerGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConsumerGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConsumerGroupsAsync</summary>
        public async Task ListConsumerGroupsAsync()
        {
            // Snippet: ListConsumerGroupsAsync(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListConsumerGroupsResponse, ConsumerGroup> response = managedKafkaClient.ListConsumerGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConsumerGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConsumerGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConsumerGroups</summary>
        public void ListConsumerGroupsResourceNames()
        {
            // Snippet: ListConsumerGroups(ClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListConsumerGroupsResponse, ConsumerGroup> response = managedKafkaClient.ListConsumerGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConsumerGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConsumerGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConsumerGroupsAsync</summary>
        public async Task ListConsumerGroupsResourceNamesAsync()
        {
            // Snippet: ListConsumerGroupsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListConsumerGroupsResponse, ConsumerGroup> response = managedKafkaClient.ListConsumerGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConsumerGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConsumerGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConsumerGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConsumerGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConsumerGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConsumerGroup</summary>
        public void GetConsumerGroupRequestObject()
        {
            // Snippet: GetConsumerGroup(GetConsumerGroupRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            GetConsumerGroupRequest request = new GetConsumerGroupRequest
            {
                ConsumerGroupName = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]"),
            };
            // Make the request
            ConsumerGroup response = managedKafkaClient.GetConsumerGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerGroupAsync</summary>
        public async Task GetConsumerGroupRequestObjectAsync()
        {
            // Snippet: GetConsumerGroupAsync(GetConsumerGroupRequest, CallSettings)
            // Additional: GetConsumerGroupAsync(GetConsumerGroupRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            GetConsumerGroupRequest request = new GetConsumerGroupRequest
            {
                ConsumerGroupName = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]"),
            };
            // Make the request
            ConsumerGroup response = await managedKafkaClient.GetConsumerGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerGroup</summary>
        public void GetConsumerGroup()
        {
            // Snippet: GetConsumerGroup(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/consumerGroups/[CONSUMER_GROUP]";
            // Make the request
            ConsumerGroup response = managedKafkaClient.GetConsumerGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerGroupAsync</summary>
        public async Task GetConsumerGroupAsync()
        {
            // Snippet: GetConsumerGroupAsync(string, CallSettings)
            // Additional: GetConsumerGroupAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/consumerGroups/[CONSUMER_GROUP]";
            // Make the request
            ConsumerGroup response = await managedKafkaClient.GetConsumerGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerGroup</summary>
        public void GetConsumerGroupResourceNames()
        {
            // Snippet: GetConsumerGroup(ConsumerGroupName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ConsumerGroupName name = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]");
            // Make the request
            ConsumerGroup response = managedKafkaClient.GetConsumerGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetConsumerGroupAsync</summary>
        public async Task GetConsumerGroupResourceNamesAsync()
        {
            // Snippet: GetConsumerGroupAsync(ConsumerGroupName, CallSettings)
            // Additional: GetConsumerGroupAsync(ConsumerGroupName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ConsumerGroupName name = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]");
            // Make the request
            ConsumerGroup response = await managedKafkaClient.GetConsumerGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConsumerGroup</summary>
        public void UpdateConsumerGroupRequestObject()
        {
            // Snippet: UpdateConsumerGroup(UpdateConsumerGroupRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            UpdateConsumerGroupRequest request = new UpdateConsumerGroupRequest
            {
                UpdateMask = new FieldMask(),
                ConsumerGroup = new ConsumerGroup(),
            };
            // Make the request
            ConsumerGroup response = managedKafkaClient.UpdateConsumerGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConsumerGroupAsync</summary>
        public async Task UpdateConsumerGroupRequestObjectAsync()
        {
            // Snippet: UpdateConsumerGroupAsync(UpdateConsumerGroupRequest, CallSettings)
            // Additional: UpdateConsumerGroupAsync(UpdateConsumerGroupRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConsumerGroupRequest request = new UpdateConsumerGroupRequest
            {
                UpdateMask = new FieldMask(),
                ConsumerGroup = new ConsumerGroup(),
            };
            // Make the request
            ConsumerGroup response = await managedKafkaClient.UpdateConsumerGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConsumerGroup</summary>
        public void UpdateConsumerGroup()
        {
            // Snippet: UpdateConsumerGroup(ConsumerGroup, FieldMask, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ConsumerGroup consumerGroup = new ConsumerGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ConsumerGroup response = managedKafkaClient.UpdateConsumerGroup(consumerGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConsumerGroupAsync</summary>
        public async Task UpdateConsumerGroupAsync()
        {
            // Snippet: UpdateConsumerGroupAsync(ConsumerGroup, FieldMask, CallSettings)
            // Additional: UpdateConsumerGroupAsync(ConsumerGroup, FieldMask, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ConsumerGroup consumerGroup = new ConsumerGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ConsumerGroup response = await managedKafkaClient.UpdateConsumerGroupAsync(consumerGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerGroup</summary>
        public void DeleteConsumerGroupRequestObject()
        {
            // Snippet: DeleteConsumerGroup(DeleteConsumerGroupRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            DeleteConsumerGroupRequest request = new DeleteConsumerGroupRequest
            {
                ConsumerGroupName = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]"),
            };
            // Make the request
            managedKafkaClient.DeleteConsumerGroup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerGroupAsync</summary>
        public async Task DeleteConsumerGroupRequestObjectAsync()
        {
            // Snippet: DeleteConsumerGroupAsync(DeleteConsumerGroupRequest, CallSettings)
            // Additional: DeleteConsumerGroupAsync(DeleteConsumerGroupRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConsumerGroupRequest request = new DeleteConsumerGroupRequest
            {
                ConsumerGroupName = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]"),
            };
            // Make the request
            await managedKafkaClient.DeleteConsumerGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerGroup</summary>
        public void DeleteConsumerGroup()
        {
            // Snippet: DeleteConsumerGroup(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/consumerGroups/[CONSUMER_GROUP]";
            // Make the request
            managedKafkaClient.DeleteConsumerGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerGroupAsync</summary>
        public async Task DeleteConsumerGroupAsync()
        {
            // Snippet: DeleteConsumerGroupAsync(string, CallSettings)
            // Additional: DeleteConsumerGroupAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/consumerGroups/[CONSUMER_GROUP]";
            // Make the request
            await managedKafkaClient.DeleteConsumerGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerGroup</summary>
        public void DeleteConsumerGroupResourceNames()
        {
            // Snippet: DeleteConsumerGroup(ConsumerGroupName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ConsumerGroupName name = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]");
            // Make the request
            managedKafkaClient.DeleteConsumerGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConsumerGroupAsync</summary>
        public async Task DeleteConsumerGroupResourceNamesAsync()
        {
            // Snippet: DeleteConsumerGroupAsync(ConsumerGroupName, CallSettings)
            // Additional: DeleteConsumerGroupAsync(ConsumerGroupName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ConsumerGroupName name = ConsumerGroupName.FromProjectLocationClusterConsumerGroup("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[CONSUMER_GROUP]");
            // Make the request
            await managedKafkaClient.DeleteConsumerGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAcls</summary>
        public void ListAclsRequestObject()
        {
            // Snippet: ListAcls(ListAclsRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ListAclsRequest request = new ListAclsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListAclsResponse, Acl> response = managedKafkaClient.ListAcls(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Acl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAclsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Acl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Acl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Acl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAclsAsync</summary>
        public async Task ListAclsRequestObjectAsync()
        {
            // Snippet: ListAclsAsync(ListAclsRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ListAclsRequest request = new ListAclsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAclsResponse, Acl> response = managedKafkaClient.ListAclsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Acl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAclsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Acl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Acl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Acl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAcls</summary>
        public void ListAcls()
        {
            // Snippet: ListAcls(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListAclsResponse, Acl> response = managedKafkaClient.ListAcls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Acl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAclsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Acl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Acl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Acl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAclsAsync</summary>
        public async Task ListAclsAsync()
        {
            // Snippet: ListAclsAsync(string, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListAclsResponse, Acl> response = managedKafkaClient.ListAclsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Acl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAclsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Acl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Acl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Acl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAcls</summary>
        public void ListAclsResourceNames()
        {
            // Snippet: ListAcls(ClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListAclsResponse, Acl> response = managedKafkaClient.ListAcls(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Acl item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAclsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Acl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Acl> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Acl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAclsAsync</summary>
        public async Task ListAclsResourceNamesAsync()
        {
            // Snippet: ListAclsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListAclsResponse, Acl> response = managedKafkaClient.ListAclsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Acl item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAclsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Acl item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Acl> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Acl item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAcl</summary>
        public void GetAclRequestObject()
        {
            // Snippet: GetAcl(GetAclRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            GetAclRequest request = new GetAclRequest
            {
                AclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
            };
            // Make the request
            Acl response = managedKafkaClient.GetAcl(request);
            // End snippet
        }

        /// <summary>Snippet for GetAclAsync</summary>
        public async Task GetAclRequestObjectAsync()
        {
            // Snippet: GetAclAsync(GetAclRequest, CallSettings)
            // Additional: GetAclAsync(GetAclRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            GetAclRequest request = new GetAclRequest
            {
                AclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
            };
            // Make the request
            Acl response = await managedKafkaClient.GetAclAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAcl</summary>
        public void GetAcl()
        {
            // Snippet: GetAcl(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            // Make the request
            Acl response = managedKafkaClient.GetAcl(name);
            // End snippet
        }

        /// <summary>Snippet for GetAclAsync</summary>
        public async Task GetAclAsync()
        {
            // Snippet: GetAclAsync(string, CallSettings)
            // Additional: GetAclAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            // Make the request
            Acl response = await managedKafkaClient.GetAclAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAcl</summary>
        public void GetAclResourceNames()
        {
            // Snippet: GetAcl(AclName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            AclName name = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            // Make the request
            Acl response = managedKafkaClient.GetAcl(name);
            // End snippet
        }

        /// <summary>Snippet for GetAclAsync</summary>
        public async Task GetAclResourceNamesAsync()
        {
            // Snippet: GetAclAsync(AclName, CallSettings)
            // Additional: GetAclAsync(AclName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            AclName name = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            // Make the request
            Acl response = await managedKafkaClient.GetAclAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAcl</summary>
        public void CreateAclRequestObject()
        {
            // Snippet: CreateAcl(CreateAclRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            CreateAclRequest request = new CreateAclRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                AclId = "",
                Acl = new Acl(),
            };
            // Make the request
            Acl response = managedKafkaClient.CreateAcl(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAclAsync</summary>
        public async Task CreateAclRequestObjectAsync()
        {
            // Snippet: CreateAclAsync(CreateAclRequest, CallSettings)
            // Additional: CreateAclAsync(CreateAclRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            CreateAclRequest request = new CreateAclRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                AclId = "",
                Acl = new Acl(),
            };
            // Make the request
            Acl response = await managedKafkaClient.CreateAclAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAcl</summary>
        public void CreateAcl()
        {
            // Snippet: CreateAcl(string, Acl, string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Acl acl = new Acl();
            string aclId = "";
            // Make the request
            Acl response = managedKafkaClient.CreateAcl(parent, acl, aclId);
            // End snippet
        }

        /// <summary>Snippet for CreateAclAsync</summary>
        public async Task CreateAclAsync()
        {
            // Snippet: CreateAclAsync(string, Acl, string, CallSettings)
            // Additional: CreateAclAsync(string, Acl, string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Acl acl = new Acl();
            string aclId = "";
            // Make the request
            Acl response = await managedKafkaClient.CreateAclAsync(parent, acl, aclId);
            // End snippet
        }

        /// <summary>Snippet for CreateAcl</summary>
        public void CreateAclResourceNames()
        {
            // Snippet: CreateAcl(ClusterName, Acl, string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Acl acl = new Acl();
            string aclId = "";
            // Make the request
            Acl response = managedKafkaClient.CreateAcl(parent, acl, aclId);
            // End snippet
        }

        /// <summary>Snippet for CreateAclAsync</summary>
        public async Task CreateAclResourceNamesAsync()
        {
            // Snippet: CreateAclAsync(ClusterName, Acl, string, CallSettings)
            // Additional: CreateAclAsync(ClusterName, Acl, string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Acl acl = new Acl();
            string aclId = "";
            // Make the request
            Acl response = await managedKafkaClient.CreateAclAsync(parent, acl, aclId);
            // End snippet
        }

        /// <summary>Snippet for UpdateAcl</summary>
        public void UpdateAclRequestObject()
        {
            // Snippet: UpdateAcl(UpdateAclRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            UpdateAclRequest request = new UpdateAclRequest
            {
                Acl = new Acl(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Acl response = managedKafkaClient.UpdateAcl(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAclAsync</summary>
        public async Task UpdateAclRequestObjectAsync()
        {
            // Snippet: UpdateAclAsync(UpdateAclRequest, CallSettings)
            // Additional: UpdateAclAsync(UpdateAclRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAclRequest request = new UpdateAclRequest
            {
                Acl = new Acl(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Acl response = await managedKafkaClient.UpdateAclAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAcl</summary>
        public void UpdateAcl()
        {
            // Snippet: UpdateAcl(Acl, FieldMask, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            Acl acl = new Acl();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Acl response = managedKafkaClient.UpdateAcl(acl, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAclAsync</summary>
        public async Task UpdateAclAsync()
        {
            // Snippet: UpdateAclAsync(Acl, FieldMask, CallSettings)
            // Additional: UpdateAclAsync(Acl, FieldMask, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            Acl acl = new Acl();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Acl response = await managedKafkaClient.UpdateAclAsync(acl, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAcl</summary>
        public void DeleteAclRequestObject()
        {
            // Snippet: DeleteAcl(DeleteAclRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            DeleteAclRequest request = new DeleteAclRequest
            {
                AclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
            };
            // Make the request
            managedKafkaClient.DeleteAcl(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAclAsync</summary>
        public async Task DeleteAclRequestObjectAsync()
        {
            // Snippet: DeleteAclAsync(DeleteAclRequest, CallSettings)
            // Additional: DeleteAclAsync(DeleteAclRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAclRequest request = new DeleteAclRequest
            {
                AclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
            };
            // Make the request
            await managedKafkaClient.DeleteAclAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAcl</summary>
        public void DeleteAcl()
        {
            // Snippet: DeleteAcl(string, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            // Make the request
            managedKafkaClient.DeleteAcl(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAclAsync</summary>
        public async Task DeleteAclAsync()
        {
            // Snippet: DeleteAclAsync(string, CallSettings)
            // Additional: DeleteAclAsync(string, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            // Make the request
            await managedKafkaClient.DeleteAclAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAcl</summary>
        public void DeleteAclResourceNames()
        {
            // Snippet: DeleteAcl(AclName, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            AclName name = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            // Make the request
            managedKafkaClient.DeleteAcl(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAclAsync</summary>
        public async Task DeleteAclResourceNamesAsync()
        {
            // Snippet: DeleteAclAsync(AclName, CallSettings)
            // Additional: DeleteAclAsync(AclName, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            AclName name = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            // Make the request
            await managedKafkaClient.DeleteAclAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AddAclEntry</summary>
        public void AddAclEntryRequestObject()
        {
            // Snippet: AddAclEntry(AddAclEntryRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            AddAclEntryRequest request = new AddAclEntryRequest
            {
                AclAsAclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
                AclEntry = new AclEntry(),
            };
            // Make the request
            AddAclEntryResponse response = managedKafkaClient.AddAclEntry(request);
            // End snippet
        }

        /// <summary>Snippet for AddAclEntryAsync</summary>
        public async Task AddAclEntryRequestObjectAsync()
        {
            // Snippet: AddAclEntryAsync(AddAclEntryRequest, CallSettings)
            // Additional: AddAclEntryAsync(AddAclEntryRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            AddAclEntryRequest request = new AddAclEntryRequest
            {
                AclAsAclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
                AclEntry = new AclEntry(),
            };
            // Make the request
            AddAclEntryResponse response = await managedKafkaClient.AddAclEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddAclEntry</summary>
        public void AddAclEntry()
        {
            // Snippet: AddAclEntry(string, AclEntry, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string acl = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            AclEntry aclEntry = new AclEntry();
            // Make the request
            AddAclEntryResponse response = managedKafkaClient.AddAclEntry(acl, aclEntry);
            // End snippet
        }

        /// <summary>Snippet for AddAclEntryAsync</summary>
        public async Task AddAclEntryAsync()
        {
            // Snippet: AddAclEntryAsync(string, AclEntry, CallSettings)
            // Additional: AddAclEntryAsync(string, AclEntry, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string acl = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            AclEntry aclEntry = new AclEntry();
            // Make the request
            AddAclEntryResponse response = await managedKafkaClient.AddAclEntryAsync(acl, aclEntry);
            // End snippet
        }

        /// <summary>Snippet for AddAclEntry</summary>
        public void AddAclEntryResourceNames()
        {
            // Snippet: AddAclEntry(AclName, AclEntry, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            AclName acl = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            AclEntry aclEntry = new AclEntry();
            // Make the request
            AddAclEntryResponse response = managedKafkaClient.AddAclEntry(acl, aclEntry);
            // End snippet
        }

        /// <summary>Snippet for AddAclEntryAsync</summary>
        public async Task AddAclEntryResourceNamesAsync()
        {
            // Snippet: AddAclEntryAsync(AclName, AclEntry, CallSettings)
            // Additional: AddAclEntryAsync(AclName, AclEntry, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            AclName acl = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            AclEntry aclEntry = new AclEntry();
            // Make the request
            AddAclEntryResponse response = await managedKafkaClient.AddAclEntryAsync(acl, aclEntry);
            // End snippet
        }

        /// <summary>Snippet for RemoveAclEntry</summary>
        public void RemoveAclEntryRequestObject()
        {
            // Snippet: RemoveAclEntry(RemoveAclEntryRequest, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            RemoveAclEntryRequest request = new RemoveAclEntryRequest
            {
                AclAsAclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
                AclEntry = new AclEntry(),
            };
            // Make the request
            RemoveAclEntryResponse response = managedKafkaClient.RemoveAclEntry(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveAclEntryAsync</summary>
        public async Task RemoveAclEntryRequestObjectAsync()
        {
            // Snippet: RemoveAclEntryAsync(RemoveAclEntryRequest, CallSettings)
            // Additional: RemoveAclEntryAsync(RemoveAclEntryRequest, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAclEntryRequest request = new RemoveAclEntryRequest
            {
                AclAsAclName = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]"),
                AclEntry = new AclEntry(),
            };
            // Make the request
            RemoveAclEntryResponse response = await managedKafkaClient.RemoveAclEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveAclEntry</summary>
        public void RemoveAclEntry()
        {
            // Snippet: RemoveAclEntry(string, AclEntry, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            string acl = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            AclEntry aclEntry = new AclEntry();
            // Make the request
            RemoveAclEntryResponse response = managedKafkaClient.RemoveAclEntry(acl, aclEntry);
            // End snippet
        }

        /// <summary>Snippet for RemoveAclEntryAsync</summary>
        public async Task RemoveAclEntryAsync()
        {
            // Snippet: RemoveAclEntryAsync(string, AclEntry, CallSettings)
            // Additional: RemoveAclEntryAsync(string, AclEntry, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            string acl = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/acls/[ACL]";
            AclEntry aclEntry = new AclEntry();
            // Make the request
            RemoveAclEntryResponse response = await managedKafkaClient.RemoveAclEntryAsync(acl, aclEntry);
            // End snippet
        }

        /// <summary>Snippet for RemoveAclEntry</summary>
        public void RemoveAclEntryResourceNames()
        {
            // Snippet: RemoveAclEntry(AclName, AclEntry, CallSettings)
            // Create client
            ManagedKafkaClient managedKafkaClient = ManagedKafkaClient.Create();
            // Initialize request argument(s)
            AclName acl = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            AclEntry aclEntry = new AclEntry();
            // Make the request
            RemoveAclEntryResponse response = managedKafkaClient.RemoveAclEntry(acl, aclEntry);
            // End snippet
        }

        /// <summary>Snippet for RemoveAclEntryAsync</summary>
        public async Task RemoveAclEntryResourceNamesAsync()
        {
            // Snippet: RemoveAclEntryAsync(AclName, AclEntry, CallSettings)
            // Additional: RemoveAclEntryAsync(AclName, AclEntry, CancellationToken)
            // Create client
            ManagedKafkaClient managedKafkaClient = await ManagedKafkaClient.CreateAsync();
            // Initialize request argument(s)
            AclName acl = AclName.FromProjectLocationClusterAcl("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[ACL]");
            AclEntry aclEntry = new AclEntry();
            // Make the request
            RemoveAclEntryResponse response = await managedKafkaClient.RemoveAclEntryAsync(acl, aclEntry);
            // End snippet
        }
    }
}
