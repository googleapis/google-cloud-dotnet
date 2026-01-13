// Copyright 2026 Google LLC
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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    [ObsoleteAttribute]
    public sealed class AllGeneratedAwsClustersClientSnippets
    {
        /// <summary>Snippet for CreateAwsCluster</summary>
        public void CreateAwsClusterRequestObject()
        {
            // Snippet: CreateAwsCluster(CreateAwsClusterRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            CreateAwsClusterRequest request = new CreateAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.CreateAwsCluster(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            CreateAwsClusterRequest request = new CreateAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.CreateAwsClusterAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster awsCluster = new AwsCluster();
#pragma warning restore CS0612
            string awsClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.CreateAwsCluster(parent, awsCluster, awsClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster awsCluster = new AwsCluster();
#pragma warning restore CS0612
            string awsClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.CreateAwsClusterAsync(parent, awsCluster, awsClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster awsCluster = new AwsCluster();
#pragma warning restore CS0612
            string awsClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.CreateAwsCluster(parent, awsCluster, awsClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster awsCluster = new AwsCluster();
#pragma warning restore CS0612
            string awsClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.CreateAwsClusterAsync(parent, awsCluster, awsClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAwsClusterRequest request = new UpdateAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.UpdateAwsCluster(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAwsClusterRequest request = new UpdateAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.UpdateAwsClusterAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster awsCluster = new AwsCluster();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = awsClustersClient.UpdateAwsCluster(awsCluster, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster awsCluster = new AwsCluster();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> response = await awsClustersClient.UpdateAwsClusterAsync(awsCluster, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsCluster, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsClusterRequest request = new GetAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsCluster response = awsClustersClient.GetAwsCluster(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsClusterRequest request = new GetAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsCluster response = await awsClustersClient.GetAwsClusterAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster response = awsClustersClient.GetAwsCluster(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster response = await awsClustersClient.GetAwsClusterAsync(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster response = awsClustersClient.GetAwsCluster(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsCluster response = await awsClustersClient.GetAwsClusterAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListAwsClusters</summary>
        public void ListAwsClustersRequestObject()
        {
            // Snippet: ListAwsClusters(ListAwsClustersRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListAwsClustersRequest request = new ListAwsClustersRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClusters(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AwsCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAwsClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsCluster> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            ListAwsClustersRequest request = new ListAwsClustersRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClustersAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await foreach (AwsCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await foreach (ListAwsClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsCluster> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClusters(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AwsCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAwsClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsCluster> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClustersAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await foreach (AwsCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await foreach (ListAwsClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsCluster> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClusters(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AwsCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAwsClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsCluster> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAwsClustersResponse, AwsCluster> response = awsClustersClient.ListAwsClustersAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await foreach (AwsCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await foreach (ListAwsClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsCluster> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAwsClusterRequest request = new DeleteAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsCluster(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsCluster(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAwsClusterRequest request = new DeleteAwsClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsClusterAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsClusterAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsCluster(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsCluster(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsClusterAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsClusterAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsCluster(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsCluster(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsClusterAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsClusterAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GenerateAwsClusterAgentTokenRequest request = new GenerateAwsClusterAgentTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAwsClusterAgentTokenResponse response = awsClustersClient.GenerateAwsClusterAgentToken(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GenerateAwsClusterAgentTokenRequest request = new GenerateAwsClusterAgentTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAwsClusterAgentTokenResponse response = await awsClustersClient.GenerateAwsClusterAgentTokenAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GenerateAwsAccessToken</summary>
        public void GenerateAwsAccessTokenRequestObject()
        {
            // Snippet: GenerateAwsAccessToken(GenerateAwsAccessTokenRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GenerateAwsAccessTokenRequest request = new GenerateAwsAccessTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAwsAccessTokenResponse response = awsClustersClient.GenerateAwsAccessToken(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GenerateAwsAccessTokenRequest request = new GenerateAwsAccessTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAwsAccessTokenResponse response = await awsClustersClient.GenerateAwsAccessTokenAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateAwsNodePool</summary>
        public void CreateAwsNodePoolRequestObject()
        {
            // Snippet: CreateAwsNodePool(CreateAwsNodePoolRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            CreateAwsNodePoolRequest request = new CreateAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.CreateAwsNodePool(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            CreateAwsNodePoolRequest request = new CreateAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.CreateAwsNodePoolAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool awsNodePool = new AwsNodePool();
#pragma warning restore CS0612
            string awsNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.CreateAwsNodePool(parent, awsNodePool, awsNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool awsNodePool = new AwsNodePool();
#pragma warning restore CS0612
            string awsNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.CreateAwsNodePoolAsync(parent, awsNodePool, awsNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool awsNodePool = new AwsNodePool();
#pragma warning restore CS0612
            string awsNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.CreateAwsNodePool(parent, awsNodePool, awsNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceCreateAwsNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool awsNodePool = new AwsNodePool();
#pragma warning restore CS0612
            string awsNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.CreateAwsNodePoolAsync(parent, awsNodePool, awsNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceCreateAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAwsNodePoolRequest request = new UpdateAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.UpdateAwsNodePool(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAwsNodePoolRequest request = new UpdateAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.UpdateAwsNodePoolAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool awsNodePool = new AwsNodePool();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.UpdateAwsNodePool(awsNodePool, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceUpdateAwsNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool awsNodePool = new AwsNodePool();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.UpdateAwsNodePoolAsync(awsNodePool, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceUpdateAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            RollbackAwsNodePoolUpdateRequest request = new RollbackAwsNodePoolUpdateRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.RollbackAwsNodePoolUpdate(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceRollbackAwsNodePoolUpdate(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            RollbackAwsNodePoolUpdateRequest request = new RollbackAwsNodePoolUpdateRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.RollbackAwsNodePoolUpdateAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceRollbackAwsNodePoolUpdateAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.RollbackAwsNodePoolUpdate(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceRollbackAwsNodePoolUpdate(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.RollbackAwsNodePoolUpdateAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceRollbackAwsNodePoolUpdateAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = awsClustersClient.RollbackAwsNodePoolUpdate(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceRollbackAwsNodePoolUpdate(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> response = await awsClustersClient.RollbackAwsNodePoolUpdateAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AwsNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AwsNodePool, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceRollbackAwsNodePoolUpdateAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AwsNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsNodePool response = awsClustersClient.GetAwsNodePool(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsNodePoolRequest request = new GetAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsNodePool response = await awsClustersClient.GetAwsNodePoolAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool response = awsClustersClient.GetAwsNodePool(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool response = await awsClustersClient.GetAwsNodePoolAsync(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool response = awsClustersClient.GetAwsNodePool(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsNodePool response = await awsClustersClient.GetAwsNodePoolAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListAwsNodePools</summary>
        public void ListAwsNodePoolsRequestObject()
        {
            // Snippet: ListAwsNodePools(ListAwsNodePoolsRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePools(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AwsNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsNodePool> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            ListAwsNodePoolsRequest request = new ListAwsNodePoolsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePoolsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await foreach (AwsNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsNodePool> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePools(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AwsNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsNodePool> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePoolsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await foreach (AwsNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsNodePool> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePools(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AwsNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsNodePool> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAwsNodePoolsResponse, AwsNodePool> response = awsClustersClient.ListAwsNodePoolsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await foreach (AwsNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await foreach (ListAwsNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AwsNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AwsNodePool> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AwsNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAwsNodePoolRequest request = new DeleteAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsNodePool(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsNodePool(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAwsNodePoolRequest request = new DeleteAwsNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsNodePoolAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsNodePool(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsNodePool(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsNodePoolAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = awsClustersClient.DeleteAwsNodePool(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = awsClustersClient.PollOnceDeleteAwsNodePool(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await awsClustersClient.DeleteAwsNodePoolAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await awsClustersClient.PollOnceDeleteAwsNodePoolAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsOpenIdConfigRequest request = new GetAwsOpenIdConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsOpenIdConfig response = awsClustersClient.GetAwsOpenIdConfig(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsOpenIdConfigRequest request = new GetAwsOpenIdConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsOpenIdConfig response = await awsClustersClient.GetAwsOpenIdConfigAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetAwsJsonWebKeys</summary>
        public void GetAwsJsonWebKeysRequestObject()
        {
            // Snippet: GetAwsJsonWebKeys(GetAwsJsonWebKeysRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetAwsJsonWebKeysRequest request = new GetAwsJsonWebKeysRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsJsonWebKeys response = awsClustersClient.GetAwsJsonWebKeys(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsJsonWebKeysRequest request = new GetAwsJsonWebKeysRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsJsonWebKeys response = await awsClustersClient.GetAwsJsonWebKeysAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetAwsServerConfig</summary>
        public void GetAwsServerConfigRequestObject()
        {
            // Snippet: GetAwsServerConfig(GetAwsServerConfigRequest, CallSettings)
            // Create client
            AwsClustersClient awsClustersClient = AwsClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsServerConfig response = awsClustersClient.GetAwsServerConfig(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAwsServerConfigRequest request = new GetAwsServerConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AwsServerConfig response = await awsClustersClient.GetAwsServerConfigAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsServerConfig response = awsClustersClient.GetAwsServerConfig(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsServerConfig response = await awsClustersClient.GetAwsServerConfigAsync(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsServerConfig response = awsClustersClient.GetAwsServerConfig(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AwsServerConfig response = await awsClustersClient.GetAwsServerConfigAsync(name);
#pragma warning restore CS0612
            // End snippet
        }
    }
}
