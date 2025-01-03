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
    using Google.Cloud.Redis.Cluster.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudRedisClusterClientSnippets
    {
        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = cloudRedisClusterClient.ListClusters(request);

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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = cloudRedisClusterClient.ListClustersAsync(request);

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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = cloudRedisClusterClient.ListClusters(parent);

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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = cloudRedisClusterClient.ListClustersAsync(parent);

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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = cloudRedisClusterClient.ListClusters(parent);

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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = cloudRedisClusterClient.ListClustersAsync(parent);

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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = cloudRedisClusterClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = await cloudRedisClusterClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = cloudRedisClusterClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, CallSettings)
            // Additional: GetClusterAsync(string, CancellationToken)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = await cloudRedisClusterClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterResourceNames()
        {
            // Snippet: GetCluster(ClusterName, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = cloudRedisClusterClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterResourceNamesAsync()
        {
            // Snippet: GetClusterAsync(ClusterName, CallSettings)
            // Additional: GetClusterAsync(ClusterName, CancellationToken)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = await cloudRedisClusterClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateClusterRequestObject()
        {
            // Snippet: UpdateCluster(UpdateClusterRequest, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, Any> response = cloudRedisClusterClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = cloudRedisClusterClient.PollOnceUpdateCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, Any> response = await cloudRedisClusterClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceUpdateClusterAsync(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, Any> response = cloudRedisClusterClient.UpdateCluster(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = cloudRedisClusterClient.PollOnceUpdateCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, Any> response = await cloudRedisClusterClient.UpdateClusterAsync(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceUpdateClusterAsync(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, Any> response = cloudRedisClusterClient.DeleteCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse = cloudRedisClusterClient.PollOnceDeleteCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, Any> response = await cloudRedisClusterClient.DeleteClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceDeleteClusterAsync(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, Any> response = cloudRedisClusterClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse = cloudRedisClusterClient.PollOnceDeleteCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, Any> response = await cloudRedisClusterClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceDeleteClusterAsync(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, Any> response = cloudRedisClusterClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse = cloudRedisClusterClient.PollOnceDeleteCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, Any> response = await cloudRedisClusterClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, Any> response = cloudRedisClusterClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = cloudRedisClusterClient.PollOnceCreateCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, Any> response = await cloudRedisClusterClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceCreateClusterAsync(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, Any> response = cloudRedisClusterClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = cloudRedisClusterClient.PollOnceCreateCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, Any> response = await cloudRedisClusterClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceCreateClusterAsync(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, Any> response = cloudRedisClusterClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = cloudRedisClusterClient.PollOnceCreateCluster(operationName);
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
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, Any> response = await cloudRedisClusterClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, Any> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, Any> retrievedResponse = await cloudRedisClusterClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetClusterCertificateAuthority</summary>
        public void GetClusterCertificateAuthorityRequestObject()
        {
            // Snippet: GetClusterCertificateAuthority(GetClusterCertificateAuthorityRequest, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            GetClusterCertificateAuthorityRequest request = new GetClusterCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            CertificateAuthority response = cloudRedisClusterClient.GetClusterCertificateAuthority(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterCertificateAuthorityAsync</summary>
        public async Task GetClusterCertificateAuthorityRequestObjectAsync()
        {
            // Snippet: GetClusterCertificateAuthorityAsync(GetClusterCertificateAuthorityRequest, CallSettings)
            // Additional: GetClusterCertificateAuthorityAsync(GetClusterCertificateAuthorityRequest, CancellationToken)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterCertificateAuthorityRequest request = new GetClusterCertificateAuthorityRequest
            {
                CertificateAuthorityName = CertificateAuthorityName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            CertificateAuthority response = await cloudRedisClusterClient.GetClusterCertificateAuthorityAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterCertificateAuthority</summary>
        public void GetClusterCertificateAuthority()
        {
            // Snippet: GetClusterCertificateAuthority(string, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/certificateAuthority";
            // Make the request
            CertificateAuthority response = cloudRedisClusterClient.GetClusterCertificateAuthority(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterCertificateAuthorityAsync</summary>
        public async Task GetClusterCertificateAuthorityAsync()
        {
            // Snippet: GetClusterCertificateAuthorityAsync(string, CallSettings)
            // Additional: GetClusterCertificateAuthorityAsync(string, CancellationToken)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/certificateAuthority";
            // Make the request
            CertificateAuthority response = await cloudRedisClusterClient.GetClusterCertificateAuthorityAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterCertificateAuthority</summary>
        public void GetClusterCertificateAuthorityResourceNames()
        {
            // Snippet: GetClusterCertificateAuthority(CertificateAuthorityName, CallSettings)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = CloudRedisClusterClient.Create();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            CertificateAuthority response = cloudRedisClusterClient.GetClusterCertificateAuthority(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterCertificateAuthorityAsync</summary>
        public async Task GetClusterCertificateAuthorityResourceNamesAsync()
        {
            // Snippet: GetClusterCertificateAuthorityAsync(CertificateAuthorityName, CallSettings)
            // Additional: GetClusterCertificateAuthorityAsync(CertificateAuthorityName, CancellationToken)
            // Create client
            CloudRedisClusterClient cloudRedisClusterClient = await CloudRedisClusterClient.CreateAsync();
            // Initialize request argument(s)
            CertificateAuthorityName name = CertificateAuthorityName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            CertificateAuthority response = await cloudRedisClusterClient.GetClusterCertificateAuthorityAsync(name);
            // End snippet
        }
    }
}
