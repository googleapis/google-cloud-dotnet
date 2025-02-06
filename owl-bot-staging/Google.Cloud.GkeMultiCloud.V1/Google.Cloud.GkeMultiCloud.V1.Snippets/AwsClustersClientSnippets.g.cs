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
    using Google.Cloud.GkeMultiCloud.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAwsClustersClientSnippets
    {
        /// <summary>Snippet for CreateAwsCluster</summary>
        public void CreateAwsClusterRequestObject()
        {
            // Snippet: CreateAwsCluster(CreateAwsClusterRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            CreateAwsClusterRequest request = new CreateAwsClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AwsCluster = new AwsCluster(),
                AwsClusterId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.CreateAwsCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsClusterAsync</summary>
        public async Task CreateAwsClusterRequestObjectAsync()
        {
            // Snippet: CreateAwsClusterAsync(CreateAwsClusterRequest, CallSettings)
            // Additional: CreateAwsClusterAsync(CreateAwsClusterRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            CreateAwsClusterRequest request = new CreateAwsClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AwsCluster = new AwsCluster(),
                AwsClusterId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.CreateAwsClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsCluster</summary>
        public void CreateAwsCluster()
        {
            // Snippet: CreateAwsCluster(string, AwsCluster, string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AwsCluster awsCluster = new AwsCluster();
            string awsClusterId = "";
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.CreateAwsCluster(parent, awsCluster, awsClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsClusterAsync</summary>
        public async Task CreateAwsClusterAsync()
        {
            // Snippet: CreateAwsClusterAsync(string, AwsCluster, string, CallSettings)
            // Additional: CreateAwsClusterAsync(string, AwsCluster, string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AwsCluster awsCluster = new AwsCluster();
            string awsClusterId = "";
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.CreateAwsClusterAsync(parent, awsCluster, awsClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsCluster</summary>
        public void CreateAwsClusterResourceNames()
        {
            // Snippet: CreateAwsCluster(LocationName, AwsCluster, string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AwsCluster awsCluster = new AwsCluster();
            string awsClusterId = "";
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.CreateAwsCluster(parent, awsCluster, awsClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsClusterAsync</summary>
        public async Task CreateAwsClusterResourceNamesAsync()
        {
            // Snippet: CreateAwsClusterAsync(LocationName, AwsCluster, string, CallSettings)
            // Additional: CreateAwsClusterAsync(LocationName, AwsCluster, string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AwsCluster awsCluster = new AwsCluster();
            string awsClusterId = "";
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.CreateAwsClusterAsync(parent, awsCluster, awsClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsCluster</summary>
        public void UpdateAwsClusterRequestObject()
        {
            // Snippet: UpdateAwsCluster(UpdateAwsClusterRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            UpdateAwsClusterRequest request = new UpdateAwsClusterRequest
            {
                AwsCluster = new AwsCluster(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.UpdateAwsCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsClusterAsync</summary>
        public async Task UpdateAwsClusterRequestObjectAsync()
        {
            // Snippet: UpdateAwsClusterAsync(UpdateAwsClusterRequest, CallSettings)
            // Additional: UpdateAwsClusterAsync(UpdateAwsClusterRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAwsClusterRequest request = new UpdateAwsClusterRequest
            {
                AwsCluster = new AwsCluster(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.UpdateAwsClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsCluster</summary>
        public void UpdateAwsCluster()
        {
            // Snippet: UpdateAwsCluster(AwsCluster, FieldMask, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsCluster awsCluster = new AwsCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.UpdateAwsCluster(awsCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsClusterAsync</summary>
        public async Task UpdateAwsClusterAsync()
        {
            // Snippet: UpdateAwsClusterAsync(AwsCluster, FieldMask, CallSettings)
            // Additional: UpdateAwsClusterAsync(AwsCluster, FieldMask, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsCluster awsCluster = new AwsCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.UpdateAwsClusterAsync(awsCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAwsCluster</summary>
        public void GetAwsClusterRequestObject()
        {
            // Snippet: GetAwsCluster(GetAwsClusterRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            AwsCluster response = awsClustersClient.GetAwsCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsClusterAsync</summary>
        public async Task GetAwsClusterRequestObjectAsync()
        {
            // Snippet: GetAwsClusterAsync(GetAwsClusterRequest, CallSettings)
            // Additional: GetAwsClusterAsync(GetAwsClusterRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAwsClusterRequest request = new GetAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            AwsCluster response = await awsClustersClient.GetAwsClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsCluster</summary>
        public void GetAwsCluster()
        {
            // Snippet: GetAwsCluster(string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            // Make the request
            AwsCluster response = awsClustersClient.GetAwsCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsClusterAsync</summary>
        public async Task GetAwsClusterAsync()
        {
            // Snippet: GetAwsClusterAsync(string, CallSettings)
            // Additional: GetAwsClusterAsync(string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            // Make the request
            AwsCluster response = await awsClustersClient.GetAwsClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsCluster</summary>
        public void GetAwsClusterResourceNames()
        {
            // Snippet: GetAwsCluster(AwsClusterName, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsClusterName name = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            // Make the request
            AwsCluster response = awsClustersClient.GetAwsCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsClusterAsync</summary>
        public async Task GetAwsClusterResourceNamesAsync()
        {
            // Snippet: GetAwsClusterAsync(AwsClusterName, CallSettings)
            // Additional: GetAwsClusterAsync(AwsClusterName, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsClusterName name = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            // Make the request
            AwsCluster response = await awsClustersClient.GetAwsClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAwsClusters</summary>
        public void ListAwsClustersRequestObject()
        {
            // Snippet: ListAwsClusters(ListAwsClustersRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            ListAwsClustersRequest request = new ListAwsClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AwsCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAwsClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsClustersAsync</summary>
        public async Task ListAwsClustersRequestObjectAsync()
        {
            // Snippet: ListAwsClustersAsync(ListAwsClustersRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            ListAwsClustersRequest request = new ListAwsClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AwsCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAwsClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsClusters</summary>
        public void ListAwsClusters()
        {
            // Snippet: ListAwsClusters(string, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AwsCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAwsClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsClustersAsync</summary>
        public async Task ListAwsClustersAsync()
        {
            // Snippet: ListAwsClustersAsync(string, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AwsCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAwsClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsClusters</summary>
        public void ListAwsClustersResourceNames()
        {
            // Snippet: ListAwsClusters(LocationName, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AwsCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAwsClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsClustersAsync</summary>
        public async Task ListAwsClustersResourceNamesAsync()
        {
            // Snippet: ListAwsClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AwsCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAwsClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsCluster</summary>
        public void DeleteAwsClusterRequestObject()
        {
            // Snippet: DeleteAwsCluster(DeleteAwsClusterRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            DeleteAwsClusterRequest request = new DeleteAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsClusterAsync</summary>
        public async Task DeleteAwsClusterRequestObjectAsync()
        {
            // Snippet: DeleteAwsClusterAsync(DeleteAwsClusterRequest, CallSettings)
            // Additional: DeleteAwsClusterAsync(DeleteAwsClusterRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAwsClusterRequest request = new DeleteAwsClusterRequest
            {
                AwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsCluster</summary>
        public void DeleteAwsCluster()
        {
            // Snippet: DeleteAwsCluster(string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsClusterAsync</summary>
        public async Task DeleteAwsClusterAsync()
        {
            // Snippet: DeleteAwsClusterAsync(string, CallSettings)
            // Additional: DeleteAwsClusterAsync(string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsCluster</summary>
        public void DeleteAwsClusterResourceNames()
        {
            // Snippet: DeleteAwsCluster(AwsClusterName, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsClusterName name = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsClusterAsync</summary>
        public async Task DeleteAwsClusterResourceNamesAsync()
        {
            // Snippet: DeleteAwsClusterAsync(AwsClusterName, CallSettings)
            // Additional: DeleteAwsClusterAsync(AwsClusterName, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsClusterName name = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAwsClusterAgentToken</summary>
        public void GenerateAwsClusterAgentTokenRequestObject()
        {
            // Snippet: GenerateAwsClusterAgentToken(GenerateAwsClusterAgentTokenRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            GenerateAwsClusterAgentTokenRequest request = new GenerateAwsClusterAgentTokenRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                SubjectToken = "",
                SubjectTokenType = "",
                Version = "",
                NodePoolId = "",
                GrantType = "",
                Audience = "",
                Scope = "",
                RequestedTokenType = "",
                Options = "",
            };
            // Make the request
            GenerateAwsClusterAgentTokenResponse response = awsClustersClient.GenerateAwsClusterAgentToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAwsClusterAgentTokenAsync</summary>
        public async Task GenerateAwsClusterAgentTokenRequestObjectAsync()
        {
            // Snippet: GenerateAwsClusterAgentTokenAsync(GenerateAwsClusterAgentTokenRequest, CallSettings)
            // Additional: GenerateAwsClusterAgentTokenAsync(GenerateAwsClusterAgentTokenRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAwsClusterAgentTokenRequest request = new GenerateAwsClusterAgentTokenRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                SubjectToken = "",
                SubjectTokenType = "",
                Version = "",
                NodePoolId = "",
                GrantType = "",
                Audience = "",
                Scope = "",
                RequestedTokenType = "",
                Options = "",
            };
            // Make the request
            GenerateAwsClusterAgentTokenResponse response = await awsClustersClient.GenerateAwsClusterAgentTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAwsAccessToken</summary>
        public void GenerateAwsAccessTokenRequestObject()
        {
            // Snippet: GenerateAwsAccessToken(GenerateAwsAccessTokenRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            GenerateAwsAccessTokenRequest request = new GenerateAwsAccessTokenRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            GenerateAwsAccessTokenResponse response = awsClustersClient.GenerateAwsAccessToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAwsAccessTokenAsync</summary>
        public async Task GenerateAwsAccessTokenRequestObjectAsync()
        {
            // Snippet: GenerateAwsAccessTokenAsync(GenerateAwsAccessTokenRequest, CallSettings)
            // Additional: GenerateAwsAccessTokenAsync(GenerateAwsAccessTokenRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAwsAccessTokenRequest request = new GenerateAwsAccessTokenRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            GenerateAwsAccessTokenResponse response = await awsClustersClient.GenerateAwsAccessTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAwsNodePool</summary>
        public void CreateAwsNodePoolRequestObject()
        {
            // Snippet: CreateAwsNodePool(CreateAwsNodePoolRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            CreateAwsNodePoolRequest request = new CreateAwsNodePoolRequest
            {
                ParentAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                AwsNodePool = new AwsNodePool(),
                AwsNodePoolId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.CreateAwsNodePool(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsNodePoolAsync</summary>
        public async Task CreateAwsNodePoolRequestObjectAsync()
        {
            // Snippet: CreateAwsNodePoolAsync(CreateAwsNodePoolRequest, CallSettings)
            // Additional: CreateAwsNodePoolAsync(CreateAwsNodePoolRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            CreateAwsNodePoolRequest request = new CreateAwsNodePoolRequest
            {
                ParentAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
                AwsNodePool = new AwsNodePool(),
                AwsNodePoolId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.CreateAwsNodePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsNodePool</summary>
        public void CreateAwsNodePool()
        {
            // Snippet: CreateAwsNodePool(string, AwsNodePool, string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            AwsNodePool awsNodePool = new AwsNodePool();
            string awsNodePoolId = "";
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.CreateAwsNodePool(parent, awsNodePool, awsNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsNodePoolAsync</summary>
        public async Task CreateAwsNodePoolAsync()
        {
            // Snippet: CreateAwsNodePoolAsync(string, AwsNodePool, string, CallSettings)
            // Additional: CreateAwsNodePoolAsync(string, AwsNodePool, string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            AwsNodePool awsNodePool = new AwsNodePool();
            string awsNodePoolId = "";
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.CreateAwsNodePoolAsync(parent, awsNodePool, awsNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsNodePool</summary>
        public void CreateAwsNodePoolResourceNames()
        {
            // Snippet: CreateAwsNodePool(AwsClusterName, AwsNodePool, string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsClusterName parent = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            AwsNodePool awsNodePool = new AwsNodePool();
            string awsNodePoolId = "";
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.CreateAwsNodePool(parent, awsNodePool, awsNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAwsNodePoolAsync</summary>
        public async Task CreateAwsNodePoolResourceNamesAsync()
        {
            // Snippet: CreateAwsNodePoolAsync(AwsClusterName, AwsNodePool, string, CallSettings)
            // Additional: CreateAwsNodePoolAsync(AwsClusterName, AwsNodePool, string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsClusterName parent = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            AwsNodePool awsNodePool = new AwsNodePool();
            string awsNodePoolId = "";
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.CreateAwsNodePoolAsync(parent, awsNodePool, awsNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsNodePool</summary>
        public void UpdateAwsNodePoolRequestObject()
        {
            // Snippet: UpdateAwsNodePool(UpdateAwsNodePoolRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            UpdateAwsNodePoolRequest request = new UpdateAwsNodePoolRequest
            {
                AwsNodePool = new AwsNodePool(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.UpdateAwsNodePool(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsNodePoolAsync</summary>
        public async Task UpdateAwsNodePoolRequestObjectAsync()
        {
            // Snippet: UpdateAwsNodePoolAsync(UpdateAwsNodePoolRequest, CallSettings)
            // Additional: UpdateAwsNodePoolAsync(UpdateAwsNodePoolRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAwsNodePoolRequest request = new UpdateAwsNodePoolRequest
            {
                AwsNodePool = new AwsNodePool(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.UpdateAwsNodePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsNodePool</summary>
        public void UpdateAwsNodePool()
        {
            // Snippet: UpdateAwsNodePool(AwsNodePool, FieldMask, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsNodePool awsNodePool = new AwsNodePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.UpdateAwsNodePool(awsNodePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAwsNodePoolAsync</summary>
        public async Task UpdateAwsNodePoolAsync()
        {
            // Snippet: UpdateAwsNodePoolAsync(AwsNodePool, FieldMask, CallSettings)
            // Additional: UpdateAwsNodePoolAsync(AwsNodePool, FieldMask, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsNodePool awsNodePool = new AwsNodePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.UpdateAwsNodePoolAsync(awsNodePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackAwsNodePoolUpdate</summary>
        public void RollbackAwsNodePoolUpdateRequestObject()
        {
            // Snippet: RollbackAwsNodePoolUpdate(RollbackAwsNodePoolUpdateRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            RollbackAwsNodePoolUpdateRequest request = new RollbackAwsNodePoolUpdateRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                RespectPdb = false,
            };
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.RollbackAwsNodePoolUpdate(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceRollbackAwsNodePoolUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackAwsNodePoolUpdateAsync</summary>
        public async Task RollbackAwsNodePoolUpdateRequestObjectAsync()
        {
            // Snippet: RollbackAwsNodePoolUpdateAsync(RollbackAwsNodePoolUpdateRequest, CallSettings)
            // Additional: RollbackAwsNodePoolUpdateAsync(RollbackAwsNodePoolUpdateRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            RollbackAwsNodePoolUpdateRequest request = new RollbackAwsNodePoolUpdateRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                RespectPdb = false,
            };
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.RollbackAwsNodePoolUpdateAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceRollbackAwsNodePoolUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackAwsNodePoolUpdate</summary>
        public void RollbackAwsNodePoolUpdate()
        {
            // Snippet: RollbackAwsNodePoolUpdate(string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]/awsNodePools/[AWS_NODE_POOL]";
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.RollbackAwsNodePoolUpdate(name);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceRollbackAwsNodePoolUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackAwsNodePoolUpdateAsync</summary>
        public async Task RollbackAwsNodePoolUpdateAsync()
        {
            // Snippet: RollbackAwsNodePoolUpdateAsync(string, CallSettings)
            // Additional: RollbackAwsNodePoolUpdateAsync(string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]/awsNodePools/[AWS_NODE_POOL]";
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.RollbackAwsNodePoolUpdateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceRollbackAwsNodePoolUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackAwsNodePoolUpdate</summary>
        public void RollbackAwsNodePoolUpdateResourceNames()
        {
            // Snippet: RollbackAwsNodePoolUpdate(AwsNodePoolName, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsNodePoolName name = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]");
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.RollbackAwsNodePoolUpdate(name);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceRollbackAwsNodePoolUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RollbackAwsNodePoolUpdateAsync</summary>
        public async Task RollbackAwsNodePoolUpdateResourceNamesAsync()
        {
            // Snippet: RollbackAwsNodePoolUpdateAsync(AwsNodePoolName, CallSettings)
            // Additional: RollbackAwsNodePoolUpdateAsync(AwsNodePoolName, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsNodePoolName name = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]");
            // Make the request
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.RollbackAwsNodePoolUpdateAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AwsNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceRollbackAwsNodePoolUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AwsNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAwsNodePool</summary>
        public void GetAwsNodePoolRequestObject()
        {
            // Snippet: GetAwsNodePool(GetAwsNodePoolRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            // Make the request
            AwsNodePool response = awsClustersClient.GetAwsNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsNodePoolAsync</summary>
        public async Task GetAwsNodePoolRequestObjectAsync()
        {
            // Snippet: GetAwsNodePoolAsync(GetAwsNodePoolRequest, CallSettings)
            // Additional: GetAwsNodePoolAsync(GetAwsNodePoolRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
            };
            // Make the request
            AwsNodePool response = await awsClustersClient.GetAwsNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsNodePool</summary>
        public void GetAwsNodePool()
        {
            // Snippet: GetAwsNodePool(string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]/awsNodePools/[AWS_NODE_POOL]";
            // Make the request
            AwsNodePool response = awsClustersClient.GetAwsNodePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsNodePoolAsync</summary>
        public async Task GetAwsNodePoolAsync()
        {
            // Snippet: GetAwsNodePoolAsync(string, CallSettings)
            // Additional: GetAwsNodePoolAsync(string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]/awsNodePools/[AWS_NODE_POOL]";
            // Make the request
            AwsNodePool response = await awsClustersClient.GetAwsNodePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsNodePool</summary>
        public void GetAwsNodePoolResourceNames()
        {
            // Snippet: GetAwsNodePool(AwsNodePoolName, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsNodePoolName name = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]");
            // Make the request
            AwsNodePool response = awsClustersClient.GetAwsNodePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsNodePoolAsync</summary>
        public async Task GetAwsNodePoolResourceNamesAsync()
        {
            // Snippet: GetAwsNodePoolAsync(AwsNodePoolName, CallSettings)
            // Additional: GetAwsNodePoolAsync(AwsNodePoolName, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsNodePoolName name = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]");
            // Make the request
            AwsNodePool response = await awsClustersClient.GetAwsNodePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAwsNodePools</summary>
        public void ListAwsNodePoolsRequestObject()
        {
            // Snippet: ListAwsNodePools(ListAwsNodePoolsRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest
            {
                ParentAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AwsNodePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsNodePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsNodePoolsAsync</summary>
        public async Task ListAwsNodePoolsRequestObjectAsync()
        {
            // Snippet: ListAwsNodePoolsAsync(ListAwsNodePoolsRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest
            {
                ParentAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AwsNodePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAwsNodePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsNodePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsNodePools</summary>
        public void ListAwsNodePools()
        {
            // Snippet: ListAwsNodePools(string, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            // Make the request
            PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AwsNodePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsNodePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsNodePoolsAsync</summary>
        public async Task ListAwsNodePoolsAsync()
        {
            // Snippet: ListAwsNodePoolsAsync(string, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AwsNodePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAwsNodePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsNodePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsNodePools</summary>
        public void ListAwsNodePoolsResourceNames()
        {
            // Snippet: ListAwsNodePools(AwsClusterName, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsClusterName parent = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            // Make the request
            PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AwsNodePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsNodePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAwsNodePoolsAsync</summary>
        public async Task ListAwsNodePoolsResourceNamesAsync()
        {
            // Snippet: ListAwsNodePoolsAsync(AwsClusterName, string, int?, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsClusterName parent = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AwsNodePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAwsNodePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AwsNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AwsNodePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AwsNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsNodePool</summary>
        public void DeleteAwsNodePoolRequestObject()
        {
            // Snippet: DeleteAwsNodePool(DeleteAwsNodePoolRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            DeleteAwsNodePoolRequest request = new DeleteAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsNodePool(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsNodePoolAsync</summary>
        public async Task DeleteAwsNodePoolRequestObjectAsync()
        {
            // Snippet: DeleteAwsNodePoolAsync(DeleteAwsNodePoolRequest, CallSettings)
            // Additional: DeleteAwsNodePoolAsync(DeleteAwsNodePoolRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAwsNodePoolRequest request = new DeleteAwsNodePoolRequest
            {
                AwsNodePoolName = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsNodePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsNodePool</summary>
        public void DeleteAwsNodePool()
        {
            // Snippet: DeleteAwsNodePool(string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]/awsNodePools/[AWS_NODE_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsNodePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsNodePoolAsync</summary>
        public async Task DeleteAwsNodePoolAsync()
        {
            // Snippet: DeleteAwsNodePoolAsync(string, CallSettings)
            // Additional: DeleteAwsNodePoolAsync(string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsClusters/[AWS_CLUSTER]/awsNodePools/[AWS_NODE_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsNodePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsNodePool</summary>
        public void DeleteAwsNodePoolResourceNames()
        {
            // Snippet: DeleteAwsNodePool(AwsNodePoolName, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsNodePoolName name = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsNodePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAwsNodePoolAsync</summary>
        public async Task DeleteAwsNodePoolResourceNamesAsync()
        {
            // Snippet: DeleteAwsNodePoolAsync(AwsNodePoolName, CallSettings)
            // Additional: DeleteAwsNodePoolAsync(AwsNodePoolName, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsNodePoolName name = AwsNodePoolName.FromProjectLocationAwsClusterAwsNodePool("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]", "[AWS_NODE_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsNodePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAwsOpenIdConfig</summary>
        public void GetAwsOpenIdConfigRequestObject()
        {
            // Snippet: GetAwsOpenIdConfig(GetAwsOpenIdConfigRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            GetAwsOpenIdConfigRequest request = new GetAwsOpenIdConfigRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            AwsOpenIdConfig response = awsClustersClient.GetAwsOpenIdConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsOpenIdConfigAsync</summary>
        public async Task GetAwsOpenIdConfigRequestObjectAsync()
        {
            // Snippet: GetAwsOpenIdConfigAsync(GetAwsOpenIdConfigRequest, CallSettings)
            // Additional: GetAwsOpenIdConfigAsync(GetAwsOpenIdConfigRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAwsOpenIdConfigRequest request = new GetAwsOpenIdConfigRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            AwsOpenIdConfig response = await awsClustersClient.GetAwsOpenIdConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsJsonWebKeys</summary>
        public void GetAwsJsonWebKeysRequestObject()
        {
            // Snippet: GetAwsJsonWebKeys(GetAwsJsonWebKeysRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            GetAwsJsonWebKeysRequest request = new GetAwsJsonWebKeysRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            AwsJsonWebKeys response = awsClustersClient.GetAwsJsonWebKeys(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsJsonWebKeysAsync</summary>
        public async Task GetAwsJsonWebKeysRequestObjectAsync()
        {
            // Snippet: GetAwsJsonWebKeysAsync(GetAwsJsonWebKeysRequest, CallSettings)
            // Additional: GetAwsJsonWebKeysAsync(GetAwsJsonWebKeysRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAwsJsonWebKeysRequest request = new GetAwsJsonWebKeysRequest
            {
                AwsClusterAsAwsClusterName = AwsClusterName.FromProjectLocationAwsCluster("[PROJECT]", "[LOCATION]", "[AWS_CLUSTER]"),
            };
            // Make the request
            AwsJsonWebKeys response = await awsClustersClient.GetAwsJsonWebKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsServerConfig</summary>
        public void GetAwsServerConfigRequestObject()
        {
            // Snippet: GetAwsServerConfig(GetAwsServerConfigRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AwsServerConfig response = awsClustersClient.GetAwsServerConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsServerConfigAsync</summary>
        public async Task GetAwsServerConfigRequestObjectAsync()
        {
            // Snippet: GetAwsServerConfigAsync(GetAwsServerConfigRequest, CallSettings)
            // Additional: GetAwsServerConfigAsync(GetAwsServerConfigRequest, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest
            {
                AwsServerConfigName = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AwsServerConfig response = await awsClustersClient.GetAwsServerConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAwsServerConfig</summary>
        public void GetAwsServerConfig()
        {
            // Snippet: GetAwsServerConfig(string, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsServerConfig";
            // Make the request
            AwsServerConfig response = awsClustersClient.GetAwsServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsServerConfigAsync</summary>
        public async Task GetAwsServerConfigAsync()
        {
            // Snippet: GetAwsServerConfigAsync(string, CallSettings)
            // Additional: GetAwsServerConfigAsync(string, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/awsServerConfig";
            // Make the request
            AwsServerConfig response = await awsClustersClient.GetAwsServerConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsServerConfig</summary>
        public void GetAwsServerConfigResourceNames()
        {
            // Snippet: GetAwsServerConfig(AwsServerConfigName, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
            AwsServerConfigName name = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AwsServerConfig response = awsClustersClient.GetAwsServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAwsServerConfigAsync</summary>
        public async Task GetAwsServerConfigResourceNamesAsync()
        {
            // Snippet: GetAwsServerConfigAsync(AwsServerConfigName, CallSettings)
            // Additional: GetAwsServerConfigAsync(AwsServerConfigName, CancellationToken)
            // Create client
            AwsClustersClient awsClustersClient = await AwsClustersClient.CreateAsync();
            // Initialize request argument(s)
            AwsServerConfigName name = AwsServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AwsServerConfig response = await awsClustersClient.GetAwsServerConfigAsync(name);
            // End snippet
        }
    }
}
