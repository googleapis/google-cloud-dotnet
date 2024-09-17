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
    using Google.Cloud.OracleDatabase.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOracleDatabaseClientSnippets
    {
        /// <summary>Snippet for ListCloudExadataInfrastructures</summary>
        public void ListCloudExadataInfrastructuresRequestObject()
        {
            // Snippet: ListCloudExadataInfrastructures(ListCloudExadataInfrastructuresRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListCloudExadataInfrastructuresRequest request = new ListCloudExadataInfrastructuresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> response = oracleDatabaseClient.ListCloudExadataInfrastructures(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudExadataInfrastructure item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudExadataInfrastructuresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudExadataInfrastructure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudExadataInfrastructure> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudExadataInfrastructure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudExadataInfrastructuresAsync</summary>
        public async Task ListCloudExadataInfrastructuresRequestObjectAsync()
        {
            // Snippet: ListCloudExadataInfrastructuresAsync(ListCloudExadataInfrastructuresRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListCloudExadataInfrastructuresRequest request = new ListCloudExadataInfrastructuresRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> response = oracleDatabaseClient.ListCloudExadataInfrastructuresAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudExadataInfrastructure item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudExadataInfrastructuresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudExadataInfrastructure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudExadataInfrastructure> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudExadataInfrastructure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudExadataInfrastructures</summary>
        public void ListCloudExadataInfrastructures()
        {
            // Snippet: ListCloudExadataInfrastructures(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> response = oracleDatabaseClient.ListCloudExadataInfrastructures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudExadataInfrastructure item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudExadataInfrastructuresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudExadataInfrastructure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudExadataInfrastructure> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudExadataInfrastructure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudExadataInfrastructuresAsync</summary>
        public async Task ListCloudExadataInfrastructuresAsync()
        {
            // Snippet: ListCloudExadataInfrastructuresAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> response = oracleDatabaseClient.ListCloudExadataInfrastructuresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudExadataInfrastructure item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudExadataInfrastructuresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudExadataInfrastructure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudExadataInfrastructure> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudExadataInfrastructure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudExadataInfrastructures</summary>
        public void ListCloudExadataInfrastructuresResourceNames()
        {
            // Snippet: ListCloudExadataInfrastructures(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> response = oracleDatabaseClient.ListCloudExadataInfrastructures(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudExadataInfrastructure item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudExadataInfrastructuresResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudExadataInfrastructure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudExadataInfrastructure> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudExadataInfrastructure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudExadataInfrastructuresAsync</summary>
        public async Task ListCloudExadataInfrastructuresResourceNamesAsync()
        {
            // Snippet: ListCloudExadataInfrastructuresAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCloudExadataInfrastructuresResponse, CloudExadataInfrastructure> response = oracleDatabaseClient.ListCloudExadataInfrastructuresAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudExadataInfrastructure item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudExadataInfrastructuresResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudExadataInfrastructure item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudExadataInfrastructure> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudExadataInfrastructure item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCloudExadataInfrastructure</summary>
        public void GetCloudExadataInfrastructureRequestObject()
        {
            // Snippet: GetCloudExadataInfrastructure(GetCloudExadataInfrastructureRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetCloudExadataInfrastructureRequest request = new GetCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]"),
            };
            // Make the request
            CloudExadataInfrastructure response = oracleDatabaseClient.GetCloudExadataInfrastructure(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudExadataInfrastructureAsync</summary>
        public async Task GetCloudExadataInfrastructureRequestObjectAsync()
        {
            // Snippet: GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest, CallSettings)
            // Additional: GetCloudExadataInfrastructureAsync(GetCloudExadataInfrastructureRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetCloudExadataInfrastructureRequest request = new GetCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]"),
            };
            // Make the request
            CloudExadataInfrastructure response = await oracleDatabaseClient.GetCloudExadataInfrastructureAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudExadataInfrastructure</summary>
        public void GetCloudExadataInfrastructure()
        {
            // Snippet: GetCloudExadataInfrastructure(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudExadataInfrastructures/[CLOUD_EXADATA_INFRASTRUCTURE]";
            // Make the request
            CloudExadataInfrastructure response = oracleDatabaseClient.GetCloudExadataInfrastructure(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudExadataInfrastructureAsync</summary>
        public async Task GetCloudExadataInfrastructureAsync()
        {
            // Snippet: GetCloudExadataInfrastructureAsync(string, CallSettings)
            // Additional: GetCloudExadataInfrastructureAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudExadataInfrastructures/[CLOUD_EXADATA_INFRASTRUCTURE]";
            // Make the request
            CloudExadataInfrastructure response = await oracleDatabaseClient.GetCloudExadataInfrastructureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudExadataInfrastructure</summary>
        public void GetCloudExadataInfrastructureResourceNames()
        {
            // Snippet: GetCloudExadataInfrastructure(CloudExadataInfrastructureName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CloudExadataInfrastructureName name = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]");
            // Make the request
            CloudExadataInfrastructure response = oracleDatabaseClient.GetCloudExadataInfrastructure(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudExadataInfrastructureAsync</summary>
        public async Task GetCloudExadataInfrastructureResourceNamesAsync()
        {
            // Snippet: GetCloudExadataInfrastructureAsync(CloudExadataInfrastructureName, CallSettings)
            // Additional: GetCloudExadataInfrastructureAsync(CloudExadataInfrastructureName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CloudExadataInfrastructureName name = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]");
            // Make the request
            CloudExadataInfrastructure response = await oracleDatabaseClient.GetCloudExadataInfrastructureAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudExadataInfrastructure</summary>
        public void CreateCloudExadataInfrastructureRequestObject()
        {
            // Snippet: CreateCloudExadataInfrastructure(CreateCloudExadataInfrastructureRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateCloudExadataInfrastructureRequest request = new CreateCloudExadataInfrastructureRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CloudExadataInfrastructureId = "",
                CloudExadataInfrastructure = new CloudExadataInfrastructure(),
                RequestId = "",
            };
            // Make the request
            Operation<CloudExadataInfrastructure, OperationMetadata> response = oracleDatabaseClient.CreateCloudExadataInfrastructure(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudExadataInfrastructure, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudExadataInfrastructure result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudExadataInfrastructure, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateCloudExadataInfrastructure(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudExadataInfrastructure retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudExadataInfrastructureAsync</summary>
        public async Task CreateCloudExadataInfrastructureRequestObjectAsync()
        {
            // Snippet: CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest, CallSettings)
            // Additional: CreateCloudExadataInfrastructureAsync(CreateCloudExadataInfrastructureRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateCloudExadataInfrastructureRequest request = new CreateCloudExadataInfrastructureRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CloudExadataInfrastructureId = "",
                CloudExadataInfrastructure = new CloudExadataInfrastructure(),
                RequestId = "",
            };
            // Make the request
            Operation<CloudExadataInfrastructure, OperationMetadata> response = await oracleDatabaseClient.CreateCloudExadataInfrastructureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudExadataInfrastructure, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudExadataInfrastructure result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudExadataInfrastructure, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateCloudExadataInfrastructureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudExadataInfrastructure retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudExadataInfrastructure</summary>
        public void CreateCloudExadataInfrastructure()
        {
            // Snippet: CreateCloudExadataInfrastructure(string, CloudExadataInfrastructure, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CloudExadataInfrastructure cloudExadataInfrastructure = new CloudExadataInfrastructure();
            string cloudExadataInfrastructureId = "";
            // Make the request
            Operation<CloudExadataInfrastructure, OperationMetadata> response = oracleDatabaseClient.CreateCloudExadataInfrastructure(parent, cloudExadataInfrastructure, cloudExadataInfrastructureId);

            // Poll until the returned long-running operation is complete
            Operation<CloudExadataInfrastructure, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudExadataInfrastructure result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudExadataInfrastructure, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateCloudExadataInfrastructure(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudExadataInfrastructure retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudExadataInfrastructureAsync</summary>
        public async Task CreateCloudExadataInfrastructureAsync()
        {
            // Snippet: CreateCloudExadataInfrastructureAsync(string, CloudExadataInfrastructure, string, CallSettings)
            // Additional: CreateCloudExadataInfrastructureAsync(string, CloudExadataInfrastructure, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CloudExadataInfrastructure cloudExadataInfrastructure = new CloudExadataInfrastructure();
            string cloudExadataInfrastructureId = "";
            // Make the request
            Operation<CloudExadataInfrastructure, OperationMetadata> response = await oracleDatabaseClient.CreateCloudExadataInfrastructureAsync(parent, cloudExadataInfrastructure, cloudExadataInfrastructureId);

            // Poll until the returned long-running operation is complete
            Operation<CloudExadataInfrastructure, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudExadataInfrastructure result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudExadataInfrastructure, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateCloudExadataInfrastructureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudExadataInfrastructure retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudExadataInfrastructure</summary>
        public void CreateCloudExadataInfrastructureResourceNames()
        {
            // Snippet: CreateCloudExadataInfrastructure(LocationName, CloudExadataInfrastructure, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudExadataInfrastructure cloudExadataInfrastructure = new CloudExadataInfrastructure();
            string cloudExadataInfrastructureId = "";
            // Make the request
            Operation<CloudExadataInfrastructure, OperationMetadata> response = oracleDatabaseClient.CreateCloudExadataInfrastructure(parent, cloudExadataInfrastructure, cloudExadataInfrastructureId);

            // Poll until the returned long-running operation is complete
            Operation<CloudExadataInfrastructure, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudExadataInfrastructure result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudExadataInfrastructure, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateCloudExadataInfrastructure(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudExadataInfrastructure retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudExadataInfrastructureAsync</summary>
        public async Task CreateCloudExadataInfrastructureResourceNamesAsync()
        {
            // Snippet: CreateCloudExadataInfrastructureAsync(LocationName, CloudExadataInfrastructure, string, CallSettings)
            // Additional: CreateCloudExadataInfrastructureAsync(LocationName, CloudExadataInfrastructure, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudExadataInfrastructure cloudExadataInfrastructure = new CloudExadataInfrastructure();
            string cloudExadataInfrastructureId = "";
            // Make the request
            Operation<CloudExadataInfrastructure, OperationMetadata> response = await oracleDatabaseClient.CreateCloudExadataInfrastructureAsync(parent, cloudExadataInfrastructure, cloudExadataInfrastructureId);

            // Poll until the returned long-running operation is complete
            Operation<CloudExadataInfrastructure, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudExadataInfrastructure result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudExadataInfrastructure, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateCloudExadataInfrastructureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudExadataInfrastructure retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudExadataInfrastructure</summary>
        public void DeleteCloudExadataInfrastructureRequestObject()
        {
            // Snippet: DeleteCloudExadataInfrastructure(DeleteCloudExadataInfrastructureRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteCloudExadataInfrastructureRequest request = new DeleteCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteCloudExadataInfrastructure(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteCloudExadataInfrastructure(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudExadataInfrastructureAsync</summary>
        public async Task DeleteCloudExadataInfrastructureRequestObjectAsync()
        {
            // Snippet: DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest, CallSettings)
            // Additional: DeleteCloudExadataInfrastructureAsync(DeleteCloudExadataInfrastructureRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCloudExadataInfrastructureRequest request = new DeleteCloudExadataInfrastructureRequest
            {
                CloudExadataInfrastructureName = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteCloudExadataInfrastructureAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteCloudExadataInfrastructureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudExadataInfrastructure</summary>
        public void DeleteCloudExadataInfrastructure()
        {
            // Snippet: DeleteCloudExadataInfrastructure(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudExadataInfrastructures/[CLOUD_EXADATA_INFRASTRUCTURE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteCloudExadataInfrastructure(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteCloudExadataInfrastructure(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudExadataInfrastructureAsync</summary>
        public async Task DeleteCloudExadataInfrastructureAsync()
        {
            // Snippet: DeleteCloudExadataInfrastructureAsync(string, CallSettings)
            // Additional: DeleteCloudExadataInfrastructureAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudExadataInfrastructures/[CLOUD_EXADATA_INFRASTRUCTURE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteCloudExadataInfrastructureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteCloudExadataInfrastructureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudExadataInfrastructure</summary>
        public void DeleteCloudExadataInfrastructureResourceNames()
        {
            // Snippet: DeleteCloudExadataInfrastructure(CloudExadataInfrastructureName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CloudExadataInfrastructureName name = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteCloudExadataInfrastructure(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteCloudExadataInfrastructure(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudExadataInfrastructureAsync</summary>
        public async Task DeleteCloudExadataInfrastructureResourceNamesAsync()
        {
            // Snippet: DeleteCloudExadataInfrastructureAsync(CloudExadataInfrastructureName, CallSettings)
            // Additional: DeleteCloudExadataInfrastructureAsync(CloudExadataInfrastructureName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CloudExadataInfrastructureName name = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteCloudExadataInfrastructureAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteCloudExadataInfrastructureAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListCloudVmClusters</summary>
        public void ListCloudVmClustersRequestObject()
        {
            // Snippet: ListCloudVmClusters(ListCloudVmClustersRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListCloudVmClustersRequest request = new ListCloudVmClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListCloudVmClustersResponse, CloudVmCluster> response = oracleDatabaseClient.ListCloudVmClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudVmCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudVmClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudVmCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudVmClustersAsync</summary>
        public async Task ListCloudVmClustersRequestObjectAsync()
        {
            // Snippet: ListCloudVmClustersAsync(ListCloudVmClustersRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListCloudVmClustersRequest request = new ListCloudVmClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCloudVmClustersResponse, CloudVmCluster> response = oracleDatabaseClient.ListCloudVmClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudVmCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudVmClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudVmCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudVmClusters</summary>
        public void ListCloudVmClusters()
        {
            // Snippet: ListCloudVmClusters(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCloudVmClustersResponse, CloudVmCluster> response = oracleDatabaseClient.ListCloudVmClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudVmCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudVmClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudVmCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudVmClustersAsync</summary>
        public async Task ListCloudVmClustersAsync()
        {
            // Snippet: ListCloudVmClustersAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCloudVmClustersResponse, CloudVmCluster> response = oracleDatabaseClient.ListCloudVmClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudVmCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudVmClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudVmCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudVmClusters</summary>
        public void ListCloudVmClustersResourceNames()
        {
            // Snippet: ListCloudVmClusters(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCloudVmClustersResponse, CloudVmCluster> response = oracleDatabaseClient.ListCloudVmClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudVmCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudVmClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudVmCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudVmClustersAsync</summary>
        public async Task ListCloudVmClustersResourceNamesAsync()
        {
            // Snippet: ListCloudVmClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCloudVmClustersResponse, CloudVmCluster> response = oracleDatabaseClient.ListCloudVmClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudVmCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudVmClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudVmCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCloudVmCluster</summary>
        public void GetCloudVmClusterRequestObject()
        {
            // Snippet: GetCloudVmCluster(GetCloudVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetCloudVmClusterRequest request = new GetCloudVmClusterRequest
            {
                CloudVmClusterName = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]"),
            };
            // Make the request
            CloudVmCluster response = oracleDatabaseClient.GetCloudVmCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudVmClusterAsync</summary>
        public async Task GetCloudVmClusterRequestObjectAsync()
        {
            // Snippet: GetCloudVmClusterAsync(GetCloudVmClusterRequest, CallSettings)
            // Additional: GetCloudVmClusterAsync(GetCloudVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetCloudVmClusterRequest request = new GetCloudVmClusterRequest
            {
                CloudVmClusterName = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]"),
            };
            // Make the request
            CloudVmCluster response = await oracleDatabaseClient.GetCloudVmClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudVmCluster</summary>
        public void GetCloudVmCluster()
        {
            // Snippet: GetCloudVmCluster(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudVmClusters/[CLOUD_VM_CLUSTER]";
            // Make the request
            CloudVmCluster response = oracleDatabaseClient.GetCloudVmCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudVmClusterAsync</summary>
        public async Task GetCloudVmClusterAsync()
        {
            // Snippet: GetCloudVmClusterAsync(string, CallSettings)
            // Additional: GetCloudVmClusterAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudVmClusters/[CLOUD_VM_CLUSTER]";
            // Make the request
            CloudVmCluster response = await oracleDatabaseClient.GetCloudVmClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudVmCluster</summary>
        public void GetCloudVmClusterResourceNames()
        {
            // Snippet: GetCloudVmCluster(CloudVmClusterName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CloudVmClusterName name = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]");
            // Make the request
            CloudVmCluster response = oracleDatabaseClient.GetCloudVmCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudVmClusterAsync</summary>
        public async Task GetCloudVmClusterResourceNamesAsync()
        {
            // Snippet: GetCloudVmClusterAsync(CloudVmClusterName, CallSettings)
            // Additional: GetCloudVmClusterAsync(CloudVmClusterName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CloudVmClusterName name = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]");
            // Make the request
            CloudVmCluster response = await oracleDatabaseClient.GetCloudVmClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateCloudVmCluster</summary>
        public void CreateCloudVmClusterRequestObject()
        {
            // Snippet: CreateCloudVmCluster(CreateCloudVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateCloudVmClusterRequest request = new CreateCloudVmClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CloudVmClusterId = "",
                CloudVmCluster = new CloudVmCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<CloudVmCluster, OperationMetadata> response = oracleDatabaseClient.CreateCloudVmCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateCloudVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudVmClusterAsync</summary>
        public async Task CreateCloudVmClusterRequestObjectAsync()
        {
            // Snippet: CreateCloudVmClusterAsync(CreateCloudVmClusterRequest, CallSettings)
            // Additional: CreateCloudVmClusterAsync(CreateCloudVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateCloudVmClusterRequest request = new CreateCloudVmClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CloudVmClusterId = "",
                CloudVmCluster = new CloudVmCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<CloudVmCluster, OperationMetadata> response = await oracleDatabaseClient.CreateCloudVmClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<CloudVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateCloudVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudVmCluster</summary>
        public void CreateCloudVmCluster()
        {
            // Snippet: CreateCloudVmCluster(string, CloudVmCluster, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CloudVmCluster cloudVmCluster = new CloudVmCluster();
            string cloudVmClusterId = "";
            // Make the request
            Operation<CloudVmCluster, OperationMetadata> response = oracleDatabaseClient.CreateCloudVmCluster(parent, cloudVmCluster, cloudVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<CloudVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateCloudVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudVmClusterAsync</summary>
        public async Task CreateCloudVmClusterAsync()
        {
            // Snippet: CreateCloudVmClusterAsync(string, CloudVmCluster, string, CallSettings)
            // Additional: CreateCloudVmClusterAsync(string, CloudVmCluster, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CloudVmCluster cloudVmCluster = new CloudVmCluster();
            string cloudVmClusterId = "";
            // Make the request
            Operation<CloudVmCluster, OperationMetadata> response = await oracleDatabaseClient.CreateCloudVmClusterAsync(parent, cloudVmCluster, cloudVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<CloudVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateCloudVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudVmCluster</summary>
        public void CreateCloudVmClusterResourceNames()
        {
            // Snippet: CreateCloudVmCluster(LocationName, CloudVmCluster, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudVmCluster cloudVmCluster = new CloudVmCluster();
            string cloudVmClusterId = "";
            // Make the request
            Operation<CloudVmCluster, OperationMetadata> response = oracleDatabaseClient.CreateCloudVmCluster(parent, cloudVmCluster, cloudVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<CloudVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            CloudVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateCloudVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateCloudVmClusterAsync</summary>
        public async Task CreateCloudVmClusterResourceNamesAsync()
        {
            // Snippet: CreateCloudVmClusterAsync(LocationName, CloudVmCluster, string, CallSettings)
            // Additional: CreateCloudVmClusterAsync(LocationName, CloudVmCluster, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudVmCluster cloudVmCluster = new CloudVmCluster();
            string cloudVmClusterId = "";
            // Make the request
            Operation<CloudVmCluster, OperationMetadata> response = await oracleDatabaseClient.CreateCloudVmClusterAsync(parent, cloudVmCluster, cloudVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<CloudVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            CloudVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<CloudVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateCloudVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                CloudVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudVmCluster</summary>
        public void DeleteCloudVmClusterRequestObject()
        {
            // Snippet: DeleteCloudVmCluster(DeleteCloudVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteCloudVmClusterRequest request = new DeleteCloudVmClusterRequest
            {
                CloudVmClusterName = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteCloudVmCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteCloudVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudVmClusterAsync</summary>
        public async Task DeleteCloudVmClusterRequestObjectAsync()
        {
            // Snippet: DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest, CallSettings)
            // Additional: DeleteCloudVmClusterAsync(DeleteCloudVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteCloudVmClusterRequest request = new DeleteCloudVmClusterRequest
            {
                CloudVmClusterName = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteCloudVmClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteCloudVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudVmCluster</summary>
        public void DeleteCloudVmCluster()
        {
            // Snippet: DeleteCloudVmCluster(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudVmClusters/[CLOUD_VM_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteCloudVmCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteCloudVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudVmClusterAsync</summary>
        public async Task DeleteCloudVmClusterAsync()
        {
            // Snippet: DeleteCloudVmClusterAsync(string, CallSettings)
            // Additional: DeleteCloudVmClusterAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudVmClusters/[CLOUD_VM_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteCloudVmClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteCloudVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudVmCluster</summary>
        public void DeleteCloudVmClusterResourceNames()
        {
            // Snippet: DeleteCloudVmCluster(CloudVmClusterName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CloudVmClusterName name = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteCloudVmCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteCloudVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteCloudVmClusterAsync</summary>
        public async Task DeleteCloudVmClusterResourceNamesAsync()
        {
            // Snippet: DeleteCloudVmClusterAsync(CloudVmClusterName, CallSettings)
            // Additional: DeleteCloudVmClusterAsync(CloudVmClusterName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CloudVmClusterName name = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteCloudVmClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteCloudVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlementsRequestObject()
        {
            // Snippet: ListEntitlements(ListEntitlementsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = oracleDatabaseClient.ListEntitlements(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsRequestObjectAsync()
        {
            // Snippet: ListEntitlementsAsync(ListEntitlementsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = oracleDatabaseClient.ListEntitlementsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlements()
        {
            // Snippet: ListEntitlements(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = oracleDatabaseClient.ListEntitlements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsAsync()
        {
            // Snippet: ListEntitlementsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = oracleDatabaseClient.ListEntitlementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlementsResourceNames()
        {
            // Snippet: ListEntitlements(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = oracleDatabaseClient.ListEntitlements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsResourceNamesAsync()
        {
            // Snippet: ListEntitlementsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = oracleDatabaseClient.ListEntitlementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbServers</summary>
        public void ListDbServersRequestObject()
        {
            // Snippet: ListDbServers(ListDbServersRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDbServersRequest request = new ListDbServersRequest
            {
                ParentAsCloudExadataInfrastructureName = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]"),
            };
            // Make the request
            PagedEnumerable<ListDbServersResponse, DbServer> response = oracleDatabaseClient.ListDbServers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbServersAsync</summary>
        public async Task ListDbServersRequestObjectAsync()
        {
            // Snippet: ListDbServersAsync(ListDbServersRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDbServersRequest request = new ListDbServersRequest
            {
                ParentAsCloudExadataInfrastructureName = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDbServersResponse, DbServer> response = oracleDatabaseClient.ListDbServersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbServers</summary>
        public void ListDbServers()
        {
            // Snippet: ListDbServers(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/cloudExadataInfrastructures/[CLOUD_EXADATA_INFRASTRUCTURE]";
            // Make the request
            PagedEnumerable<ListDbServersResponse, DbServer> response = oracleDatabaseClient.ListDbServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbServersAsync</summary>
        public async Task ListDbServersAsync()
        {
            // Snippet: ListDbServersAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/cloudExadataInfrastructures/[CLOUD_EXADATA_INFRASTRUCTURE]";
            // Make the request
            PagedAsyncEnumerable<ListDbServersResponse, DbServer> response = oracleDatabaseClient.ListDbServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbServers</summary>
        public void ListDbServersResourceNames()
        {
            // Snippet: ListDbServers(CloudExadataInfrastructureName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CloudExadataInfrastructureName parent = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]");
            // Make the request
            PagedEnumerable<ListDbServersResponse, DbServer> response = oracleDatabaseClient.ListDbServers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbServer item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbServersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbServer> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbServersAsync</summary>
        public async Task ListDbServersResourceNamesAsync()
        {
            // Snippet: ListDbServersAsync(CloudExadataInfrastructureName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CloudExadataInfrastructureName parent = CloudExadataInfrastructureName.FromProjectLocationCloudExadataInfrastructure("[PROJECT]", "[LOCATION]", "[CLOUD_EXADATA_INFRASTRUCTURE]");
            // Make the request
            PagedAsyncEnumerable<ListDbServersResponse, DbServer> response = oracleDatabaseClient.ListDbServersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbServer item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbServersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbServer item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbServer> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbServer item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbNodes</summary>
        public void ListDbNodesRequestObject()
        {
            // Snippet: ListDbNodes(ListDbNodesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                ParentAsCloudVmClusterName = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListDbNodesResponse, DbNode> response = oracleDatabaseClient.ListDbNodes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbNode item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbNode> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbNodesAsync</summary>
        public async Task ListDbNodesRequestObjectAsync()
        {
            // Snippet: ListDbNodesAsync(ListDbNodesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDbNodesRequest request = new ListDbNodesRequest
            {
                ParentAsCloudVmClusterName = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDbNodesResponse, DbNode> response = oracleDatabaseClient.ListDbNodesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbNode item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbNode> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbNodes</summary>
        public void ListDbNodes()
        {
            // Snippet: ListDbNodes(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/cloudVmClusters/[CLOUD_VM_CLUSTER]";
            // Make the request
            PagedEnumerable<ListDbNodesResponse, DbNode> response = oracleDatabaseClient.ListDbNodes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbNode item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbNode> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbNodesAsync</summary>
        public async Task ListDbNodesAsync()
        {
            // Snippet: ListDbNodesAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/cloudVmClusters/[CLOUD_VM_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListDbNodesResponse, DbNode> response = oracleDatabaseClient.ListDbNodesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbNode item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbNode> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbNodes</summary>
        public void ListDbNodesResourceNames()
        {
            // Snippet: ListDbNodes(CloudVmClusterName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CloudVmClusterName parent = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]");
            // Make the request
            PagedEnumerable<ListDbNodesResponse, DbNode> response = oracleDatabaseClient.ListDbNodes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbNode item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbNodesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbNode> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbNodesAsync</summary>
        public async Task ListDbNodesResourceNamesAsync()
        {
            // Snippet: ListDbNodesAsync(CloudVmClusterName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CloudVmClusterName parent = CloudVmClusterName.FromProjectLocationCloudVmCluster("[PROJECT]", "[LOCATION]", "[CLOUD_VM_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListDbNodesResponse, DbNode> response = oracleDatabaseClient.ListDbNodesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbNode item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbNodesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbNode item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbNode> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbNode item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGiVersions</summary>
        public void ListGiVersionsRequestObject()
        {
            // Snippet: ListGiVersions(ListGiVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListGiVersionsRequest request = new ListGiVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListGiVersionsResponse, GiVersion> response = oracleDatabaseClient.ListGiVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GiVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGiVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GiVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGiVersionsAsync</summary>
        public async Task ListGiVersionsRequestObjectAsync()
        {
            // Snippet: ListGiVersionsAsync(ListGiVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListGiVersionsRequest request = new ListGiVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListGiVersionsResponse, GiVersion> response = oracleDatabaseClient.ListGiVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GiVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGiVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GiVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGiVersions</summary>
        public void ListGiVersions()
        {
            // Snippet: ListGiVersions(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListGiVersionsResponse, GiVersion> response = oracleDatabaseClient.ListGiVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GiVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGiVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GiVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGiVersionsAsync</summary>
        public async Task ListGiVersionsAsync()
        {
            // Snippet: ListGiVersionsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListGiVersionsResponse, GiVersion> response = oracleDatabaseClient.ListGiVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GiVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGiVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GiVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGiVersions</summary>
        public void ListGiVersionsResourceNames()
        {
            // Snippet: ListGiVersions(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListGiVersionsResponse, GiVersion> response = oracleDatabaseClient.ListGiVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GiVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGiVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GiVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGiVersionsAsync</summary>
        public async Task ListGiVersionsResourceNamesAsync()
        {
            // Snippet: ListGiVersionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListGiVersionsResponse, GiVersion> response = oracleDatabaseClient.ListGiVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((GiVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGiVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GiVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GiVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GiVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemShapes</summary>
        public void ListDbSystemShapesRequestObject()
        {
            // Snippet: ListDbSystemShapes(ListDbSystemShapesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDbSystemShapesRequest request = new ListDbSystemShapesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDbSystemShapesResponse, DbSystemShape> response = oracleDatabaseClient.ListDbSystemShapes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystemShape item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemShapesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemShape item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemShape> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemShape item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemShapesAsync</summary>
        public async Task ListDbSystemShapesRequestObjectAsync()
        {
            // Snippet: ListDbSystemShapesAsync(ListDbSystemShapesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDbSystemShapesRequest request = new ListDbSystemShapesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDbSystemShapesResponse, DbSystemShape> response = oracleDatabaseClient.ListDbSystemShapesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystemShape item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemShapesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemShape item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemShape> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemShape item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemShapes</summary>
        public void ListDbSystemShapes()
        {
            // Snippet: ListDbSystemShapes(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDbSystemShapesResponse, DbSystemShape> response = oracleDatabaseClient.ListDbSystemShapes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystemShape item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemShapesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemShape item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemShape> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemShape item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemShapesAsync</summary>
        public async Task ListDbSystemShapesAsync()
        {
            // Snippet: ListDbSystemShapesAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDbSystemShapesResponse, DbSystemShape> response = oracleDatabaseClient.ListDbSystemShapesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystemShape item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemShapesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemShape item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemShape> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemShape item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemShapes</summary>
        public void ListDbSystemShapesResourceNames()
        {
            // Snippet: ListDbSystemShapes(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDbSystemShapesResponse, DbSystemShape> response = oracleDatabaseClient.ListDbSystemShapes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystemShape item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemShapesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemShape item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemShape> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemShape item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemShapesAsync</summary>
        public async Task ListDbSystemShapesResourceNamesAsync()
        {
            // Snippet: ListDbSystemShapesAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDbSystemShapesResponse, DbSystemShape> response = oracleDatabaseClient.ListDbSystemShapesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystemShape item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemShapesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemShape item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemShape> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemShape item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabases</summary>
        public void ListAutonomousDatabasesRequestObject()
        {
            // Snippet: ListAutonomousDatabases(ListAutonomousDatabasesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListAutonomousDatabasesRequest request = new ListAutonomousDatabasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> response = oracleDatabaseClient.ListAutonomousDatabases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabasesAsync</summary>
        public async Task ListAutonomousDatabasesRequestObjectAsync()
        {
            // Snippet: ListAutonomousDatabasesAsync(ListAutonomousDatabasesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListAutonomousDatabasesRequest request = new ListAutonomousDatabasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> response = oracleDatabaseClient.ListAutonomousDatabasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabases</summary>
        public void ListAutonomousDatabases()
        {
            // Snippet: ListAutonomousDatabases(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> response = oracleDatabaseClient.ListAutonomousDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabasesAsync</summary>
        public async Task ListAutonomousDatabasesAsync()
        {
            // Snippet: ListAutonomousDatabasesAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> response = oracleDatabaseClient.ListAutonomousDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabases</summary>
        public void ListAutonomousDatabasesResourceNames()
        {
            // Snippet: ListAutonomousDatabases(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> response = oracleDatabaseClient.ListAutonomousDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabasesAsync</summary>
        public async Task ListAutonomousDatabasesResourceNamesAsync()
        {
            // Snippet: ListAutonomousDatabasesAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabasesResponse, AutonomousDatabase> response = oracleDatabaseClient.ListAutonomousDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAutonomousDatabase</summary>
        public void GetAutonomousDatabaseRequestObject()
        {
            // Snippet: GetAutonomousDatabase(GetAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetAutonomousDatabaseRequest request = new GetAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            AutonomousDatabase response = oracleDatabaseClient.GetAutonomousDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutonomousDatabaseAsync</summary>
        public async Task GetAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: GetAutonomousDatabaseAsync(GetAutonomousDatabaseRequest, CallSettings)
            // Additional: GetAutonomousDatabaseAsync(GetAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetAutonomousDatabaseRequest request = new GetAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            AutonomousDatabase response = await oracleDatabaseClient.GetAutonomousDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutonomousDatabase</summary>
        public void GetAutonomousDatabase()
        {
            // Snippet: GetAutonomousDatabase(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            AutonomousDatabase response = oracleDatabaseClient.GetAutonomousDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutonomousDatabaseAsync</summary>
        public async Task GetAutonomousDatabaseAsync()
        {
            // Snippet: GetAutonomousDatabaseAsync(string, CallSettings)
            // Additional: GetAutonomousDatabaseAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            AutonomousDatabase response = await oracleDatabaseClient.GetAutonomousDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutonomousDatabase</summary>
        public void GetAutonomousDatabaseResourceNames()
        {
            // Snippet: GetAutonomousDatabase(AutonomousDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            AutonomousDatabase response = oracleDatabaseClient.GetAutonomousDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutonomousDatabaseAsync</summary>
        public async Task GetAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: GetAutonomousDatabaseAsync(AutonomousDatabaseName, CallSettings)
            // Additional: GetAutonomousDatabaseAsync(AutonomousDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            AutonomousDatabase response = await oracleDatabaseClient.GetAutonomousDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAutonomousDatabase</summary>
        public void CreateAutonomousDatabaseRequestObject()
        {
            // Snippet: CreateAutonomousDatabase(CreateAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateAutonomousDatabaseRequest request = new CreateAutonomousDatabaseRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AutonomousDatabaseId = "",
                AutonomousDatabase = new AutonomousDatabase(),
                RequestId = "",
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.CreateAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutonomousDatabaseAsync</summary>
        public async Task CreateAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: CreateAutonomousDatabaseAsync(CreateAutonomousDatabaseRequest, CallSettings)
            // Additional: CreateAutonomousDatabaseAsync(CreateAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateAutonomousDatabaseRequest request = new CreateAutonomousDatabaseRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AutonomousDatabaseId = "",
                AutonomousDatabase = new AutonomousDatabase(),
                RequestId = "",
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.CreateAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutonomousDatabase</summary>
        public void CreateAutonomousDatabase()
        {
            // Snippet: CreateAutonomousDatabase(string, AutonomousDatabase, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AutonomousDatabase autonomousDatabase = new AutonomousDatabase();
            string autonomousDatabaseId = "";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.CreateAutonomousDatabase(parent, autonomousDatabase, autonomousDatabaseId);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutonomousDatabaseAsync</summary>
        public async Task CreateAutonomousDatabaseAsync()
        {
            // Snippet: CreateAutonomousDatabaseAsync(string, AutonomousDatabase, string, CallSettings)
            // Additional: CreateAutonomousDatabaseAsync(string, AutonomousDatabase, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AutonomousDatabase autonomousDatabase = new AutonomousDatabase();
            string autonomousDatabaseId = "";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.CreateAutonomousDatabaseAsync(parent, autonomousDatabase, autonomousDatabaseId);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutonomousDatabase</summary>
        public void CreateAutonomousDatabaseResourceNames()
        {
            // Snippet: CreateAutonomousDatabase(LocationName, AutonomousDatabase, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AutonomousDatabase autonomousDatabase = new AutonomousDatabase();
            string autonomousDatabaseId = "";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.CreateAutonomousDatabase(parent, autonomousDatabase, autonomousDatabaseId);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAutonomousDatabaseAsync</summary>
        public async Task CreateAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: CreateAutonomousDatabaseAsync(LocationName, AutonomousDatabase, string, CallSettings)
            // Additional: CreateAutonomousDatabaseAsync(LocationName, AutonomousDatabase, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AutonomousDatabase autonomousDatabase = new AutonomousDatabase();
            string autonomousDatabaseId = "";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.CreateAutonomousDatabaseAsync(parent, autonomousDatabase, autonomousDatabaseId);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutonomousDatabase</summary>
        public void DeleteAutonomousDatabaseRequestObject()
        {
            // Snippet: DeleteAutonomousDatabase(DeleteAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteAutonomousDatabaseRequest request = new DeleteAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutonomousDatabaseAsync</summary>
        public async Task DeleteAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: DeleteAutonomousDatabaseAsync(DeleteAutonomousDatabaseRequest, CallSettings)
            // Additional: DeleteAutonomousDatabaseAsync(DeleteAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAutonomousDatabaseRequest request = new DeleteAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutonomousDatabase</summary>
        public void DeleteAutonomousDatabase()
        {
            // Snippet: DeleteAutonomousDatabase(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutonomousDatabaseAsync</summary>
        public async Task DeleteAutonomousDatabaseAsync()
        {
            // Snippet: DeleteAutonomousDatabaseAsync(string, CallSettings)
            // Additional: DeleteAutonomousDatabaseAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutonomousDatabase</summary>
        public void DeleteAutonomousDatabaseResourceNames()
        {
            // Snippet: DeleteAutonomousDatabase(AutonomousDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAutonomousDatabaseAsync</summary>
        public async Task DeleteAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: DeleteAutonomousDatabaseAsync(AutonomousDatabaseName, CallSettings)
            // Additional: DeleteAutonomousDatabaseAsync(AutonomousDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAutonomousDatabase</summary>
        public void RestoreAutonomousDatabaseRequestObject()
        {
            // Snippet: RestoreAutonomousDatabase(RestoreAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            RestoreAutonomousDatabaseRequest request = new RestoreAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                RestoreTime = new Timestamp(),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.RestoreAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRestoreAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAutonomousDatabaseAsync</summary>
        public async Task RestoreAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: RestoreAutonomousDatabaseAsync(RestoreAutonomousDatabaseRequest, CallSettings)
            // Additional: RestoreAutonomousDatabaseAsync(RestoreAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            RestoreAutonomousDatabaseRequest request = new RestoreAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                RestoreTime = new Timestamp(),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.RestoreAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRestoreAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAutonomousDatabase</summary>
        public void RestoreAutonomousDatabase()
        {
            // Snippet: RestoreAutonomousDatabase(string, Timestamp, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            Timestamp restoreTime = new Timestamp();
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.RestoreAutonomousDatabase(name, restoreTime);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRestoreAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAutonomousDatabaseAsync</summary>
        public async Task RestoreAutonomousDatabaseAsync()
        {
            // Snippet: RestoreAutonomousDatabaseAsync(string, Timestamp, CallSettings)
            // Additional: RestoreAutonomousDatabaseAsync(string, Timestamp, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            Timestamp restoreTime = new Timestamp();
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.RestoreAutonomousDatabaseAsync(name, restoreTime);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRestoreAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAutonomousDatabase</summary>
        public void RestoreAutonomousDatabaseResourceNames()
        {
            // Snippet: RestoreAutonomousDatabase(AutonomousDatabaseName, Timestamp, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            Timestamp restoreTime = new Timestamp();
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.RestoreAutonomousDatabase(name, restoreTime);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRestoreAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreAutonomousDatabaseAsync</summary>
        public async Task RestoreAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: RestoreAutonomousDatabaseAsync(AutonomousDatabaseName, Timestamp, CallSettings)
            // Additional: RestoreAutonomousDatabaseAsync(AutonomousDatabaseName, Timestamp, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            Timestamp restoreTime = new Timestamp();
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.RestoreAutonomousDatabaseAsync(name, restoreTime);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRestoreAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAutonomousDatabaseWallet</summary>
        public void GenerateAutonomousDatabaseWalletRequestObject()
        {
            // Snippet: GenerateAutonomousDatabaseWallet(GenerateAutonomousDatabaseWalletRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GenerateAutonomousDatabaseWalletRequest request = new GenerateAutonomousDatabaseWalletRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                Type = GenerateType.Unspecified,
                IsRegional = false,
                Password = "",
            };
            // Make the request
            GenerateAutonomousDatabaseWalletResponse response = oracleDatabaseClient.GenerateAutonomousDatabaseWallet(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAutonomousDatabaseWalletAsync</summary>
        public async Task GenerateAutonomousDatabaseWalletRequestObjectAsync()
        {
            // Snippet: GenerateAutonomousDatabaseWalletAsync(GenerateAutonomousDatabaseWalletRequest, CallSettings)
            // Additional: GenerateAutonomousDatabaseWalletAsync(GenerateAutonomousDatabaseWalletRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAutonomousDatabaseWalletRequest request = new GenerateAutonomousDatabaseWalletRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                Type = GenerateType.Unspecified,
                IsRegional = false,
                Password = "",
            };
            // Make the request
            GenerateAutonomousDatabaseWalletResponse response = await oracleDatabaseClient.GenerateAutonomousDatabaseWalletAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAutonomousDatabaseWallet</summary>
        public void GenerateAutonomousDatabaseWallet()
        {
            // Snippet: GenerateAutonomousDatabaseWallet(string, GenerateType, bool, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            GenerateType type = GenerateType.Unspecified;
            bool isRegional = false;
            string password = "";
            // Make the request
            GenerateAutonomousDatabaseWalletResponse response = oracleDatabaseClient.GenerateAutonomousDatabaseWallet(name, type, isRegional, password);
            // End snippet
        }

        /// <summary>Snippet for GenerateAutonomousDatabaseWalletAsync</summary>
        public async Task GenerateAutonomousDatabaseWalletAsync()
        {
            // Snippet: GenerateAutonomousDatabaseWalletAsync(string, GenerateType, bool, string, CallSettings)
            // Additional: GenerateAutonomousDatabaseWalletAsync(string, GenerateType, bool, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            GenerateType type = GenerateType.Unspecified;
            bool isRegional = false;
            string password = "";
            // Make the request
            GenerateAutonomousDatabaseWalletResponse response = await oracleDatabaseClient.GenerateAutonomousDatabaseWalletAsync(name, type, isRegional, password);
            // End snippet
        }

        /// <summary>Snippet for GenerateAutonomousDatabaseWallet</summary>
        public void GenerateAutonomousDatabaseWalletResourceNames()
        {
            // Snippet: GenerateAutonomousDatabaseWallet(AutonomousDatabaseName, GenerateType, bool, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            GenerateType type = GenerateType.Unspecified;
            bool isRegional = false;
            string password = "";
            // Make the request
            GenerateAutonomousDatabaseWalletResponse response = oracleDatabaseClient.GenerateAutonomousDatabaseWallet(name, type, isRegional, password);
            // End snippet
        }

        /// <summary>Snippet for GenerateAutonomousDatabaseWalletAsync</summary>
        public async Task GenerateAutonomousDatabaseWalletResourceNamesAsync()
        {
            // Snippet: GenerateAutonomousDatabaseWalletAsync(AutonomousDatabaseName, GenerateType, bool, string, CallSettings)
            // Additional: GenerateAutonomousDatabaseWalletAsync(AutonomousDatabaseName, GenerateType, bool, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            GenerateType type = GenerateType.Unspecified;
            bool isRegional = false;
            string password = "";
            // Make the request
            GenerateAutonomousDatabaseWalletResponse response = await oracleDatabaseClient.GenerateAutonomousDatabaseWalletAsync(name, type, isRegional, password);
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDbVersions</summary>
        public void ListAutonomousDbVersionsRequestObject()
        {
            // Snippet: ListAutonomousDbVersions(ListAutonomousDbVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListAutonomousDbVersionsRequest request = new ListAutonomousDbVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> response = oracleDatabaseClient.ListAutonomousDbVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDbVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDbVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDbVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDbVersionsAsync</summary>
        public async Task ListAutonomousDbVersionsRequestObjectAsync()
        {
            // Snippet: ListAutonomousDbVersionsAsync(ListAutonomousDbVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListAutonomousDbVersionsRequest request = new ListAutonomousDbVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> response = oracleDatabaseClient.ListAutonomousDbVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDbVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDbVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDbVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDbVersions</summary>
        public void ListAutonomousDbVersions()
        {
            // Snippet: ListAutonomousDbVersions(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> response = oracleDatabaseClient.ListAutonomousDbVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDbVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDbVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDbVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDbVersionsAsync</summary>
        public async Task ListAutonomousDbVersionsAsync()
        {
            // Snippet: ListAutonomousDbVersionsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> response = oracleDatabaseClient.ListAutonomousDbVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDbVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDbVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDbVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDbVersions</summary>
        public void ListAutonomousDbVersionsResourceNames()
        {
            // Snippet: ListAutonomousDbVersions(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> response = oracleDatabaseClient.ListAutonomousDbVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDbVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDbVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDbVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDbVersionsAsync</summary>
        public async Task ListAutonomousDbVersionsResourceNamesAsync()
        {
            // Snippet: ListAutonomousDbVersionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDbVersionsResponse, AutonomousDbVersion> response = oracleDatabaseClient.ListAutonomousDbVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDbVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDbVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDbVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseCharacterSets</summary>
        public void ListAutonomousDatabaseCharacterSetsRequestObject()
        {
            // Snippet: ListAutonomousDatabaseCharacterSets(ListAutonomousDatabaseCharacterSetsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListAutonomousDatabaseCharacterSetsRequest request = new ListAutonomousDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> response = oracleDatabaseClient.ListAutonomousDatabaseCharacterSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabaseCharacterSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabaseCharacterSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseCharacterSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseCharacterSetsAsync</summary>
        public async Task ListAutonomousDatabaseCharacterSetsRequestObjectAsync()
        {
            // Snippet: ListAutonomousDatabaseCharacterSetsAsync(ListAutonomousDatabaseCharacterSetsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListAutonomousDatabaseCharacterSetsRequest request = new ListAutonomousDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> response = oracleDatabaseClient.ListAutonomousDatabaseCharacterSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabaseCharacterSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabaseCharacterSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseCharacterSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseCharacterSets</summary>
        public void ListAutonomousDatabaseCharacterSets()
        {
            // Snippet: ListAutonomousDatabaseCharacterSets(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> response = oracleDatabaseClient.ListAutonomousDatabaseCharacterSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabaseCharacterSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabaseCharacterSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseCharacterSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseCharacterSetsAsync</summary>
        public async Task ListAutonomousDatabaseCharacterSetsAsync()
        {
            // Snippet: ListAutonomousDatabaseCharacterSetsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> response = oracleDatabaseClient.ListAutonomousDatabaseCharacterSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabaseCharacterSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabaseCharacterSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseCharacterSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseCharacterSets</summary>
        public void ListAutonomousDatabaseCharacterSetsResourceNames()
        {
            // Snippet: ListAutonomousDatabaseCharacterSets(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> response = oracleDatabaseClient.ListAutonomousDatabaseCharacterSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabaseCharacterSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabaseCharacterSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseCharacterSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseCharacterSetsAsync</summary>
        public async Task ListAutonomousDatabaseCharacterSetsResourceNamesAsync()
        {
            // Snippet: ListAutonomousDatabaseCharacterSetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabaseCharacterSetsResponse, AutonomousDatabaseCharacterSet> response = oracleDatabaseClient.ListAutonomousDatabaseCharacterSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabaseCharacterSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabaseCharacterSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseCharacterSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseBackups</summary>
        public void ListAutonomousDatabaseBackupsRequestObject()
        {
            // Snippet: ListAutonomousDatabaseBackups(ListAutonomousDatabaseBackupsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListAutonomousDatabaseBackupsRequest request = new ListAutonomousDatabaseBackupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> response = oracleDatabaseClient.ListAutonomousDatabaseBackups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabaseBackup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabaseBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseBackup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseBackupsAsync</summary>
        public async Task ListAutonomousDatabaseBackupsRequestObjectAsync()
        {
            // Snippet: ListAutonomousDatabaseBackupsAsync(ListAutonomousDatabaseBackupsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListAutonomousDatabaseBackupsRequest request = new ListAutonomousDatabaseBackupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> response = oracleDatabaseClient.ListAutonomousDatabaseBackupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabaseBackup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabaseBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseBackup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseBackups</summary>
        public void ListAutonomousDatabaseBackups()
        {
            // Snippet: ListAutonomousDatabaseBackups(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> response = oracleDatabaseClient.ListAutonomousDatabaseBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabaseBackup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabaseBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseBackup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseBackupsAsync</summary>
        public async Task ListAutonomousDatabaseBackupsAsync()
        {
            // Snippet: ListAutonomousDatabaseBackupsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> response = oracleDatabaseClient.ListAutonomousDatabaseBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabaseBackup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabaseBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseBackup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseBackups</summary>
        public void ListAutonomousDatabaseBackupsResourceNames()
        {
            // Snippet: ListAutonomousDatabaseBackups(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> response = oracleDatabaseClient.ListAutonomousDatabaseBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutonomousDatabaseBackup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutonomousDatabaseBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseBackup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseBackup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutonomousDatabaseBackupsAsync</summary>
        public async Task ListAutonomousDatabaseBackupsResourceNamesAsync()
        {
            // Snippet: ListAutonomousDatabaseBackupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAutonomousDatabaseBackupsResponse, AutonomousDatabaseBackup> response = oracleDatabaseClient.ListAutonomousDatabaseBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutonomousDatabaseBackup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutonomousDatabaseBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutonomousDatabaseBackup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutonomousDatabaseBackup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutonomousDatabaseBackup item in singlePage)
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
