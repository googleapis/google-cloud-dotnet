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
    using Google.Cloud.Workstations.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedWorkstationsClientSnippets
    {
        /// <summary>Snippet for GetWorkstationCluster</summary>
        public void GetWorkstationClusterRequestObject()
        {
            // Snippet: GetWorkstationCluster(GetWorkstationClusterRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            GetWorkstationClusterRequest request = new GetWorkstationClusterRequest
            {
                WorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
            };
            // Make the request
            WorkstationCluster response = workstationsClient.GetWorkstationCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationClusterAsync</summary>
        public async Task GetWorkstationClusterRequestObjectAsync()
        {
            // Snippet: GetWorkstationClusterAsync(GetWorkstationClusterRequest, CallSettings)
            // Additional: GetWorkstationClusterAsync(GetWorkstationClusterRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkstationClusterRequest request = new GetWorkstationClusterRequest
            {
                WorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
            };
            // Make the request
            WorkstationCluster response = await workstationsClient.GetWorkstationClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationCluster</summary>
        public void GetWorkstationCluster()
        {
            // Snippet: GetWorkstationCluster(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            WorkstationCluster response = workstationsClient.GetWorkstationCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationClusterAsync</summary>
        public async Task GetWorkstationClusterAsync()
        {
            // Snippet: GetWorkstationClusterAsync(string, CallSettings)
            // Additional: GetWorkstationClusterAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            WorkstationCluster response = await workstationsClient.GetWorkstationClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationCluster</summary>
        public void GetWorkstationClusterResourceNames()
        {
            // Snippet: GetWorkstationCluster(WorkstationClusterName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationClusterName name = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            WorkstationCluster response = workstationsClient.GetWorkstationCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationClusterAsync</summary>
        public async Task GetWorkstationClusterResourceNamesAsync()
        {
            // Snippet: GetWorkstationClusterAsync(WorkstationClusterName, CallSettings)
            // Additional: GetWorkstationClusterAsync(WorkstationClusterName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationClusterName name = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            WorkstationCluster response = await workstationsClient.GetWorkstationClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationClusters</summary>
        public void ListWorkstationClustersRequestObject()
        {
            // Snippet: ListWorkstationClusters(ListWorkstationClustersRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            ListWorkstationClustersRequest request = new ListWorkstationClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListWorkstationClustersResponse, WorkstationCluster> response = workstationsClient.ListWorkstationClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationClustersAsync</summary>
        public async Task ListWorkstationClustersRequestObjectAsync()
        {
            // Snippet: ListWorkstationClustersAsync(ListWorkstationClustersRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkstationClustersRequest request = new ListWorkstationClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkstationClustersResponse, WorkstationCluster> response = workstationsClient.ListWorkstationClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationClusters</summary>
        public void ListWorkstationClusters()
        {
            // Snippet: ListWorkstationClusters(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListWorkstationClustersResponse, WorkstationCluster> response = workstationsClient.ListWorkstationClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationClustersAsync</summary>
        public async Task ListWorkstationClustersAsync()
        {
            // Snippet: ListWorkstationClustersAsync(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListWorkstationClustersResponse, WorkstationCluster> response = workstationsClient.ListWorkstationClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationClusters</summary>
        public void ListWorkstationClustersResourceNames()
        {
            // Snippet: ListWorkstationClusters(LocationName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListWorkstationClustersResponse, WorkstationCluster> response = workstationsClient.ListWorkstationClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationClustersAsync</summary>
        public async Task ListWorkstationClustersResourceNamesAsync()
        {
            // Snippet: ListWorkstationClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListWorkstationClustersResponse, WorkstationCluster> response = workstationsClient.ListWorkstationClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationCluster</summary>
        public void CreateWorkstationClusterRequestObject()
        {
            // Snippet: CreateWorkstationCluster(CreateWorkstationClusterRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            CreateWorkstationClusterRequest request = new CreateWorkstationClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                WorkstationClusterId = "",
                WorkstationCluster = new WorkstationCluster(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.CreateWorkstationCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationClusterAsync</summary>
        public async Task CreateWorkstationClusterRequestObjectAsync()
        {
            // Snippet: CreateWorkstationClusterAsync(CreateWorkstationClusterRequest, CallSettings)
            // Additional: CreateWorkstationClusterAsync(CreateWorkstationClusterRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkstationClusterRequest request = new CreateWorkstationClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                WorkstationClusterId = "",
                WorkstationCluster = new WorkstationCluster(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.CreateWorkstationClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationCluster</summary>
        public void CreateWorkstationCluster()
        {
            // Snippet: CreateWorkstationCluster(string, WorkstationCluster, string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            WorkstationCluster workstationCluster = new WorkstationCluster();
            string workstationClusterId = "";
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.CreateWorkstationCluster(parent, workstationCluster, workstationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationClusterAsync</summary>
        public async Task CreateWorkstationClusterAsync()
        {
            // Snippet: CreateWorkstationClusterAsync(string, WorkstationCluster, string, CallSettings)
            // Additional: CreateWorkstationClusterAsync(string, WorkstationCluster, string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            WorkstationCluster workstationCluster = new WorkstationCluster();
            string workstationClusterId = "";
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.CreateWorkstationClusterAsync(parent, workstationCluster, workstationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationCluster</summary>
        public void CreateWorkstationClusterResourceNames()
        {
            // Snippet: CreateWorkstationCluster(LocationName, WorkstationCluster, string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            WorkstationCluster workstationCluster = new WorkstationCluster();
            string workstationClusterId = "";
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.CreateWorkstationCluster(parent, workstationCluster, workstationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationClusterAsync</summary>
        public async Task CreateWorkstationClusterResourceNamesAsync()
        {
            // Snippet: CreateWorkstationClusterAsync(LocationName, WorkstationCluster, string, CallSettings)
            // Additional: CreateWorkstationClusterAsync(LocationName, WorkstationCluster, string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            WorkstationCluster workstationCluster = new WorkstationCluster();
            string workstationClusterId = "";
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.CreateWorkstationClusterAsync(parent, workstationCluster, workstationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationCluster</summary>
        public void UpdateWorkstationClusterRequestObject()
        {
            // Snippet: UpdateWorkstationCluster(UpdateWorkstationClusterRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            UpdateWorkstationClusterRequest request = new UpdateWorkstationClusterRequest
            {
                WorkstationCluster = new WorkstationCluster(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.UpdateWorkstationCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceUpdateWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationClusterAsync</summary>
        public async Task UpdateWorkstationClusterRequestObjectAsync()
        {
            // Snippet: UpdateWorkstationClusterAsync(UpdateWorkstationClusterRequest, CallSettings)
            // Additional: UpdateWorkstationClusterAsync(UpdateWorkstationClusterRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkstationClusterRequest request = new UpdateWorkstationClusterRequest
            {
                WorkstationCluster = new WorkstationCluster(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.UpdateWorkstationClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceUpdateWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationCluster</summary>
        public void UpdateWorkstationCluster()
        {
            // Snippet: UpdateWorkstationCluster(WorkstationCluster, FieldMask, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationCluster workstationCluster = new WorkstationCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.UpdateWorkstationCluster(workstationCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceUpdateWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationClusterAsync</summary>
        public async Task UpdateWorkstationClusterAsync()
        {
            // Snippet: UpdateWorkstationClusterAsync(WorkstationCluster, FieldMask, CallSettings)
            // Additional: UpdateWorkstationClusterAsync(WorkstationCluster, FieldMask, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationCluster workstationCluster = new WorkstationCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.UpdateWorkstationClusterAsync(workstationCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceUpdateWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationCluster</summary>
        public void DeleteWorkstationClusterRequestObject()
        {
            // Snippet: DeleteWorkstationCluster(DeleteWorkstationClusterRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            DeleteWorkstationClusterRequest request = new DeleteWorkstationClusterRequest
            {
                WorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.DeleteWorkstationCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationClusterAsync</summary>
        public async Task DeleteWorkstationClusterRequestObjectAsync()
        {
            // Snippet: DeleteWorkstationClusterAsync(DeleteWorkstationClusterRequest, CallSettings)
            // Additional: DeleteWorkstationClusterAsync(DeleteWorkstationClusterRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkstationClusterRequest request = new DeleteWorkstationClusterRequest
            {
                WorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.DeleteWorkstationClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationCluster</summary>
        public void DeleteWorkstationCluster()
        {
            // Snippet: DeleteWorkstationCluster(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.DeleteWorkstationCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationClusterAsync</summary>
        public async Task DeleteWorkstationClusterAsync()
        {
            // Snippet: DeleteWorkstationClusterAsync(string, CallSettings)
            // Additional: DeleteWorkstationClusterAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.DeleteWorkstationClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationCluster</summary>
        public void DeleteWorkstationClusterResourceNames()
        {
            // Snippet: DeleteWorkstationCluster(WorkstationClusterName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationClusterName name = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = workstationsClient.DeleteWorkstationCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationClusterAsync</summary>
        public async Task DeleteWorkstationClusterResourceNamesAsync()
        {
            // Snippet: DeleteWorkstationClusterAsync(WorkstationClusterName, CallSettings)
            // Additional: DeleteWorkstationClusterAsync(WorkstationClusterName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationClusterName name = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            Operation<WorkstationCluster, OperationMetadata> response = await workstationsClient.DeleteWorkstationClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationCluster, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationConfig</summary>
        public void GetWorkstationConfigRequestObject()
        {
            // Snippet: GetWorkstationConfig(GetWorkstationConfigRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            GetWorkstationConfigRequest request = new GetWorkstationConfigRequest
            {
                WorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
            };
            // Make the request
            WorkstationConfig response = workstationsClient.GetWorkstationConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationConfigAsync</summary>
        public async Task GetWorkstationConfigRequestObjectAsync()
        {
            // Snippet: GetWorkstationConfigAsync(GetWorkstationConfigRequest, CallSettings)
            // Additional: GetWorkstationConfigAsync(GetWorkstationConfigRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkstationConfigRequest request = new GetWorkstationConfigRequest
            {
                WorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
            };
            // Make the request
            WorkstationConfig response = await workstationsClient.GetWorkstationConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationConfig</summary>
        public void GetWorkstationConfig()
        {
            // Snippet: GetWorkstationConfig(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            WorkstationConfig response = workstationsClient.GetWorkstationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationConfigAsync</summary>
        public async Task GetWorkstationConfigAsync()
        {
            // Snippet: GetWorkstationConfigAsync(string, CallSettings)
            // Additional: GetWorkstationConfigAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            WorkstationConfig response = await workstationsClient.GetWorkstationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationConfig</summary>
        public void GetWorkstationConfigResourceNames()
        {
            // Snippet: GetWorkstationConfig(WorkstationConfigName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationConfigName name = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            WorkstationConfig response = workstationsClient.GetWorkstationConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationConfigAsync</summary>
        public async Task GetWorkstationConfigResourceNamesAsync()
        {
            // Snippet: GetWorkstationConfigAsync(WorkstationConfigName, CallSettings)
            // Additional: GetWorkstationConfigAsync(WorkstationConfigName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationConfigName name = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            WorkstationConfig response = await workstationsClient.GetWorkstationConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationConfigs</summary>
        public void ListWorkstationConfigsRequestObject()
        {
            // Snippet: ListWorkstationConfigs(ListWorkstationConfigsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            ListWorkstationConfigsRequest request = new ListWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListWorkstationConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationConfigsAsync</summary>
        public async Task ListWorkstationConfigsRequestObjectAsync()
        {
            // Snippet: ListWorkstationConfigsAsync(ListWorkstationConfigsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkstationConfigsRequest request = new ListWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListWorkstationConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationConfigs</summary>
        public void ListWorkstationConfigs()
        {
            // Snippet: ListWorkstationConfigs(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            PagedEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListWorkstationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationConfigsAsync</summary>
        public async Task ListWorkstationConfigsAsync()
        {
            // Snippet: ListWorkstationConfigsAsync(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListWorkstationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationConfigs</summary>
        public void ListWorkstationConfigsResourceNames()
        {
            // Snippet: ListWorkstationConfigs(WorkstationClusterName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationClusterName parent = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            PagedEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListWorkstationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationConfigsAsync</summary>
        public async Task ListWorkstationConfigsResourceNamesAsync()
        {
            // Snippet: ListWorkstationConfigsAsync(WorkstationClusterName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationClusterName parent = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListWorkstationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationConfigs</summary>
        public void ListUsableWorkstationConfigsRequestObject()
        {
            // Snippet: ListUsableWorkstationConfigs(ListUsableWorkstationConfigsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            ListUsableWorkstationConfigsRequest request = new ListUsableWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListUsableWorkstationConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableWorkstationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationConfigsAsync</summary>
        public async Task ListUsableWorkstationConfigsRequestObjectAsync()
        {
            // Snippet: ListUsableWorkstationConfigsAsync(ListUsableWorkstationConfigsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableWorkstationConfigsRequest request = new ListUsableWorkstationConfigsRequest
            {
                ParentAsWorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListUsableWorkstationConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableWorkstationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationConfigs</summary>
        public void ListUsableWorkstationConfigs()
        {
            // Snippet: ListUsableWorkstationConfigs(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            PagedEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListUsableWorkstationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableWorkstationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationConfigsAsync</summary>
        public async Task ListUsableWorkstationConfigsAsync()
        {
            // Snippet: ListUsableWorkstationConfigsAsync(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListUsableWorkstationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableWorkstationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationConfigs</summary>
        public void ListUsableWorkstationConfigsResourceNames()
        {
            // Snippet: ListUsableWorkstationConfigs(WorkstationClusterName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationClusterName parent = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            PagedEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListUsableWorkstationConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (WorkstationConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableWorkstationConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationConfigsAsync</summary>
        public async Task ListUsableWorkstationConfigsResourceNamesAsync()
        {
            // Snippet: ListUsableWorkstationConfigsAsync(WorkstationClusterName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationClusterName parent = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListUsableWorkstationConfigsResponse, WorkstationConfig> response = workstationsClient.ListUsableWorkstationConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((WorkstationConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableWorkstationConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (WorkstationConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<WorkstationConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (WorkstationConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationConfig</summary>
        public void CreateWorkstationConfigRequestObject()
        {
            // Snippet: CreateWorkstationConfig(CreateWorkstationConfigRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            CreateWorkstationConfigRequest request = new CreateWorkstationConfigRequest
            {
                ParentAsWorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
                WorkstationConfigId = "",
                WorkstationConfig = new WorkstationConfig(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.CreateWorkstationConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationConfigAsync</summary>
        public async Task CreateWorkstationConfigRequestObjectAsync()
        {
            // Snippet: CreateWorkstationConfigAsync(CreateWorkstationConfigRequest, CallSettings)
            // Additional: CreateWorkstationConfigAsync(CreateWorkstationConfigRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkstationConfigRequest request = new CreateWorkstationConfigRequest
            {
                ParentAsWorkstationClusterName = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]"),
                WorkstationConfigId = "",
                WorkstationConfig = new WorkstationConfig(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.CreateWorkstationConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationConfig</summary>
        public void CreateWorkstationConfig()
        {
            // Snippet: CreateWorkstationConfig(string, WorkstationConfig, string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            WorkstationConfig workstationConfig = new WorkstationConfig();
            string workstationConfigId = "";
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.CreateWorkstationConfig(parent, workstationConfig, workstationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationConfigAsync</summary>
        public async Task CreateWorkstationConfigAsync()
        {
            // Snippet: CreateWorkstationConfigAsync(string, WorkstationConfig, string, CallSettings)
            // Additional: CreateWorkstationConfigAsync(string, WorkstationConfig, string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]";
            WorkstationConfig workstationConfig = new WorkstationConfig();
            string workstationConfigId = "";
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.CreateWorkstationConfigAsync(parent, workstationConfig, workstationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationConfig</summary>
        public void CreateWorkstationConfigResourceNames()
        {
            // Snippet: CreateWorkstationConfig(WorkstationClusterName, WorkstationConfig, string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationClusterName parent = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            WorkstationConfig workstationConfig = new WorkstationConfig();
            string workstationConfigId = "";
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.CreateWorkstationConfig(parent, workstationConfig, workstationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationConfigAsync</summary>
        public async Task CreateWorkstationConfigResourceNamesAsync()
        {
            // Snippet: CreateWorkstationConfigAsync(WorkstationClusterName, WorkstationConfig, string, CallSettings)
            // Additional: CreateWorkstationConfigAsync(WorkstationClusterName, WorkstationConfig, string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationClusterName parent = WorkstationClusterName.FromProjectLocationWorkstationCluster("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]");
            WorkstationConfig workstationConfig = new WorkstationConfig();
            string workstationConfigId = "";
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.CreateWorkstationConfigAsync(parent, workstationConfig, workstationConfigId);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationConfig</summary>
        public void UpdateWorkstationConfigRequestObject()
        {
            // Snippet: UpdateWorkstationConfig(UpdateWorkstationConfigRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            UpdateWorkstationConfigRequest request = new UpdateWorkstationConfigRequest
            {
                WorkstationConfig = new WorkstationConfig(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.UpdateWorkstationConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceUpdateWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationConfigAsync</summary>
        public async Task UpdateWorkstationConfigRequestObjectAsync()
        {
            // Snippet: UpdateWorkstationConfigAsync(UpdateWorkstationConfigRequest, CallSettings)
            // Additional: UpdateWorkstationConfigAsync(UpdateWorkstationConfigRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkstationConfigRequest request = new UpdateWorkstationConfigRequest
            {
                WorkstationConfig = new WorkstationConfig(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.UpdateWorkstationConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceUpdateWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationConfig</summary>
        public void UpdateWorkstationConfig()
        {
            // Snippet: UpdateWorkstationConfig(WorkstationConfig, FieldMask, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationConfig workstationConfig = new WorkstationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.UpdateWorkstationConfig(workstationConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceUpdateWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationConfigAsync</summary>
        public async Task UpdateWorkstationConfigAsync()
        {
            // Snippet: UpdateWorkstationConfigAsync(WorkstationConfig, FieldMask, CallSettings)
            // Additional: UpdateWorkstationConfigAsync(WorkstationConfig, FieldMask, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationConfig workstationConfig = new WorkstationConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.UpdateWorkstationConfigAsync(workstationConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceUpdateWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationConfig</summary>
        public void DeleteWorkstationConfigRequestObject()
        {
            // Snippet: DeleteWorkstationConfig(DeleteWorkstationConfigRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            DeleteWorkstationConfigRequest request = new DeleteWorkstationConfigRequest
            {
                WorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.DeleteWorkstationConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationConfigAsync</summary>
        public async Task DeleteWorkstationConfigRequestObjectAsync()
        {
            // Snippet: DeleteWorkstationConfigAsync(DeleteWorkstationConfigRequest, CallSettings)
            // Additional: DeleteWorkstationConfigAsync(DeleteWorkstationConfigRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkstationConfigRequest request = new DeleteWorkstationConfigRequest
            {
                WorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
                ValidateOnly = false,
                Etag = "",
                Force = false,
            };
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.DeleteWorkstationConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationConfig</summary>
        public void DeleteWorkstationConfig()
        {
            // Snippet: DeleteWorkstationConfig(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.DeleteWorkstationConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationConfigAsync</summary>
        public async Task DeleteWorkstationConfigAsync()
        {
            // Snippet: DeleteWorkstationConfigAsync(string, CallSettings)
            // Additional: DeleteWorkstationConfigAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.DeleteWorkstationConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationConfig</summary>
        public void DeleteWorkstationConfigResourceNames()
        {
            // Snippet: DeleteWorkstationConfig(WorkstationConfigName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationConfigName name = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = workstationsClient.DeleteWorkstationConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstationConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationConfigAsync</summary>
        public async Task DeleteWorkstationConfigResourceNamesAsync()
        {
            // Snippet: DeleteWorkstationConfigAsync(WorkstationConfigName, CallSettings)
            // Additional: DeleteWorkstationConfigAsync(WorkstationConfigName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationConfigName name = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            Operation<WorkstationConfig, OperationMetadata> response = await workstationsClient.DeleteWorkstationConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<WorkstationConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            WorkstationConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<WorkstationConfig, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                WorkstationConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetWorkstation</summary>
        public void GetWorkstationRequestObject()
        {
            // Snippet: GetWorkstation(GetWorkstationRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            GetWorkstationRequest request = new GetWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
            };
            // Make the request
            Workstation response = workstationsClient.GetWorkstation(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationAsync</summary>
        public async Task GetWorkstationRequestObjectAsync()
        {
            // Snippet: GetWorkstationAsync(GetWorkstationRequest, CallSettings)
            // Additional: GetWorkstationAsync(GetWorkstationRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkstationRequest request = new GetWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
            };
            // Make the request
            Workstation response = await workstationsClient.GetWorkstationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstation</summary>
        public void GetWorkstation()
        {
            // Snippet: GetWorkstation(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Workstation response = workstationsClient.GetWorkstation(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationAsync</summary>
        public async Task GetWorkstationAsync()
        {
            // Snippet: GetWorkstationAsync(string, CallSettings)
            // Additional: GetWorkstationAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Workstation response = await workstationsClient.GetWorkstationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstation</summary>
        public void GetWorkstationResourceNames()
        {
            // Snippet: GetWorkstation(WorkstationName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Workstation response = workstationsClient.GetWorkstation(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkstationAsync</summary>
        public async Task GetWorkstationResourceNamesAsync()
        {
            // Snippet: GetWorkstationAsync(WorkstationName, CallSettings)
            // Additional: GetWorkstationAsync(WorkstationName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Workstation response = await workstationsClient.GetWorkstationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkstations</summary>
        public void ListWorkstationsRequestObject()
        {
            // Snippet: ListWorkstations(ListWorkstationsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            ListWorkstationsRequest request = new ListWorkstationsRequest
            {
                ParentAsWorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
            };
            // Make the request
            PagedEnumerable<ListWorkstationsResponse, Workstation> response = workstationsClient.ListWorkstations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workstation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationsAsync</summary>
        public async Task ListWorkstationsRequestObjectAsync()
        {
            // Snippet: ListWorkstationsAsync(ListWorkstationsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkstationsRequest request = new ListWorkstationsRequest
            {
                ParentAsWorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListWorkstationsResponse, Workstation> response = workstationsClient.ListWorkstationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workstation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstations</summary>
        public void ListWorkstations()
        {
            // Snippet: ListWorkstations(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            PagedEnumerable<ListWorkstationsResponse, Workstation> response = workstationsClient.ListWorkstations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workstation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationsAsync</summary>
        public async Task ListWorkstationsAsync()
        {
            // Snippet: ListWorkstationsAsync(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListWorkstationsResponse, Workstation> response = workstationsClient.ListWorkstationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workstation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstations</summary>
        public void ListWorkstationsResourceNames()
        {
            // Snippet: ListWorkstations(WorkstationConfigName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationConfigName parent = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            PagedEnumerable<ListWorkstationsResponse, Workstation> response = workstationsClient.ListWorkstations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workstation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkstationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkstationsAsync</summary>
        public async Task ListWorkstationsResourceNamesAsync()
        {
            // Snippet: ListWorkstationsAsync(WorkstationConfigName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationConfigName parent = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListWorkstationsResponse, Workstation> response = workstationsClient.ListWorkstationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workstation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkstationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstations</summary>
        public void ListUsableWorkstationsRequestObject()
        {
            // Snippet: ListUsableWorkstations(ListUsableWorkstationsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            ListUsableWorkstationsRequest request = new ListUsableWorkstationsRequest
            {
                ParentAsWorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
            };
            // Make the request
            PagedEnumerable<ListUsableWorkstationsResponse, Workstation> response = workstationsClient.ListUsableWorkstations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workstation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableWorkstationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationsAsync</summary>
        public async Task ListUsableWorkstationsRequestObjectAsync()
        {
            // Snippet: ListUsableWorkstationsAsync(ListUsableWorkstationsRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            ListUsableWorkstationsRequest request = new ListUsableWorkstationsRequest
            {
                ParentAsWorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListUsableWorkstationsResponse, Workstation> response = workstationsClient.ListUsableWorkstationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workstation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableWorkstationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstations</summary>
        public void ListUsableWorkstations()
        {
            // Snippet: ListUsableWorkstations(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            PagedEnumerable<ListUsableWorkstationsResponse, Workstation> response = workstationsClient.ListUsableWorkstations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workstation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableWorkstationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationsAsync</summary>
        public async Task ListUsableWorkstationsAsync()
        {
            // Snippet: ListUsableWorkstationsAsync(string, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            // Make the request
            PagedAsyncEnumerable<ListUsableWorkstationsResponse, Workstation> response = workstationsClient.ListUsableWorkstationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workstation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableWorkstationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstations</summary>
        public void ListUsableWorkstationsResourceNames()
        {
            // Snippet: ListUsableWorkstations(WorkstationConfigName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationConfigName parent = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            PagedEnumerable<ListUsableWorkstationsResponse, Workstation> response = workstationsClient.ListUsableWorkstations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workstation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUsableWorkstationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUsableWorkstationsAsync</summary>
        public async Task ListUsableWorkstationsResourceNamesAsync()
        {
            // Snippet: ListUsableWorkstationsAsync(WorkstationConfigName, string, int?, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationConfigName parent = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            // Make the request
            PagedAsyncEnumerable<ListUsableWorkstationsResponse, Workstation> response = workstationsClient.ListUsableWorkstationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workstation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUsableWorkstationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workstation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workstation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workstation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstation</summary>
        public void CreateWorkstationRequestObject()
        {
            // Snippet: CreateWorkstation(CreateWorkstationRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            CreateWorkstationRequest request = new CreateWorkstationRequest
            {
                ParentAsWorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
                WorkstationId = "",
                Workstation = new Workstation(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.CreateWorkstation(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationAsync</summary>
        public async Task CreateWorkstationRequestObjectAsync()
        {
            // Snippet: CreateWorkstationAsync(CreateWorkstationRequest, CallSettings)
            // Additional: CreateWorkstationAsync(CreateWorkstationRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            CreateWorkstationRequest request = new CreateWorkstationRequest
            {
                ParentAsWorkstationConfigName = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]"),
                WorkstationId = "",
                Workstation = new Workstation(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.CreateWorkstationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstation</summary>
        public void CreateWorkstation()
        {
            // Snippet: CreateWorkstation(string, Workstation, string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            Workstation workstation = new Workstation();
            string workstationId = "";
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.CreateWorkstation(parent, workstation, workstationId);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationAsync</summary>
        public async Task CreateWorkstationAsync()
        {
            // Snippet: CreateWorkstationAsync(string, Workstation, string, CallSettings)
            // Additional: CreateWorkstationAsync(string, Workstation, string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]";
            Workstation workstation = new Workstation();
            string workstationId = "";
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.CreateWorkstationAsync(parent, workstation, workstationId);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstation</summary>
        public void CreateWorkstationResourceNames()
        {
            // Snippet: CreateWorkstation(WorkstationConfigName, Workstation, string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationConfigName parent = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            Workstation workstation = new Workstation();
            string workstationId = "";
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.CreateWorkstation(parent, workstation, workstationId);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceCreateWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateWorkstationAsync</summary>
        public async Task CreateWorkstationResourceNamesAsync()
        {
            // Snippet: CreateWorkstationAsync(WorkstationConfigName, Workstation, string, CallSettings)
            // Additional: CreateWorkstationAsync(WorkstationConfigName, Workstation, string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationConfigName parent = WorkstationConfigName.FromProjectLocationWorkstationClusterWorkstationConfig("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]");
            Workstation workstation = new Workstation();
            string workstationId = "";
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.CreateWorkstationAsync(parent, workstation, workstationId);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceCreateWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstation</summary>
        public void UpdateWorkstationRequestObject()
        {
            // Snippet: UpdateWorkstation(UpdateWorkstationRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            UpdateWorkstationRequest request = new UpdateWorkstationRequest
            {
                Workstation = new Workstation(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.UpdateWorkstation(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceUpdateWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationAsync</summary>
        public async Task UpdateWorkstationRequestObjectAsync()
        {
            // Snippet: UpdateWorkstationAsync(UpdateWorkstationRequest, CallSettings)
            // Additional: UpdateWorkstationAsync(UpdateWorkstationRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWorkstationRequest request = new UpdateWorkstationRequest
            {
                Workstation = new Workstation(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.UpdateWorkstationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceUpdateWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstation</summary>
        public void UpdateWorkstation()
        {
            // Snippet: UpdateWorkstation(Workstation, FieldMask, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            Workstation workstation = new Workstation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.UpdateWorkstation(workstation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceUpdateWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateWorkstationAsync</summary>
        public async Task UpdateWorkstationAsync()
        {
            // Snippet: UpdateWorkstationAsync(Workstation, FieldMask, CallSettings)
            // Additional: UpdateWorkstationAsync(Workstation, FieldMask, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            Workstation workstation = new Workstation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.UpdateWorkstationAsync(workstation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceUpdateWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstation</summary>
        public void DeleteWorkstationRequestObject()
        {
            // Snippet: DeleteWorkstation(DeleteWorkstationRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            DeleteWorkstationRequest request = new DeleteWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.DeleteWorkstation(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationAsync</summary>
        public async Task DeleteWorkstationRequestObjectAsync()
        {
            // Snippet: DeleteWorkstationAsync(DeleteWorkstationRequest, CallSettings)
            // Additional: DeleteWorkstationAsync(DeleteWorkstationRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWorkstationRequest request = new DeleteWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.DeleteWorkstationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstation</summary>
        public void DeleteWorkstation()
        {
            // Snippet: DeleteWorkstation(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.DeleteWorkstation(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationAsync</summary>
        public async Task DeleteWorkstationAsync()
        {
            // Snippet: DeleteWorkstationAsync(string, CallSettings)
            // Additional: DeleteWorkstationAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.DeleteWorkstationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstation</summary>
        public void DeleteWorkstationResourceNames()
        {
            // Snippet: DeleteWorkstation(WorkstationName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.DeleteWorkstation(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceDeleteWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteWorkstationAsync</summary>
        public async Task DeleteWorkstationResourceNamesAsync()
        {
            // Snippet: DeleteWorkstationAsync(WorkstationName, CallSettings)
            // Additional: DeleteWorkstationAsync(WorkstationName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.DeleteWorkstationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceDeleteWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartWorkstation</summary>
        public void StartWorkstationRequestObject()
        {
            // Snippet: StartWorkstation(StartWorkstationRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            StartWorkstationRequest request = new StartWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.StartWorkstation(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceStartWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartWorkstationAsync</summary>
        public async Task StartWorkstationRequestObjectAsync()
        {
            // Snippet: StartWorkstationAsync(StartWorkstationRequest, CallSettings)
            // Additional: StartWorkstationAsync(StartWorkstationRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            StartWorkstationRequest request = new StartWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.StartWorkstationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceStartWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartWorkstation</summary>
        public void StartWorkstation()
        {
            // Snippet: StartWorkstation(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.StartWorkstation(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceStartWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartWorkstationAsync</summary>
        public async Task StartWorkstationAsync()
        {
            // Snippet: StartWorkstationAsync(string, CallSettings)
            // Additional: StartWorkstationAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.StartWorkstationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceStartWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartWorkstation</summary>
        public void StartWorkstationResourceNames()
        {
            // Snippet: StartWorkstation(WorkstationName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.StartWorkstation(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceStartWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartWorkstationAsync</summary>
        public async Task StartWorkstationResourceNamesAsync()
        {
            // Snippet: StartWorkstationAsync(WorkstationName, CallSettings)
            // Additional: StartWorkstationAsync(WorkstationName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.StartWorkstationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceStartWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopWorkstation</summary>
        public void StopWorkstationRequestObject()
        {
            // Snippet: StopWorkstation(StopWorkstationRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            StopWorkstationRequest request = new StopWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.StopWorkstation(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceStopWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopWorkstationAsync</summary>
        public async Task StopWorkstationRequestObjectAsync()
        {
            // Snippet: StopWorkstationAsync(StopWorkstationRequest, CallSettings)
            // Additional: StopWorkstationAsync(StopWorkstationRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            StopWorkstationRequest request = new StopWorkstationRequest
            {
                WorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.StopWorkstationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceStopWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopWorkstation</summary>
        public void StopWorkstation()
        {
            // Snippet: StopWorkstation(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.StopWorkstation(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceStopWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopWorkstationAsync</summary>
        public async Task StopWorkstationAsync()
        {
            // Snippet: StopWorkstationAsync(string, CallSettings)
            // Additional: StopWorkstationAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.StopWorkstationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceStopWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopWorkstation</summary>
        public void StopWorkstationResourceNames()
        {
            // Snippet: StopWorkstation(WorkstationName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Operation<Workstation, OperationMetadata> response = workstationsClient.StopWorkstation(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = workstationsClient.PollOnceStopWorkstation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopWorkstationAsync</summary>
        public async Task StopWorkstationResourceNamesAsync()
        {
            // Snippet: StopWorkstationAsync(WorkstationName, CallSettings)
            // Additional: StopWorkstationAsync(WorkstationName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationName name = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            Operation<Workstation, OperationMetadata> response = await workstationsClient.StopWorkstationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Workstation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Workstation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Workstation, OperationMetadata> retrievedResponse = await workstationsClient.PollOnceStopWorkstationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Workstation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessToken</summary>
        public void GenerateAccessTokenRequestObject()
        {
            // Snippet: GenerateAccessToken(GenerateAccessTokenRequest, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                WorkstationAsWorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            GenerateAccessTokenResponse response = workstationsClient.GenerateAccessToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessTokenAsync</summary>
        public async Task GenerateAccessTokenRequestObjectAsync()
        {
            // Snippet: GenerateAccessTokenAsync(GenerateAccessTokenRequest, CallSettings)
            // Additional: GenerateAccessTokenAsync(GenerateAccessTokenRequest, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                WorkstationAsWorkstationName = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            GenerateAccessTokenResponse response = await workstationsClient.GenerateAccessTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessToken</summary>
        public void GenerateAccessToken()
        {
            // Snippet: GenerateAccessToken(string, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            string workstation = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            GenerateAccessTokenResponse response = workstationsClient.GenerateAccessToken(workstation);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessTokenAsync</summary>
        public async Task GenerateAccessTokenAsync()
        {
            // Snippet: GenerateAccessTokenAsync(string, CallSettings)
            // Additional: GenerateAccessTokenAsync(string, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            string workstation = "projects/[PROJECT]/locations/[LOCATION]/workstationClusters/[WORKSTATION_CLUSTER]/workstationConfigs/[WORKSTATION_CONFIG]/workstations/[WORKSTATION]";
            // Make the request
            GenerateAccessTokenResponse response = await workstationsClient.GenerateAccessTokenAsync(workstation);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessToken</summary>
        public void GenerateAccessTokenResourceNames()
        {
            // Snippet: GenerateAccessToken(WorkstationName, CallSettings)
            // Create client
            WorkstationsClient workstationsClient = WorkstationsClient.Create();
            // Initialize request argument(s)
            WorkstationName workstation = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            GenerateAccessTokenResponse response = workstationsClient.GenerateAccessToken(workstation);
            // End snippet
        }

        /// <summary>Snippet for GenerateAccessTokenAsync</summary>
        public async Task GenerateAccessTokenResourceNamesAsync()
        {
            // Snippet: GenerateAccessTokenAsync(WorkstationName, CallSettings)
            // Additional: GenerateAccessTokenAsync(WorkstationName, CancellationToken)
            // Create client
            WorkstationsClient workstationsClient = await WorkstationsClient.CreateAsync();
            // Initialize request argument(s)
            WorkstationName workstation = WorkstationName.FromProjectLocationWorkstationClusterWorkstationConfigWorkstation("[PROJECT]", "[LOCATION]", "[WORKSTATION_CLUSTER]", "[WORKSTATION_CONFIG]", "[WORKSTATION]");
            // Make the request
            GenerateAccessTokenResponse response = await workstationsClient.GenerateAccessTokenAsync(workstation);
            // End snippet
        }
    }
}
