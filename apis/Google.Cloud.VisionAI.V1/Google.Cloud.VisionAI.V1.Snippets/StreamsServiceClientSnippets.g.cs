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
    using Google.Cloud.VisionAI.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStreamsServiceClientSnippets
    {
        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = streamsServiceClient.ListClusters(request);

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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = streamsServiceClient.ListClustersAsync(request);

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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = streamsServiceClient.ListClusters(parent);

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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = streamsServiceClient.ListClustersAsync(parent);

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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = streamsServiceClient.ListClusters(parent);

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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = streamsServiceClient.ListClustersAsync(parent);

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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = streamsServiceClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
            };
            // Make the request
            Cluster response = await streamsServiceClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = streamsServiceClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, CallSettings)
            // Additional: GetClusterAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = await streamsServiceClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterResourceNames()
        {
            // Snippet: GetCluster(ClusterName, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = streamsServiceClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterResourceNamesAsync()
        {
            // Snippet: GetClusterAsync(ClusterName, CallSettings)
            // Additional: GetClusterAsync(ClusterName, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = await streamsServiceClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = streamsServiceClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await streamsServiceClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateClusterAsync(operationName);
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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = streamsServiceClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await streamsServiceClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateClusterAsync(operationName);
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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = streamsServiceClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await streamsServiceClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateClusterAsync(operationName);
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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = streamsServiceClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await streamsServiceClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateClusterAsync(operationName);
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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = streamsServiceClient.UpdateCluster(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = await streamsServiceClient.UpdateClusterAsync(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateClusterAsync(operationName);
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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteClusterAsync(operationName);
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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteClusterAsync(operationName);
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
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteCluster(operationName);
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
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListStreams</summary>
        public void ListStreamsRequestObject()
        {
            // Snippet: ListStreams(ListStreamsRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ListStreamsRequest request = new ListStreamsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListStreamsResponse, Stream> response = streamsServiceClient.ListStreams(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Stream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreamsAsync</summary>
        public async Task ListStreamsRequestObjectAsync()
        {
            // Snippet: ListStreamsAsync(ListStreamsRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListStreamsRequest request = new ListStreamsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListStreamsResponse, Stream> response = streamsServiceClient.ListStreamsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Stream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreams</summary>
        public void ListStreams()
        {
            // Snippet: ListStreams(string, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListStreamsResponse, Stream> response = streamsServiceClient.ListStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Stream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreamsAsync</summary>
        public async Task ListStreamsAsync()
        {
            // Snippet: ListStreamsAsync(string, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListStreamsResponse, Stream> response = streamsServiceClient.ListStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Stream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreams</summary>
        public void ListStreamsResourceNames()
        {
            // Snippet: ListStreams(ClusterName, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListStreamsResponse, Stream> response = streamsServiceClient.ListStreams(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Stream item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListStreamsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListStreamsAsync</summary>
        public async Task ListStreamsResourceNamesAsync()
        {
            // Snippet: ListStreamsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListStreamsResponse, Stream> response = streamsServiceClient.ListStreamsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Stream item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListStreamsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Stream item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Stream> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Stream item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetStream</summary>
        public void GetStreamRequestObject()
        {
            // Snippet: GetStream(GetStreamRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            // Make the request
            Stream response = streamsServiceClient.GetStream(request);
            // End snippet
        }

        /// <summary>Snippet for GetStreamAsync</summary>
        public async Task GetStreamRequestObjectAsync()
        {
            // Snippet: GetStreamAsync(GetStreamRequest, CallSettings)
            // Additional: GetStreamAsync(GetStreamRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStreamRequest request = new GetStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
            };
            // Make the request
            Stream response = await streamsServiceClient.GetStreamAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetStream</summary>
        public void GetStream()
        {
            // Snippet: GetStream(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/streams/[STREAM]";
            // Make the request
            Stream response = streamsServiceClient.GetStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetStreamAsync</summary>
        public async Task GetStreamAsync()
        {
            // Snippet: GetStreamAsync(string, CallSettings)
            // Additional: GetStreamAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/streams/[STREAM]";
            // Make the request
            Stream response = await streamsServiceClient.GetStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetStream</summary>
        public void GetStreamResourceNames()
        {
            // Snippet: GetStream(StreamName, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]");
            // Make the request
            Stream response = streamsServiceClient.GetStream(name);
            // End snippet
        }

        /// <summary>Snippet for GetStreamAsync</summary>
        public async Task GetStreamResourceNamesAsync()
        {
            // Snippet: GetStreamAsync(StreamName, CallSettings)
            // Additional: GetStreamAsync(StreamName, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]");
            // Make the request
            Stream response = await streamsServiceClient.GetStreamAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateStream</summary>
        public void CreateStreamRequestObject()
        {
            // Snippet: CreateStream(CreateStreamRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            CreateStreamRequest request = new CreateStreamRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                StreamId = "",
                Stream = new Stream(),
                RequestId = "",
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = streamsServiceClient.CreateStream(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStreamAsync</summary>
        public async Task CreateStreamRequestObjectAsync()
        {
            // Snippet: CreateStreamAsync(CreateStreamRequest, CallSettings)
            // Additional: CreateStreamAsync(CreateStreamRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateStreamRequest request = new CreateStreamRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                StreamId = "",
                Stream = new Stream(),
                RequestId = "",
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = await streamsServiceClient.CreateStreamAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStream</summary>
        public void CreateStream()
        {
            // Snippet: CreateStream(string, Stream, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = streamsServiceClient.CreateStream(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStreamAsync</summary>
        public async Task CreateStreamAsync()
        {
            // Snippet: CreateStreamAsync(string, Stream, string, CallSettings)
            // Additional: CreateStreamAsync(string, Stream, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = await streamsServiceClient.CreateStreamAsync(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStream</summary>
        public void CreateStreamResourceNames()
        {
            // Snippet: CreateStream(ClusterName, Stream, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = streamsServiceClient.CreateStream(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateStreamAsync</summary>
        public async Task CreateStreamResourceNamesAsync()
        {
            // Snippet: CreateStreamAsync(ClusterName, Stream, string, CallSettings)
            // Additional: CreateStreamAsync(ClusterName, Stream, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Stream stream = new Stream();
            string streamId = "";
            // Make the request
            Operation<Stream, OperationMetadata> response = await streamsServiceClient.CreateStreamAsync(parent, stream, streamId);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStream</summary>
        public void UpdateStreamRequestObject()
        {
            // Snippet: UpdateStream(UpdateStreamRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            UpdateStreamRequest request = new UpdateStreamRequest
            {
                UpdateMask = new FieldMask(),
                Stream = new Stream(),
                RequestId = "",
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = streamsServiceClient.UpdateStream(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStreamAsync</summary>
        public async Task UpdateStreamRequestObjectAsync()
        {
            // Snippet: UpdateStreamAsync(UpdateStreamRequest, CallSettings)
            // Additional: UpdateStreamAsync(UpdateStreamRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStreamRequest request = new UpdateStreamRequest
            {
                UpdateMask = new FieldMask(),
                Stream = new Stream(),
                RequestId = "",
            };
            // Make the request
            Operation<Stream, OperationMetadata> response = await streamsServiceClient.UpdateStreamAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStream</summary>
        public void UpdateStream()
        {
            // Snippet: UpdateStream(Stream, FieldMask, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            Stream stream = new Stream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Stream, OperationMetadata> response = streamsServiceClient.UpdateStream(stream, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateStreamAsync</summary>
        public async Task UpdateStreamAsync()
        {
            // Snippet: UpdateStreamAsync(Stream, FieldMask, CallSettings)
            // Additional: UpdateStreamAsync(Stream, FieldMask, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Stream stream = new Stream();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Stream, OperationMetadata> response = await streamsServiceClient.UpdateStreamAsync(stream, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Stream, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Stream result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Stream, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Stream retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStream</summary>
        public void DeleteStreamRequestObject()
        {
            // Snippet: DeleteStream(DeleteStreamRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            DeleteStreamRequest request = new DeleteStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteStream(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStreamAsync</summary>
        public async Task DeleteStreamRequestObjectAsync()
        {
            // Snippet: DeleteStreamAsync(DeleteStreamRequest, CallSettings)
            // Additional: DeleteStreamAsync(DeleteStreamRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStreamRequest request = new DeleteStreamRequest
            {
                StreamName = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteStreamAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStream</summary>
        public void DeleteStream()
        {
            // Snippet: DeleteStream(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/streams/[STREAM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteStream(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStreamAsync</summary>
        public async Task DeleteStreamAsync()
        {
            // Snippet: DeleteStreamAsync(string, CallSettings)
            // Additional: DeleteStreamAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/streams/[STREAM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteStreamAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStream</summary>
        public void DeleteStreamResourceNames()
        {
            // Snippet: DeleteStream(StreamName, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteStream(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteStream(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteStreamAsync</summary>
        public async Task DeleteStreamResourceNamesAsync()
        {
            // Snippet: DeleteStreamAsync(StreamName, CallSettings)
            // Additional: DeleteStreamAsync(StreamName, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            StreamName name = StreamName.FromProjectLocationClusterStream("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[STREAM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteStreamAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteStreamAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetStreamThumbnail</summary>
        public void GetStreamThumbnailRequestObject()
        {
            // Snippet: GetStreamThumbnail(GetStreamThumbnailRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            GetStreamThumbnailRequest request = new GetStreamThumbnailRequest
            {
                Stream = "",
                GcsObjectName = "",
                Event = "",
                RequestId = "",
            };
            // Make the request
            Operation<GetStreamThumbnailResponse, OperationMetadata> response = streamsServiceClient.GetStreamThumbnail(request);

            // Poll until the returned long-running operation is complete
            Operation<GetStreamThumbnailResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GetStreamThumbnailResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GetStreamThumbnailResponse, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceGetStreamThumbnail(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GetStreamThumbnailResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetStreamThumbnailAsync</summary>
        public async Task GetStreamThumbnailRequestObjectAsync()
        {
            // Snippet: GetStreamThumbnailAsync(GetStreamThumbnailRequest, CallSettings)
            // Additional: GetStreamThumbnailAsync(GetStreamThumbnailRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetStreamThumbnailRequest request = new GetStreamThumbnailRequest
            {
                Stream = "",
                GcsObjectName = "",
                Event = "",
                RequestId = "",
            };
            // Make the request
            Operation<GetStreamThumbnailResponse, OperationMetadata> response = await streamsServiceClient.GetStreamThumbnailAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<GetStreamThumbnailResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GetStreamThumbnailResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GetStreamThumbnailResponse, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceGetStreamThumbnailAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GetStreamThumbnailResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetStreamThumbnail</summary>
        public void GetStreamThumbnail()
        {
            // Snippet: GetStreamThumbnail(string, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string stream = "";
            string gcsObjectName = "";
            // Make the request
            Operation<GetStreamThumbnailResponse, OperationMetadata> response = streamsServiceClient.GetStreamThumbnail(stream, gcsObjectName);

            // Poll until the returned long-running operation is complete
            Operation<GetStreamThumbnailResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            GetStreamThumbnailResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GetStreamThumbnailResponse, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceGetStreamThumbnail(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GetStreamThumbnailResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetStreamThumbnailAsync</summary>
        public async Task GetStreamThumbnailAsync()
        {
            // Snippet: GetStreamThumbnailAsync(string, string, CallSettings)
            // Additional: GetStreamThumbnailAsync(string, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string stream = "";
            string gcsObjectName = "";
            // Make the request
            Operation<GetStreamThumbnailResponse, OperationMetadata> response = await streamsServiceClient.GetStreamThumbnailAsync(stream, gcsObjectName);

            // Poll until the returned long-running operation is complete
            Operation<GetStreamThumbnailResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            GetStreamThumbnailResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<GetStreamThumbnailResponse, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceGetStreamThumbnailAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                GetStreamThumbnailResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateStreamHlsToken</summary>
        public void GenerateStreamHlsTokenRequestObject()
        {
            // Snippet: GenerateStreamHlsToken(GenerateStreamHlsTokenRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            GenerateStreamHlsTokenRequest request = new GenerateStreamHlsTokenRequest { Stream = "", };
            // Make the request
            GenerateStreamHlsTokenResponse response = streamsServiceClient.GenerateStreamHlsToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateStreamHlsTokenAsync</summary>
        public async Task GenerateStreamHlsTokenRequestObjectAsync()
        {
            // Snippet: GenerateStreamHlsTokenAsync(GenerateStreamHlsTokenRequest, CallSettings)
            // Additional: GenerateStreamHlsTokenAsync(GenerateStreamHlsTokenRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateStreamHlsTokenRequest request = new GenerateStreamHlsTokenRequest { Stream = "", };
            // Make the request
            GenerateStreamHlsTokenResponse response = await streamsServiceClient.GenerateStreamHlsTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateStreamHlsToken</summary>
        public void GenerateStreamHlsToken()
        {
            // Snippet: GenerateStreamHlsToken(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string stream = "";
            // Make the request
            GenerateStreamHlsTokenResponse response = streamsServiceClient.GenerateStreamHlsToken(stream);
            // End snippet
        }

        /// <summary>Snippet for GenerateStreamHlsTokenAsync</summary>
        public async Task GenerateStreamHlsTokenAsync()
        {
            // Snippet: GenerateStreamHlsTokenAsync(string, CallSettings)
            // Additional: GenerateStreamHlsTokenAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string stream = "";
            // Make the request
            GenerateStreamHlsTokenResponse response = await streamsServiceClient.GenerateStreamHlsTokenAsync(stream);
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsRequestObject()
        {
            // Snippet: ListEvents(ListEventsRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = streamsServiceClient.ListEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsRequestObjectAsync()
        {
            // Snippet: ListEventsAsync(ListEventsRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = streamsServiceClient.ListEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEvents()
        {
            // Snippet: ListEvents(string, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = streamsServiceClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsAsync()
        {
            // Snippet: ListEventsAsync(string, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = streamsServiceClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsResourceNames()
        {
            // Snippet: ListEvents(ClusterName, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListEventsResponse, Event> response = streamsServiceClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Event item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsResourceNamesAsync()
        {
            // Snippet: ListEventsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = streamsServiceClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEventRequestObject()
        {
            // Snippet: GetEvent(GetEventRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]"),
            };
            // Make the request
            Event response = streamsServiceClient.GetEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventRequestObjectAsync()
        {
            // Snippet: GetEventAsync(GetEventRequest, CallSettings)
            // Additional: GetEventAsync(GetEventRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEventRequest request = new GetEventRequest
            {
                EventName = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]"),
            };
            // Make the request
            Event response = await streamsServiceClient.GetEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEvent()
        {
            // Snippet: GetEvent(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/events/[EVENT]";
            // Make the request
            Event response = streamsServiceClient.GetEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventAsync()
        {
            // Snippet: GetEventAsync(string, CallSettings)
            // Additional: GetEventAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/events/[EVENT]";
            // Make the request
            Event response = await streamsServiceClient.GetEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEvent</summary>
        public void GetEventResourceNames()
        {
            // Snippet: GetEvent(EventName, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]");
            // Make the request
            Event response = streamsServiceClient.GetEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetEventAsync</summary>
        public async Task GetEventResourceNamesAsync()
        {
            // Snippet: GetEventAsync(EventName, CallSettings)
            // Additional: GetEventAsync(EventName, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]");
            // Make the request
            Event response = await streamsServiceClient.GetEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEvent</summary>
        public void CreateEventRequestObject()
        {
            // Snippet: CreateEvent(CreateEventRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                EventId = "",
                Event = new Event(),
                RequestId = "",
            };
            // Make the request
            Operation<Event, OperationMetadata> response = streamsServiceClient.CreateEvent(request);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEventAsync</summary>
        public async Task CreateEventRequestObjectAsync()
        {
            // Snippet: CreateEventAsync(CreateEventRequest, CallSettings)
            // Additional: CreateEventAsync(CreateEventRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEventRequest request = new CreateEventRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                EventId = "",
                Event = new Event(),
                RequestId = "",
            };
            // Make the request
            Operation<Event, OperationMetadata> response = await streamsServiceClient.CreateEventAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvent</summary>
        public void CreateEvent()
        {
            // Snippet: CreateEvent(string, Event, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Operation<Event, OperationMetadata> response = streamsServiceClient.CreateEvent(parent, @event, eventId);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEventAsync</summary>
        public async Task CreateEventAsync()
        {
            // Snippet: CreateEventAsync(string, Event, string, CallSettings)
            // Additional: CreateEventAsync(string, Event, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Operation<Event, OperationMetadata> response = await streamsServiceClient.CreateEventAsync(parent, @event, eventId);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEvent</summary>
        public void CreateEventResourceNames()
        {
            // Snippet: CreateEvent(ClusterName, Event, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Operation<Event, OperationMetadata> response = streamsServiceClient.CreateEvent(parent, @event, eventId);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEventAsync</summary>
        public async Task CreateEventResourceNamesAsync()
        {
            // Snippet: CreateEventAsync(ClusterName, Event, string, CallSettings)
            // Additional: CreateEventAsync(ClusterName, Event, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Event @event = new Event();
            string eventId = "";
            // Make the request
            Operation<Event, OperationMetadata> response = await streamsServiceClient.CreateEventAsync(parent, @event, eventId);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEvent</summary>
        public void UpdateEventRequestObject()
        {
            // Snippet: UpdateEvent(UpdateEventRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            UpdateEventRequest request = new UpdateEventRequest
            {
                UpdateMask = new FieldMask(),
                Event = new Event(),
                RequestId = "",
            };
            // Make the request
            Operation<Event, OperationMetadata> response = streamsServiceClient.UpdateEvent(request);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEventAsync</summary>
        public async Task UpdateEventRequestObjectAsync()
        {
            // Snippet: UpdateEventAsync(UpdateEventRequest, CallSettings)
            // Additional: UpdateEventAsync(UpdateEventRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEventRequest request = new UpdateEventRequest
            {
                UpdateMask = new FieldMask(),
                Event = new Event(),
                RequestId = "",
            };
            // Make the request
            Operation<Event, OperationMetadata> response = await streamsServiceClient.UpdateEventAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEvent</summary>
        public void UpdateEvent()
        {
            // Snippet: UpdateEvent(Event, FieldMask, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            Event @event = new Event();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Event, OperationMetadata> response = streamsServiceClient.UpdateEvent(@event, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEventAsync</summary>
        public async Task UpdateEventAsync()
        {
            // Snippet: UpdateEventAsync(Event, FieldMask, CallSettings)
            // Additional: UpdateEventAsync(Event, FieldMask, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Event @event = new Event();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Event, OperationMetadata> response = await streamsServiceClient.UpdateEventAsync(@event, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Event, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Event result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Event, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Event retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvent</summary>
        public void DeleteEventRequestObject()
        {
            // Snippet: DeleteEvent(DeleteEventRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteEvent(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEventAsync</summary>
        public async Task DeleteEventRequestObjectAsync()
        {
            // Snippet: DeleteEventAsync(DeleteEventRequest, CallSettings)
            // Additional: DeleteEventAsync(DeleteEventRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEventRequest request = new DeleteEventRequest
            {
                EventName = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteEventAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvent</summary>
        public void DeleteEvent()
        {
            // Snippet: DeleteEvent(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/events/[EVENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteEvent(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEventAsync</summary>
        public async Task DeleteEventAsync()
        {
            // Snippet: DeleteEventAsync(string, CallSettings)
            // Additional: DeleteEventAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/events/[EVENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteEventAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEvent</summary>
        public void DeleteEventResourceNames()
        {
            // Snippet: DeleteEvent(EventName, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteEvent(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteEvent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEventAsync</summary>
        public async Task DeleteEventResourceNamesAsync()
        {
            // Snippet: DeleteEventAsync(EventName, CallSettings)
            // Additional: DeleteEventAsync(EventName, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            EventName name = EventName.FromProjectLocationClusterEvent("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[EVENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteEventAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteEventAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSeries</summary>
        public void ListSeriesRequestObject()
        {
            // Snippet: ListSeries(ListSeriesRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ListSeriesRequest request = new ListSeriesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSeriesResponse, Series> response = streamsServiceClient.ListSeries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Series item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Series item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Series> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Series item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSeriesAsync</summary>
        public async Task ListSeriesRequestObjectAsync()
        {
            // Snippet: ListSeriesAsync(ListSeriesRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSeriesRequest request = new ListSeriesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSeriesResponse, Series> response = streamsServiceClient.ListSeriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Series item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Series item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Series> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Series item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSeries</summary>
        public void ListSeries()
        {
            // Snippet: ListSeries(string, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListSeriesResponse, Series> response = streamsServiceClient.ListSeries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Series item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Series item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Series> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Series item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSeriesAsync</summary>
        public async Task ListSeriesAsync()
        {
            // Snippet: ListSeriesAsync(string, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListSeriesResponse, Series> response = streamsServiceClient.ListSeriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Series item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Series item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Series> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Series item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSeries</summary>
        public void ListSeriesResourceNames()
        {
            // Snippet: ListSeries(ClusterName, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListSeriesResponse, Series> response = streamsServiceClient.ListSeries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Series item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSeriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Series item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Series> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Series item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSeriesAsync</summary>
        public async Task ListSeriesResourceNamesAsync()
        {
            // Snippet: ListSeriesAsync(ClusterName, string, int?, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListSeriesResponse, Series> response = streamsServiceClient.ListSeriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Series item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSeriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Series item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Series> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Series item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSeries</summary>
        public void GetSeriesRequestObject()
        {
            // Snippet: GetSeries(GetSeriesRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            GetSeriesRequest request = new GetSeriesRequest
            {
                SeriesName = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]"),
            };
            // Make the request
            Series response = streamsServiceClient.GetSeries(request);
            // End snippet
        }

        /// <summary>Snippet for GetSeriesAsync</summary>
        public async Task GetSeriesRequestObjectAsync()
        {
            // Snippet: GetSeriesAsync(GetSeriesRequest, CallSettings)
            // Additional: GetSeriesAsync(GetSeriesRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSeriesRequest request = new GetSeriesRequest
            {
                SeriesName = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]"),
            };
            // Make the request
            Series response = await streamsServiceClient.GetSeriesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSeries</summary>
        public void GetSeries()
        {
            // Snippet: GetSeries(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/series/[SERIES]";
            // Make the request
            Series response = streamsServiceClient.GetSeries(name);
            // End snippet
        }

        /// <summary>Snippet for GetSeriesAsync</summary>
        public async Task GetSeriesAsync()
        {
            // Snippet: GetSeriesAsync(string, CallSettings)
            // Additional: GetSeriesAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/series/[SERIES]";
            // Make the request
            Series response = await streamsServiceClient.GetSeriesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSeries</summary>
        public void GetSeriesResourceNames()
        {
            // Snippet: GetSeries(SeriesName, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            SeriesName name = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]");
            // Make the request
            Series response = streamsServiceClient.GetSeries(name);
            // End snippet
        }

        /// <summary>Snippet for GetSeriesAsync</summary>
        public async Task GetSeriesResourceNamesAsync()
        {
            // Snippet: GetSeriesAsync(SeriesName, CallSettings)
            // Additional: GetSeriesAsync(SeriesName, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SeriesName name = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]");
            // Make the request
            Series response = await streamsServiceClient.GetSeriesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSeries</summary>
        public void CreateSeriesRequestObject()
        {
            // Snippet: CreateSeries(CreateSeriesRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            CreateSeriesRequest request = new CreateSeriesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                SeriesId = "",
                Series = new Series(),
                RequestId = "",
            };
            // Make the request
            Operation<Series, OperationMetadata> response = streamsServiceClient.CreateSeries(request);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSeriesAsync</summary>
        public async Task CreateSeriesRequestObjectAsync()
        {
            // Snippet: CreateSeriesAsync(CreateSeriesRequest, CallSettings)
            // Additional: CreateSeriesAsync(CreateSeriesRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSeriesRequest request = new CreateSeriesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                SeriesId = "",
                Series = new Series(),
                RequestId = "",
            };
            // Make the request
            Operation<Series, OperationMetadata> response = await streamsServiceClient.CreateSeriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSeries</summary>
        public void CreateSeries()
        {
            // Snippet: CreateSeries(string, Series, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Series series = new Series();
            string seriesId = "";
            // Make the request
            Operation<Series, OperationMetadata> response = streamsServiceClient.CreateSeries(parent, series, seriesId);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSeriesAsync</summary>
        public async Task CreateSeriesAsync()
        {
            // Snippet: CreateSeriesAsync(string, Series, string, CallSettings)
            // Additional: CreateSeriesAsync(string, Series, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Series series = new Series();
            string seriesId = "";
            // Make the request
            Operation<Series, OperationMetadata> response = await streamsServiceClient.CreateSeriesAsync(parent, series, seriesId);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSeries</summary>
        public void CreateSeriesResourceNames()
        {
            // Snippet: CreateSeries(ClusterName, Series, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Series series = new Series();
            string seriesId = "";
            // Make the request
            Operation<Series, OperationMetadata> response = streamsServiceClient.CreateSeries(parent, series, seriesId);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceCreateSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSeriesAsync</summary>
        public async Task CreateSeriesResourceNamesAsync()
        {
            // Snippet: CreateSeriesAsync(ClusterName, Series, string, CallSettings)
            // Additional: CreateSeriesAsync(ClusterName, Series, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Series series = new Series();
            string seriesId = "";
            // Make the request
            Operation<Series, OperationMetadata> response = await streamsServiceClient.CreateSeriesAsync(parent, series, seriesId);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceCreateSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSeries</summary>
        public void UpdateSeriesRequestObject()
        {
            // Snippet: UpdateSeries(UpdateSeriesRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            UpdateSeriesRequest request = new UpdateSeriesRequest
            {
                UpdateMask = new FieldMask(),
                Series = new Series(),
                RequestId = "",
            };
            // Make the request
            Operation<Series, OperationMetadata> response = streamsServiceClient.UpdateSeries(request);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSeriesAsync</summary>
        public async Task UpdateSeriesRequestObjectAsync()
        {
            // Snippet: UpdateSeriesAsync(UpdateSeriesRequest, CallSettings)
            // Additional: UpdateSeriesAsync(UpdateSeriesRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSeriesRequest request = new UpdateSeriesRequest
            {
                UpdateMask = new FieldMask(),
                Series = new Series(),
                RequestId = "",
            };
            // Make the request
            Operation<Series, OperationMetadata> response = await streamsServiceClient.UpdateSeriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSeries</summary>
        public void UpdateSeries()
        {
            // Snippet: UpdateSeries(Series, FieldMask, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            Series series = new Series();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Series, OperationMetadata> response = streamsServiceClient.UpdateSeries(series, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceUpdateSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateSeriesAsync</summary>
        public async Task UpdateSeriesAsync()
        {
            // Snippet: UpdateSeriesAsync(Series, FieldMask, CallSettings)
            // Additional: UpdateSeriesAsync(Series, FieldMask, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Series series = new Series();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Series, OperationMetadata> response = await streamsServiceClient.UpdateSeriesAsync(series, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Series, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Series result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Series, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceUpdateSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Series retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSeries</summary>
        public void DeleteSeriesRequestObject()
        {
            // Snippet: DeleteSeries(DeleteSeriesRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            DeleteSeriesRequest request = new DeleteSeriesRequest
            {
                SeriesName = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteSeries(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSeriesAsync</summary>
        public async Task DeleteSeriesRequestObjectAsync()
        {
            // Snippet: DeleteSeriesAsync(DeleteSeriesRequest, CallSettings)
            // Additional: DeleteSeriesAsync(DeleteSeriesRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSeriesRequest request = new DeleteSeriesRequest
            {
                SeriesName = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteSeriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSeries</summary>
        public void DeleteSeries()
        {
            // Snippet: DeleteSeries(string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/series/[SERIES]";
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteSeries(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSeriesAsync</summary>
        public async Task DeleteSeriesAsync()
        {
            // Snippet: DeleteSeriesAsync(string, CallSettings)
            // Additional: DeleteSeriesAsync(string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/series/[SERIES]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteSeriesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSeries</summary>
        public void DeleteSeriesResourceNames()
        {
            // Snippet: DeleteSeries(SeriesName, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            SeriesName name = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]");
            // Make the request
            Operation<Empty, OperationMetadata> response = streamsServiceClient.DeleteSeries(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceDeleteSeries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSeriesAsync</summary>
        public async Task DeleteSeriesResourceNamesAsync()
        {
            // Snippet: DeleteSeriesAsync(SeriesName, CallSettings)
            // Additional: DeleteSeriesAsync(SeriesName, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SeriesName name = SeriesName.FromProjectLocationClusterSeries("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[SERIES]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await streamsServiceClient.DeleteSeriesAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceDeleteSeriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MaterializeChannel</summary>
        public void MaterializeChannelRequestObject()
        {
            // Snippet: MaterializeChannel(MaterializeChannelRequest, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            MaterializeChannelRequest request = new MaterializeChannelRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                ChannelId = "",
                Channel = new Channel(),
                RequestId = "",
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = streamsServiceClient.MaterializeChannel(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceMaterializeChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MaterializeChannelAsync</summary>
        public async Task MaterializeChannelRequestObjectAsync()
        {
            // Snippet: MaterializeChannelAsync(MaterializeChannelRequest, CallSettings)
            // Additional: MaterializeChannelAsync(MaterializeChannelRequest, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            MaterializeChannelRequest request = new MaterializeChannelRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                ChannelId = "",
                Channel = new Channel(),
                RequestId = "",
            };
            // Make the request
            Operation<Channel, OperationMetadata> response = await streamsServiceClient.MaterializeChannelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceMaterializeChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MaterializeChannel</summary>
        public void MaterializeChannel()
        {
            // Snippet: MaterializeChannel(string, Channel, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = streamsServiceClient.MaterializeChannel(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceMaterializeChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MaterializeChannelAsync</summary>
        public async Task MaterializeChannelAsync()
        {
            // Snippet: MaterializeChannelAsync(string, Channel, string, CallSettings)
            // Additional: MaterializeChannelAsync(string, Channel, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = await streamsServiceClient.MaterializeChannelAsync(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceMaterializeChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MaterializeChannel</summary>
        public void MaterializeChannelResourceNames()
        {
            // Snippet: MaterializeChannel(ClusterName, Channel, string, CallSettings)
            // Create client
            StreamsServiceClient streamsServiceClient = StreamsServiceClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = streamsServiceClient.MaterializeChannel(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = streamsServiceClient.PollOnceMaterializeChannel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for MaterializeChannelAsync</summary>
        public async Task MaterializeChannelResourceNamesAsync()
        {
            // Snippet: MaterializeChannelAsync(ClusterName, Channel, string, CallSettings)
            // Additional: MaterializeChannelAsync(ClusterName, Channel, string, CancellationToken)
            // Create client
            StreamsServiceClient streamsServiceClient = await StreamsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Channel channel = new Channel();
            string channelId = "";
            // Make the request
            Operation<Channel, OperationMetadata> response = await streamsServiceClient.MaterializeChannelAsync(parent, channel, channelId);

            // Poll until the returned long-running operation is complete
            Operation<Channel, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Channel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Channel, OperationMetadata> retrievedResponse = await streamsServiceClient.PollOnceMaterializeChannelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Channel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
