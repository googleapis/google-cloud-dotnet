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
    using Google.Cloud.TelcoAutomation.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTelcoAutomationClientSnippets
    {
        /// <summary>Snippet for ListOrchestrationClusters</summary>
        public void ListOrchestrationClustersRequestObject()
        {
            // Snippet: ListOrchestrationClusters(ListOrchestrationClustersRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListOrchestrationClustersRequest request = new ListOrchestrationClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> response = telcoAutomationClient.ListOrchestrationClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrchestrationCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrchestrationClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrchestrationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrchestrationCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrchestrationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrchestrationClustersAsync</summary>
        public async Task ListOrchestrationClustersRequestObjectAsync()
        {
            // Snippet: ListOrchestrationClustersAsync(ListOrchestrationClustersRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListOrchestrationClustersRequest request = new ListOrchestrationClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> response = telcoAutomationClient.ListOrchestrationClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrchestrationCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrchestrationClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrchestrationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrchestrationCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrchestrationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrchestrationClusters</summary>
        public void ListOrchestrationClusters()
        {
            // Snippet: ListOrchestrationClusters(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> response = telcoAutomationClient.ListOrchestrationClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrchestrationCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrchestrationClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrchestrationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrchestrationCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrchestrationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrchestrationClustersAsync</summary>
        public async Task ListOrchestrationClustersAsync()
        {
            // Snippet: ListOrchestrationClustersAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> response = telcoAutomationClient.ListOrchestrationClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrchestrationCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrchestrationClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrchestrationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrchestrationCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrchestrationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrchestrationClusters</summary>
        public void ListOrchestrationClustersResourceNames()
        {
            // Snippet: ListOrchestrationClusters(LocationName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> response = telcoAutomationClient.ListOrchestrationClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OrchestrationCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOrchestrationClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrchestrationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrchestrationCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrchestrationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOrchestrationClustersAsync</summary>
        public async Task ListOrchestrationClustersResourceNamesAsync()
        {
            // Snippet: ListOrchestrationClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOrchestrationClustersResponse, OrchestrationCluster> response = telcoAutomationClient.ListOrchestrationClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OrchestrationCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOrchestrationClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OrchestrationCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OrchestrationCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OrchestrationCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOrchestrationCluster</summary>
        public void GetOrchestrationClusterRequestObject()
        {
            // Snippet: GetOrchestrationCluster(GetOrchestrationClusterRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            GetOrchestrationClusterRequest request = new GetOrchestrationClusterRequest
            {
                OrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
            };
            // Make the request
            OrchestrationCluster response = telcoAutomationClient.GetOrchestrationCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrchestrationClusterAsync</summary>
        public async Task GetOrchestrationClusterRequestObjectAsync()
        {
            // Snippet: GetOrchestrationClusterAsync(GetOrchestrationClusterRequest, CallSettings)
            // Additional: GetOrchestrationClusterAsync(GetOrchestrationClusterRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            GetOrchestrationClusterRequest request = new GetOrchestrationClusterRequest
            {
                OrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
            };
            // Make the request
            OrchestrationCluster response = await telcoAutomationClient.GetOrchestrationClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOrchestrationCluster</summary>
        public void GetOrchestrationCluster()
        {
            // Snippet: GetOrchestrationCluster(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            OrchestrationCluster response = telcoAutomationClient.GetOrchestrationCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrchestrationClusterAsync</summary>
        public async Task GetOrchestrationClusterAsync()
        {
            // Snippet: GetOrchestrationClusterAsync(string, CallSettings)
            // Additional: GetOrchestrationClusterAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            OrchestrationCluster response = await telcoAutomationClient.GetOrchestrationClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrchestrationCluster</summary>
        public void GetOrchestrationClusterResourceNames()
        {
            // Snippet: GetOrchestrationCluster(OrchestrationClusterName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName name = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            OrchestrationCluster response = telcoAutomationClient.GetOrchestrationCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetOrchestrationClusterAsync</summary>
        public async Task GetOrchestrationClusterResourceNamesAsync()
        {
            // Snippet: GetOrchestrationClusterAsync(OrchestrationClusterName, CallSettings)
            // Additional: GetOrchestrationClusterAsync(OrchestrationClusterName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName name = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            OrchestrationCluster response = await telcoAutomationClient.GetOrchestrationClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateOrchestrationCluster</summary>
        public void CreateOrchestrationClusterRequestObject()
        {
            // Snippet: CreateOrchestrationCluster(CreateOrchestrationClusterRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            CreateOrchestrationClusterRequest request = new CreateOrchestrationClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrchestrationClusterId = "",
                OrchestrationCluster = new OrchestrationCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<OrchestrationCluster, OperationMetadata> response = telcoAutomationClient.CreateOrchestrationCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<OrchestrationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OrchestrationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrchestrationCluster, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceCreateOrchestrationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrchestrationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrchestrationClusterAsync</summary>
        public async Task CreateOrchestrationClusterRequestObjectAsync()
        {
            // Snippet: CreateOrchestrationClusterAsync(CreateOrchestrationClusterRequest, CallSettings)
            // Additional: CreateOrchestrationClusterAsync(CreateOrchestrationClusterRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            CreateOrchestrationClusterRequest request = new CreateOrchestrationClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OrchestrationClusterId = "",
                OrchestrationCluster = new OrchestrationCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<OrchestrationCluster, OperationMetadata> response = await telcoAutomationClient.CreateOrchestrationClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OrchestrationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OrchestrationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrchestrationCluster, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceCreateOrchestrationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrchestrationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrchestrationCluster</summary>
        public void CreateOrchestrationCluster()
        {
            // Snippet: CreateOrchestrationCluster(string, OrchestrationCluster, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OrchestrationCluster orchestrationCluster = new OrchestrationCluster();
            string orchestrationClusterId = "";
            // Make the request
            Operation<OrchestrationCluster, OperationMetadata> response = telcoAutomationClient.CreateOrchestrationCluster(parent, orchestrationCluster, orchestrationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<OrchestrationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OrchestrationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrchestrationCluster, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceCreateOrchestrationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrchestrationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrchestrationClusterAsync</summary>
        public async Task CreateOrchestrationClusterAsync()
        {
            // Snippet: CreateOrchestrationClusterAsync(string, OrchestrationCluster, string, CallSettings)
            // Additional: CreateOrchestrationClusterAsync(string, OrchestrationCluster, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OrchestrationCluster orchestrationCluster = new OrchestrationCluster();
            string orchestrationClusterId = "";
            // Make the request
            Operation<OrchestrationCluster, OperationMetadata> response = await telcoAutomationClient.CreateOrchestrationClusterAsync(parent, orchestrationCluster, orchestrationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<OrchestrationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OrchestrationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrchestrationCluster, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceCreateOrchestrationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrchestrationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrchestrationCluster</summary>
        public void CreateOrchestrationClusterResourceNames()
        {
            // Snippet: CreateOrchestrationCluster(LocationName, OrchestrationCluster, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OrchestrationCluster orchestrationCluster = new OrchestrationCluster();
            string orchestrationClusterId = "";
            // Make the request
            Operation<OrchestrationCluster, OperationMetadata> response = telcoAutomationClient.CreateOrchestrationCluster(parent, orchestrationCluster, orchestrationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<OrchestrationCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OrchestrationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrchestrationCluster, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceCreateOrchestrationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrchestrationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOrchestrationClusterAsync</summary>
        public async Task CreateOrchestrationClusterResourceNamesAsync()
        {
            // Snippet: CreateOrchestrationClusterAsync(LocationName, OrchestrationCluster, string, CallSettings)
            // Additional: CreateOrchestrationClusterAsync(LocationName, OrchestrationCluster, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OrchestrationCluster orchestrationCluster = new OrchestrationCluster();
            string orchestrationClusterId = "";
            // Make the request
            Operation<OrchestrationCluster, OperationMetadata> response = await telcoAutomationClient.CreateOrchestrationClusterAsync(parent, orchestrationCluster, orchestrationClusterId);

            // Poll until the returned long-running operation is complete
            Operation<OrchestrationCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OrchestrationCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OrchestrationCluster, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceCreateOrchestrationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OrchestrationCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrchestrationCluster</summary>
        public void DeleteOrchestrationClusterRequestObject()
        {
            // Snippet: DeleteOrchestrationCluster(DeleteOrchestrationClusterRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeleteOrchestrationClusterRequest request = new DeleteOrchestrationClusterRequest
            {
                OrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = telcoAutomationClient.DeleteOrchestrationCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceDeleteOrchestrationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrchestrationClusterAsync</summary>
        public async Task DeleteOrchestrationClusterRequestObjectAsync()
        {
            // Snippet: DeleteOrchestrationClusterAsync(DeleteOrchestrationClusterRequest, CallSettings)
            // Additional: DeleteOrchestrationClusterAsync(DeleteOrchestrationClusterRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOrchestrationClusterRequest request = new DeleteOrchestrationClusterRequest
            {
                OrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await telcoAutomationClient.DeleteOrchestrationClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceDeleteOrchestrationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrchestrationCluster</summary>
        public void DeleteOrchestrationCluster()
        {
            // Snippet: DeleteOrchestrationCluster(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = telcoAutomationClient.DeleteOrchestrationCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceDeleteOrchestrationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrchestrationClusterAsync</summary>
        public async Task DeleteOrchestrationClusterAsync()
        {
            // Snippet: DeleteOrchestrationClusterAsync(string, CallSettings)
            // Additional: DeleteOrchestrationClusterAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await telcoAutomationClient.DeleteOrchestrationClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceDeleteOrchestrationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrchestrationCluster</summary>
        public void DeleteOrchestrationClusterResourceNames()
        {
            // Snippet: DeleteOrchestrationCluster(OrchestrationClusterName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName name = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = telcoAutomationClient.DeleteOrchestrationCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceDeleteOrchestrationCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOrchestrationClusterAsync</summary>
        public async Task DeleteOrchestrationClusterResourceNamesAsync()
        {
            // Snippet: DeleteOrchestrationClusterAsync(OrchestrationClusterName, CallSettings)
            // Additional: DeleteOrchestrationClusterAsync(OrchestrationClusterName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName name = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await telcoAutomationClient.DeleteOrchestrationClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceDeleteOrchestrationClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEdgeSlms</summary>
        public void ListEdgeSlmsRequestObject()
        {
            // Snippet: ListEdgeSlms(ListEdgeSlmsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListEdgeSlmsRequest request = new ListEdgeSlmsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEdgeSlmsResponse, EdgeSlm> response = telcoAutomationClient.ListEdgeSlms(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EdgeSlm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEdgeSlmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EdgeSlm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EdgeSlm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EdgeSlm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEdgeSlmsAsync</summary>
        public async Task ListEdgeSlmsRequestObjectAsync()
        {
            // Snippet: ListEdgeSlmsAsync(ListEdgeSlmsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListEdgeSlmsRequest request = new ListEdgeSlmsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEdgeSlmsResponse, EdgeSlm> response = telcoAutomationClient.ListEdgeSlmsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EdgeSlm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEdgeSlmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EdgeSlm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EdgeSlm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EdgeSlm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEdgeSlms</summary>
        public void ListEdgeSlms()
        {
            // Snippet: ListEdgeSlms(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEdgeSlmsResponse, EdgeSlm> response = telcoAutomationClient.ListEdgeSlms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EdgeSlm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEdgeSlmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EdgeSlm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EdgeSlm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EdgeSlm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEdgeSlmsAsync</summary>
        public async Task ListEdgeSlmsAsync()
        {
            // Snippet: ListEdgeSlmsAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEdgeSlmsResponse, EdgeSlm> response = telcoAutomationClient.ListEdgeSlmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EdgeSlm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEdgeSlmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EdgeSlm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EdgeSlm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EdgeSlm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEdgeSlms</summary>
        public void ListEdgeSlmsResourceNames()
        {
            // Snippet: ListEdgeSlms(LocationName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEdgeSlmsResponse, EdgeSlm> response = telcoAutomationClient.ListEdgeSlms(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EdgeSlm item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEdgeSlmsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EdgeSlm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EdgeSlm> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EdgeSlm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEdgeSlmsAsync</summary>
        public async Task ListEdgeSlmsResourceNamesAsync()
        {
            // Snippet: ListEdgeSlmsAsync(LocationName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEdgeSlmsResponse, EdgeSlm> response = telcoAutomationClient.ListEdgeSlmsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EdgeSlm item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEdgeSlmsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EdgeSlm item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EdgeSlm> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EdgeSlm item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEdgeSlm</summary>
        public void GetEdgeSlmRequestObject()
        {
            // Snippet: GetEdgeSlm(GetEdgeSlmRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            GetEdgeSlmRequest request = new GetEdgeSlmRequest
            {
                EdgeSlmName = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]"),
            };
            // Make the request
            EdgeSlm response = telcoAutomationClient.GetEdgeSlm(request);
            // End snippet
        }

        /// <summary>Snippet for GetEdgeSlmAsync</summary>
        public async Task GetEdgeSlmRequestObjectAsync()
        {
            // Snippet: GetEdgeSlmAsync(GetEdgeSlmRequest, CallSettings)
            // Additional: GetEdgeSlmAsync(GetEdgeSlmRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            GetEdgeSlmRequest request = new GetEdgeSlmRequest
            {
                EdgeSlmName = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]"),
            };
            // Make the request
            EdgeSlm response = await telcoAutomationClient.GetEdgeSlmAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEdgeSlm</summary>
        public void GetEdgeSlm()
        {
            // Snippet: GetEdgeSlm(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/edgeSlms/[EDGE_SLM]";
            // Make the request
            EdgeSlm response = telcoAutomationClient.GetEdgeSlm(name);
            // End snippet
        }

        /// <summary>Snippet for GetEdgeSlmAsync</summary>
        public async Task GetEdgeSlmAsync()
        {
            // Snippet: GetEdgeSlmAsync(string, CallSettings)
            // Additional: GetEdgeSlmAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/edgeSlms/[EDGE_SLM]";
            // Make the request
            EdgeSlm response = await telcoAutomationClient.GetEdgeSlmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEdgeSlm</summary>
        public void GetEdgeSlmResourceNames()
        {
            // Snippet: GetEdgeSlm(EdgeSlmName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            EdgeSlmName name = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]");
            // Make the request
            EdgeSlm response = telcoAutomationClient.GetEdgeSlm(name);
            // End snippet
        }

        /// <summary>Snippet for GetEdgeSlmAsync</summary>
        public async Task GetEdgeSlmResourceNamesAsync()
        {
            // Snippet: GetEdgeSlmAsync(EdgeSlmName, CallSettings)
            // Additional: GetEdgeSlmAsync(EdgeSlmName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            EdgeSlmName name = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]");
            // Make the request
            EdgeSlm response = await telcoAutomationClient.GetEdgeSlmAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEdgeSlm</summary>
        public void CreateEdgeSlmRequestObject()
        {
            // Snippet: CreateEdgeSlm(CreateEdgeSlmRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            CreateEdgeSlmRequest request = new CreateEdgeSlmRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EdgeSlmId = "",
                EdgeSlm = new EdgeSlm(),
                RequestId = "",
            };
            // Make the request
            Operation<EdgeSlm, OperationMetadata> response = telcoAutomationClient.CreateEdgeSlm(request);

            // Poll until the returned long-running operation is complete
            Operation<EdgeSlm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EdgeSlm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EdgeSlm, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceCreateEdgeSlm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EdgeSlm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEdgeSlmAsync</summary>
        public async Task CreateEdgeSlmRequestObjectAsync()
        {
            // Snippet: CreateEdgeSlmAsync(CreateEdgeSlmRequest, CallSettings)
            // Additional: CreateEdgeSlmAsync(CreateEdgeSlmRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            CreateEdgeSlmRequest request = new CreateEdgeSlmRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EdgeSlmId = "",
                EdgeSlm = new EdgeSlm(),
                RequestId = "",
            };
            // Make the request
            Operation<EdgeSlm, OperationMetadata> response = await telcoAutomationClient.CreateEdgeSlmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<EdgeSlm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EdgeSlm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EdgeSlm, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceCreateEdgeSlmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EdgeSlm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEdgeSlm</summary>
        public void CreateEdgeSlm()
        {
            // Snippet: CreateEdgeSlm(string, EdgeSlm, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EdgeSlm edgeSlm = new EdgeSlm();
            string edgeSlmId = "";
            // Make the request
            Operation<EdgeSlm, OperationMetadata> response = telcoAutomationClient.CreateEdgeSlm(parent, edgeSlm, edgeSlmId);

            // Poll until the returned long-running operation is complete
            Operation<EdgeSlm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EdgeSlm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EdgeSlm, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceCreateEdgeSlm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EdgeSlm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEdgeSlmAsync</summary>
        public async Task CreateEdgeSlmAsync()
        {
            // Snippet: CreateEdgeSlmAsync(string, EdgeSlm, string, CallSettings)
            // Additional: CreateEdgeSlmAsync(string, EdgeSlm, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            EdgeSlm edgeSlm = new EdgeSlm();
            string edgeSlmId = "";
            // Make the request
            Operation<EdgeSlm, OperationMetadata> response = await telcoAutomationClient.CreateEdgeSlmAsync(parent, edgeSlm, edgeSlmId);

            // Poll until the returned long-running operation is complete
            Operation<EdgeSlm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EdgeSlm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EdgeSlm, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceCreateEdgeSlmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EdgeSlm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEdgeSlm</summary>
        public void CreateEdgeSlmResourceNames()
        {
            // Snippet: CreateEdgeSlm(LocationName, EdgeSlm, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EdgeSlm edgeSlm = new EdgeSlm();
            string edgeSlmId = "";
            // Make the request
            Operation<EdgeSlm, OperationMetadata> response = telcoAutomationClient.CreateEdgeSlm(parent, edgeSlm, edgeSlmId);

            // Poll until the returned long-running operation is complete
            Operation<EdgeSlm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            EdgeSlm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EdgeSlm, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceCreateEdgeSlm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EdgeSlm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEdgeSlmAsync</summary>
        public async Task CreateEdgeSlmResourceNamesAsync()
        {
            // Snippet: CreateEdgeSlmAsync(LocationName, EdgeSlm, string, CallSettings)
            // Additional: CreateEdgeSlmAsync(LocationName, EdgeSlm, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            EdgeSlm edgeSlm = new EdgeSlm();
            string edgeSlmId = "";
            // Make the request
            Operation<EdgeSlm, OperationMetadata> response = await telcoAutomationClient.CreateEdgeSlmAsync(parent, edgeSlm, edgeSlmId);

            // Poll until the returned long-running operation is complete
            Operation<EdgeSlm, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            EdgeSlm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<EdgeSlm, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceCreateEdgeSlmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                EdgeSlm retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEdgeSlm</summary>
        public void DeleteEdgeSlmRequestObject()
        {
            // Snippet: DeleteEdgeSlm(DeleteEdgeSlmRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeleteEdgeSlmRequest request = new DeleteEdgeSlmRequest
            {
                EdgeSlmName = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = telcoAutomationClient.DeleteEdgeSlm(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceDeleteEdgeSlm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEdgeSlmAsync</summary>
        public async Task DeleteEdgeSlmRequestObjectAsync()
        {
            // Snippet: DeleteEdgeSlmAsync(DeleteEdgeSlmRequest, CallSettings)
            // Additional: DeleteEdgeSlmAsync(DeleteEdgeSlmRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEdgeSlmRequest request = new DeleteEdgeSlmRequest
            {
                EdgeSlmName = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await telcoAutomationClient.DeleteEdgeSlmAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceDeleteEdgeSlmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEdgeSlm</summary>
        public void DeleteEdgeSlm()
        {
            // Snippet: DeleteEdgeSlm(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/edgeSlms/[EDGE_SLM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = telcoAutomationClient.DeleteEdgeSlm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceDeleteEdgeSlm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEdgeSlmAsync</summary>
        public async Task DeleteEdgeSlmAsync()
        {
            // Snippet: DeleteEdgeSlmAsync(string, CallSettings)
            // Additional: DeleteEdgeSlmAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/edgeSlms/[EDGE_SLM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await telcoAutomationClient.DeleteEdgeSlmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceDeleteEdgeSlmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEdgeSlm</summary>
        public void DeleteEdgeSlmResourceNames()
        {
            // Snippet: DeleteEdgeSlm(EdgeSlmName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            EdgeSlmName name = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = telcoAutomationClient.DeleteEdgeSlm(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = telcoAutomationClient.PollOnceDeleteEdgeSlm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEdgeSlmAsync</summary>
        public async Task DeleteEdgeSlmResourceNamesAsync()
        {
            // Snippet: DeleteEdgeSlmAsync(EdgeSlmName, CallSettings)
            // Additional: DeleteEdgeSlmAsync(EdgeSlmName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            EdgeSlmName name = EdgeSlmName.FromProjectLocationEdgeSlm("[PROJECT]", "[LOCATION]", "[EDGE_SLM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await telcoAutomationClient.DeleteEdgeSlmAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await telcoAutomationClient.PollOnceDeleteEdgeSlmAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBlueprint</summary>
        public void CreateBlueprintRequestObject()
        {
            // Snippet: CreateBlueprint(CreateBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            CreateBlueprintRequest request = new CreateBlueprintRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                BlueprintId = "",
                Blueprint = new Blueprint(),
            };
            // Make the request
            Blueprint response = telcoAutomationClient.CreateBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueprintAsync</summary>
        public async Task CreateBlueprintRequestObjectAsync()
        {
            // Snippet: CreateBlueprintAsync(CreateBlueprintRequest, CallSettings)
            // Additional: CreateBlueprintAsync(CreateBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            CreateBlueprintRequest request = new CreateBlueprintRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                BlueprintId = "",
                Blueprint = new Blueprint(),
            };
            // Make the request
            Blueprint response = await telcoAutomationClient.CreateBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueprint</summary>
        public void CreateBlueprint()
        {
            // Snippet: CreateBlueprint(string, Blueprint, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            Blueprint blueprint = new Blueprint();
            string blueprintId = "";
            // Make the request
            Blueprint response = telcoAutomationClient.CreateBlueprint(parent, blueprint, blueprintId);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueprintAsync</summary>
        public async Task CreateBlueprintAsync()
        {
            // Snippet: CreateBlueprintAsync(string, Blueprint, string, CallSettings)
            // Additional: CreateBlueprintAsync(string, Blueprint, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            Blueprint blueprint = new Blueprint();
            string blueprintId = "";
            // Make the request
            Blueprint response = await telcoAutomationClient.CreateBlueprintAsync(parent, blueprint, blueprintId);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueprint</summary>
        public void CreateBlueprintResourceNames()
        {
            // Snippet: CreateBlueprint(OrchestrationClusterName, Blueprint, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            Blueprint blueprint = new Blueprint();
            string blueprintId = "";
            // Make the request
            Blueprint response = telcoAutomationClient.CreateBlueprint(parent, blueprint, blueprintId);
            // End snippet
        }

        /// <summary>Snippet for CreateBlueprintAsync</summary>
        public async Task CreateBlueprintResourceNamesAsync()
        {
            // Snippet: CreateBlueprintAsync(OrchestrationClusterName, Blueprint, string, CallSettings)
            // Additional: CreateBlueprintAsync(OrchestrationClusterName, Blueprint, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            Blueprint blueprint = new Blueprint();
            string blueprintId = "";
            // Make the request
            Blueprint response = await telcoAutomationClient.CreateBlueprintAsync(parent, blueprint, blueprintId);
            // End snippet
        }

        /// <summary>Snippet for UpdateBlueprint</summary>
        public void UpdateBlueprintRequestObject()
        {
            // Snippet: UpdateBlueprint(UpdateBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            UpdateBlueprintRequest request = new UpdateBlueprintRequest
            {
                Blueprint = new Blueprint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Blueprint response = telcoAutomationClient.UpdateBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBlueprintAsync</summary>
        public async Task UpdateBlueprintRequestObjectAsync()
        {
            // Snippet: UpdateBlueprintAsync(UpdateBlueprintRequest, CallSettings)
            // Additional: UpdateBlueprintAsync(UpdateBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBlueprintRequest request = new UpdateBlueprintRequest
            {
                Blueprint = new Blueprint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Blueprint response = await telcoAutomationClient.UpdateBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBlueprint</summary>
        public void UpdateBlueprint()
        {
            // Snippet: UpdateBlueprint(Blueprint, FieldMask, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            Blueprint blueprint = new Blueprint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Blueprint response = telcoAutomationClient.UpdateBlueprint(blueprint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBlueprintAsync</summary>
        public async Task UpdateBlueprintAsync()
        {
            // Snippet: UpdateBlueprintAsync(Blueprint, FieldMask, CallSettings)
            // Additional: UpdateBlueprintAsync(Blueprint, FieldMask, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            Blueprint blueprint = new Blueprint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Blueprint response = await telcoAutomationClient.UpdateBlueprintAsync(blueprint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetBlueprint</summary>
        public void GetBlueprintRequestObject()
        {
            // Snippet: GetBlueprint(GetBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            GetBlueprintRequest request = new GetBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
                View = BlueprintView.Unspecified,
            };
            // Make the request
            Blueprint response = telcoAutomationClient.GetBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for GetBlueprintAsync</summary>
        public async Task GetBlueprintRequestObjectAsync()
        {
            // Snippet: GetBlueprintAsync(GetBlueprintRequest, CallSettings)
            // Additional: GetBlueprintAsync(GetBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            GetBlueprintRequest request = new GetBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
                View = BlueprintView.Unspecified,
            };
            // Make the request
            Blueprint response = await telcoAutomationClient.GetBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBlueprint</summary>
        public void GetBlueprint()
        {
            // Snippet: GetBlueprint(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = telcoAutomationClient.GetBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for GetBlueprintAsync</summary>
        public async Task GetBlueprintAsync()
        {
            // Snippet: GetBlueprintAsync(string, CallSettings)
            // Additional: GetBlueprintAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = await telcoAutomationClient.GetBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBlueprint</summary>
        public void GetBlueprintResourceNames()
        {
            // Snippet: GetBlueprint(BlueprintName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = telcoAutomationClient.GetBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for GetBlueprintAsync</summary>
        public async Task GetBlueprintResourceNamesAsync()
        {
            // Snippet: GetBlueprintAsync(BlueprintName, CallSettings)
            // Additional: GetBlueprintAsync(BlueprintName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = await telcoAutomationClient.GetBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueprint</summary>
        public void DeleteBlueprintRequestObject()
        {
            // Snippet: DeleteBlueprint(DeleteBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeleteBlueprintRequest request = new DeleteBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            telcoAutomationClient.DeleteBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueprintAsync</summary>
        public async Task DeleteBlueprintRequestObjectAsync()
        {
            // Snippet: DeleteBlueprintAsync(DeleteBlueprintRequest, CallSettings)
            // Additional: DeleteBlueprintAsync(DeleteBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBlueprintRequest request = new DeleteBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            await telcoAutomationClient.DeleteBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueprint</summary>
        public void DeleteBlueprint()
        {
            // Snippet: DeleteBlueprint(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            telcoAutomationClient.DeleteBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueprintAsync</summary>
        public async Task DeleteBlueprintAsync()
        {
            // Snippet: DeleteBlueprintAsync(string, CallSettings)
            // Additional: DeleteBlueprintAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            await telcoAutomationClient.DeleteBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueprint</summary>
        public void DeleteBlueprintResourceNames()
        {
            // Snippet: DeleteBlueprint(BlueprintName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            telcoAutomationClient.DeleteBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBlueprintAsync</summary>
        public async Task DeleteBlueprintResourceNamesAsync()
        {
            // Snippet: DeleteBlueprintAsync(BlueprintName, CallSettings)
            // Additional: DeleteBlueprintAsync(BlueprintName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            await telcoAutomationClient.DeleteBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBlueprints</summary>
        public void ListBlueprintsRequestObject()
        {
            // Snippet: ListBlueprints(ListBlueprintsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListBlueprintsRequest request = new ListBlueprintsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListBlueprintsResponse, Blueprint> response = telcoAutomationClient.ListBlueprints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueprintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintsAsync</summary>
        public async Task ListBlueprintsRequestObjectAsync()
        {
            // Snippet: ListBlueprintsAsync(ListBlueprintsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListBlueprintsRequest request = new ListBlueprintsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBlueprintsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBlueprintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprints</summary>
        public void ListBlueprints()
        {
            // Snippet: ListBlueprints(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            PagedEnumerable<ListBlueprintsResponse, Blueprint> response = telcoAutomationClient.ListBlueprints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueprintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintsAsync</summary>
        public async Task ListBlueprintsAsync()
        {
            // Snippet: ListBlueprintsAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListBlueprintsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBlueprintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprints</summary>
        public void ListBlueprintsResourceNames()
        {
            // Snippet: ListBlueprints(OrchestrationClusterName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            PagedEnumerable<ListBlueprintsResponse, Blueprint> response = telcoAutomationClient.ListBlueprints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueprintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintsAsync</summary>
        public async Task ListBlueprintsResourceNamesAsync()
        {
            // Snippet: ListBlueprintsAsync(OrchestrationClusterName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListBlueprintsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBlueprintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ApproveBlueprint</summary>
        public void ApproveBlueprintRequestObject()
        {
            // Snippet: ApproveBlueprint(ApproveBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ApproveBlueprintRequest request = new ApproveBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            Blueprint response = telcoAutomationClient.ApproveBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveBlueprintAsync</summary>
        public async Task ApproveBlueprintRequestObjectAsync()
        {
            // Snippet: ApproveBlueprintAsync(ApproveBlueprintRequest, CallSettings)
            // Additional: ApproveBlueprintAsync(ApproveBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ApproveBlueprintRequest request = new ApproveBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            Blueprint response = await telcoAutomationClient.ApproveBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveBlueprint</summary>
        public void ApproveBlueprint()
        {
            // Snippet: ApproveBlueprint(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = telcoAutomationClient.ApproveBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveBlueprintAsync</summary>
        public async Task ApproveBlueprintAsync()
        {
            // Snippet: ApproveBlueprintAsync(string, CallSettings)
            // Additional: ApproveBlueprintAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = await telcoAutomationClient.ApproveBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveBlueprint</summary>
        public void ApproveBlueprintResourceNames()
        {
            // Snippet: ApproveBlueprint(BlueprintName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = telcoAutomationClient.ApproveBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveBlueprintAsync</summary>
        public async Task ApproveBlueprintResourceNamesAsync()
        {
            // Snippet: ApproveBlueprintAsync(BlueprintName, CallSettings)
            // Additional: ApproveBlueprintAsync(BlueprintName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = await telcoAutomationClient.ApproveBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ProposeBlueprint</summary>
        public void ProposeBlueprintRequestObject()
        {
            // Snippet: ProposeBlueprint(ProposeBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ProposeBlueprintRequest request = new ProposeBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            Blueprint response = telcoAutomationClient.ProposeBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for ProposeBlueprintAsync</summary>
        public async Task ProposeBlueprintRequestObjectAsync()
        {
            // Snippet: ProposeBlueprintAsync(ProposeBlueprintRequest, CallSettings)
            // Additional: ProposeBlueprintAsync(ProposeBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ProposeBlueprintRequest request = new ProposeBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            Blueprint response = await telcoAutomationClient.ProposeBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ProposeBlueprint</summary>
        public void ProposeBlueprint()
        {
            // Snippet: ProposeBlueprint(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = telcoAutomationClient.ProposeBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for ProposeBlueprintAsync</summary>
        public async Task ProposeBlueprintAsync()
        {
            // Snippet: ProposeBlueprintAsync(string, CallSettings)
            // Additional: ProposeBlueprintAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = await telcoAutomationClient.ProposeBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ProposeBlueprint</summary>
        public void ProposeBlueprintResourceNames()
        {
            // Snippet: ProposeBlueprint(BlueprintName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = telcoAutomationClient.ProposeBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for ProposeBlueprintAsync</summary>
        public async Task ProposeBlueprintResourceNamesAsync()
        {
            // Snippet: ProposeBlueprintAsync(BlueprintName, CallSettings)
            // Additional: ProposeBlueprintAsync(BlueprintName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = await telcoAutomationClient.ProposeBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RejectBlueprint</summary>
        public void RejectBlueprintRequestObject()
        {
            // Snippet: RejectBlueprint(RejectBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            RejectBlueprintRequest request = new RejectBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            Blueprint response = telcoAutomationClient.RejectBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for RejectBlueprintAsync</summary>
        public async Task RejectBlueprintRequestObjectAsync()
        {
            // Snippet: RejectBlueprintAsync(RejectBlueprintRequest, CallSettings)
            // Additional: RejectBlueprintAsync(RejectBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            RejectBlueprintRequest request = new RejectBlueprintRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            Blueprint response = await telcoAutomationClient.RejectBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RejectBlueprint</summary>
        public void RejectBlueprint()
        {
            // Snippet: RejectBlueprint(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = telcoAutomationClient.RejectBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for RejectBlueprintAsync</summary>
        public async Task RejectBlueprintAsync()
        {
            // Snippet: RejectBlueprintAsync(string, CallSettings)
            // Additional: RejectBlueprintAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            Blueprint response = await telcoAutomationClient.RejectBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RejectBlueprint</summary>
        public void RejectBlueprintResourceNames()
        {
            // Snippet: RejectBlueprint(BlueprintName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = telcoAutomationClient.RejectBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for RejectBlueprintAsync</summary>
        public async Task RejectBlueprintResourceNamesAsync()
        {
            // Snippet: RejectBlueprintAsync(BlueprintName, CallSettings)
            // Additional: RejectBlueprintAsync(BlueprintName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            Blueprint response = await telcoAutomationClient.RejectBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintRevisions</summary>
        public void ListBlueprintRevisionsRequestObject()
        {
            // Snippet: ListBlueprintRevisions(ListBlueprintRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListBlueprintRevisionsRequest request = new ListBlueprintRevisionsRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            PagedEnumerable<ListBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueprintRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintRevisionsAsync</summary>
        public async Task ListBlueprintRevisionsRequestObjectAsync()
        {
            // Snippet: ListBlueprintRevisionsAsync(ListBlueprintRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListBlueprintRevisionsRequest request = new ListBlueprintRevisionsRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBlueprintRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintRevisions</summary>
        public void ListBlueprintRevisions()
        {
            // Snippet: ListBlueprintRevisions(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            PagedEnumerable<ListBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueprintRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintRevisionsAsync</summary>
        public async Task ListBlueprintRevisionsAsync()
        {
            // Snippet: ListBlueprintRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            PagedAsyncEnumerable<ListBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBlueprintRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintRevisions</summary>
        public void ListBlueprintRevisionsResourceNames()
        {
            // Snippet: ListBlueprintRevisions(BlueprintName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            PagedEnumerable<ListBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBlueprintRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBlueprintRevisionsAsync</summary>
        public async Task ListBlueprintRevisionsResourceNamesAsync()
        {
            // Snippet: ListBlueprintRevisionsAsync(BlueprintName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            PagedAsyncEnumerable<ListBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.ListBlueprintRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBlueprintRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchBlueprintRevisions</summary>
        public void SearchBlueprintRevisionsRequestObject()
        {
            // Snippet: SearchBlueprintRevisions(SearchBlueprintRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            SearchBlueprintRevisionsRequest request = new SearchBlueprintRevisionsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.SearchBlueprintRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchBlueprintRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchBlueprintRevisionsAsync</summary>
        public async Task SearchBlueprintRevisionsRequestObjectAsync()
        {
            // Snippet: SearchBlueprintRevisionsAsync(SearchBlueprintRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            SearchBlueprintRevisionsRequest request = new SearchBlueprintRevisionsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.SearchBlueprintRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchBlueprintRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchBlueprintRevisions</summary>
        public void SearchBlueprintRevisions()
        {
            // Snippet: SearchBlueprintRevisions(string, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            string query = "";
            // Make the request
            PagedEnumerable<SearchBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.SearchBlueprintRevisions(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchBlueprintRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchBlueprintRevisionsAsync</summary>
        public async Task SearchBlueprintRevisionsAsync()
        {
            // Snippet: SearchBlueprintRevisionsAsync(string, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.SearchBlueprintRevisionsAsync(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchBlueprintRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchBlueprintRevisions</summary>
        public void SearchBlueprintRevisionsResourceNames()
        {
            // Snippet: SearchBlueprintRevisions(OrchestrationClusterName, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            string query = "";
            // Make the request
            PagedEnumerable<SearchBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.SearchBlueprintRevisions(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Blueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchBlueprintRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchBlueprintRevisionsAsync</summary>
        public async Task SearchBlueprintRevisionsResourceNamesAsync()
        {
            // Snippet: SearchBlueprintRevisionsAsync(OrchestrationClusterName, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchBlueprintRevisionsResponse, Blueprint> response = telcoAutomationClient.SearchBlueprintRevisionsAsync(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Blueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchBlueprintRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Blueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Blueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Blueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDeploymentRevisions</summary>
        public void SearchDeploymentRevisionsRequestObject()
        {
            // Snippet: SearchDeploymentRevisions(SearchDeploymentRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            SearchDeploymentRevisionsRequest request = new SearchDeploymentRevisionsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.SearchDeploymentRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchDeploymentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDeploymentRevisionsAsync</summary>
        public async Task SearchDeploymentRevisionsRequestObjectAsync()
        {
            // Snippet: SearchDeploymentRevisionsAsync(SearchDeploymentRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            SearchDeploymentRevisionsRequest request = new SearchDeploymentRevisionsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.SearchDeploymentRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchDeploymentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDeploymentRevisions</summary>
        public void SearchDeploymentRevisions()
        {
            // Snippet: SearchDeploymentRevisions(string, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            string query = "";
            // Make the request
            PagedEnumerable<SearchDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.SearchDeploymentRevisions(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchDeploymentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDeploymentRevisionsAsync</summary>
        public async Task SearchDeploymentRevisionsAsync()
        {
            // Snippet: SearchDeploymentRevisionsAsync(string, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.SearchDeploymentRevisionsAsync(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchDeploymentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDeploymentRevisions</summary>
        public void SearchDeploymentRevisionsResourceNames()
        {
            // Snippet: SearchDeploymentRevisions(OrchestrationClusterName, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            string query = "";
            // Make the request
            PagedEnumerable<SearchDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.SearchDeploymentRevisions(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchDeploymentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchDeploymentRevisionsAsync</summary>
        public async Task SearchDeploymentRevisionsResourceNamesAsync()
        {
            // Snippet: SearchDeploymentRevisionsAsync(OrchestrationClusterName, string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.SearchDeploymentRevisionsAsync(parent, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchDeploymentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DiscardBlueprintChanges</summary>
        public void DiscardBlueprintChangesRequestObject()
        {
            // Snippet: DiscardBlueprintChanges(DiscardBlueprintChangesRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DiscardBlueprintChangesRequest request = new DiscardBlueprintChangesRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            DiscardBlueprintChangesResponse response = telcoAutomationClient.DiscardBlueprintChanges(request);
            // End snippet
        }

        /// <summary>Snippet for DiscardBlueprintChangesAsync</summary>
        public async Task DiscardBlueprintChangesRequestObjectAsync()
        {
            // Snippet: DiscardBlueprintChangesAsync(DiscardBlueprintChangesRequest, CallSettings)
            // Additional: DiscardBlueprintChangesAsync(DiscardBlueprintChangesRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DiscardBlueprintChangesRequest request = new DiscardBlueprintChangesRequest
            {
                BlueprintName = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]"),
            };
            // Make the request
            DiscardBlueprintChangesResponse response = await telcoAutomationClient.DiscardBlueprintChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DiscardBlueprintChanges</summary>
        public void DiscardBlueprintChanges()
        {
            // Snippet: DiscardBlueprintChanges(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            DiscardBlueprintChangesResponse response = telcoAutomationClient.DiscardBlueprintChanges(name);
            // End snippet
        }

        /// <summary>Snippet for DiscardBlueprintChangesAsync</summary>
        public async Task DiscardBlueprintChangesAsync()
        {
            // Snippet: DiscardBlueprintChangesAsync(string, CallSettings)
            // Additional: DiscardBlueprintChangesAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/blueprints/[BLUEPRINT]";
            // Make the request
            DiscardBlueprintChangesResponse response = await telcoAutomationClient.DiscardBlueprintChangesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiscardBlueprintChanges</summary>
        public void DiscardBlueprintChangesResourceNames()
        {
            // Snippet: DiscardBlueprintChanges(BlueprintName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            DiscardBlueprintChangesResponse response = telcoAutomationClient.DiscardBlueprintChanges(name);
            // End snippet
        }

        /// <summary>Snippet for DiscardBlueprintChangesAsync</summary>
        public async Task DiscardBlueprintChangesResourceNamesAsync()
        {
            // Snippet: DiscardBlueprintChangesAsync(BlueprintName, CallSettings)
            // Additional: DiscardBlueprintChangesAsync(BlueprintName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            BlueprintName name = BlueprintName.FromProjectLocationOrchestrationClusterBlueprint("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[BLUEPRINT]");
            // Make the request
            DiscardBlueprintChangesResponse response = await telcoAutomationClient.DiscardBlueprintChangesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPublicBlueprints</summary>
        public void ListPublicBlueprintsRequestObject()
        {
            // Snippet: ListPublicBlueprints(ListPublicBlueprintsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListPublicBlueprintsRequest request = new ListPublicBlueprintsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> response = telcoAutomationClient.ListPublicBlueprints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicBlueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublicBlueprintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicBlueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicBlueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicBlueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicBlueprintsAsync</summary>
        public async Task ListPublicBlueprintsRequestObjectAsync()
        {
            // Snippet: ListPublicBlueprintsAsync(ListPublicBlueprintsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListPublicBlueprintsRequest request = new ListPublicBlueprintsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> response = telcoAutomationClient.ListPublicBlueprintsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicBlueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublicBlueprintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicBlueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicBlueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicBlueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicBlueprints</summary>
        public void ListPublicBlueprints()
        {
            // Snippet: ListPublicBlueprints(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> response = telcoAutomationClient.ListPublicBlueprints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicBlueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublicBlueprintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicBlueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicBlueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicBlueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicBlueprintsAsync</summary>
        public async Task ListPublicBlueprintsAsync()
        {
            // Snippet: ListPublicBlueprintsAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> response = telcoAutomationClient.ListPublicBlueprintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicBlueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublicBlueprintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicBlueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicBlueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicBlueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicBlueprints</summary>
        public void ListPublicBlueprintsResourceNames()
        {
            // Snippet: ListPublicBlueprints(LocationName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> response = telcoAutomationClient.ListPublicBlueprints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PublicBlueprint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPublicBlueprintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicBlueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicBlueprint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicBlueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPublicBlueprintsAsync</summary>
        public async Task ListPublicBlueprintsResourceNamesAsync()
        {
            // Snippet: ListPublicBlueprintsAsync(LocationName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPublicBlueprintsResponse, PublicBlueprint> response = telcoAutomationClient.ListPublicBlueprintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PublicBlueprint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPublicBlueprintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PublicBlueprint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PublicBlueprint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PublicBlueprint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPublicBlueprint</summary>
        public void GetPublicBlueprintRequestObject()
        {
            // Snippet: GetPublicBlueprint(GetPublicBlueprintRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            GetPublicBlueprintRequest request = new GetPublicBlueprintRequest
            {
                PublicBlueprintName = PublicBlueprintName.FromProjectLocationPublicLueprint("[PROJECT]", "[LOCATION]", "[PUBLIC_LUEPRINT]"),
            };
            // Make the request
            PublicBlueprint response = telcoAutomationClient.GetPublicBlueprint(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicBlueprintAsync</summary>
        public async Task GetPublicBlueprintRequestObjectAsync()
        {
            // Snippet: GetPublicBlueprintAsync(GetPublicBlueprintRequest, CallSettings)
            // Additional: GetPublicBlueprintAsync(GetPublicBlueprintRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            GetPublicBlueprintRequest request = new GetPublicBlueprintRequest
            {
                PublicBlueprintName = PublicBlueprintName.FromProjectLocationPublicLueprint("[PROJECT]", "[LOCATION]", "[PUBLIC_LUEPRINT]"),
            };
            // Make the request
            PublicBlueprint response = await telcoAutomationClient.GetPublicBlueprintAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPublicBlueprint</summary>
        public void GetPublicBlueprint()
        {
            // Snippet: GetPublicBlueprint(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/publicBlueprints/[PUBLIC_LUEPRINT]";
            // Make the request
            PublicBlueprint response = telcoAutomationClient.GetPublicBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicBlueprintAsync</summary>
        public async Task GetPublicBlueprintAsync()
        {
            // Snippet: GetPublicBlueprintAsync(string, CallSettings)
            // Additional: GetPublicBlueprintAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/publicBlueprints/[PUBLIC_LUEPRINT]";
            // Make the request
            PublicBlueprint response = await telcoAutomationClient.GetPublicBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicBlueprint</summary>
        public void GetPublicBlueprintResourceNames()
        {
            // Snippet: GetPublicBlueprint(PublicBlueprintName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            PublicBlueprintName name = PublicBlueprintName.FromProjectLocationPublicLueprint("[PROJECT]", "[LOCATION]", "[PUBLIC_LUEPRINT]");
            // Make the request
            PublicBlueprint response = telcoAutomationClient.GetPublicBlueprint(name);
            // End snippet
        }

        /// <summary>Snippet for GetPublicBlueprintAsync</summary>
        public async Task GetPublicBlueprintResourceNamesAsync()
        {
            // Snippet: GetPublicBlueprintAsync(PublicBlueprintName, CallSettings)
            // Additional: GetPublicBlueprintAsync(PublicBlueprintName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            PublicBlueprintName name = PublicBlueprintName.FromProjectLocationPublicLueprint("[PROJECT]", "[LOCATION]", "[PUBLIC_LUEPRINT]");
            // Make the request
            PublicBlueprint response = await telcoAutomationClient.GetPublicBlueprintAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentRequestObject()
        {
            // Snippet: CreateDeployment(CreateDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                DeploymentId = "",
                Deployment = new Deployment(),
            };
            // Make the request
            Deployment response = telcoAutomationClient.CreateDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentRequestObjectAsync()
        {
            // Snippet: CreateDeploymentAsync(CreateDeploymentRequest, CallSettings)
            // Additional: CreateDeploymentAsync(CreateDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            CreateDeploymentRequest request = new CreateDeploymentRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                DeploymentId = "",
                Deployment = new Deployment(),
            };
            // Make the request
            Deployment response = await telcoAutomationClient.CreateDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeployment()
        {
            // Snippet: CreateDeployment(string, Deployment, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = telcoAutomationClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentAsync()
        {
            // Snippet: CreateDeploymentAsync(string, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(string, Deployment, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = await telcoAutomationClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeployment</summary>
        public void CreateDeploymentResourceNames()
        {
            // Snippet: CreateDeployment(OrchestrationClusterName, Deployment, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = telcoAutomationClient.CreateDeployment(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for CreateDeploymentAsync</summary>
        public async Task CreateDeploymentResourceNamesAsync()
        {
            // Snippet: CreateDeploymentAsync(OrchestrationClusterName, Deployment, string, CallSettings)
            // Additional: CreateDeploymentAsync(OrchestrationClusterName, Deployment, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            Deployment deployment = new Deployment();
            string deploymentId = "";
            // Make the request
            Deployment response = await telcoAutomationClient.CreateDeploymentAsync(parent, deployment, deploymentId);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeploymentRequestObject()
        {
            // Snippet: UpdateDeployment(UpdateDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            UpdateDeploymentRequest request = new UpdateDeploymentRequest
            {
                Deployment = new Deployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Deployment response = telcoAutomationClient.UpdateDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateDeploymentAsync(UpdateDeploymentRequest, CallSettings)
            // Additional: UpdateDeploymentAsync(UpdateDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDeploymentRequest request = new UpdateDeploymentRequest
            {
                Deployment = new Deployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Deployment response = await telcoAutomationClient.UpdateDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeployment</summary>
        public void UpdateDeployment()
        {
            // Snippet: UpdateDeployment(Deployment, FieldMask, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Deployment response = telcoAutomationClient.UpdateDeployment(deployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDeploymentAsync</summary>
        public async Task UpdateDeploymentAsync()
        {
            // Snippet: UpdateDeploymentAsync(Deployment, FieldMask, CallSettings)
            // Additional: UpdateDeploymentAsync(Deployment, FieldMask, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            Deployment deployment = new Deployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Deployment response = await telcoAutomationClient.UpdateDeploymentAsync(deployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentRequestObject()
        {
            // Snippet: GetDeployment(GetDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
                View = DeploymentView.Unspecified,
            };
            // Make the request
            Deployment response = telcoAutomationClient.GetDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentRequestObjectAsync()
        {
            // Snippet: GetDeploymentAsync(GetDeploymentRequest, CallSettings)
            // Additional: GetDeploymentAsync(GetDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            GetDeploymentRequest request = new GetDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
                View = DeploymentView.Unspecified,
            };
            // Make the request
            Deployment response = await telcoAutomationClient.GetDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeployment()
        {
            // Snippet: GetDeployment(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = telcoAutomationClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentAsync()
        {
            // Snippet: GetDeploymentAsync(string, CallSettings)
            // Additional: GetDeploymentAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = await telcoAutomationClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeployment</summary>
        public void GetDeploymentResourceNames()
        {
            // Snippet: GetDeployment(DeploymentName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = telcoAutomationClient.GetDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetDeploymentAsync</summary>
        public async Task GetDeploymentResourceNamesAsync()
        {
            // Snippet: GetDeploymentAsync(DeploymentName, CallSettings)
            // Additional: GetDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = await telcoAutomationClient.GetDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RemoveDeployment</summary>
        public void RemoveDeploymentRequestObject()
        {
            // Snippet: RemoveDeployment(RemoveDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            RemoveDeploymentRequest request = new RemoveDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            telcoAutomationClient.RemoveDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDeploymentAsync</summary>
        public async Task RemoveDeploymentRequestObjectAsync()
        {
            // Snippet: RemoveDeploymentAsync(RemoveDeploymentRequest, CallSettings)
            // Additional: RemoveDeploymentAsync(RemoveDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            RemoveDeploymentRequest request = new RemoveDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            await telcoAutomationClient.RemoveDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveDeployment</summary>
        public void RemoveDeployment()
        {
            // Snippet: RemoveDeployment(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            telcoAutomationClient.RemoveDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for RemoveDeploymentAsync</summary>
        public async Task RemoveDeploymentAsync()
        {
            // Snippet: RemoveDeploymentAsync(string, CallSettings)
            // Additional: RemoveDeploymentAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            await telcoAutomationClient.RemoveDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RemoveDeployment</summary>
        public void RemoveDeploymentResourceNames()
        {
            // Snippet: RemoveDeployment(DeploymentName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            telcoAutomationClient.RemoveDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for RemoveDeploymentAsync</summary>
        public async Task RemoveDeploymentResourceNamesAsync()
        {
            // Snippet: RemoveDeploymentAsync(DeploymentName, CallSettings)
            // Additional: RemoveDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            await telcoAutomationClient.RemoveDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsRequestObject()
        {
            // Snippet: ListDeployments(ListDeploymentsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = telcoAutomationClient.ListDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsRequestObjectAsync()
        {
            // Snippet: ListDeploymentsAsync(ListDeploymentsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentsRequest request = new ListDeploymentsRequest
            {
                ParentAsOrchestrationClusterName = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = telcoAutomationClient.ListDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeployments()
        {
            // Snippet: ListDeployments(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = telcoAutomationClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsAsync()
        {
            // Snippet: ListDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = telcoAutomationClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeployments</summary>
        public void ListDeploymentsResourceNames()
        {
            // Snippet: ListDeployments(OrchestrationClusterName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            PagedEnumerable<ListDeploymentsResponse, Deployment> response = telcoAutomationClient.ListDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentsAsync</summary>
        public async Task ListDeploymentsResourceNamesAsync()
        {
            // Snippet: ListDeploymentsAsync(OrchestrationClusterName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            OrchestrationClusterName parent = OrchestrationClusterName.FromProjectLocationOrchestrationCluster("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> response = telcoAutomationClient.ListDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentRevisions</summary>
        public void ListDeploymentRevisionsRequestObject()
        {
            // Snippet: ListDeploymentRevisions(ListDeploymentRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListDeploymentRevisionsRequest request = new ListDeploymentRevisionsRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            PagedEnumerable<ListDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.ListDeploymentRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentRevisionsAsync</summary>
        public async Task ListDeploymentRevisionsRequestObjectAsync()
        {
            // Snippet: ListDeploymentRevisionsAsync(ListDeploymentRevisionsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListDeploymentRevisionsRequest request = new ListDeploymentRevisionsRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.ListDeploymentRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentRevisions</summary>
        public void ListDeploymentRevisions()
        {
            // Snippet: ListDeploymentRevisions(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            PagedEnumerable<ListDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.ListDeploymentRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentRevisionsAsync</summary>
        public async Task ListDeploymentRevisionsAsync()
        {
            // Snippet: ListDeploymentRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            PagedAsyncEnumerable<ListDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.ListDeploymentRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentRevisions</summary>
        public void ListDeploymentRevisionsResourceNames()
        {
            // Snippet: ListDeploymentRevisions(DeploymentName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            PagedEnumerable<ListDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.ListDeploymentRevisions(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Deployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDeploymentRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDeploymentRevisionsAsync</summary>
        public async Task ListDeploymentRevisionsResourceNamesAsync()
        {
            // Snippet: ListDeploymentRevisionsAsync(DeploymentName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            PagedAsyncEnumerable<ListDeploymentRevisionsResponse, Deployment> response = telcoAutomationClient.ListDeploymentRevisionsAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Deployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDeploymentRevisionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Deployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Deployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Deployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DiscardDeploymentChanges</summary>
        public void DiscardDeploymentChangesRequestObject()
        {
            // Snippet: DiscardDeploymentChanges(DiscardDeploymentChangesRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DiscardDeploymentChangesRequest request = new DiscardDeploymentChangesRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            DiscardDeploymentChangesResponse response = telcoAutomationClient.DiscardDeploymentChanges(request);
            // End snippet
        }

        /// <summary>Snippet for DiscardDeploymentChangesAsync</summary>
        public async Task DiscardDeploymentChangesRequestObjectAsync()
        {
            // Snippet: DiscardDeploymentChangesAsync(DiscardDeploymentChangesRequest, CallSettings)
            // Additional: DiscardDeploymentChangesAsync(DiscardDeploymentChangesRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DiscardDeploymentChangesRequest request = new DiscardDeploymentChangesRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            DiscardDeploymentChangesResponse response = await telcoAutomationClient.DiscardDeploymentChangesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DiscardDeploymentChanges</summary>
        public void DiscardDeploymentChanges()
        {
            // Snippet: DiscardDeploymentChanges(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            DiscardDeploymentChangesResponse response = telcoAutomationClient.DiscardDeploymentChanges(name);
            // End snippet
        }

        /// <summary>Snippet for DiscardDeploymentChangesAsync</summary>
        public async Task DiscardDeploymentChangesAsync()
        {
            // Snippet: DiscardDeploymentChangesAsync(string, CallSettings)
            // Additional: DiscardDeploymentChangesAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            DiscardDeploymentChangesResponse response = await telcoAutomationClient.DiscardDeploymentChangesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DiscardDeploymentChanges</summary>
        public void DiscardDeploymentChangesResourceNames()
        {
            // Snippet: DiscardDeploymentChanges(DeploymentName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            DiscardDeploymentChangesResponse response = telcoAutomationClient.DiscardDeploymentChanges(name);
            // End snippet
        }

        /// <summary>Snippet for DiscardDeploymentChangesAsync</summary>
        public async Task DiscardDeploymentChangesResourceNamesAsync()
        {
            // Snippet: DiscardDeploymentChangesAsync(DeploymentName, CallSettings)
            // Additional: DiscardDeploymentChangesAsync(DeploymentName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            DiscardDeploymentChangesResponse response = await telcoAutomationClient.DiscardDeploymentChangesAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApplyDeployment</summary>
        public void ApplyDeploymentRequestObject()
        {
            // Snippet: ApplyDeployment(ApplyDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ApplyDeploymentRequest request = new ApplyDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = telcoAutomationClient.ApplyDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyDeploymentAsync</summary>
        public async Task ApplyDeploymentRequestObjectAsync()
        {
            // Snippet: ApplyDeploymentAsync(ApplyDeploymentRequest, CallSettings)
            // Additional: ApplyDeploymentAsync(ApplyDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ApplyDeploymentRequest request = new ApplyDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            Deployment response = await telcoAutomationClient.ApplyDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyDeployment</summary>
        public void ApplyDeployment()
        {
            // Snippet: ApplyDeployment(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = telcoAutomationClient.ApplyDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for ApplyDeploymentAsync</summary>
        public async Task ApplyDeploymentAsync()
        {
            // Snippet: ApplyDeploymentAsync(string, CallSettings)
            // Additional: ApplyDeploymentAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            Deployment response = await telcoAutomationClient.ApplyDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApplyDeployment</summary>
        public void ApplyDeploymentResourceNames()
        {
            // Snippet: ApplyDeployment(DeploymentName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = telcoAutomationClient.ApplyDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for ApplyDeploymentAsync</summary>
        public async Task ApplyDeploymentResourceNamesAsync()
        {
            // Snippet: ApplyDeploymentAsync(DeploymentName, CallSettings)
            // Additional: ApplyDeploymentAsync(DeploymentName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            Deployment response = await telcoAutomationClient.ApplyDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeDeploymentStatus</summary>
        public void ComputeDeploymentStatusRequestObject()
        {
            // Snippet: ComputeDeploymentStatus(ComputeDeploymentStatusRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ComputeDeploymentStatusRequest request = new ComputeDeploymentStatusRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            ComputeDeploymentStatusResponse response = telcoAutomationClient.ComputeDeploymentStatus(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeDeploymentStatusAsync</summary>
        public async Task ComputeDeploymentStatusRequestObjectAsync()
        {
            // Snippet: ComputeDeploymentStatusAsync(ComputeDeploymentStatusRequest, CallSettings)
            // Additional: ComputeDeploymentStatusAsync(ComputeDeploymentStatusRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ComputeDeploymentStatusRequest request = new ComputeDeploymentStatusRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            ComputeDeploymentStatusResponse response = await telcoAutomationClient.ComputeDeploymentStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ComputeDeploymentStatus</summary>
        public void ComputeDeploymentStatus()
        {
            // Snippet: ComputeDeploymentStatus(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            ComputeDeploymentStatusResponse response = telcoAutomationClient.ComputeDeploymentStatus(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeDeploymentStatusAsync</summary>
        public async Task ComputeDeploymentStatusAsync()
        {
            // Snippet: ComputeDeploymentStatusAsync(string, CallSettings)
            // Additional: ComputeDeploymentStatusAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            ComputeDeploymentStatusResponse response = await telcoAutomationClient.ComputeDeploymentStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeDeploymentStatus</summary>
        public void ComputeDeploymentStatusResourceNames()
        {
            // Snippet: ComputeDeploymentStatus(DeploymentName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            ComputeDeploymentStatusResponse response = telcoAutomationClient.ComputeDeploymentStatus(name);
            // End snippet
        }

        /// <summary>Snippet for ComputeDeploymentStatusAsync</summary>
        public async Task ComputeDeploymentStatusResourceNamesAsync()
        {
            // Snippet: ComputeDeploymentStatusAsync(DeploymentName, CallSettings)
            // Additional: ComputeDeploymentStatusAsync(DeploymentName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            ComputeDeploymentStatusResponse response = await telcoAutomationClient.ComputeDeploymentStatusAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RollbackDeployment</summary>
        public void RollbackDeploymentRequestObject()
        {
            // Snippet: RollbackDeployment(RollbackDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            RollbackDeploymentRequest request = new RollbackDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
                RevisionId = "",
            };
            // Make the request
            Deployment response = telcoAutomationClient.RollbackDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackDeploymentAsync</summary>
        public async Task RollbackDeploymentRequestObjectAsync()
        {
            // Snippet: RollbackDeploymentAsync(RollbackDeploymentRequest, CallSettings)
            // Additional: RollbackDeploymentAsync(RollbackDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            RollbackDeploymentRequest request = new RollbackDeploymentRequest
            {
                DeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
                RevisionId = "",
            };
            // Make the request
            Deployment response = await telcoAutomationClient.RollbackDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackDeployment</summary>
        public void RollbackDeployment()
        {
            // Snippet: RollbackDeployment(string, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            string revisionId = "";
            // Make the request
            Deployment response = telcoAutomationClient.RollbackDeployment(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackDeploymentAsync</summary>
        public async Task RollbackDeploymentAsync()
        {
            // Snippet: RollbackDeploymentAsync(string, string, CallSettings)
            // Additional: RollbackDeploymentAsync(string, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            string revisionId = "";
            // Make the request
            Deployment response = await telcoAutomationClient.RollbackDeploymentAsync(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackDeployment</summary>
        public void RollbackDeploymentResourceNames()
        {
            // Snippet: RollbackDeployment(DeploymentName, string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            string revisionId = "";
            // Make the request
            Deployment response = telcoAutomationClient.RollbackDeployment(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackDeploymentAsync</summary>
        public async Task RollbackDeploymentResourceNamesAsync()
        {
            // Snippet: RollbackDeploymentAsync(DeploymentName, string, CallSettings)
            // Additional: RollbackDeploymentAsync(DeploymentName, string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName name = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            string revisionId = "";
            // Make the request
            Deployment response = await telcoAutomationClient.RollbackDeploymentAsync(name, revisionId);
            // End snippet
        }

        /// <summary>Snippet for GetHydratedDeployment</summary>
        public void GetHydratedDeploymentRequestObject()
        {
            // Snippet: GetHydratedDeployment(GetHydratedDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            GetHydratedDeploymentRequest request = new GetHydratedDeploymentRequest
            {
                HydratedDeploymentName = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]"),
            };
            // Make the request
            HydratedDeployment response = telcoAutomationClient.GetHydratedDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetHydratedDeploymentAsync</summary>
        public async Task GetHydratedDeploymentRequestObjectAsync()
        {
            // Snippet: GetHydratedDeploymentAsync(GetHydratedDeploymentRequest, CallSettings)
            // Additional: GetHydratedDeploymentAsync(GetHydratedDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            GetHydratedDeploymentRequest request = new GetHydratedDeploymentRequest
            {
                HydratedDeploymentName = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]"),
            };
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.GetHydratedDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHydratedDeployment</summary>
        public void GetHydratedDeployment()
        {
            // Snippet: GetHydratedDeployment(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]/hydratedDeployments/[HYDRATED_DEPLOYMENT]";
            // Make the request
            HydratedDeployment response = telcoAutomationClient.GetHydratedDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetHydratedDeploymentAsync</summary>
        public async Task GetHydratedDeploymentAsync()
        {
            // Snippet: GetHydratedDeploymentAsync(string, CallSettings)
            // Additional: GetHydratedDeploymentAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]/hydratedDeployments/[HYDRATED_DEPLOYMENT]";
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.GetHydratedDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHydratedDeployment</summary>
        public void GetHydratedDeploymentResourceNames()
        {
            // Snippet: GetHydratedDeployment(HydratedDeploymentName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            HydratedDeploymentName name = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]");
            // Make the request
            HydratedDeployment response = telcoAutomationClient.GetHydratedDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetHydratedDeploymentAsync</summary>
        public async Task GetHydratedDeploymentResourceNamesAsync()
        {
            // Snippet: GetHydratedDeploymentAsync(HydratedDeploymentName, CallSettings)
            // Additional: GetHydratedDeploymentAsync(HydratedDeploymentName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            HydratedDeploymentName name = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]");
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.GetHydratedDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListHydratedDeployments</summary>
        public void ListHydratedDeploymentsRequestObject()
        {
            // Snippet: ListHydratedDeployments(ListHydratedDeploymentsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ListHydratedDeploymentsRequest request = new ListHydratedDeploymentsRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            PagedEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> response = telcoAutomationClient.ListHydratedDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HydratedDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHydratedDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HydratedDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HydratedDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HydratedDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHydratedDeploymentsAsync</summary>
        public async Task ListHydratedDeploymentsRequestObjectAsync()
        {
            // Snippet: ListHydratedDeploymentsAsync(ListHydratedDeploymentsRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ListHydratedDeploymentsRequest request = new ListHydratedDeploymentsRequest
            {
                ParentAsDeploymentName = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> response = telcoAutomationClient.ListHydratedDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HydratedDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHydratedDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HydratedDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HydratedDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HydratedDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHydratedDeployments</summary>
        public void ListHydratedDeployments()
        {
            // Snippet: ListHydratedDeployments(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            PagedEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> response = telcoAutomationClient.ListHydratedDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HydratedDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHydratedDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HydratedDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HydratedDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HydratedDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHydratedDeploymentsAsync</summary>
        public async Task ListHydratedDeploymentsAsync()
        {
            // Snippet: ListHydratedDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]";
            // Make the request
            PagedAsyncEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> response = telcoAutomationClient.ListHydratedDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HydratedDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHydratedDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HydratedDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HydratedDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HydratedDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHydratedDeployments</summary>
        public void ListHydratedDeploymentsResourceNames()
        {
            // Snippet: ListHydratedDeployments(DeploymentName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            DeploymentName parent = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            PagedEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> response = telcoAutomationClient.ListHydratedDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HydratedDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHydratedDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HydratedDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HydratedDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HydratedDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHydratedDeploymentsAsync</summary>
        public async Task ListHydratedDeploymentsResourceNamesAsync()
        {
            // Snippet: ListHydratedDeploymentsAsync(DeploymentName, string, int?, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            DeploymentName parent = DeploymentName.FromProjectLocationOrchestrationClusterDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]");
            // Make the request
            PagedAsyncEnumerable<ListHydratedDeploymentsResponse, HydratedDeployment> response = telcoAutomationClient.ListHydratedDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HydratedDeployment item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHydratedDeploymentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HydratedDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HydratedDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HydratedDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateHydratedDeployment</summary>
        public void UpdateHydratedDeploymentRequestObject()
        {
            // Snippet: UpdateHydratedDeployment(UpdateHydratedDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            UpdateHydratedDeploymentRequest request = new UpdateHydratedDeploymentRequest
            {
                HydratedDeployment = new HydratedDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            HydratedDeployment response = telcoAutomationClient.UpdateHydratedDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateHydratedDeploymentAsync</summary>
        public async Task UpdateHydratedDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateHydratedDeploymentAsync(UpdateHydratedDeploymentRequest, CallSettings)
            // Additional: UpdateHydratedDeploymentAsync(UpdateHydratedDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            UpdateHydratedDeploymentRequest request = new UpdateHydratedDeploymentRequest
            {
                HydratedDeployment = new HydratedDeployment(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.UpdateHydratedDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateHydratedDeployment</summary>
        public void UpdateHydratedDeployment()
        {
            // Snippet: UpdateHydratedDeployment(HydratedDeployment, FieldMask, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            HydratedDeployment hydratedDeployment = new HydratedDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            HydratedDeployment response = telcoAutomationClient.UpdateHydratedDeployment(hydratedDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateHydratedDeploymentAsync</summary>
        public async Task UpdateHydratedDeploymentAsync()
        {
            // Snippet: UpdateHydratedDeploymentAsync(HydratedDeployment, FieldMask, CallSettings)
            // Additional: UpdateHydratedDeploymentAsync(HydratedDeployment, FieldMask, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            HydratedDeployment hydratedDeployment = new HydratedDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.UpdateHydratedDeploymentAsync(hydratedDeployment, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ApplyHydratedDeployment</summary>
        public void ApplyHydratedDeploymentRequestObject()
        {
            // Snippet: ApplyHydratedDeployment(ApplyHydratedDeploymentRequest, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            ApplyHydratedDeploymentRequest request = new ApplyHydratedDeploymentRequest
            {
                HydratedDeploymentName = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]"),
            };
            // Make the request
            HydratedDeployment response = telcoAutomationClient.ApplyHydratedDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyHydratedDeploymentAsync</summary>
        public async Task ApplyHydratedDeploymentRequestObjectAsync()
        {
            // Snippet: ApplyHydratedDeploymentAsync(ApplyHydratedDeploymentRequest, CallSettings)
            // Additional: ApplyHydratedDeploymentAsync(ApplyHydratedDeploymentRequest, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            ApplyHydratedDeploymentRequest request = new ApplyHydratedDeploymentRequest
            {
                HydratedDeploymentName = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]"),
            };
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.ApplyHydratedDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApplyHydratedDeployment</summary>
        public void ApplyHydratedDeployment()
        {
            // Snippet: ApplyHydratedDeployment(string, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]/hydratedDeployments/[HYDRATED_DEPLOYMENT]";
            // Make the request
            HydratedDeployment response = telcoAutomationClient.ApplyHydratedDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for ApplyHydratedDeploymentAsync</summary>
        public async Task ApplyHydratedDeploymentAsync()
        {
            // Snippet: ApplyHydratedDeploymentAsync(string, CallSettings)
            // Additional: ApplyHydratedDeploymentAsync(string, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/orchestrationClusters/[ORCHESTRATION_CLUSTER]/deployments/[DEPLOYMENT]/hydratedDeployments/[HYDRATED_DEPLOYMENT]";
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.ApplyHydratedDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApplyHydratedDeployment</summary>
        public void ApplyHydratedDeploymentResourceNames()
        {
            // Snippet: ApplyHydratedDeployment(HydratedDeploymentName, CallSettings)
            // Create client
            TelcoAutomationClient telcoAutomationClient = TelcoAutomationClient.Create();
            // Initialize request argument(s)
            HydratedDeploymentName name = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]");
            // Make the request
            HydratedDeployment response = telcoAutomationClient.ApplyHydratedDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for ApplyHydratedDeploymentAsync</summary>
        public async Task ApplyHydratedDeploymentResourceNamesAsync()
        {
            // Snippet: ApplyHydratedDeploymentAsync(HydratedDeploymentName, CallSettings)
            // Additional: ApplyHydratedDeploymentAsync(HydratedDeploymentName, CancellationToken)
            // Create client
            TelcoAutomationClient telcoAutomationClient = await TelcoAutomationClient.CreateAsync();
            // Initialize request argument(s)
            HydratedDeploymentName name = HydratedDeploymentName.FromProjectLocationOrchestrationClusterDeploymentHydratedDeployment("[PROJECT]", "[LOCATION]", "[ORCHESTRATION_CLUSTER]", "[DEPLOYMENT]", "[HYDRATED_DEPLOYMENT]");
            // Make the request
            HydratedDeployment response = await telcoAutomationClient.ApplyHydratedDeploymentAsync(name);
            // End snippet
        }
    }
}
