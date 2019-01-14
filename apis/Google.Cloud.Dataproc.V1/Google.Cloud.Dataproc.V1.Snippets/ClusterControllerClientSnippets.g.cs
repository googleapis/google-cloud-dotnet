// Copyright 2019 Google LLC
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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedClusterControllerClientSnippets
    {
        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync()
        {
            // Snippet: CreateClusterAsync(string,string,Cluster,CallSettings)
            // Additional: CreateClusterAsync(string,string,Cluster,CancellationToken)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                await clusterControllerClient.CreateClusterAsync(projectId, region, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                await clusterControllerClient.PollOnceCreateClusterAsync(operationName);
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
            // Snippet: CreateCluster(string,string,Cluster,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            Cluster cluster = new Cluster();
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                clusterControllerClient.CreateCluster(projectId, region, cluster);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                clusterControllerClient.PollOnceCreateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClusterAsync</summary>
        public async Task CreateClusterAsync_RequestObject()
        {
            // Snippet: CreateClusterAsync(CreateClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "",
                Region = "",
                Cluster = new Cluster(),
            };
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                await clusterControllerClient.CreateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                await clusterControllerClient.PollOnceCreateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCluster</summary>
        public void CreateCluster_RequestObject()
        {
            // Snippet: CreateCluster(CreateClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            CreateClusterRequest request = new CreateClusterRequest
            {
                ProjectId = "",
                Region = "",
                Cluster = new Cluster(),
            };
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                clusterControllerClient.CreateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                clusterControllerClient.PollOnceCreateCluster(operationName);
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
            // Snippet: UpdateClusterAsync(string,string,string,Cluster,FieldMask,CallSettings)
            // Additional: UpdateClusterAsync(string,string,string,Cluster,FieldMask,CancellationToken)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                await clusterControllerClient.UpdateClusterAsync(projectId, region, clusterName, cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                await clusterControllerClient.PollOnceUpdateClusterAsync(operationName);
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
            // Snippet: UpdateCluster(string,string,string,Cluster,FieldMask,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            Cluster cluster = new Cluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                clusterControllerClient.UpdateCluster(projectId, region, clusterName, cluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                clusterControllerClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClusterAsync</summary>
        public async Task UpdateClusterAsync_RequestObject()
        {
            // Snippet: UpdateClusterAsync(UpdateClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
                Cluster = new Cluster(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                await clusterControllerClient.UpdateClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                await clusterControllerClient.PollOnceUpdateClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateCluster</summary>
        public void UpdateCluster_RequestObject()
        {
            // Snippet: UpdateCluster(UpdateClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            UpdateClusterRequest request = new UpdateClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
                Cluster = new Cluster(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Cluster, ClusterOperationMetadata> response =
                clusterControllerClient.UpdateCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, ClusterOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, ClusterOperationMetadata> retrievedResponse =
                clusterControllerClient.PollOnceUpdateCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync()
        {
            // Snippet: DeleteClusterAsync(string,string,string,CallSettings)
            // Additional: DeleteClusterAsync(string,string,string,CancellationToken)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            // Make the request
            Operation<Empty, ClusterOperationMetadata> response =
                await clusterControllerClient.DeleteClusterAsync(projectId, region, clusterName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClusterOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClusterOperationMetadata> retrievedResponse =
                await clusterControllerClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster()
        {
            // Snippet: DeleteCluster(string,string,string,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            // Make the request
            Operation<Empty, ClusterOperationMetadata> response =
                clusterControllerClient.DeleteCluster(projectId, region, clusterName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClusterOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClusterOperationMetadata> retrievedResponse =
                clusterControllerClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClusterAsync</summary>
        public async Task DeleteClusterAsync_RequestObject()
        {
            // Snippet: DeleteClusterAsync(DeleteClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
            };
            // Make the request
            Operation<Empty, ClusterOperationMetadata> response =
                await clusterControllerClient.DeleteClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClusterOperationMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClusterOperationMetadata> retrievedResponse =
                await clusterControllerClient.PollOnceDeleteClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCluster</summary>
        public void DeleteCluster_RequestObject()
        {
            // Snippet: DeleteCluster(DeleteClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            DeleteClusterRequest request = new DeleteClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
            };
            // Make the request
            Operation<Empty, ClusterOperationMetadata> response =
                clusterControllerClient.DeleteCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClusterOperationMetadata> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClusterOperationMetadata> retrievedResponse =
                clusterControllerClient.PollOnceDeleteCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync()
        {
            // Snippet: GetClusterAsync(string,string,string,CallSettings)
            // Additional: GetClusterAsync(string,string,string,CancellationToken)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            // Make the request
            Cluster response = await clusterControllerClient.GetClusterAsync(projectId, region, clusterName);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster()
        {
            // Snippet: GetCluster(string,string,string,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            // Make the request
            Cluster response = clusterControllerClient.GetCluster(projectId, region, clusterName);
            // End snippet
        }

        /// <summary>Snippet for GetClusterAsync</summary>
        public async Task GetClusterAsync_RequestObject()
        {
            // Snippet: GetClusterAsync(GetClusterRequest,CallSettings)
            // Additional: GetClusterAsync(GetClusterRequest,CancellationToken)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
            };
            // Make the request
            Cluster response = await clusterControllerClient.GetClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCluster</summary>
        public void GetCluster_RequestObject()
        {
            // Snippet: GetCluster(GetClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            GetClusterRequest request = new GetClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
            };
            // Make the request
            Cluster response = clusterControllerClient.GetCluster(request);
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync1()
        {
            // Snippet: ListClustersAsync(string,string,string,int?,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response =
                clusterControllerClient.ListClustersAsync(projectId, region);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters1()
        {
            // Snippet: ListClusters(string,string,string,int?,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response =
                clusterControllerClient.ListClusters(projectId, region);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync2()
        {
            // Snippet: ListClustersAsync(string,string,string,string,int?,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response =
                clusterControllerClient.ListClustersAsync(projectId: projectId, region: region, filter: filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters2()
        {
            // Snippet: ListClusters(string,string,string,string,int?,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string filter = "";
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response =
                clusterControllerClient.ListClusters(projectId: projectId, region: region, filter: filter);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClustersAsync</summary>
        public async Task ListClustersAsync_RequestObject()
        {
            // Snippet: ListClustersAsync(ListClustersRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "",
                Region = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListClustersResponse, Cluster> response =
                clusterControllerClient.ListClustersAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClusters</summary>
        public void ListClusters_RequestObject()
        {
            // Snippet: ListClusters(ListClustersRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            ListClustersRequest request = new ListClustersRequest
            {
                ProjectId = "",
                Region = "",
            };
            // Make the request
            PagedEnumerable<ListClustersResponse, Cluster> response =
                clusterControllerClient.ListClusters(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DiagnoseClusterAsync</summary>
        public async Task DiagnoseClusterAsync()
        {
            // Snippet: DiagnoseClusterAsync(string,string,string,CallSettings)
            // Additional: DiagnoseClusterAsync(string,string,string,CancellationToken)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            // Make the request
            Operation<Empty, DiagnoseClusterResults> response =
                await clusterControllerClient.DiagnoseClusterAsync(projectId, region, clusterName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DiagnoseClusterResults> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DiagnoseClusterResults> retrievedResponse =
                await clusterControllerClient.PollOnceDiagnoseClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseCluster</summary>
        public void DiagnoseCluster()
        {
            // Snippet: DiagnoseCluster(string,string,string,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            // Make the request
            Operation<Empty, DiagnoseClusterResults> response =
                clusterControllerClient.DiagnoseCluster(projectId, region, clusterName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DiagnoseClusterResults> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DiagnoseClusterResults> retrievedResponse =
                clusterControllerClient.PollOnceDiagnoseCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseClusterAsync</summary>
        public async Task DiagnoseClusterAsync_RequestObject()
        {
            // Snippet: DiagnoseClusterAsync(DiagnoseClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = await ClusterControllerClient.CreateAsync();
            // Initialize request argument(s)
            DiagnoseClusterRequest request = new DiagnoseClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
            };
            // Make the request
            Operation<Empty, DiagnoseClusterResults> response =
                await clusterControllerClient.DiagnoseClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DiagnoseClusterResults> completedResponse =
                await response.PollUntilCompletedAsync();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DiagnoseClusterResults> retrievedResponse =
                await clusterControllerClient.PollOnceDiagnoseClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

        /// <summary>Snippet for DiagnoseCluster</summary>
        public void DiagnoseCluster_RequestObject()
        {
            // Snippet: DiagnoseCluster(DiagnoseClusterRequest,CallSettings)
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            DiagnoseClusterRequest request = new DiagnoseClusterRequest
            {
                ProjectId = "",
                Region = "",
                ClusterName = "",
            };
            // Make the request
            Operation<Empty, DiagnoseClusterResults> response =
                clusterControllerClient.DiagnoseCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DiagnoseClusterResults> completedResponse =
                response.PollUntilCompleted();
            // The long-running operation is now complete.

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DiagnoseClusterResults> retrievedResponse =
                clusterControllerClient.PollOnceDiagnoseCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // The long-running operation is now complete.
            }
            // End snippet
        }

    }
}
