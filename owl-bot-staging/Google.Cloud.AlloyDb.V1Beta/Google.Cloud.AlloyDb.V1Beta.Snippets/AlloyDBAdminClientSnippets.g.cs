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
    using Google.Cloud.AlloyDb.V1Beta;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAlloyDBAdminClientSnippets
    {
        /// <summary>Snippet for ListClusters</summary>
        public void ListClustersRequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = alloyDBAdminClient.ListClusters(request);

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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = alloyDBAdminClient.ListClustersAsync(request);

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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = alloyDBAdminClient.ListClusters(parent);

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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = alloyDBAdminClient.ListClustersAsync(parent);

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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response = alloyDBAdminClient.ListClusters(parent);

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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response = alloyDBAdminClient.ListClustersAsync(parent);

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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                View = ClusterView.Unspecified,
            };
            // Make the request
            Cluster response = alloyDBAdminClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterRequestObjectAsync()
        {
            // Snippet: GetClusterAsync(GetClusterRequest, CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                View = ClusterView.Unspecified,
            };
            // Make the request
            Cluster response = await alloyDBAdminClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = alloyDBAdminClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string, CallSettings)
            // Additional: GetClusterAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Cluster response = await alloyDBAdminClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetClusterResourceNames()
        {
            // Snippet: GetCluster(ClusterName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = alloyDBAdminClient.GetCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterResourceNamesAsync()
        {
            // Snippet: GetClusterAsync(ClusterName, CallSettings)
            // Additional: GetClusterAsync(ClusterName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Cluster response = await alloyDBAdminClient.GetClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateClusterRequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateClusterAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateClusterAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.CreateCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.CreateClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateClusterAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpdateCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                UpdateMask = new FieldMask(),
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpdateClusterAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.UpdateCluster(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpdateCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.UpdateClusterAsync(cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeCluster</summary>
        public void UpgradeClusterRequestObject()
        {
            // Snippet: UpgradeCluster(UpgradeClusterRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            UpgradeClusterRequest request = new UpgradeClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Version = DatabaseVersion.Unspecified,
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<UpgradeClusterResponse, OperationMetadata> response = alloyDBAdminClient.UpgradeCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeClusterResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeClusterResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeClusterResponse, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpgradeCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeClusterResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeClusterAsync</summary>
        public async Task UpgradeClusterRequestObjectAsync()
        {
            // Snippet: UpgradeClusterAsync(UpgradeClusterRequest, CallSettings)
            // Additional: UpgradeClusterAsync(UpgradeClusterRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpgradeClusterRequest request = new UpgradeClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Version = DatabaseVersion.Unspecified,
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<UpgradeClusterResponse, OperationMetadata> response = await alloyDBAdminClient.UpgradeClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeClusterResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpgradeClusterResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeClusterResponse, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpgradeClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeClusterResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeCluster</summary>
        public void UpgradeCluster()
        {
            // Snippet: UpgradeCluster(string, DatabaseVersion, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            DatabaseVersion version = DatabaseVersion.Unspecified;
            // Make the request
            Operation<UpgradeClusterResponse, OperationMetadata> response = alloyDBAdminClient.UpgradeCluster(name, version);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeClusterResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeClusterResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeClusterResponse, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpgradeCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeClusterResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeClusterAsync</summary>
        public async Task UpgradeClusterAsync()
        {
            // Snippet: UpgradeClusterAsync(string, DatabaseVersion, CallSettings)
            // Additional: UpgradeClusterAsync(string, DatabaseVersion, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            DatabaseVersion version = DatabaseVersion.Unspecified;
            // Make the request
            Operation<UpgradeClusterResponse, OperationMetadata> response = await alloyDBAdminClient.UpgradeClusterAsync(name, version);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeClusterResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpgradeClusterResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeClusterResponse, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpgradeClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeClusterResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeCluster</summary>
        public void UpgradeClusterResourceNames()
        {
            // Snippet: UpgradeCluster(ClusterName, DatabaseVersion, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            DatabaseVersion version = DatabaseVersion.Unspecified;
            // Make the request
            Operation<UpgradeClusterResponse, OperationMetadata> response = alloyDBAdminClient.UpgradeCluster(name, version);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeClusterResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UpgradeClusterResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeClusterResponse, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpgradeCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeClusterResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpgradeClusterAsync</summary>
        public async Task UpgradeClusterResourceNamesAsync()
        {
            // Snippet: UpgradeClusterAsync(ClusterName, DatabaseVersion, CallSettings)
            // Additional: UpgradeClusterAsync(ClusterName, DatabaseVersion, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            DatabaseVersion version = DatabaseVersion.Unspecified;
            // Make the request
            Operation<UpgradeClusterResponse, OperationMetadata> response = await alloyDBAdminClient.UpgradeClusterAsync(name, version);

            // Poll until the returned long-running operation is complete
            Operation<UpgradeClusterResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UpgradeClusterResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UpgradeClusterResponse, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpgradeClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UpgradeClusterResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteClusterRequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                Etag = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                Etag = "",
                ValidateOnly = false,
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteClusterAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteClusterAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteCluster(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCluster</summary>
        public void PromoteClusterRequestObject()
        {
            // Snippet: PromoteCluster(PromoteClusterRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            PromoteClusterRequest request = new PromoteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.PromoteCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOncePromoteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteClusterAsync</summary>
        public async Task PromoteClusterRequestObjectAsync()
        {
            // Snippet: PromoteClusterAsync(PromoteClusterRequest, CallSettings)
            // Additional: PromoteClusterAsync(PromoteClusterRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            PromoteClusterRequest request = new PromoteClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.PromoteClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOncePromoteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCluster</summary>
        public void PromoteCluster()
        {
            // Snippet: PromoteCluster(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.PromoteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOncePromoteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteClusterAsync</summary>
        public async Task PromoteClusterAsync()
        {
            // Snippet: PromoteClusterAsync(string, CallSettings)
            // Additional: PromoteClusterAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.PromoteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOncePromoteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteCluster</summary>
        public void PromoteClusterResourceNames()
        {
            // Snippet: PromoteCluster(ClusterName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.PromoteCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOncePromoteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PromoteClusterAsync</summary>
        public async Task PromoteClusterResourceNamesAsync()
        {
            // Snippet: PromoteClusterAsync(ClusterName, CallSettings)
            // Additional: PromoteClusterAsync(ClusterName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.PromoteClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOncePromoteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverCluster</summary>
        public void SwitchoverClusterRequestObject()
        {
            // Snippet: SwitchoverCluster(SwitchoverClusterRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            SwitchoverClusterRequest request = new SwitchoverClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.SwitchoverCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceSwitchoverCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverClusterAsync</summary>
        public async Task SwitchoverClusterRequestObjectAsync()
        {
            // Snippet: SwitchoverClusterAsync(SwitchoverClusterRequest, CallSettings)
            // Additional: SwitchoverClusterAsync(SwitchoverClusterRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            SwitchoverClusterRequest request = new SwitchoverClusterRequest
            {
                ClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.SwitchoverClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceSwitchoverClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverCluster</summary>
        public void SwitchoverCluster()
        {
            // Snippet: SwitchoverCluster(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.SwitchoverCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceSwitchoverCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverClusterAsync</summary>
        public async Task SwitchoverClusterAsync()
        {
            // Snippet: SwitchoverClusterAsync(string, CallSettings)
            // Additional: SwitchoverClusterAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.SwitchoverClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceSwitchoverClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverCluster</summary>
        public void SwitchoverClusterResourceNames()
        {
            // Snippet: SwitchoverCluster(ClusterName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.SwitchoverCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceSwitchoverCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverClusterAsync</summary>
        public async Task SwitchoverClusterResourceNamesAsync()
        {
            // Snippet: SwitchoverClusterAsync(ClusterName, CallSettings)
            // Additional: SwitchoverClusterAsync(ClusterName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName name = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.SwitchoverClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceSwitchoverClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreCluster</summary>
        public void RestoreClusterRequestObject()
        {
            // Snippet: RestoreCluster(RestoreClusterRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            RestoreClusterRequest request = new RestoreClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                BackupSource = new BackupSource(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.RestoreCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceRestoreCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreClusterAsync</summary>
        public async Task RestoreClusterRequestObjectAsync()
        {
            // Snippet: RestoreClusterAsync(RestoreClusterRequest, CallSettings)
            // Additional: RestoreClusterAsync(RestoreClusterRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            RestoreClusterRequest request = new RestoreClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                BackupSource = new BackupSource(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.RestoreClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceRestoreClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryCluster</summary>
        public void CreateSecondaryClusterRequestObject()
        {
            // Snippet: CreateSecondaryCluster(CreateSecondaryClusterRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            CreateSecondaryClusterRequest request = new CreateSecondaryClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.CreateSecondaryCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateSecondaryCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryClusterAsync</summary>
        public async Task CreateSecondaryClusterRequestObjectAsync()
        {
            // Snippet: CreateSecondaryClusterAsync(CreateSecondaryClusterRequest, CallSettings)
            // Additional: CreateSecondaryClusterAsync(CreateSecondaryClusterRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateSecondaryClusterRequest request = new CreateSecondaryClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.CreateSecondaryClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateSecondaryClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryCluster</summary>
        public void CreateSecondaryCluster()
        {
            // Snippet: CreateSecondaryCluster(string, Cluster, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.CreateSecondaryCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateSecondaryCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryClusterAsync</summary>
        public async Task CreateSecondaryClusterAsync()
        {
            // Snippet: CreateSecondaryClusterAsync(string, Cluster, string, CallSettings)
            // Additional: CreateSecondaryClusterAsync(string, Cluster, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.CreateSecondaryClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateSecondaryClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryCluster</summary>
        public void CreateSecondaryClusterResourceNames()
        {
            // Snippet: CreateSecondaryCluster(LocationName, Cluster, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBAdminClient.CreateSecondaryCluster(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateSecondaryCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryClusterAsync</summary>
        public async Task CreateSecondaryClusterResourceNamesAsync()
        {
            // Snippet: CreateSecondaryClusterAsync(LocationName, Cluster, string, CallSettings)
            // Additional: CreateSecondaryClusterAsync(LocationName, Cluster, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Cluster cluster = new Cluster();
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBAdminClient.CreateSecondaryClusterAsync(parent, cluster, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateSecondaryClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = alloyDBAdminClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesRequest request = new ListInstancesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = alloyDBAdminClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = alloyDBAdminClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = alloyDBAdminClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesResourceNames()
        {
            // Snippet: ListInstances(ClusterName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListInstancesResponse, Instance> response = alloyDBAdminClient.ListInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Instance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesResourceNamesAsync()
        {
            // Snippet: ListInstancesAsync(ClusterName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListInstancesResponse, Instance> response = alloyDBAdminClient.ListInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Instance item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListInstancesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Instance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Instance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Instance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceRequestObject()
        {
            // Snippet: GetInstance(GetInstanceRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                View = InstanceView.Unspecified,
            };
            // Make the request
            Instance response = alloyDBAdminClient.GetInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceRequestObjectAsync()
        {
            // Snippet: GetInstanceAsync(GetInstanceRequest, CallSettings)
            // Additional: GetInstanceAsync(GetInstanceRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                View = InstanceView.Unspecified,
            };
            // Make the request
            Instance response = await alloyDBAdminClient.GetInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstance()
        {
            // Snippet: GetInstance(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Instance response = alloyDBAdminClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceAsync()
        {
            // Snippet: GetInstanceAsync(string, CallSettings)
            // Additional: GetInstanceAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Instance response = await alloyDBAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstance</summary>
        public void GetInstanceResourceNames()
        {
            // Snippet: GetInstance(InstanceName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Instance response = alloyDBAdminClient.GetInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetInstanceAsync</summary>
        public async Task GetInstanceResourceNamesAsync()
        {
            // Snippet: GetInstanceAsync(InstanceName, CallSettings)
            // Additional: GetInstanceAsync(InstanceName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Instance response = await alloyDBAdminClient.GetInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceRequestObject()
        {
            // Snippet: CreateInstance(CreateInstanceRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.CreateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceRequestObjectAsync()
        {
            // Snippet: CreateInstanceAsync(CreateInstanceRequest, CallSettings)
            // Additional: CreateInstanceAsync(CreateInstanceRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateInstanceRequest request = new CreateInstanceRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.CreateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstance()
        {
            // Snippet: CreateInstance(string, Instance, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceAsync()
        {
            // Snippet: CreateInstanceAsync(string, Instance, string, CallSettings)
            // Additional: CreateInstanceAsync(string, Instance, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstance</summary>
        public void CreateInstanceResourceNames()
        {
            // Snippet: CreateInstance(ClusterName, Instance, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.CreateInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInstanceAsync</summary>
        public async Task CreateInstanceResourceNamesAsync()
        {
            // Snippet: CreateInstanceAsync(ClusterName, Instance, string, CallSettings)
            // Additional: CreateInstanceAsync(ClusterName, Instance, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.CreateInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryInstance</summary>
        public void CreateSecondaryInstanceRequestObject()
        {
            // Snippet: CreateSecondaryInstance(CreateSecondaryInstanceRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            CreateSecondaryInstanceRequest request = new CreateSecondaryInstanceRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.CreateSecondaryInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateSecondaryInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryInstanceAsync</summary>
        public async Task CreateSecondaryInstanceRequestObjectAsync()
        {
            // Snippet: CreateSecondaryInstanceAsync(CreateSecondaryInstanceRequest, CallSettings)
            // Additional: CreateSecondaryInstanceAsync(CreateSecondaryInstanceRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateSecondaryInstanceRequest request = new CreateSecondaryInstanceRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                InstanceId = "",
                Instance = new Instance(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.CreateSecondaryInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateSecondaryInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryInstance</summary>
        public void CreateSecondaryInstance()
        {
            // Snippet: CreateSecondaryInstance(string, Instance, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.CreateSecondaryInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateSecondaryInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryInstanceAsync</summary>
        public async Task CreateSecondaryInstanceAsync()
        {
            // Snippet: CreateSecondaryInstanceAsync(string, Instance, string, CallSettings)
            // Additional: CreateSecondaryInstanceAsync(string, Instance, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.CreateSecondaryInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateSecondaryInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryInstance</summary>
        public void CreateSecondaryInstanceResourceNames()
        {
            // Snippet: CreateSecondaryInstance(ClusterName, Instance, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.CreateSecondaryInstance(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateSecondaryInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSecondaryInstanceAsync</summary>
        public async Task CreateSecondaryInstanceResourceNamesAsync()
        {
            // Snippet: CreateSecondaryInstanceAsync(ClusterName, Instance, string, CallSettings)
            // Additional: CreateSecondaryInstanceAsync(ClusterName, Instance, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            Instance instance = new Instance();
            string instanceId = "";
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.CreateSecondaryInstanceAsync(parent, instance, instanceId);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateSecondaryInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateInstances</summary>
        public void BatchCreateInstancesRequestObject()
        {
            // Snippet: BatchCreateInstances(BatchCreateInstancesRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            BatchCreateInstancesRequest request = new BatchCreateInstancesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Requests = new CreateInstanceRequests(),
                RequestId = "",
            };
            // Make the request
            Operation<BatchCreateInstancesResponse, OperationMetadata> response = alloyDBAdminClient.BatchCreateInstances(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateInstancesResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchCreateInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateInstancesResponse, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceBatchCreateInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchCreateInstancesAsync</summary>
        public async Task BatchCreateInstancesRequestObjectAsync()
        {
            // Snippet: BatchCreateInstancesAsync(BatchCreateInstancesRequest, CallSettings)
            // Additional: BatchCreateInstancesAsync(BatchCreateInstancesRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateInstancesRequest request = new BatchCreateInstancesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Requests = new CreateInstanceRequests(),
                RequestId = "",
            };
            // Make the request
            Operation<BatchCreateInstancesResponse, OperationMetadata> response = await alloyDBAdminClient.BatchCreateInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchCreateInstancesResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchCreateInstancesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchCreateInstancesResponse, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceBatchCreateInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchCreateInstancesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstanceRequestObject()
        {
            // Snippet: UpdateInstance(UpdateInstanceRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.UpdateInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceRequestObjectAsync()
        {
            // Snippet: UpdateInstanceAsync(UpdateInstanceRequest, CallSettings)
            // Additional: UpdateInstanceAsync(UpdateInstanceRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInstanceRequest request = new UpdateInstanceRequest
            {
                UpdateMask = new FieldMask(),
                Instance = new Instance(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.UpdateInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstance</summary>
        public void UpdateInstance()
        {
            // Snippet: UpdateInstance(Instance, FieldMask, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.UpdateInstance(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpdateInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInstanceAsync</summary>
        public async Task UpdateInstanceAsync()
        {
            // Snippet: UpdateInstanceAsync(Instance, FieldMask, CallSettings)
            // Additional: UpdateInstanceAsync(Instance, FieldMask, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            Instance instance = new Instance();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.UpdateInstanceAsync(instance, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpdateInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceRequestObject()
        {
            // Snippet: DeleteInstance(DeleteInstanceRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceRequestObjectAsync()
        {
            // Snippet: DeleteInstanceAsync(DeleteInstanceRequest, CallSettings)
            // Additional: DeleteInstanceAsync(DeleteInstanceRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                Etag = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstance()
        {
            // Snippet: DeleteInstance(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceAsync()
        {
            // Snippet: DeleteInstanceAsync(string, CallSettings)
            // Additional: DeleteInstanceAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstance</summary>
        public void DeleteInstanceResourceNames()
        {
            // Snippet: DeleteInstance(InstanceName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInstanceAsync</summary>
        public async Task DeleteInstanceResourceNamesAsync()
        {
            // Snippet: DeleteInstanceAsync(InstanceName, CallSettings)
            // Additional: DeleteInstanceAsync(InstanceName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstanceRequestObject()
        {
            // Snippet: FailoverInstance(FailoverInstanceRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            FailoverInstanceRequest request = new FailoverInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.FailoverInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceRequestObjectAsync()
        {
            // Snippet: FailoverInstanceAsync(FailoverInstanceRequest, CallSettings)
            // Additional: FailoverInstanceAsync(FailoverInstanceRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            FailoverInstanceRequest request = new FailoverInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.FailoverInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceFailoverInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstance()
        {
            // Snippet: FailoverInstance(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.FailoverInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceAsync()
        {
            // Snippet: FailoverInstanceAsync(string, CallSettings)
            // Additional: FailoverInstanceAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.FailoverInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceFailoverInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstance</summary>
        public void FailoverInstanceResourceNames()
        {
            // Snippet: FailoverInstance(InstanceName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.FailoverInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceFailoverInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverInstanceAsync</summary>
        public async Task FailoverInstanceResourceNamesAsync()
        {
            // Snippet: FailoverInstanceAsync(InstanceName, CallSettings)
            // Additional: FailoverInstanceAsync(InstanceName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.FailoverInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceFailoverInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InjectFault</summary>
        public void InjectFaultRequestObject()
        {
            // Snippet: InjectFault(InjectFaultRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InjectFaultRequest request = new InjectFaultRequest
            {
                FaultType = InjectFaultRequest.Types.FaultType.Unspecified,
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.InjectFault(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceInjectFault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InjectFaultAsync</summary>
        public async Task InjectFaultRequestObjectAsync()
        {
            // Snippet: InjectFaultAsync(InjectFaultRequest, CallSettings)
            // Additional: InjectFaultAsync(InjectFaultRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InjectFaultRequest request = new InjectFaultRequest
            {
                FaultType = InjectFaultRequest.Types.FaultType.Unspecified,
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.InjectFaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceInjectFaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InjectFault</summary>
        public void InjectFault()
        {
            // Snippet: InjectFault(InjectFaultRequest.Types.FaultType, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InjectFaultRequest.Types.FaultType faultType = InjectFaultRequest.Types.FaultType.Unspecified;
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.InjectFault(faultType, name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceInjectFault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InjectFaultAsync</summary>
        public async Task InjectFaultAsync()
        {
            // Snippet: InjectFaultAsync(InjectFaultRequest.Types.FaultType, string, CallSettings)
            // Additional: InjectFaultAsync(InjectFaultRequest.Types.FaultType, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InjectFaultRequest.Types.FaultType faultType = InjectFaultRequest.Types.FaultType.Unspecified;
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.InjectFaultAsync(faultType, name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceInjectFaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InjectFault</summary>
        public void InjectFaultResourceNames()
        {
            // Snippet: InjectFault(InjectFaultRequest.Types.FaultType, InstanceName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InjectFaultRequest.Types.FaultType faultType = InjectFaultRequest.Types.FaultType.Unspecified;
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.InjectFault(faultType, name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceInjectFault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InjectFaultAsync</summary>
        public async Task InjectFaultResourceNamesAsync()
        {
            // Snippet: InjectFaultAsync(InjectFaultRequest.Types.FaultType, InstanceName, CallSettings)
            // Additional: InjectFaultAsync(InjectFaultRequest.Types.FaultType, InstanceName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InjectFaultRequest.Types.FaultType faultType = InjectFaultRequest.Types.FaultType.Unspecified;
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.InjectFaultAsync(faultType, name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceInjectFaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartInstance</summary>
        public void RestartInstanceRequestObject()
        {
            // Snippet: RestartInstance(RestartInstanceRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            RestartInstanceRequest request = new RestartInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                ValidateOnly = false,
                NodeIds = { "", },
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.RestartInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceRestartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartInstanceAsync</summary>
        public async Task RestartInstanceRequestObjectAsync()
        {
            // Snippet: RestartInstanceAsync(RestartInstanceRequest, CallSettings)
            // Additional: RestartInstanceAsync(RestartInstanceRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            RestartInstanceRequest request = new RestartInstanceRequest
            {
                InstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
                ValidateOnly = false,
                NodeIds = { "", },
            };
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.RestartInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceRestartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartInstance</summary>
        public void RestartInstance()
        {
            // Snippet: RestartInstance(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.RestartInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceRestartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartInstanceAsync</summary>
        public async Task RestartInstanceAsync()
        {
            // Snippet: RestartInstanceAsync(string, CallSettings)
            // Additional: RestartInstanceAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.RestartInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceRestartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartInstance</summary>
        public void RestartInstanceResourceNames()
        {
            // Snippet: RestartInstance(InstanceName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = alloyDBAdminClient.RestartInstance(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceRestartInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartInstanceAsync</summary>
        public async Task RestartInstanceResourceNamesAsync()
        {
            // Snippet: RestartInstanceAsync(InstanceName, CallSettings)
            // Additional: RestartInstanceAsync(InstanceName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName name = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            Operation<Instance, OperationMetadata> response = await alloyDBAdminClient.RestartInstanceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Instance, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Instance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Instance, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceRestartInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Instance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecuteSql</summary>
        public void ExecuteSqlRequestObject()
        {
            // Snippet: ExecuteSql(ExecuteSqlRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                Database = "",
                User = "",
                SqlStatement = "",
                Password = "",
            };
            // Make the request
            ExecuteSqlResponse response = alloyDBAdminClient.ExecuteSql(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSqlAsync</summary>
        public async Task ExecuteSqlRequestObjectAsync()
        {
            // Snippet: ExecuteSqlAsync(ExecuteSqlRequest, CallSettings)
            // Additional: ExecuteSqlAsync(ExecuteSqlRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                InstanceAsInstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                Database = "",
                User = "",
                SqlStatement = "",
                Password = "",
            };
            // Make the request
            ExecuteSqlResponse response = await alloyDBAdminClient.ExecuteSqlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSql</summary>
        public void ExecuteSql()
        {
            // Snippet: ExecuteSql(string, string, string, string, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            string database = "";
            string user = "";
            string sqlStatement = "";
            string password = "";
            // Make the request
            ExecuteSqlResponse response = alloyDBAdminClient.ExecuteSql(instance, database, user, sqlStatement, password);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSqlAsync</summary>
        public async Task ExecuteSqlAsync()
        {
            // Snippet: ExecuteSqlAsync(string, string, string, string, string, CallSettings)
            // Additional: ExecuteSqlAsync(string, string, string, string, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string instance = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            string database = "";
            string user = "";
            string sqlStatement = "";
            string password = "";
            // Make the request
            ExecuteSqlResponse response = await alloyDBAdminClient.ExecuteSqlAsync(instance, database, user, sqlStatement, password);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSql</summary>
        public void ExecuteSqlResourceNames()
        {
            // Snippet: ExecuteSql(InstanceName, string, string, string, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            string database = "";
            string user = "";
            string sqlStatement = "";
            string password = "";
            // Make the request
            ExecuteSqlResponse response = alloyDBAdminClient.ExecuteSql(instance, database, user, sqlStatement, password);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSqlAsync</summary>
        public async Task ExecuteSqlResourceNamesAsync()
        {
            // Snippet: ExecuteSqlAsync(InstanceName, string, string, string, string, CallSettings)
            // Additional: ExecuteSqlAsync(InstanceName, string, string, string, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName instance = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            string database = "";
            string user = "";
            string sqlStatement = "";
            string password = "";
            // Make the request
            ExecuteSqlResponse response = await alloyDBAdminClient.ExecuteSqlAsync(instance, database, user, sqlStatement, password);
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = alloyDBAdminClient.ListBackups(request);

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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = alloyDBAdminClient.ListBackupsAsync(request);

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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = alloyDBAdminClient.ListBackups(parent);

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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = alloyDBAdminClient.ListBackupsAsync(parent);

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
            // Snippet: ListBackups(LocationName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = alloyDBAdminClient.ListBackups(parent);

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
            // Snippet: ListBackupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = alloyDBAdminClient.ListBackupsAsync(parent);

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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            // Make the request
            Backup response = alloyDBAdminClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await alloyDBAdminClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Backup response = alloyDBAdminClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Backup response = await alloyDBAdminClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Backup response = alloyDBAdminClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Backup response = await alloyDBAdminClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupRequestObject()
        {
            // Snippet: CreateBackup(CreateBackupRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupId = "",
                Backup = new Backup(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = alloyDBAdminClient.CreateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupRequestObjectAsync()
        {
            // Snippet: CreateBackupAsync(CreateBackupRequest, CallSettings)
            // Additional: CreateBackupAsync(CreateBackupRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BackupId = "",
                Backup = new Backup(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await alloyDBAdminClient.CreateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackup()
        {
            // Snippet: CreateBackup(string, Backup, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = alloyDBAdminClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupAsync()
        {
            // Snippet: CreateBackupAsync(string, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(string, Backup, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await alloyDBAdminClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupResourceNames()
        {
            // Snippet: CreateBackup(LocationName, Backup, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = alloyDBAdminClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupResourceNamesAsync()
        {
            // Snippet: CreateBackupAsync(LocationName, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(LocationName, Backup, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, OperationMetadata> response = await alloyDBAdminClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackupRequestObject()
        {
            // Snippet: UpdateBackup(UpdateBackupRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = alloyDBAdminClient.UpdateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpdateBackup(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                UpdateMask = new FieldMask(),
                Backup = new Backup(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Backup, OperationMetadata> response = await alloyDBAdminClient.UpdateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpdateBackupAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = alloyDBAdminClient.UpdateBackup(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceUpdateBackup(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Backup, OperationMetadata> response = await alloyDBAdminClient.UpdateBackupAsync(backup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Backup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceUpdateBackupAsync(operationName);
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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupRequestObjectAsync()
        {
            // Snippet: DeleteBackupAsync(DeleteBackupRequest, CallSettings)
            // Additional: DeleteBackupAsync(DeleteBackupRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]"),
                RequestId = "",
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackup()
        {
            // Snippet: DeleteBackup(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupAsync()
        {
            // Snippet: DeleteBackupAsync(string, CallSettings)
            // Additional: DeleteBackupAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/backups/[BACKUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupResourceNames()
        {
            // Snippet: DeleteBackup(BackupName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = alloyDBAdminClient.DeleteBackup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = alloyDBAdminClient.PollOnceDeleteBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupResourceNamesAsync()
        {
            // Snippet: DeleteBackupAsync(BackupName, CallSettings)
            // Additional: DeleteBackupAsync(BackupName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectLocationBackup("[PROJECT]", "[LOCATION]", "[BACKUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await alloyDBAdminClient.DeleteBackupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await alloyDBAdminClient.PollOnceDeleteBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListSupportedDatabaseFlags</summary>
        public void ListSupportedDatabaseFlagsRequestObject()
        {
            // Snippet: ListSupportedDatabaseFlags(ListSupportedDatabaseFlagsRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ListSupportedDatabaseFlagsRequest request = new ListSupportedDatabaseFlagsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> response = alloyDBAdminClient.ListSupportedDatabaseFlags(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SupportedDatabaseFlag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSupportedDatabaseFlagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportedDatabaseFlag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportedDatabaseFlag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportedDatabaseFlag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportedDatabaseFlagsAsync</summary>
        public async Task ListSupportedDatabaseFlagsRequestObjectAsync()
        {
            // Snippet: ListSupportedDatabaseFlagsAsync(ListSupportedDatabaseFlagsRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListSupportedDatabaseFlagsRequest request = new ListSupportedDatabaseFlagsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> response = alloyDBAdminClient.ListSupportedDatabaseFlagsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SupportedDatabaseFlag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSupportedDatabaseFlagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportedDatabaseFlag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportedDatabaseFlag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportedDatabaseFlag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportedDatabaseFlags</summary>
        public void ListSupportedDatabaseFlags()
        {
            // Snippet: ListSupportedDatabaseFlags(string, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> response = alloyDBAdminClient.ListSupportedDatabaseFlags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SupportedDatabaseFlag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSupportedDatabaseFlagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportedDatabaseFlag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportedDatabaseFlag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportedDatabaseFlag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportedDatabaseFlagsAsync</summary>
        public async Task ListSupportedDatabaseFlagsAsync()
        {
            // Snippet: ListSupportedDatabaseFlagsAsync(string, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> response = alloyDBAdminClient.ListSupportedDatabaseFlagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SupportedDatabaseFlag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSupportedDatabaseFlagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportedDatabaseFlag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportedDatabaseFlag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportedDatabaseFlag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportedDatabaseFlags</summary>
        public void ListSupportedDatabaseFlagsResourceNames()
        {
            // Snippet: ListSupportedDatabaseFlags(LocationName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> response = alloyDBAdminClient.ListSupportedDatabaseFlags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SupportedDatabaseFlag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSupportedDatabaseFlagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportedDatabaseFlag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportedDatabaseFlag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportedDatabaseFlag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSupportedDatabaseFlagsAsync</summary>
        public async Task ListSupportedDatabaseFlagsResourceNamesAsync()
        {
            // Snippet: ListSupportedDatabaseFlagsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSupportedDatabaseFlagsResponse, SupportedDatabaseFlag> response = alloyDBAdminClient.ListSupportedDatabaseFlagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SupportedDatabaseFlag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSupportedDatabaseFlagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SupportedDatabaseFlag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SupportedDatabaseFlag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SupportedDatabaseFlag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GenerateClientCertificate</summary>
        public void GenerateClientCertificateRequestObject()
        {
            // Snippet: GenerateClientCertificate(GenerateClientCertificateRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            GenerateClientCertificateRequest request = new GenerateClientCertificateRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                CertDuration = new Duration(),
                PublicKey = "",
                UseMetadataExchange = false,
            };
            // Make the request
            GenerateClientCertificateResponse response = alloyDBAdminClient.GenerateClientCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateClientCertificateAsync</summary>
        public async Task GenerateClientCertificateRequestObjectAsync()
        {
            // Snippet: GenerateClientCertificateAsync(GenerateClientCertificateRequest, CallSettings)
            // Additional: GenerateClientCertificateAsync(GenerateClientCertificateRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            GenerateClientCertificateRequest request = new GenerateClientCertificateRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                RequestId = "",
                CertDuration = new Duration(),
                PublicKey = "",
                UseMetadataExchange = false,
            };
            // Make the request
            GenerateClientCertificateResponse response = await alloyDBAdminClient.GenerateClientCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateClientCertificate</summary>
        public void GenerateClientCertificate()
        {
            // Snippet: GenerateClientCertificate(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            GenerateClientCertificateResponse response = alloyDBAdminClient.GenerateClientCertificate(parent);
            // End snippet
        }

        /// <summary>Snippet for GenerateClientCertificateAsync</summary>
        public async Task GenerateClientCertificateAsync()
        {
            // Snippet: GenerateClientCertificateAsync(string, CallSettings)
            // Additional: GenerateClientCertificateAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            GenerateClientCertificateResponse response = await alloyDBAdminClient.GenerateClientCertificateAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GenerateClientCertificate</summary>
        public void GenerateClientCertificateResourceNames()
        {
            // Snippet: GenerateClientCertificate(ClusterName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            GenerateClientCertificateResponse response = alloyDBAdminClient.GenerateClientCertificate(parent);
            // End snippet
        }

        /// <summary>Snippet for GenerateClientCertificateAsync</summary>
        public async Task GenerateClientCertificateResourceNamesAsync()
        {
            // Snippet: GenerateClientCertificateAsync(ClusterName, CallSettings)
            // Additional: GenerateClientCertificateAsync(ClusterName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            GenerateClientCertificateResponse response = await alloyDBAdminClient.GenerateClientCertificateAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionInfo</summary>
        public void GetConnectionInfoRequestObject()
        {
            // Snippet: GetConnectionInfo(GetConnectionInfoRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            GetConnectionInfoRequest request = new GetConnectionInfoRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            ConnectionInfo response = alloyDBAdminClient.GetConnectionInfo(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionInfoAsync</summary>
        public async Task GetConnectionInfoRequestObjectAsync()
        {
            // Snippet: GetConnectionInfoAsync(GetConnectionInfoRequest, CallSettings)
            // Additional: GetConnectionInfoAsync(GetConnectionInfoRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetConnectionInfoRequest request = new GetConnectionInfoRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]"),
                RequestId = "",
            };
            // Make the request
            ConnectionInfo response = await alloyDBAdminClient.GetConnectionInfoAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionInfo</summary>
        public void GetConnectionInfo()
        {
            // Snippet: GetConnectionInfo(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            ConnectionInfo response = alloyDBAdminClient.GetConnectionInfo(parent);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionInfoAsync</summary>
        public async Task GetConnectionInfoAsync()
        {
            // Snippet: GetConnectionInfoAsync(string, CallSettings)
            // Additional: GetConnectionInfoAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/instances/[INSTANCE]";
            // Make the request
            ConnectionInfo response = await alloyDBAdminClient.GetConnectionInfoAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionInfo</summary>
        public void GetConnectionInfoResourceNames()
        {
            // Snippet: GetConnectionInfo(InstanceName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            ConnectionInfo response = alloyDBAdminClient.GetConnectionInfo(parent);
            // End snippet
        }

        /// <summary>Snippet for GetConnectionInfoAsync</summary>
        public async Task GetConnectionInfoResourceNamesAsync()
        {
            // Snippet: GetConnectionInfoAsync(InstanceName, CallSettings)
            // Additional: GetConnectionInfoAsync(InstanceName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationClusterInstance("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[INSTANCE]");
            // Make the request
            ConnectionInfo response = await alloyDBAdminClient.GetConnectionInfoAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListUsers</summary>
        public void ListUsersRequestObject()
        {
            // Snippet: ListUsers(ListUsersRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = alloyDBAdminClient.ListUsers(request);

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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListUsersRequest request = new ListUsersRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = alloyDBAdminClient.ListUsersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((User item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = alloyDBAdminClient.ListUsers(parent);

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
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = alloyDBAdminClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((User item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            // Snippet: ListUsers(ClusterName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListUsersResponse, User> response = alloyDBAdminClient.ListUsers(parent);

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
            // Snippet: ListUsersAsync(ClusterName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListUsersResponse, User> response = alloyDBAdminClient.ListUsersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((User item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (User item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]"),
            };
            // Make the request
            User response = alloyDBAdminClient.GetUser(request);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserRequestObjectAsync()
        {
            // Snippet: GetUserAsync(GetUserRequest, CallSettings)
            // Additional: GetUserAsync(GetUserRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetUserRequest request = new GetUserRequest
            {
                UserName = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]"),
            };
            // Make the request
            User response = await alloyDBAdminClient.GetUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUser()
        {
            // Snippet: GetUser(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/users/[USER]";
            // Make the request
            User response = alloyDBAdminClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserAsync()
        {
            // Snippet: GetUserAsync(string, CallSettings)
            // Additional: GetUserAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/users/[USER]";
            // Make the request
            User response = await alloyDBAdminClient.GetUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetUser</summary>
        public void GetUserResourceNames()
        {
            // Snippet: GetUser(UserName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]");
            // Make the request
            User response = alloyDBAdminClient.GetUser(name);
            // End snippet
        }

        /// <summary>Snippet for GetUserAsync</summary>
        public async Task GetUserResourceNamesAsync()
        {
            // Snippet: GetUserAsync(UserName, CallSettings)
            // Additional: GetUserAsync(UserName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]");
            // Make the request
            User response = await alloyDBAdminClient.GetUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserRequestObject()
        {
            // Snippet: CreateUser(CreateUserRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            CreateUserRequest request = new CreateUserRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                UserId = "",
                User = new User(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            User response = alloyDBAdminClient.CreateUser(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserRequestObjectAsync()
        {
            // Snippet: CreateUserAsync(CreateUserRequest, CallSettings)
            // Additional: CreateUserAsync(CreateUserRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateUserRequest request = new CreateUserRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                UserId = "",
                User = new User(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            User response = await alloyDBAdminClient.CreateUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUser()
        {
            // Snippet: CreateUser(string, User, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            User user = new User();
            string userId = "";
            // Make the request
            User response = alloyDBAdminClient.CreateUser(parent, user, userId);
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserAsync()
        {
            // Snippet: CreateUserAsync(string, User, string, CallSettings)
            // Additional: CreateUserAsync(string, User, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            User user = new User();
            string userId = "";
            // Make the request
            User response = await alloyDBAdminClient.CreateUserAsync(parent, user, userId);
            // End snippet
        }

        /// <summary>Snippet for CreateUser</summary>
        public void CreateUserResourceNames()
        {
            // Snippet: CreateUser(ClusterName, User, string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            User user = new User();
            string userId = "";
            // Make the request
            User response = alloyDBAdminClient.CreateUser(parent, user, userId);
            // End snippet
        }

        /// <summary>Snippet for CreateUserAsync</summary>
        public async Task CreateUserResourceNamesAsync()
        {
            // Snippet: CreateUserAsync(ClusterName, User, string, CallSettings)
            // Additional: CreateUserAsync(ClusterName, User, string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            User user = new User();
            string userId = "";
            // Make the request
            User response = await alloyDBAdminClient.CreateUserAsync(parent, user, userId);
            // End snippet
        }

        /// <summary>Snippet for UpdateUser</summary>
        public void UpdateUserRequestObject()
        {
            // Snippet: UpdateUser(UpdateUserRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            UpdateUserRequest request = new UpdateUserRequest
            {
                UpdateMask = new FieldMask(),
                User = new User(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            User response = alloyDBAdminClient.UpdateUser(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserAsync</summary>
        public async Task UpdateUserRequestObjectAsync()
        {
            // Snippet: UpdateUserAsync(UpdateUserRequest, CallSettings)
            // Additional: UpdateUserAsync(UpdateUserRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateUserRequest request = new UpdateUserRequest
            {
                UpdateMask = new FieldMask(),
                User = new User(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            User response = await alloyDBAdminClient.UpdateUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateUser</summary>
        public void UpdateUser()
        {
            // Snippet: UpdateUser(User, FieldMask, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            User user = new User();
            FieldMask updateMask = new FieldMask();
            // Make the request
            User response = alloyDBAdminClient.UpdateUser(user, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateUserAsync</summary>
        public async Task UpdateUserAsync()
        {
            // Snippet: UpdateUserAsync(User, FieldMask, CallSettings)
            // Additional: UpdateUserAsync(User, FieldMask, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            User user = new User();
            FieldMask updateMask = new FieldMask();
            // Make the request
            User response = await alloyDBAdminClient.UpdateUserAsync(user, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUserRequestObject()
        {
            // Snippet: DeleteUser(DeleteUserRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            alloyDBAdminClient.DeleteUser(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserRequestObjectAsync()
        {
            // Snippet: DeleteUserAsync(DeleteUserRequest, CallSettings)
            // Additional: DeleteUserAsync(DeleteUserRequest, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteUserRequest request = new DeleteUserRequest
            {
                UserName = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            await alloyDBAdminClient.DeleteUserAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUser()
        {
            // Snippet: DeleteUser(string, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/users/[USER]";
            // Make the request
            alloyDBAdminClient.DeleteUser(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserAsync()
        {
            // Snippet: DeleteUserAsync(string, CallSettings)
            // Additional: DeleteUserAsync(string, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]/users/[USER]";
            // Make the request
            await alloyDBAdminClient.DeleteUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUser</summary>
        public void DeleteUserResourceNames()
        {
            // Snippet: DeleteUser(UserName, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]");
            // Make the request
            alloyDBAdminClient.DeleteUser(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteUserAsync</summary>
        public async Task DeleteUserResourceNamesAsync()
        {
            // Snippet: DeleteUserAsync(UserName, CallSettings)
            // Additional: DeleteUserAsync(UserName, CancellationToken)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            UserName name = UserName.FromProjectLocationClusterUser("[PROJECT]", "[LOCATION]", "[CLUSTER]", "[USER]");
            // Make the request
            await alloyDBAdminClient.DeleteUserAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesRequestObject()
        {
            // Snippet: ListDatabases(ListDatabasesRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = alloyDBAdminClient.ListDatabases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesRequestObjectAsync()
        {
            // Snippet: ListDatabasesAsync(ListDatabasesRequest, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsClusterName = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = alloyDBAdminClient.ListDatabasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabases()
        {
            // Snippet: ListDatabases(string, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = alloyDBAdminClient.ListDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesAsync()
        {
            // Snippet: ListDatabasesAsync(string, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = alloyDBAdminClient.ListDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesResourceNames()
        {
            // Snippet: ListDatabases(ClusterName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = AlloyDBAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = alloyDBAdminClient.ListDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesResourceNamesAsync()
        {
            // Snippet: ListDatabasesAsync(ClusterName, string, int?, CallSettings)
            // Create client
            AlloyDBAdminClient alloyDBAdminClient = await AlloyDBAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectLocationCluster("[PROJECT]", "[LOCATION]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = alloyDBAdminClient.ListDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
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
