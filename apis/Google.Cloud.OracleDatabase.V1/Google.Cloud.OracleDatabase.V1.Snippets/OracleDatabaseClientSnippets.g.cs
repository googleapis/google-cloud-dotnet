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
    using Google.Cloud.OracleDatabase.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
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
                Filter = "",
                OrderBy = "",
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
                Filter = "",
                OrderBy = "",
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
        public void ListDbNodesResourceNames1()
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
        public async Task ListDbNodesResourceNames1Async()
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

        /// <summary>Snippet for ListDbNodes</summary>
        public void ListDbNodesResourceNames2()
        {
            // Snippet: ListDbNodes(ExadbVmClusterName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ExadbVmClusterName parent = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
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
        public async Task ListDbNodesResourceNames2Async()
        {
            // Snippet: ListDbNodesAsync(ExadbVmClusterName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ExadbVmClusterName parent = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
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
                Filter = "",
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
                Filter = "",
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

        /// <summary>Snippet for ListMinorVersions</summary>
        public void ListMinorVersionsRequestObject()
        {
            // Snippet: ListMinorVersions(ListMinorVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListMinorVersionsRequest request = new ListMinorVersionsRequest
            {
                ParentAsGiVersionName = GiVersionName.FromProjectLocationGiVersion("[PROJECT]", "[LOCATION]", "[GI_VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMinorVersionsResponse, MinorVersion> response = oracleDatabaseClient.ListMinorVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MinorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMinorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MinorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MinorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MinorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMinorVersionsAsync</summary>
        public async Task ListMinorVersionsRequestObjectAsync()
        {
            // Snippet: ListMinorVersionsAsync(ListMinorVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListMinorVersionsRequest request = new ListMinorVersionsRequest
            {
                ParentAsGiVersionName = GiVersionName.FromProjectLocationGiVersion("[PROJECT]", "[LOCATION]", "[GI_VERSION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMinorVersionsResponse, MinorVersion> response = oracleDatabaseClient.ListMinorVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MinorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMinorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MinorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MinorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MinorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMinorVersions</summary>
        public void ListMinorVersions()
        {
            // Snippet: ListMinorVersions(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/giVersions/[GI_VERSION]";
            // Make the request
            PagedEnumerable<ListMinorVersionsResponse, MinorVersion> response = oracleDatabaseClient.ListMinorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MinorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMinorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MinorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MinorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MinorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMinorVersionsAsync</summary>
        public async Task ListMinorVersionsAsync()
        {
            // Snippet: ListMinorVersionsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/giVersions/[GI_VERSION]";
            // Make the request
            PagedAsyncEnumerable<ListMinorVersionsResponse, MinorVersion> response = oracleDatabaseClient.ListMinorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MinorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMinorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MinorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MinorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MinorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMinorVersions</summary>
        public void ListMinorVersionsResourceNames()
        {
            // Snippet: ListMinorVersions(GiVersionName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GiVersionName parent = GiVersionName.FromProjectLocationGiVersion("[PROJECT]", "[LOCATION]", "[GI_VERSION]");
            // Make the request
            PagedEnumerable<ListMinorVersionsResponse, MinorVersion> response = oracleDatabaseClient.ListMinorVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MinorVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMinorVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MinorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MinorVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MinorVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMinorVersionsAsync</summary>
        public async Task ListMinorVersionsResourceNamesAsync()
        {
            // Snippet: ListMinorVersionsAsync(GiVersionName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GiVersionName parent = GiVersionName.FromProjectLocationGiVersion("[PROJECT]", "[LOCATION]", "[GI_VERSION]");
            // Make the request
            PagedAsyncEnumerable<ListMinorVersionsResponse, MinorVersion> response = oracleDatabaseClient.ListMinorVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((MinorVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMinorVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MinorVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MinorVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MinorVersion item in singlePage)
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
                Filter = "",
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
                Filter = "",
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

        /// <summary>Snippet for UpdateAutonomousDatabase</summary>
        public void UpdateAutonomousDatabaseRequestObject()
        {
            // Snippet: UpdateAutonomousDatabase(UpdateAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            UpdateAutonomousDatabaseRequest request = new UpdateAutonomousDatabaseRequest
            {
                UpdateMask = new FieldMask(),
                AutonomousDatabase = new AutonomousDatabase(),
                RequestId = "",
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.UpdateAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceUpdateAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutonomousDatabaseAsync</summary>
        public async Task UpdateAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: UpdateAutonomousDatabaseAsync(UpdateAutonomousDatabaseRequest, CallSettings)
            // Additional: UpdateAutonomousDatabaseAsync(UpdateAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutonomousDatabaseRequest request = new UpdateAutonomousDatabaseRequest
            {
                UpdateMask = new FieldMask(),
                AutonomousDatabase = new AutonomousDatabase(),
                RequestId = "",
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.UpdateAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceUpdateAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutonomousDatabase</summary>
        public void UpdateAutonomousDatabase()
        {
            // Snippet: UpdateAutonomousDatabase(AutonomousDatabase, FieldMask, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabase autonomousDatabase = new AutonomousDatabase();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.UpdateAutonomousDatabase(autonomousDatabase, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceUpdateAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAutonomousDatabaseAsync</summary>
        public async Task UpdateAutonomousDatabaseAsync()
        {
            // Snippet: UpdateAutonomousDatabaseAsync(AutonomousDatabase, FieldMask, CallSettings)
            // Additional: UpdateAutonomousDatabaseAsync(AutonomousDatabase, FieldMask, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabase autonomousDatabase = new AutonomousDatabase();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.UpdateAutonomousDatabaseAsync(autonomousDatabase, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceUpdateAutonomousDatabaseAsync(operationName);
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

        /// <summary>Snippet for StopAutonomousDatabase</summary>
        public void StopAutonomousDatabaseRequestObject()
        {
            // Snippet: StopAutonomousDatabase(StopAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            StopAutonomousDatabaseRequest request = new StopAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.StopAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceStopAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAutonomousDatabaseAsync</summary>
        public async Task StopAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: StopAutonomousDatabaseAsync(StopAutonomousDatabaseRequest, CallSettings)
            // Additional: StopAutonomousDatabaseAsync(StopAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            StopAutonomousDatabaseRequest request = new StopAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.StopAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceStopAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAutonomousDatabase</summary>
        public void StopAutonomousDatabase()
        {
            // Snippet: StopAutonomousDatabase(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.StopAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceStopAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAutonomousDatabaseAsync</summary>
        public async Task StopAutonomousDatabaseAsync()
        {
            // Snippet: StopAutonomousDatabaseAsync(string, CallSettings)
            // Additional: StopAutonomousDatabaseAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.StopAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceStopAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAutonomousDatabase</summary>
        public void StopAutonomousDatabaseResourceNames()
        {
            // Snippet: StopAutonomousDatabase(AutonomousDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.StopAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceStopAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StopAutonomousDatabaseAsync</summary>
        public async Task StopAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: StopAutonomousDatabaseAsync(AutonomousDatabaseName, CallSettings)
            // Additional: StopAutonomousDatabaseAsync(AutonomousDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.StopAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceStopAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAutonomousDatabase</summary>
        public void StartAutonomousDatabaseRequestObject()
        {
            // Snippet: StartAutonomousDatabase(StartAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            StartAutonomousDatabaseRequest request = new StartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.StartAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceStartAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAutonomousDatabaseAsync</summary>
        public async Task StartAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: StartAutonomousDatabaseAsync(StartAutonomousDatabaseRequest, CallSettings)
            // Additional: StartAutonomousDatabaseAsync(StartAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            StartAutonomousDatabaseRequest request = new StartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.StartAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceStartAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAutonomousDatabase</summary>
        public void StartAutonomousDatabase()
        {
            // Snippet: StartAutonomousDatabase(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.StartAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceStartAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAutonomousDatabaseAsync</summary>
        public async Task StartAutonomousDatabaseAsync()
        {
            // Snippet: StartAutonomousDatabaseAsync(string, CallSettings)
            // Additional: StartAutonomousDatabaseAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.StartAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceStartAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAutonomousDatabase</summary>
        public void StartAutonomousDatabaseResourceNames()
        {
            // Snippet: StartAutonomousDatabase(AutonomousDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.StartAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceStartAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StartAutonomousDatabaseAsync</summary>
        public async Task StartAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: StartAutonomousDatabaseAsync(AutonomousDatabaseName, CallSettings)
            // Additional: StartAutonomousDatabaseAsync(AutonomousDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.StartAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceStartAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartAutonomousDatabase</summary>
        public void RestartAutonomousDatabaseRequestObject()
        {
            // Snippet: RestartAutonomousDatabase(RestartAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            RestartAutonomousDatabaseRequest request = new RestartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.RestartAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRestartAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartAutonomousDatabaseAsync</summary>
        public async Task RestartAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: RestartAutonomousDatabaseAsync(RestartAutonomousDatabaseRequest, CallSettings)
            // Additional: RestartAutonomousDatabaseAsync(RestartAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            RestartAutonomousDatabaseRequest request = new RestartAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.RestartAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRestartAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartAutonomousDatabase</summary>
        public void RestartAutonomousDatabase()
        {
            // Snippet: RestartAutonomousDatabase(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.RestartAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRestartAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartAutonomousDatabaseAsync</summary>
        public async Task RestartAutonomousDatabaseAsync()
        {
            // Snippet: RestartAutonomousDatabaseAsync(string, CallSettings)
            // Additional: RestartAutonomousDatabaseAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.RestartAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRestartAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartAutonomousDatabase</summary>
        public void RestartAutonomousDatabaseResourceNames()
        {
            // Snippet: RestartAutonomousDatabase(AutonomousDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.RestartAutonomousDatabase(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRestartAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestartAutonomousDatabaseAsync</summary>
        public async Task RestartAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: RestartAutonomousDatabaseAsync(AutonomousDatabaseName, CallSettings)
            // Additional: RestartAutonomousDatabaseAsync(AutonomousDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.RestartAutonomousDatabaseAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRestartAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverAutonomousDatabase</summary>
        public void SwitchoverAutonomousDatabaseRequestObject()
        {
            // Snippet: SwitchoverAutonomousDatabase(SwitchoverAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            SwitchoverAutonomousDatabaseRequest request = new SwitchoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.SwitchoverAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceSwitchoverAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverAutonomousDatabaseAsync</summary>
        public async Task SwitchoverAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: SwitchoverAutonomousDatabaseAsync(SwitchoverAutonomousDatabaseRequest, CallSettings)
            // Additional: SwitchoverAutonomousDatabaseAsync(SwitchoverAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            SwitchoverAutonomousDatabaseRequest request = new SwitchoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.SwitchoverAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceSwitchoverAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverAutonomousDatabase</summary>
        public void SwitchoverAutonomousDatabase()
        {
            // Snippet: SwitchoverAutonomousDatabase(string, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            string peerAutonomousDatabase = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.SwitchoverAutonomousDatabase(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceSwitchoverAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverAutonomousDatabaseAsync</summary>
        public async Task SwitchoverAutonomousDatabaseAsync()
        {
            // Snippet: SwitchoverAutonomousDatabaseAsync(string, string, CallSettings)
            // Additional: SwitchoverAutonomousDatabaseAsync(string, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            string peerAutonomousDatabase = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.SwitchoverAutonomousDatabaseAsync(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceSwitchoverAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverAutonomousDatabase</summary>
        public void SwitchoverAutonomousDatabaseResourceNames()
        {
            // Snippet: SwitchoverAutonomousDatabase(AutonomousDatabaseName, AutonomousDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            AutonomousDatabaseName peerAutonomousDatabase = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.SwitchoverAutonomousDatabase(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceSwitchoverAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SwitchoverAutonomousDatabaseAsync</summary>
        public async Task SwitchoverAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: SwitchoverAutonomousDatabaseAsync(AutonomousDatabaseName, AutonomousDatabaseName, CallSettings)
            // Additional: SwitchoverAutonomousDatabaseAsync(AutonomousDatabaseName, AutonomousDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            AutonomousDatabaseName peerAutonomousDatabase = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.SwitchoverAutonomousDatabaseAsync(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceSwitchoverAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverAutonomousDatabase</summary>
        public void FailoverAutonomousDatabaseRequestObject()
        {
            // Snippet: FailoverAutonomousDatabase(FailoverAutonomousDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            FailoverAutonomousDatabaseRequest request = new FailoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.FailoverAutonomousDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceFailoverAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverAutonomousDatabaseAsync</summary>
        public async Task FailoverAutonomousDatabaseRequestObjectAsync()
        {
            // Snippet: FailoverAutonomousDatabaseAsync(FailoverAutonomousDatabaseRequest, CallSettings)
            // Additional: FailoverAutonomousDatabaseAsync(FailoverAutonomousDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            FailoverAutonomousDatabaseRequest request = new FailoverAutonomousDatabaseRequest
            {
                AutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
                PeerAutonomousDatabaseAsAutonomousDatabaseName = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]"),
            };
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.FailoverAutonomousDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceFailoverAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverAutonomousDatabase</summary>
        public void FailoverAutonomousDatabase()
        {
            // Snippet: FailoverAutonomousDatabase(string, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            string peerAutonomousDatabase = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.FailoverAutonomousDatabase(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceFailoverAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverAutonomousDatabaseAsync</summary>
        public async Task FailoverAutonomousDatabaseAsync()
        {
            // Snippet: FailoverAutonomousDatabaseAsync(string, string, CallSettings)
            // Additional: FailoverAutonomousDatabaseAsync(string, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            string peerAutonomousDatabase = "projects/[PROJECT]/locations/[LOCATION]/autonomousDatabases/[AUTONOMOUS_DATABASE]";
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.FailoverAutonomousDatabaseAsync(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceFailoverAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverAutonomousDatabase</summary>
        public void FailoverAutonomousDatabaseResourceNames()
        {
            // Snippet: FailoverAutonomousDatabase(AutonomousDatabaseName, AutonomousDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            AutonomousDatabaseName peerAutonomousDatabase = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = oracleDatabaseClient.FailoverAutonomousDatabase(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceFailoverAutonomousDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for FailoverAutonomousDatabaseAsync</summary>
        public async Task FailoverAutonomousDatabaseResourceNamesAsync()
        {
            // Snippet: FailoverAutonomousDatabaseAsync(AutonomousDatabaseName, AutonomousDatabaseName, CallSettings)
            // Additional: FailoverAutonomousDatabaseAsync(AutonomousDatabaseName, AutonomousDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            AutonomousDatabaseName name = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            AutonomousDatabaseName peerAutonomousDatabase = AutonomousDatabaseName.FromProjectLocationAutonomousDatabase("[PROJECT]", "[LOCATION]", "[AUTONOMOUS_DATABASE]");
            // Make the request
            Operation<AutonomousDatabase, OperationMetadata> response = await oracleDatabaseClient.FailoverAutonomousDatabaseAsync(name, peerAutonomousDatabase);

            // Poll until the returned long-running operation is complete
            Operation<AutonomousDatabase, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AutonomousDatabase result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AutonomousDatabase, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceFailoverAutonomousDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AutonomousDatabase retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListOdbNetworks</summary>
        public void ListOdbNetworksRequestObject()
        {
            // Snippet: ListOdbNetworks(ListOdbNetworksRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListOdbNetworksRequest request = new ListOdbNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListOdbNetworksResponse, OdbNetwork> response = oracleDatabaseClient.ListOdbNetworks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OdbNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOdbNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbNetworksAsync</summary>
        public async Task ListOdbNetworksRequestObjectAsync()
        {
            // Snippet: ListOdbNetworksAsync(ListOdbNetworksRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListOdbNetworksRequest request = new ListOdbNetworksRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOdbNetworksResponse, OdbNetwork> response = oracleDatabaseClient.ListOdbNetworksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OdbNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOdbNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbNetworks</summary>
        public void ListOdbNetworks()
        {
            // Snippet: ListOdbNetworks(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListOdbNetworksResponse, OdbNetwork> response = oracleDatabaseClient.ListOdbNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OdbNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOdbNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbNetworksAsync</summary>
        public async Task ListOdbNetworksAsync()
        {
            // Snippet: ListOdbNetworksAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListOdbNetworksResponse, OdbNetwork> response = oracleDatabaseClient.ListOdbNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OdbNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOdbNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbNetworks</summary>
        public void ListOdbNetworksResourceNames()
        {
            // Snippet: ListOdbNetworks(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListOdbNetworksResponse, OdbNetwork> response = oracleDatabaseClient.ListOdbNetworks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OdbNetwork item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOdbNetworksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbNetwork> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbNetworksAsync</summary>
        public async Task ListOdbNetworksResourceNamesAsync()
        {
            // Snippet: ListOdbNetworksAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListOdbNetworksResponse, OdbNetwork> response = oracleDatabaseClient.ListOdbNetworksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OdbNetwork item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOdbNetworksResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbNetwork item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbNetwork> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbNetwork item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOdbNetwork</summary>
        public void GetOdbNetworkRequestObject()
        {
            // Snippet: GetOdbNetwork(GetOdbNetworkRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetOdbNetworkRequest request = new GetOdbNetworkRequest
            {
                OdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
            };
            // Make the request
            OdbNetwork response = oracleDatabaseClient.GetOdbNetwork(request);
            // End snippet
        }

        /// <summary>Snippet for GetOdbNetworkAsync</summary>
        public async Task GetOdbNetworkRequestObjectAsync()
        {
            // Snippet: GetOdbNetworkAsync(GetOdbNetworkRequest, CallSettings)
            // Additional: GetOdbNetworkAsync(GetOdbNetworkRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetOdbNetworkRequest request = new GetOdbNetworkRequest
            {
                OdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
            };
            // Make the request
            OdbNetwork response = await oracleDatabaseClient.GetOdbNetworkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOdbNetwork</summary>
        public void GetOdbNetwork()
        {
            // Snippet: GetOdbNetwork(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            // Make the request
            OdbNetwork response = oracleDatabaseClient.GetOdbNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetOdbNetworkAsync</summary>
        public async Task GetOdbNetworkAsync()
        {
            // Snippet: GetOdbNetworkAsync(string, CallSettings)
            // Additional: GetOdbNetworkAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            // Make the request
            OdbNetwork response = await oracleDatabaseClient.GetOdbNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOdbNetwork</summary>
        public void GetOdbNetworkResourceNames()
        {
            // Snippet: GetOdbNetwork(OdbNetworkName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            OdbNetworkName name = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            // Make the request
            OdbNetwork response = oracleDatabaseClient.GetOdbNetwork(name);
            // End snippet
        }

        /// <summary>Snippet for GetOdbNetworkAsync</summary>
        public async Task GetOdbNetworkResourceNamesAsync()
        {
            // Snippet: GetOdbNetworkAsync(OdbNetworkName, CallSettings)
            // Additional: GetOdbNetworkAsync(OdbNetworkName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            OdbNetworkName name = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            // Make the request
            OdbNetwork response = await oracleDatabaseClient.GetOdbNetworkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateOdbNetwork</summary>
        public void CreateOdbNetworkRequestObject()
        {
            // Snippet: CreateOdbNetwork(CreateOdbNetworkRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateOdbNetworkRequest request = new CreateOdbNetworkRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OdbNetworkId = "",
                OdbNetwork = new OdbNetwork(),
                RequestId = "",
            };
            // Make the request
            Operation<OdbNetwork, OperationMetadata> response = oracleDatabaseClient.CreateOdbNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<OdbNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OdbNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbNetwork, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateOdbNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbNetworkAsync</summary>
        public async Task CreateOdbNetworkRequestObjectAsync()
        {
            // Snippet: CreateOdbNetworkAsync(CreateOdbNetworkRequest, CallSettings)
            // Additional: CreateOdbNetworkAsync(CreateOdbNetworkRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateOdbNetworkRequest request = new CreateOdbNetworkRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                OdbNetworkId = "",
                OdbNetwork = new OdbNetwork(),
                RequestId = "",
            };
            // Make the request
            Operation<OdbNetwork, OperationMetadata> response = await oracleDatabaseClient.CreateOdbNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OdbNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OdbNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbNetwork, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateOdbNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbNetwork</summary>
        public void CreateOdbNetwork()
        {
            // Snippet: CreateOdbNetwork(string, OdbNetwork, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OdbNetwork odbNetwork = new OdbNetwork();
            string odbNetworkId = "";
            // Make the request
            Operation<OdbNetwork, OperationMetadata> response = oracleDatabaseClient.CreateOdbNetwork(parent, odbNetwork, odbNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<OdbNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OdbNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbNetwork, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateOdbNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbNetworkAsync</summary>
        public async Task CreateOdbNetworkAsync()
        {
            // Snippet: CreateOdbNetworkAsync(string, OdbNetwork, string, CallSettings)
            // Additional: CreateOdbNetworkAsync(string, OdbNetwork, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            OdbNetwork odbNetwork = new OdbNetwork();
            string odbNetworkId = "";
            // Make the request
            Operation<OdbNetwork, OperationMetadata> response = await oracleDatabaseClient.CreateOdbNetworkAsync(parent, odbNetwork, odbNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<OdbNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OdbNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbNetwork, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateOdbNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbNetwork</summary>
        public void CreateOdbNetworkResourceNames()
        {
            // Snippet: CreateOdbNetwork(LocationName, OdbNetwork, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OdbNetwork odbNetwork = new OdbNetwork();
            string odbNetworkId = "";
            // Make the request
            Operation<OdbNetwork, OperationMetadata> response = oracleDatabaseClient.CreateOdbNetwork(parent, odbNetwork, odbNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<OdbNetwork, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OdbNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbNetwork, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateOdbNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbNetworkAsync</summary>
        public async Task CreateOdbNetworkResourceNamesAsync()
        {
            // Snippet: CreateOdbNetworkAsync(LocationName, OdbNetwork, string, CallSettings)
            // Additional: CreateOdbNetworkAsync(LocationName, OdbNetwork, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            OdbNetwork odbNetwork = new OdbNetwork();
            string odbNetworkId = "";
            // Make the request
            Operation<OdbNetwork, OperationMetadata> response = await oracleDatabaseClient.CreateOdbNetworkAsync(parent, odbNetwork, odbNetworkId);

            // Poll until the returned long-running operation is complete
            Operation<OdbNetwork, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OdbNetwork result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbNetwork, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateOdbNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbNetwork retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbNetwork</summary>
        public void DeleteOdbNetworkRequestObject()
        {
            // Snippet: DeleteOdbNetwork(DeleteOdbNetworkRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteOdbNetworkRequest request = new DeleteOdbNetworkRequest
            {
                OdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteOdbNetwork(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteOdbNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbNetworkAsync</summary>
        public async Task DeleteOdbNetworkRequestObjectAsync()
        {
            // Snippet: DeleteOdbNetworkAsync(DeleteOdbNetworkRequest, CallSettings)
            // Additional: DeleteOdbNetworkAsync(DeleteOdbNetworkRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOdbNetworkRequest request = new DeleteOdbNetworkRequest
            {
                OdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteOdbNetworkAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteOdbNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbNetwork</summary>
        public void DeleteOdbNetwork()
        {
            // Snippet: DeleteOdbNetwork(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteOdbNetwork(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteOdbNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbNetworkAsync</summary>
        public async Task DeleteOdbNetworkAsync()
        {
            // Snippet: DeleteOdbNetworkAsync(string, CallSettings)
            // Additional: DeleteOdbNetworkAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteOdbNetworkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteOdbNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbNetwork</summary>
        public void DeleteOdbNetworkResourceNames()
        {
            // Snippet: DeleteOdbNetwork(OdbNetworkName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            OdbNetworkName name = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteOdbNetwork(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteOdbNetwork(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbNetworkAsync</summary>
        public async Task DeleteOdbNetworkResourceNamesAsync()
        {
            // Snippet: DeleteOdbNetworkAsync(OdbNetworkName, CallSettings)
            // Additional: DeleteOdbNetworkAsync(OdbNetworkName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            OdbNetworkName name = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteOdbNetworkAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteOdbNetworkAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListOdbSubnets</summary>
        public void ListOdbSubnetsRequestObject()
        {
            // Snippet: ListOdbSubnets(ListOdbSubnetsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListOdbSubnetsRequest request = new ListOdbSubnetsRequest
            {
                ParentAsOdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListOdbSubnetsResponse, OdbSubnet> response = oracleDatabaseClient.ListOdbSubnets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OdbSubnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOdbSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbSubnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbSubnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbSubnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbSubnetsAsync</summary>
        public async Task ListOdbSubnetsRequestObjectAsync()
        {
            // Snippet: ListOdbSubnetsAsync(ListOdbSubnetsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListOdbSubnetsRequest request = new ListOdbSubnetsRequest
            {
                ParentAsOdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListOdbSubnetsResponse, OdbSubnet> response = oracleDatabaseClient.ListOdbSubnetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OdbSubnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOdbSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbSubnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbSubnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbSubnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbSubnets</summary>
        public void ListOdbSubnets()
        {
            // Snippet: ListOdbSubnets(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            // Make the request
            PagedEnumerable<ListOdbSubnetsResponse, OdbSubnet> response = oracleDatabaseClient.ListOdbSubnets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OdbSubnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOdbSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbSubnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbSubnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbSubnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbSubnetsAsync</summary>
        public async Task ListOdbSubnetsAsync()
        {
            // Snippet: ListOdbSubnetsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            // Make the request
            PagedAsyncEnumerable<ListOdbSubnetsResponse, OdbSubnet> response = oracleDatabaseClient.ListOdbSubnetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OdbSubnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOdbSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbSubnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbSubnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbSubnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbSubnets</summary>
        public void ListOdbSubnetsResourceNames()
        {
            // Snippet: ListOdbSubnets(OdbNetworkName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            OdbNetworkName parent = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            // Make the request
            PagedEnumerable<ListOdbSubnetsResponse, OdbSubnet> response = oracleDatabaseClient.ListOdbSubnets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (OdbSubnet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListOdbSubnetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbSubnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbSubnet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbSubnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListOdbSubnetsAsync</summary>
        public async Task ListOdbSubnetsResourceNamesAsync()
        {
            // Snippet: ListOdbSubnetsAsync(OdbNetworkName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            OdbNetworkName parent = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            // Make the request
            PagedAsyncEnumerable<ListOdbSubnetsResponse, OdbSubnet> response = oracleDatabaseClient.ListOdbSubnetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((OdbSubnet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListOdbSubnetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (OdbSubnet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<OdbSubnet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (OdbSubnet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetOdbSubnet</summary>
        public void GetOdbSubnetRequestObject()
        {
            // Snippet: GetOdbSubnet(GetOdbSubnetRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetOdbSubnetRequest request = new GetOdbSubnetRequest
            {
                OdbSubnetName = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]"),
            };
            // Make the request
            OdbSubnet response = oracleDatabaseClient.GetOdbSubnet(request);
            // End snippet
        }

        /// <summary>Snippet for GetOdbSubnetAsync</summary>
        public async Task GetOdbSubnetRequestObjectAsync()
        {
            // Snippet: GetOdbSubnetAsync(GetOdbSubnetRequest, CallSettings)
            // Additional: GetOdbSubnetAsync(GetOdbSubnetRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetOdbSubnetRequest request = new GetOdbSubnetRequest
            {
                OdbSubnetName = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]"),
            };
            // Make the request
            OdbSubnet response = await oracleDatabaseClient.GetOdbSubnetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOdbSubnet</summary>
        public void GetOdbSubnet()
        {
            // Snippet: GetOdbSubnet(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]/odbSubnets/[ODB_SUBNET]";
            // Make the request
            OdbSubnet response = oracleDatabaseClient.GetOdbSubnet(name);
            // End snippet
        }

        /// <summary>Snippet for GetOdbSubnetAsync</summary>
        public async Task GetOdbSubnetAsync()
        {
            // Snippet: GetOdbSubnetAsync(string, CallSettings)
            // Additional: GetOdbSubnetAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]/odbSubnets/[ODB_SUBNET]";
            // Make the request
            OdbSubnet response = await oracleDatabaseClient.GetOdbSubnetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetOdbSubnet</summary>
        public void GetOdbSubnetResourceNames()
        {
            // Snippet: GetOdbSubnet(OdbSubnetName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            OdbSubnetName name = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]");
            // Make the request
            OdbSubnet response = oracleDatabaseClient.GetOdbSubnet(name);
            // End snippet
        }

        /// <summary>Snippet for GetOdbSubnetAsync</summary>
        public async Task GetOdbSubnetResourceNamesAsync()
        {
            // Snippet: GetOdbSubnetAsync(OdbSubnetName, CallSettings)
            // Additional: GetOdbSubnetAsync(OdbSubnetName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            OdbSubnetName name = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]");
            // Make the request
            OdbSubnet response = await oracleDatabaseClient.GetOdbSubnetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateOdbSubnet</summary>
        public void CreateOdbSubnetRequestObject()
        {
            // Snippet: CreateOdbSubnet(CreateOdbSubnetRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateOdbSubnetRequest request = new CreateOdbSubnetRequest
            {
                ParentAsOdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
                OdbSubnetId = "",
                OdbSubnet = new OdbSubnet(),
                RequestId = "",
            };
            // Make the request
            Operation<OdbSubnet, OperationMetadata> response = oracleDatabaseClient.CreateOdbSubnet(request);

            // Poll until the returned long-running operation is complete
            Operation<OdbSubnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OdbSubnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbSubnet, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateOdbSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbSubnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbSubnetAsync</summary>
        public async Task CreateOdbSubnetRequestObjectAsync()
        {
            // Snippet: CreateOdbSubnetAsync(CreateOdbSubnetRequest, CallSettings)
            // Additional: CreateOdbSubnetAsync(CreateOdbSubnetRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateOdbSubnetRequest request = new CreateOdbSubnetRequest
            {
                ParentAsOdbNetworkName = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]"),
                OdbSubnetId = "",
                OdbSubnet = new OdbSubnet(),
                RequestId = "",
            };
            // Make the request
            Operation<OdbSubnet, OperationMetadata> response = await oracleDatabaseClient.CreateOdbSubnetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<OdbSubnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OdbSubnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbSubnet, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateOdbSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbSubnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbSubnet</summary>
        public void CreateOdbSubnet()
        {
            // Snippet: CreateOdbSubnet(string, OdbSubnet, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            OdbSubnet odbSubnet = new OdbSubnet();
            string odbSubnetId = "";
            // Make the request
            Operation<OdbSubnet, OperationMetadata> response = oracleDatabaseClient.CreateOdbSubnet(parent, odbSubnet, odbSubnetId);

            // Poll until the returned long-running operation is complete
            Operation<OdbSubnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OdbSubnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbSubnet, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateOdbSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbSubnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbSubnetAsync</summary>
        public async Task CreateOdbSubnetAsync()
        {
            // Snippet: CreateOdbSubnetAsync(string, OdbSubnet, string, CallSettings)
            // Additional: CreateOdbSubnetAsync(string, OdbSubnet, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]";
            OdbSubnet odbSubnet = new OdbSubnet();
            string odbSubnetId = "";
            // Make the request
            Operation<OdbSubnet, OperationMetadata> response = await oracleDatabaseClient.CreateOdbSubnetAsync(parent, odbSubnet, odbSubnetId);

            // Poll until the returned long-running operation is complete
            Operation<OdbSubnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OdbSubnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbSubnet, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateOdbSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbSubnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbSubnet</summary>
        public void CreateOdbSubnetResourceNames()
        {
            // Snippet: CreateOdbSubnet(OdbNetworkName, OdbSubnet, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            OdbNetworkName parent = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            OdbSubnet odbSubnet = new OdbSubnet();
            string odbSubnetId = "";
            // Make the request
            Operation<OdbSubnet, OperationMetadata> response = oracleDatabaseClient.CreateOdbSubnet(parent, odbSubnet, odbSubnetId);

            // Poll until the returned long-running operation is complete
            Operation<OdbSubnet, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            OdbSubnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbSubnet, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateOdbSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbSubnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateOdbSubnetAsync</summary>
        public async Task CreateOdbSubnetResourceNamesAsync()
        {
            // Snippet: CreateOdbSubnetAsync(OdbNetworkName, OdbSubnet, string, CallSettings)
            // Additional: CreateOdbSubnetAsync(OdbNetworkName, OdbSubnet, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            OdbNetworkName parent = OdbNetworkName.FromProjectLocationOdbNetwork("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]");
            OdbSubnet odbSubnet = new OdbSubnet();
            string odbSubnetId = "";
            // Make the request
            Operation<OdbSubnet, OperationMetadata> response = await oracleDatabaseClient.CreateOdbSubnetAsync(parent, odbSubnet, odbSubnetId);

            // Poll until the returned long-running operation is complete
            Operation<OdbSubnet, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            OdbSubnet result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<OdbSubnet, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateOdbSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                OdbSubnet retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbSubnet</summary>
        public void DeleteOdbSubnetRequestObject()
        {
            // Snippet: DeleteOdbSubnet(DeleteOdbSubnetRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteOdbSubnetRequest request = new DeleteOdbSubnetRequest
            {
                OdbSubnetName = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteOdbSubnet(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteOdbSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbSubnetAsync</summary>
        public async Task DeleteOdbSubnetRequestObjectAsync()
        {
            // Snippet: DeleteOdbSubnetAsync(DeleteOdbSubnetRequest, CallSettings)
            // Additional: DeleteOdbSubnetAsync(DeleteOdbSubnetRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteOdbSubnetRequest request = new DeleteOdbSubnetRequest
            {
                OdbSubnetName = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteOdbSubnetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteOdbSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbSubnet</summary>
        public void DeleteOdbSubnet()
        {
            // Snippet: DeleteOdbSubnet(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]/odbSubnets/[ODB_SUBNET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteOdbSubnet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteOdbSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbSubnetAsync</summary>
        public async Task DeleteOdbSubnetAsync()
        {
            // Snippet: DeleteOdbSubnetAsync(string, CallSettings)
            // Additional: DeleteOdbSubnetAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/odbNetworks/[ODB_NETWORK]/odbSubnets/[ODB_SUBNET]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteOdbSubnetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteOdbSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbSubnet</summary>
        public void DeleteOdbSubnetResourceNames()
        {
            // Snippet: DeleteOdbSubnet(OdbSubnetName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            OdbSubnetName name = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteOdbSubnet(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteOdbSubnet(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteOdbSubnetAsync</summary>
        public async Task DeleteOdbSubnetResourceNamesAsync()
        {
            // Snippet: DeleteOdbSubnetAsync(OdbSubnetName, CallSettings)
            // Additional: DeleteOdbSubnetAsync(OdbSubnetName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            OdbSubnetName name = OdbSubnetName.FromProjectLocationOdbNetworkOdbSubnet("[PROJECT]", "[LOCATION]", "[ODB_NETWORK]", "[ODB_SUBNET]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteOdbSubnetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteOdbSubnetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExadbVmClusters</summary>
        public void ListExadbVmClustersRequestObject()
        {
            // Snippet: ListExadbVmClusters(ListExadbVmClustersRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListExadbVmClustersRequest request = new ListExadbVmClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> response = oracleDatabaseClient.ListExadbVmClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExadbVmCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExadbVmClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExadbVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExadbVmCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExadbVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExadbVmClustersAsync</summary>
        public async Task ListExadbVmClustersRequestObjectAsync()
        {
            // Snippet: ListExadbVmClustersAsync(ListExadbVmClustersRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListExadbVmClustersRequest request = new ListExadbVmClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> response = oracleDatabaseClient.ListExadbVmClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExadbVmCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExadbVmClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExadbVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExadbVmCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExadbVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExadbVmClusters</summary>
        public void ListExadbVmClusters()
        {
            // Snippet: ListExadbVmClusters(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> response = oracleDatabaseClient.ListExadbVmClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExadbVmCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExadbVmClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExadbVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExadbVmCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExadbVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExadbVmClustersAsync</summary>
        public async Task ListExadbVmClustersAsync()
        {
            // Snippet: ListExadbVmClustersAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> response = oracleDatabaseClient.ListExadbVmClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExadbVmCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExadbVmClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExadbVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExadbVmCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExadbVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExadbVmClusters</summary>
        public void ListExadbVmClustersResourceNames()
        {
            // Snippet: ListExadbVmClusters(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> response = oracleDatabaseClient.ListExadbVmClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExadbVmCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExadbVmClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExadbVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExadbVmCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExadbVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExadbVmClustersAsync</summary>
        public async Task ListExadbVmClustersResourceNamesAsync()
        {
            // Snippet: ListExadbVmClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListExadbVmClustersResponse, ExadbVmCluster> response = oracleDatabaseClient.ListExadbVmClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExadbVmCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExadbVmClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExadbVmCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExadbVmCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExadbVmCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExadbVmCluster</summary>
        public void GetExadbVmClusterRequestObject()
        {
            // Snippet: GetExadbVmCluster(GetExadbVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetExadbVmClusterRequest request = new GetExadbVmClusterRequest
            {
                ExadbVmClusterName = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]"),
            };
            // Make the request
            ExadbVmCluster response = oracleDatabaseClient.GetExadbVmCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetExadbVmClusterAsync</summary>
        public async Task GetExadbVmClusterRequestObjectAsync()
        {
            // Snippet: GetExadbVmClusterAsync(GetExadbVmClusterRequest, CallSettings)
            // Additional: GetExadbVmClusterAsync(GetExadbVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetExadbVmClusterRequest request = new GetExadbVmClusterRequest
            {
                ExadbVmClusterName = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]"),
            };
            // Make the request
            ExadbVmCluster response = await oracleDatabaseClient.GetExadbVmClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExadbVmCluster</summary>
        public void GetExadbVmCluster()
        {
            // Snippet: GetExadbVmCluster(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exadbVmClusters/[EXADB_VM_CLUSTER]";
            // Make the request
            ExadbVmCluster response = oracleDatabaseClient.GetExadbVmCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetExadbVmClusterAsync</summary>
        public async Task GetExadbVmClusterAsync()
        {
            // Snippet: GetExadbVmClusterAsync(string, CallSettings)
            // Additional: GetExadbVmClusterAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exadbVmClusters/[EXADB_VM_CLUSTER]";
            // Make the request
            ExadbVmCluster response = await oracleDatabaseClient.GetExadbVmClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExadbVmCluster</summary>
        public void GetExadbVmClusterResourceNames()
        {
            // Snippet: GetExadbVmCluster(ExadbVmClusterName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ExadbVmClusterName name = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
            // Make the request
            ExadbVmCluster response = oracleDatabaseClient.GetExadbVmCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetExadbVmClusterAsync</summary>
        public async Task GetExadbVmClusterResourceNamesAsync()
        {
            // Snippet: GetExadbVmClusterAsync(ExadbVmClusterName, CallSettings)
            // Additional: GetExadbVmClusterAsync(ExadbVmClusterName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ExadbVmClusterName name = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
            // Make the request
            ExadbVmCluster response = await oracleDatabaseClient.GetExadbVmClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExadbVmCluster</summary>
        public void CreateExadbVmClusterRequestObject()
        {
            // Snippet: CreateExadbVmCluster(CreateExadbVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateExadbVmClusterRequest request = new CreateExadbVmClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExadbVmClusterId = "",
                ExadbVmCluster = new ExadbVmCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.CreateExadbVmCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExadbVmClusterAsync</summary>
        public async Task CreateExadbVmClusterRequestObjectAsync()
        {
            // Snippet: CreateExadbVmClusterAsync(CreateExadbVmClusterRequest, CallSettings)
            // Additional: CreateExadbVmClusterAsync(CreateExadbVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateExadbVmClusterRequest request = new CreateExadbVmClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExadbVmClusterId = "",
                ExadbVmCluster = new ExadbVmCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.CreateExadbVmClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExadbVmCluster</summary>
        public void CreateExadbVmCluster()
        {
            // Snippet: CreateExadbVmCluster(string, ExadbVmCluster, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExadbVmCluster exadbVmCluster = new ExadbVmCluster();
            string exadbVmClusterId = "";
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.CreateExadbVmCluster(parent, exadbVmCluster, exadbVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExadbVmClusterAsync</summary>
        public async Task CreateExadbVmClusterAsync()
        {
            // Snippet: CreateExadbVmClusterAsync(string, ExadbVmCluster, string, CallSettings)
            // Additional: CreateExadbVmClusterAsync(string, ExadbVmCluster, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExadbVmCluster exadbVmCluster = new ExadbVmCluster();
            string exadbVmClusterId = "";
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.CreateExadbVmClusterAsync(parent, exadbVmCluster, exadbVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExadbVmCluster</summary>
        public void CreateExadbVmClusterResourceNames()
        {
            // Snippet: CreateExadbVmCluster(LocationName, ExadbVmCluster, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExadbVmCluster exadbVmCluster = new ExadbVmCluster();
            string exadbVmClusterId = "";
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.CreateExadbVmCluster(parent, exadbVmCluster, exadbVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExadbVmClusterAsync</summary>
        public async Task CreateExadbVmClusterResourceNamesAsync()
        {
            // Snippet: CreateExadbVmClusterAsync(LocationName, ExadbVmCluster, string, CallSettings)
            // Additional: CreateExadbVmClusterAsync(LocationName, ExadbVmCluster, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExadbVmCluster exadbVmCluster = new ExadbVmCluster();
            string exadbVmClusterId = "";
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.CreateExadbVmClusterAsync(parent, exadbVmCluster, exadbVmClusterId);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExadbVmCluster</summary>
        public void DeleteExadbVmClusterRequestObject()
        {
            // Snippet: DeleteExadbVmCluster(DeleteExadbVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteExadbVmClusterRequest request = new DeleteExadbVmClusterRequest
            {
                ExadbVmClusterName = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteExadbVmCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExadbVmClusterAsync</summary>
        public async Task DeleteExadbVmClusterRequestObjectAsync()
        {
            // Snippet: DeleteExadbVmClusterAsync(DeleteExadbVmClusterRequest, CallSettings)
            // Additional: DeleteExadbVmClusterAsync(DeleteExadbVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExadbVmClusterRequest request = new DeleteExadbVmClusterRequest
            {
                ExadbVmClusterName = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteExadbVmClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExadbVmCluster</summary>
        public void DeleteExadbVmCluster()
        {
            // Snippet: DeleteExadbVmCluster(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exadbVmClusters/[EXADB_VM_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteExadbVmCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExadbVmClusterAsync</summary>
        public async Task DeleteExadbVmClusterAsync()
        {
            // Snippet: DeleteExadbVmClusterAsync(string, CallSettings)
            // Additional: DeleteExadbVmClusterAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exadbVmClusters/[EXADB_VM_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteExadbVmClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExadbVmCluster</summary>
        public void DeleteExadbVmClusterResourceNames()
        {
            // Snippet: DeleteExadbVmCluster(ExadbVmClusterName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ExadbVmClusterName name = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteExadbVmCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExadbVmClusterAsync</summary>
        public async Task DeleteExadbVmClusterResourceNamesAsync()
        {
            // Snippet: DeleteExadbVmClusterAsync(ExadbVmClusterName, CallSettings)
            // Additional: DeleteExadbVmClusterAsync(ExadbVmClusterName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ExadbVmClusterName name = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteExadbVmClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExadbVmCluster</summary>
        public void UpdateExadbVmClusterRequestObject()
        {
            // Snippet: UpdateExadbVmCluster(UpdateExadbVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            UpdateExadbVmClusterRequest request = new UpdateExadbVmClusterRequest
            {
                UpdateMask = new FieldMask(),
                ExadbVmCluster = new ExadbVmCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.UpdateExadbVmCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceUpdateExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExadbVmClusterAsync</summary>
        public async Task UpdateExadbVmClusterRequestObjectAsync()
        {
            // Snippet: UpdateExadbVmClusterAsync(UpdateExadbVmClusterRequest, CallSettings)
            // Additional: UpdateExadbVmClusterAsync(UpdateExadbVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            UpdateExadbVmClusterRequest request = new UpdateExadbVmClusterRequest
            {
                UpdateMask = new FieldMask(),
                ExadbVmCluster = new ExadbVmCluster(),
                RequestId = "",
            };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.UpdateExadbVmClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceUpdateExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExadbVmCluster</summary>
        public void UpdateExadbVmCluster()
        {
            // Snippet: UpdateExadbVmCluster(ExadbVmCluster, FieldMask, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ExadbVmCluster exadbVmCluster = new ExadbVmCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.UpdateExadbVmCluster(exadbVmCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceUpdateExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateExadbVmClusterAsync</summary>
        public async Task UpdateExadbVmClusterAsync()
        {
            // Snippet: UpdateExadbVmClusterAsync(ExadbVmCluster, FieldMask, CallSettings)
            // Additional: UpdateExadbVmClusterAsync(ExadbVmCluster, FieldMask, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ExadbVmCluster exadbVmCluster = new ExadbVmCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.UpdateExadbVmClusterAsync(exadbVmCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceUpdateExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveVirtualMachineExadbVmCluster</summary>
        public void RemoveVirtualMachineExadbVmClusterRequestObject()
        {
            // Snippet: RemoveVirtualMachineExadbVmCluster(RemoveVirtualMachineExadbVmClusterRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            RemoveVirtualMachineExadbVmClusterRequest request = new RemoveVirtualMachineExadbVmClusterRequest
            {
                ExadbVmClusterName = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]"),
                RequestId = "",
                Hostnames = { "", },
            };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.RemoveVirtualMachineExadbVmCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRemoveVirtualMachineExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveVirtualMachineExadbVmClusterAsync</summary>
        public async Task RemoveVirtualMachineExadbVmClusterRequestObjectAsync()
        {
            // Snippet: RemoveVirtualMachineExadbVmClusterAsync(RemoveVirtualMachineExadbVmClusterRequest, CallSettings)
            // Additional: RemoveVirtualMachineExadbVmClusterAsync(RemoveVirtualMachineExadbVmClusterRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            RemoveVirtualMachineExadbVmClusterRequest request = new RemoveVirtualMachineExadbVmClusterRequest
            {
                ExadbVmClusterName = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]"),
                RequestId = "",
                Hostnames = { "", },
            };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.RemoveVirtualMachineExadbVmClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRemoveVirtualMachineExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveVirtualMachineExadbVmCluster</summary>
        public void RemoveVirtualMachineExadbVmCluster()
        {
            // Snippet: RemoveVirtualMachineExadbVmCluster(string, IEnumerable<string>, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exadbVmClusters/[EXADB_VM_CLUSTER]";
            IEnumerable<string> hostnames = new string[] { "", };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.RemoveVirtualMachineExadbVmCluster(name, hostnames);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRemoveVirtualMachineExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveVirtualMachineExadbVmClusterAsync</summary>
        public async Task RemoveVirtualMachineExadbVmClusterAsync()
        {
            // Snippet: RemoveVirtualMachineExadbVmClusterAsync(string, IEnumerable<string>, CallSettings)
            // Additional: RemoveVirtualMachineExadbVmClusterAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exadbVmClusters/[EXADB_VM_CLUSTER]";
            IEnumerable<string> hostnames = new string[] { "", };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.RemoveVirtualMachineExadbVmClusterAsync(name, hostnames);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRemoveVirtualMachineExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveVirtualMachineExadbVmCluster</summary>
        public void RemoveVirtualMachineExadbVmClusterResourceNames()
        {
            // Snippet: RemoveVirtualMachineExadbVmCluster(ExadbVmClusterName, IEnumerable<string>, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ExadbVmClusterName name = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
            IEnumerable<string> hostnames = new string[] { "", };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = oracleDatabaseClient.RemoveVirtualMachineExadbVmCluster(name, hostnames);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceRemoveVirtualMachineExadbVmCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveVirtualMachineExadbVmClusterAsync</summary>
        public async Task RemoveVirtualMachineExadbVmClusterResourceNamesAsync()
        {
            // Snippet: RemoveVirtualMachineExadbVmClusterAsync(ExadbVmClusterName, IEnumerable<string>, CallSettings)
            // Additional: RemoveVirtualMachineExadbVmClusterAsync(ExadbVmClusterName, IEnumerable<string>, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ExadbVmClusterName name = ExadbVmClusterName.FromProjectLocationExadbVmCluster("[PROJECT]", "[LOCATION]", "[EXADB_VM_CLUSTER]");
            IEnumerable<string> hostnames = new string[] { "", };
            // Make the request
            Operation<ExadbVmCluster, OperationMetadata> response = await oracleDatabaseClient.RemoveVirtualMachineExadbVmClusterAsync(name, hostnames);

            // Poll until the returned long-running operation is complete
            Operation<ExadbVmCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExadbVmCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExadbVmCluster, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceRemoveVirtualMachineExadbVmClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExadbVmCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListExascaleDbStorageVaults</summary>
        public void ListExascaleDbStorageVaultsRequestObject()
        {
            // Snippet: ListExascaleDbStorageVaults(ListExascaleDbStorageVaultsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListExascaleDbStorageVaultsRequest request = new ListExascaleDbStorageVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> response = oracleDatabaseClient.ListExascaleDbStorageVaults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExascaleDbStorageVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExascaleDbStorageVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExascaleDbStorageVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExascaleDbStorageVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExascaleDbStorageVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExascaleDbStorageVaultsAsync</summary>
        public async Task ListExascaleDbStorageVaultsRequestObjectAsync()
        {
            // Snippet: ListExascaleDbStorageVaultsAsync(ListExascaleDbStorageVaultsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListExascaleDbStorageVaultsRequest request = new ListExascaleDbStorageVaultsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> response = oracleDatabaseClient.ListExascaleDbStorageVaultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExascaleDbStorageVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExascaleDbStorageVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExascaleDbStorageVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExascaleDbStorageVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExascaleDbStorageVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExascaleDbStorageVaults</summary>
        public void ListExascaleDbStorageVaults()
        {
            // Snippet: ListExascaleDbStorageVaults(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> response = oracleDatabaseClient.ListExascaleDbStorageVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExascaleDbStorageVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExascaleDbStorageVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExascaleDbStorageVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExascaleDbStorageVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExascaleDbStorageVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExascaleDbStorageVaultsAsync</summary>
        public async Task ListExascaleDbStorageVaultsAsync()
        {
            // Snippet: ListExascaleDbStorageVaultsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> response = oracleDatabaseClient.ListExascaleDbStorageVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExascaleDbStorageVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExascaleDbStorageVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExascaleDbStorageVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExascaleDbStorageVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExascaleDbStorageVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExascaleDbStorageVaults</summary>
        public void ListExascaleDbStorageVaultsResourceNames()
        {
            // Snippet: ListExascaleDbStorageVaults(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> response = oracleDatabaseClient.ListExascaleDbStorageVaults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ExascaleDbStorageVault item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListExascaleDbStorageVaultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExascaleDbStorageVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExascaleDbStorageVault> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExascaleDbStorageVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListExascaleDbStorageVaultsAsync</summary>
        public async Task ListExascaleDbStorageVaultsResourceNamesAsync()
        {
            // Snippet: ListExascaleDbStorageVaultsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListExascaleDbStorageVaultsResponse, ExascaleDbStorageVault> response = oracleDatabaseClient.ListExascaleDbStorageVaultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ExascaleDbStorageVault item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListExascaleDbStorageVaultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ExascaleDbStorageVault item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ExascaleDbStorageVault> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ExascaleDbStorageVault item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetExascaleDbStorageVault</summary>
        public void GetExascaleDbStorageVaultRequestObject()
        {
            // Snippet: GetExascaleDbStorageVault(GetExascaleDbStorageVaultRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetExascaleDbStorageVaultRequest request = new GetExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]"),
            };
            // Make the request
            ExascaleDbStorageVault response = oracleDatabaseClient.GetExascaleDbStorageVault(request);
            // End snippet
        }

        /// <summary>Snippet for GetExascaleDbStorageVaultAsync</summary>
        public async Task GetExascaleDbStorageVaultRequestObjectAsync()
        {
            // Snippet: GetExascaleDbStorageVaultAsync(GetExascaleDbStorageVaultRequest, CallSettings)
            // Additional: GetExascaleDbStorageVaultAsync(GetExascaleDbStorageVaultRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetExascaleDbStorageVaultRequest request = new GetExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]"),
            };
            // Make the request
            ExascaleDbStorageVault response = await oracleDatabaseClient.GetExascaleDbStorageVaultAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetExascaleDbStorageVault</summary>
        public void GetExascaleDbStorageVault()
        {
            // Snippet: GetExascaleDbStorageVault(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exascaleDbStorageVaults/[EXASCALE_DB_STORAGE_VAULT]";
            // Make the request
            ExascaleDbStorageVault response = oracleDatabaseClient.GetExascaleDbStorageVault(name);
            // End snippet
        }

        /// <summary>Snippet for GetExascaleDbStorageVaultAsync</summary>
        public async Task GetExascaleDbStorageVaultAsync()
        {
            // Snippet: GetExascaleDbStorageVaultAsync(string, CallSettings)
            // Additional: GetExascaleDbStorageVaultAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exascaleDbStorageVaults/[EXASCALE_DB_STORAGE_VAULT]";
            // Make the request
            ExascaleDbStorageVault response = await oracleDatabaseClient.GetExascaleDbStorageVaultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetExascaleDbStorageVault</summary>
        public void GetExascaleDbStorageVaultResourceNames()
        {
            // Snippet: GetExascaleDbStorageVault(ExascaleDbStorageVaultName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ExascaleDbStorageVaultName name = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]");
            // Make the request
            ExascaleDbStorageVault response = oracleDatabaseClient.GetExascaleDbStorageVault(name);
            // End snippet
        }

        /// <summary>Snippet for GetExascaleDbStorageVaultAsync</summary>
        public async Task GetExascaleDbStorageVaultResourceNamesAsync()
        {
            // Snippet: GetExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName, CallSettings)
            // Additional: GetExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ExascaleDbStorageVaultName name = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]");
            // Make the request
            ExascaleDbStorageVault response = await oracleDatabaseClient.GetExascaleDbStorageVaultAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateExascaleDbStorageVault</summary>
        public void CreateExascaleDbStorageVaultRequestObject()
        {
            // Snippet: CreateExascaleDbStorageVault(CreateExascaleDbStorageVaultRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateExascaleDbStorageVaultRequest request = new CreateExascaleDbStorageVaultRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExascaleDbStorageVaultId = "",
                ExascaleDbStorageVault = new ExascaleDbStorageVault(),
                RequestId = "",
            };
            // Make the request
            Operation<ExascaleDbStorageVault, OperationMetadata> response = oracleDatabaseClient.CreateExascaleDbStorageVault(request);

            // Poll until the returned long-running operation is complete
            Operation<ExascaleDbStorageVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExascaleDbStorageVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExascaleDbStorageVault, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateExascaleDbStorageVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExascaleDbStorageVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExascaleDbStorageVaultAsync</summary>
        public async Task CreateExascaleDbStorageVaultRequestObjectAsync()
        {
            // Snippet: CreateExascaleDbStorageVaultAsync(CreateExascaleDbStorageVaultRequest, CallSettings)
            // Additional: CreateExascaleDbStorageVaultAsync(CreateExascaleDbStorageVaultRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateExascaleDbStorageVaultRequest request = new CreateExascaleDbStorageVaultRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExascaleDbStorageVaultId = "",
                ExascaleDbStorageVault = new ExascaleDbStorageVault(),
                RequestId = "",
            };
            // Make the request
            Operation<ExascaleDbStorageVault, OperationMetadata> response = await oracleDatabaseClient.CreateExascaleDbStorageVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExascaleDbStorageVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExascaleDbStorageVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExascaleDbStorageVault, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateExascaleDbStorageVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExascaleDbStorageVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExascaleDbStorageVault</summary>
        public void CreateExascaleDbStorageVault()
        {
            // Snippet: CreateExascaleDbStorageVault(string, ExascaleDbStorageVault, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExascaleDbStorageVault exascaleDbStorageVault = new ExascaleDbStorageVault();
            string exascaleDbStorageVaultId = "";
            // Make the request
            Operation<ExascaleDbStorageVault, OperationMetadata> response = oracleDatabaseClient.CreateExascaleDbStorageVault(parent, exascaleDbStorageVault, exascaleDbStorageVaultId);

            // Poll until the returned long-running operation is complete
            Operation<ExascaleDbStorageVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExascaleDbStorageVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExascaleDbStorageVault, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateExascaleDbStorageVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExascaleDbStorageVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExascaleDbStorageVaultAsync</summary>
        public async Task CreateExascaleDbStorageVaultAsync()
        {
            // Snippet: CreateExascaleDbStorageVaultAsync(string, ExascaleDbStorageVault, string, CallSettings)
            // Additional: CreateExascaleDbStorageVaultAsync(string, ExascaleDbStorageVault, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ExascaleDbStorageVault exascaleDbStorageVault = new ExascaleDbStorageVault();
            string exascaleDbStorageVaultId = "";
            // Make the request
            Operation<ExascaleDbStorageVault, OperationMetadata> response = await oracleDatabaseClient.CreateExascaleDbStorageVaultAsync(parent, exascaleDbStorageVault, exascaleDbStorageVaultId);

            // Poll until the returned long-running operation is complete
            Operation<ExascaleDbStorageVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExascaleDbStorageVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExascaleDbStorageVault, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateExascaleDbStorageVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExascaleDbStorageVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExascaleDbStorageVault</summary>
        public void CreateExascaleDbStorageVaultResourceNames()
        {
            // Snippet: CreateExascaleDbStorageVault(LocationName, ExascaleDbStorageVault, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExascaleDbStorageVault exascaleDbStorageVault = new ExascaleDbStorageVault();
            string exascaleDbStorageVaultId = "";
            // Make the request
            Operation<ExascaleDbStorageVault, OperationMetadata> response = oracleDatabaseClient.CreateExascaleDbStorageVault(parent, exascaleDbStorageVault, exascaleDbStorageVaultId);

            // Poll until the returned long-running operation is complete
            Operation<ExascaleDbStorageVault, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExascaleDbStorageVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExascaleDbStorageVault, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateExascaleDbStorageVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExascaleDbStorageVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateExascaleDbStorageVaultAsync</summary>
        public async Task CreateExascaleDbStorageVaultResourceNamesAsync()
        {
            // Snippet: CreateExascaleDbStorageVaultAsync(LocationName, ExascaleDbStorageVault, string, CallSettings)
            // Additional: CreateExascaleDbStorageVaultAsync(LocationName, ExascaleDbStorageVault, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ExascaleDbStorageVault exascaleDbStorageVault = new ExascaleDbStorageVault();
            string exascaleDbStorageVaultId = "";
            // Make the request
            Operation<ExascaleDbStorageVault, OperationMetadata> response = await oracleDatabaseClient.CreateExascaleDbStorageVaultAsync(parent, exascaleDbStorageVault, exascaleDbStorageVaultId);

            // Poll until the returned long-running operation is complete
            Operation<ExascaleDbStorageVault, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExascaleDbStorageVault result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExascaleDbStorageVault, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateExascaleDbStorageVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExascaleDbStorageVault retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExascaleDbStorageVault</summary>
        public void DeleteExascaleDbStorageVaultRequestObject()
        {
            // Snippet: DeleteExascaleDbStorageVault(DeleteExascaleDbStorageVaultRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteExascaleDbStorageVaultRequest request = new DeleteExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteExascaleDbStorageVault(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteExascaleDbStorageVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExascaleDbStorageVaultAsync</summary>
        public async Task DeleteExascaleDbStorageVaultRequestObjectAsync()
        {
            // Snippet: DeleteExascaleDbStorageVaultAsync(DeleteExascaleDbStorageVaultRequest, CallSettings)
            // Additional: DeleteExascaleDbStorageVaultAsync(DeleteExascaleDbStorageVaultRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteExascaleDbStorageVaultRequest request = new DeleteExascaleDbStorageVaultRequest
            {
                ExascaleDbStorageVaultName = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteExascaleDbStorageVaultAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteExascaleDbStorageVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExascaleDbStorageVault</summary>
        public void DeleteExascaleDbStorageVault()
        {
            // Snippet: DeleteExascaleDbStorageVault(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exascaleDbStorageVaults/[EXASCALE_DB_STORAGE_VAULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteExascaleDbStorageVault(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteExascaleDbStorageVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExascaleDbStorageVaultAsync</summary>
        public async Task DeleteExascaleDbStorageVaultAsync()
        {
            // Snippet: DeleteExascaleDbStorageVaultAsync(string, CallSettings)
            // Additional: DeleteExascaleDbStorageVaultAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/exascaleDbStorageVaults/[EXASCALE_DB_STORAGE_VAULT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteExascaleDbStorageVaultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteExascaleDbStorageVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExascaleDbStorageVault</summary>
        public void DeleteExascaleDbStorageVaultResourceNames()
        {
            // Snippet: DeleteExascaleDbStorageVault(ExascaleDbStorageVaultName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ExascaleDbStorageVaultName name = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteExascaleDbStorageVault(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteExascaleDbStorageVault(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteExascaleDbStorageVaultAsync</summary>
        public async Task DeleteExascaleDbStorageVaultResourceNamesAsync()
        {
            // Snippet: DeleteExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName, CallSettings)
            // Additional: DeleteExascaleDbStorageVaultAsync(ExascaleDbStorageVaultName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ExascaleDbStorageVaultName name = ExascaleDbStorageVaultName.FromProjectLocationExascaleDbStorageVault("[PROJECT]", "[LOCATION]", "[EXASCALE_DB_STORAGE_VAULT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteExascaleDbStorageVaultAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteExascaleDbStorageVaultAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemInitialStorageSizes</summary>
        public void ListDbSystemInitialStorageSizesRequestObject()
        {
            // Snippet: ListDbSystemInitialStorageSizes(ListDbSystemInitialStorageSizesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDbSystemInitialStorageSizesRequest request = new ListDbSystemInitialStorageSizesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> response = oracleDatabaseClient.ListDbSystemInitialStorageSizes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystemInitialStorageSize item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemInitialStorageSizesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemInitialStorageSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemInitialStorageSize> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemInitialStorageSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemInitialStorageSizesAsync</summary>
        public async Task ListDbSystemInitialStorageSizesRequestObjectAsync()
        {
            // Snippet: ListDbSystemInitialStorageSizesAsync(ListDbSystemInitialStorageSizesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDbSystemInitialStorageSizesRequest request = new ListDbSystemInitialStorageSizesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> response = oracleDatabaseClient.ListDbSystemInitialStorageSizesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystemInitialStorageSize item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemInitialStorageSizesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemInitialStorageSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemInitialStorageSize> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemInitialStorageSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemInitialStorageSizes</summary>
        public void ListDbSystemInitialStorageSizes()
        {
            // Snippet: ListDbSystemInitialStorageSizes(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> response = oracleDatabaseClient.ListDbSystemInitialStorageSizes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystemInitialStorageSize item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemInitialStorageSizesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemInitialStorageSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemInitialStorageSize> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemInitialStorageSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemInitialStorageSizesAsync</summary>
        public async Task ListDbSystemInitialStorageSizesAsync()
        {
            // Snippet: ListDbSystemInitialStorageSizesAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> response = oracleDatabaseClient.ListDbSystemInitialStorageSizesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystemInitialStorageSize item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemInitialStorageSizesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemInitialStorageSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemInitialStorageSize> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemInitialStorageSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemInitialStorageSizes</summary>
        public void ListDbSystemInitialStorageSizesResourceNames()
        {
            // Snippet: ListDbSystemInitialStorageSizes(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> response = oracleDatabaseClient.ListDbSystemInitialStorageSizes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystemInitialStorageSize item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemInitialStorageSizesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemInitialStorageSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemInitialStorageSize> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemInitialStorageSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemInitialStorageSizesAsync</summary>
        public async Task ListDbSystemInitialStorageSizesResourceNamesAsync()
        {
            // Snippet: ListDbSystemInitialStorageSizesAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDbSystemInitialStorageSizesResponse, DbSystemInitialStorageSize> response = oracleDatabaseClient.ListDbSystemInitialStorageSizesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystemInitialStorageSize item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemInitialStorageSizesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystemInitialStorageSize item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystemInitialStorageSize> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystemInitialStorageSize item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesRequestObject()
        {
            // Snippet: ListDatabases(ListDatabasesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = oracleDatabaseClient.ListDatabases(request);

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
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = oracleDatabaseClient.ListDatabasesAsync(request);

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
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = oracleDatabaseClient.ListDatabases(parent);

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
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = oracleDatabaseClient.ListDatabasesAsync(parent);

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
            // Snippet: ListDatabases(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = oracleDatabaseClient.ListDatabases(parent);

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
            // Snippet: ListDatabasesAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = oracleDatabaseClient.ListDatabasesAsync(parent);

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

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseRequestObject()
        {
            // Snippet: GetDatabase(GetDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectLocationDatabase("[PROJECT]", "[LOCATION]", "[DATABASE]"),
            };
            // Make the request
            Database response = oracleDatabaseClient.GetDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseRequestObjectAsync()
        {
            // Snippet: GetDatabaseAsync(GetDatabaseRequest, CallSettings)
            // Additional: GetDatabaseAsync(GetDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectLocationDatabase("[PROJECT]", "[LOCATION]", "[DATABASE]"),
            };
            // Make the request
            Database response = await oracleDatabaseClient.GetDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabase()
        {
            // Snippet: GetDatabase(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/databases/[DATABASE]";
            // Make the request
            Database response = oracleDatabaseClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseAsync()
        {
            // Snippet: GetDatabaseAsync(string, CallSettings)
            // Additional: GetDatabaseAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/databases/[DATABASE]";
            // Make the request
            Database response = await oracleDatabaseClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseResourceNames()
        {
            // Snippet: GetDatabase(DatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectLocationDatabase("[PROJECT]", "[LOCATION]", "[DATABASE]");
            // Make the request
            Database response = oracleDatabaseClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseResourceNamesAsync()
        {
            // Snippet: GetDatabaseAsync(DatabaseName, CallSettings)
            // Additional: GetDatabaseAsync(DatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectLocationDatabase("[PROJECT]", "[LOCATION]", "[DATABASE]");
            // Make the request
            Database response = await oracleDatabaseClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPluggableDatabases</summary>
        public void ListPluggableDatabasesRequestObject()
        {
            // Snippet: ListPluggableDatabases(ListPluggableDatabasesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListPluggableDatabasesRequest request = new ListPluggableDatabasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> response = oracleDatabaseClient.ListPluggableDatabases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PluggableDatabase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluggableDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluggableDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluggableDatabase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluggableDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluggableDatabasesAsync</summary>
        public async Task ListPluggableDatabasesRequestObjectAsync()
        {
            // Snippet: ListPluggableDatabasesAsync(ListPluggableDatabasesRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListPluggableDatabasesRequest request = new ListPluggableDatabasesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> response = oracleDatabaseClient.ListPluggableDatabasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PluggableDatabase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluggableDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluggableDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluggableDatabase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluggableDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluggableDatabases</summary>
        public void ListPluggableDatabases()
        {
            // Snippet: ListPluggableDatabases(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> response = oracleDatabaseClient.ListPluggableDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PluggableDatabase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluggableDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluggableDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluggableDatabase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluggableDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluggableDatabasesAsync</summary>
        public async Task ListPluggableDatabasesAsync()
        {
            // Snippet: ListPluggableDatabasesAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> response = oracleDatabaseClient.ListPluggableDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PluggableDatabase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluggableDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluggableDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluggableDatabase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluggableDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluggableDatabases</summary>
        public void ListPluggableDatabasesResourceNames()
        {
            // Snippet: ListPluggableDatabases(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> response = oracleDatabaseClient.ListPluggableDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PluggableDatabase item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPluggableDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluggableDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluggableDatabase> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluggableDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPluggableDatabasesAsync</summary>
        public async Task ListPluggableDatabasesResourceNamesAsync()
        {
            // Snippet: ListPluggableDatabasesAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPluggableDatabasesResponse, PluggableDatabase> response = oracleDatabaseClient.ListPluggableDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PluggableDatabase item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPluggableDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PluggableDatabase item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PluggableDatabase> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PluggableDatabase item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPluggableDatabase</summary>
        public void GetPluggableDatabaseRequestObject()
        {
            // Snippet: GetPluggableDatabase(GetPluggableDatabaseRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetPluggableDatabaseRequest request = new GetPluggableDatabaseRequest
            {
                PluggableDatabaseName = PluggableDatabaseName.FromProjectLocationPluggableDatabase("[PROJECT]", "[LOCATION]", "[PLUGGABLE_DATABASE]"),
            };
            // Make the request
            PluggableDatabase response = oracleDatabaseClient.GetPluggableDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for GetPluggableDatabaseAsync</summary>
        public async Task GetPluggableDatabaseRequestObjectAsync()
        {
            // Snippet: GetPluggableDatabaseAsync(GetPluggableDatabaseRequest, CallSettings)
            // Additional: GetPluggableDatabaseAsync(GetPluggableDatabaseRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetPluggableDatabaseRequest request = new GetPluggableDatabaseRequest
            {
                PluggableDatabaseName = PluggableDatabaseName.FromProjectLocationPluggableDatabase("[PROJECT]", "[LOCATION]", "[PLUGGABLE_DATABASE]"),
            };
            // Make the request
            PluggableDatabase response = await oracleDatabaseClient.GetPluggableDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPluggableDatabase</summary>
        public void GetPluggableDatabase()
        {
            // Snippet: GetPluggableDatabase(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pluggableDatabases/[PLUGGABLE_DATABASE]";
            // Make the request
            PluggableDatabase response = oracleDatabaseClient.GetPluggableDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluggableDatabaseAsync</summary>
        public async Task GetPluggableDatabaseAsync()
        {
            // Snippet: GetPluggableDatabaseAsync(string, CallSettings)
            // Additional: GetPluggableDatabaseAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/pluggableDatabases/[PLUGGABLE_DATABASE]";
            // Make the request
            PluggableDatabase response = await oracleDatabaseClient.GetPluggableDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluggableDatabase</summary>
        public void GetPluggableDatabaseResourceNames()
        {
            // Snippet: GetPluggableDatabase(PluggableDatabaseName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            PluggableDatabaseName name = PluggableDatabaseName.FromProjectLocationPluggableDatabase("[PROJECT]", "[LOCATION]", "[PLUGGABLE_DATABASE]");
            // Make the request
            PluggableDatabase response = oracleDatabaseClient.GetPluggableDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetPluggableDatabaseAsync</summary>
        public async Task GetPluggableDatabaseResourceNamesAsync()
        {
            // Snippet: GetPluggableDatabaseAsync(PluggableDatabaseName, CallSettings)
            // Additional: GetPluggableDatabaseAsync(PluggableDatabaseName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            PluggableDatabaseName name = PluggableDatabaseName.FromProjectLocationPluggableDatabase("[PROJECT]", "[LOCATION]", "[PLUGGABLE_DATABASE]");
            // Make the request
            PluggableDatabase response = await oracleDatabaseClient.GetPluggableDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListDbSystems</summary>
        public void ListDbSystemsRequestObject()
        {
            // Snippet: ListDbSystems(ListDbSystemsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDbSystemsRequest request = new ListDbSystemsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDbSystemsResponse, DbSystem> response = oracleDatabaseClient.ListDbSystems(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemsAsync</summary>
        public async Task ListDbSystemsRequestObjectAsync()
        {
            // Snippet: ListDbSystemsAsync(ListDbSystemsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDbSystemsRequest request = new ListDbSystemsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDbSystemsResponse, DbSystem> response = oracleDatabaseClient.ListDbSystemsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystems</summary>
        public void ListDbSystems()
        {
            // Snippet: ListDbSystems(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDbSystemsResponse, DbSystem> response = oracleDatabaseClient.ListDbSystems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemsAsync</summary>
        public async Task ListDbSystemsAsync()
        {
            // Snippet: ListDbSystemsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDbSystemsResponse, DbSystem> response = oracleDatabaseClient.ListDbSystemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystems</summary>
        public void ListDbSystemsResourceNames()
        {
            // Snippet: ListDbSystems(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDbSystemsResponse, DbSystem> response = oracleDatabaseClient.ListDbSystems(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbSystem item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbSystemsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystem> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbSystemsAsync</summary>
        public async Task ListDbSystemsResourceNamesAsync()
        {
            // Snippet: ListDbSystemsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDbSystemsResponse, DbSystem> response = oracleDatabaseClient.ListDbSystemsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbSystem item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbSystemsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbSystem item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbSystem> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbSystem item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDbSystem</summary>
        public void GetDbSystemRequestObject()
        {
            // Snippet: GetDbSystem(GetDbSystemRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            GetDbSystemRequest request = new GetDbSystemRequest
            {
                DbSystemName = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]"),
            };
            // Make the request
            DbSystem response = oracleDatabaseClient.GetDbSystem(request);
            // End snippet
        }

        /// <summary>Snippet for GetDbSystemAsync</summary>
        public async Task GetDbSystemRequestObjectAsync()
        {
            // Snippet: GetDbSystemAsync(GetDbSystemRequest, CallSettings)
            // Additional: GetDbSystemAsync(GetDbSystemRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            GetDbSystemRequest request = new GetDbSystemRequest
            {
                DbSystemName = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]"),
            };
            // Make the request
            DbSystem response = await oracleDatabaseClient.GetDbSystemAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDbSystem</summary>
        public void GetDbSystem()
        {
            // Snippet: GetDbSystem(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dbSystems/[DB_SYSTEM]";
            // Make the request
            DbSystem response = oracleDatabaseClient.GetDbSystem(name);
            // End snippet
        }

        /// <summary>Snippet for GetDbSystemAsync</summary>
        public async Task GetDbSystemAsync()
        {
            // Snippet: GetDbSystemAsync(string, CallSettings)
            // Additional: GetDbSystemAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dbSystems/[DB_SYSTEM]";
            // Make the request
            DbSystem response = await oracleDatabaseClient.GetDbSystemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDbSystem</summary>
        public void GetDbSystemResourceNames()
        {
            // Snippet: GetDbSystem(DbSystemName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DbSystemName name = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]");
            // Make the request
            DbSystem response = oracleDatabaseClient.GetDbSystem(name);
            // End snippet
        }

        /// <summary>Snippet for GetDbSystemAsync</summary>
        public async Task GetDbSystemResourceNamesAsync()
        {
            // Snippet: GetDbSystemAsync(DbSystemName, CallSettings)
            // Additional: GetDbSystemAsync(DbSystemName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DbSystemName name = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]");
            // Make the request
            DbSystem response = await oracleDatabaseClient.GetDbSystemAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDbSystem</summary>
        public void CreateDbSystemRequestObject()
        {
            // Snippet: CreateDbSystem(CreateDbSystemRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            CreateDbSystemRequest request = new CreateDbSystemRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DbSystemId = "",
                DbSystem = new DbSystem(),
                RequestId = "",
            };
            // Make the request
            Operation<DbSystem, OperationMetadata> response = oracleDatabaseClient.CreateDbSystem(request);

            // Poll until the returned long-running operation is complete
            Operation<DbSystem, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DbSystem result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DbSystem, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateDbSystem(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DbSystem retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDbSystemAsync</summary>
        public async Task CreateDbSystemRequestObjectAsync()
        {
            // Snippet: CreateDbSystemAsync(CreateDbSystemRequest, CallSettings)
            // Additional: CreateDbSystemAsync(CreateDbSystemRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            CreateDbSystemRequest request = new CreateDbSystemRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DbSystemId = "",
                DbSystem = new DbSystem(),
                RequestId = "",
            };
            // Make the request
            Operation<DbSystem, OperationMetadata> response = await oracleDatabaseClient.CreateDbSystemAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DbSystem, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DbSystem result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DbSystem, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateDbSystemAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DbSystem retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDbSystem</summary>
        public void CreateDbSystem()
        {
            // Snippet: CreateDbSystem(string, DbSystem, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DbSystem dbSystem = new DbSystem();
            string dbSystemId = "";
            // Make the request
            Operation<DbSystem, OperationMetadata> response = oracleDatabaseClient.CreateDbSystem(parent, dbSystem, dbSystemId);

            // Poll until the returned long-running operation is complete
            Operation<DbSystem, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DbSystem result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DbSystem, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateDbSystem(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DbSystem retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDbSystemAsync</summary>
        public async Task CreateDbSystemAsync()
        {
            // Snippet: CreateDbSystemAsync(string, DbSystem, string, CallSettings)
            // Additional: CreateDbSystemAsync(string, DbSystem, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DbSystem dbSystem = new DbSystem();
            string dbSystemId = "";
            // Make the request
            Operation<DbSystem, OperationMetadata> response = await oracleDatabaseClient.CreateDbSystemAsync(parent, dbSystem, dbSystemId);

            // Poll until the returned long-running operation is complete
            Operation<DbSystem, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DbSystem result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DbSystem, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateDbSystemAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DbSystem retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDbSystem</summary>
        public void CreateDbSystemResourceNames()
        {
            // Snippet: CreateDbSystem(LocationName, DbSystem, string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DbSystem dbSystem = new DbSystem();
            string dbSystemId = "";
            // Make the request
            Operation<DbSystem, OperationMetadata> response = oracleDatabaseClient.CreateDbSystem(parent, dbSystem, dbSystemId);

            // Poll until the returned long-running operation is complete
            Operation<DbSystem, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DbSystem result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DbSystem, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceCreateDbSystem(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DbSystem retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDbSystemAsync</summary>
        public async Task CreateDbSystemResourceNamesAsync()
        {
            // Snippet: CreateDbSystemAsync(LocationName, DbSystem, string, CallSettings)
            // Additional: CreateDbSystemAsync(LocationName, DbSystem, string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DbSystem dbSystem = new DbSystem();
            string dbSystemId = "";
            // Make the request
            Operation<DbSystem, OperationMetadata> response = await oracleDatabaseClient.CreateDbSystemAsync(parent, dbSystem, dbSystemId);

            // Poll until the returned long-running operation is complete
            Operation<DbSystem, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DbSystem result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DbSystem, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceCreateDbSystemAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DbSystem retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDbSystem</summary>
        public void DeleteDbSystemRequestObject()
        {
            // Snippet: DeleteDbSystem(DeleteDbSystemRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DeleteDbSystemRequest request = new DeleteDbSystemRequest
            {
                DbSystemName = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteDbSystem(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteDbSystem(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDbSystemAsync</summary>
        public async Task DeleteDbSystemRequestObjectAsync()
        {
            // Snippet: DeleteDbSystemAsync(DeleteDbSystemRequest, CallSettings)
            // Additional: DeleteDbSystemAsync(DeleteDbSystemRequest, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDbSystemRequest request = new DeleteDbSystemRequest
            {
                DbSystemName = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteDbSystemAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteDbSystemAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDbSystem</summary>
        public void DeleteDbSystem()
        {
            // Snippet: DeleteDbSystem(string, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dbSystems/[DB_SYSTEM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteDbSystem(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteDbSystem(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDbSystemAsync</summary>
        public async Task DeleteDbSystemAsync()
        {
            // Snippet: DeleteDbSystemAsync(string, CallSettings)
            // Additional: DeleteDbSystemAsync(string, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dbSystems/[DB_SYSTEM]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteDbSystemAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteDbSystemAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDbSystem</summary>
        public void DeleteDbSystemResourceNames()
        {
            // Snippet: DeleteDbSystem(DbSystemName, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            DbSystemName name = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = oracleDatabaseClient.DeleteDbSystem(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = oracleDatabaseClient.PollOnceDeleteDbSystem(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDbSystemAsync</summary>
        public async Task DeleteDbSystemResourceNamesAsync()
        {
            // Snippet: DeleteDbSystemAsync(DbSystemName, CallSettings)
            // Additional: DeleteDbSystemAsync(DbSystemName, CancellationToken)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            DbSystemName name = DbSystemName.FromProjectLocationDbSystem("[PROJECT]", "[LOCATION]", "[DB_SYSTEM]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await oracleDatabaseClient.DeleteDbSystemAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await oracleDatabaseClient.PollOnceDeleteDbSystemAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDbVersions</summary>
        public void ListDbVersionsRequestObject()
        {
            // Snippet: ListDbVersions(ListDbVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDbVersionsRequest request = new ListDbVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDbVersionsResponse, DbVersion> response = oracleDatabaseClient.ListDbVersions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbVersionsAsync</summary>
        public async Task ListDbVersionsRequestObjectAsync()
        {
            // Snippet: ListDbVersionsAsync(ListDbVersionsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDbVersionsRequest request = new ListDbVersionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDbVersionsResponse, DbVersion> response = oracleDatabaseClient.ListDbVersionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbVersions</summary>
        public void ListDbVersions()
        {
            // Snippet: ListDbVersions(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDbVersionsResponse, DbVersion> response = oracleDatabaseClient.ListDbVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbVersionsAsync</summary>
        public async Task ListDbVersionsAsync()
        {
            // Snippet: ListDbVersionsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDbVersionsResponse, DbVersion> response = oracleDatabaseClient.ListDbVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbVersions</summary>
        public void ListDbVersionsResourceNames()
        {
            // Snippet: ListDbVersions(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDbVersionsResponse, DbVersion> response = oracleDatabaseClient.ListDbVersions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DbVersion item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDbVersionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbVersion> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDbVersionsAsync</summary>
        public async Task ListDbVersionsResourceNamesAsync()
        {
            // Snippet: ListDbVersionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDbVersionsResponse, DbVersion> response = oracleDatabaseClient.ListDbVersionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DbVersion item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDbVersionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DbVersion item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DbVersion> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DbVersion item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseCharacterSets</summary>
        public void ListDatabaseCharacterSetsRequestObject()
        {
            // Snippet: ListDatabaseCharacterSets(ListDatabaseCharacterSetsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            ListDatabaseCharacterSetsRequest request = new ListDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> response = oracleDatabaseClient.ListDatabaseCharacterSets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatabaseCharacterSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabaseCharacterSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseCharacterSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseCharacterSetsAsync</summary>
        public async Task ListDatabaseCharacterSetsRequestObjectAsync()
        {
            // Snippet: ListDatabaseCharacterSetsAsync(ListDatabaseCharacterSetsRequest, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabaseCharacterSetsRequest request = new ListDatabaseCharacterSetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> response = oracleDatabaseClient.ListDatabaseCharacterSetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatabaseCharacterSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabaseCharacterSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseCharacterSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseCharacterSets</summary>
        public void ListDatabaseCharacterSets()
        {
            // Snippet: ListDatabaseCharacterSets(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> response = oracleDatabaseClient.ListDatabaseCharacterSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatabaseCharacterSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabaseCharacterSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseCharacterSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseCharacterSetsAsync</summary>
        public async Task ListDatabaseCharacterSetsAsync()
        {
            // Snippet: ListDatabaseCharacterSetsAsync(string, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> response = oracleDatabaseClient.ListDatabaseCharacterSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatabaseCharacterSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabaseCharacterSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseCharacterSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseCharacterSets</summary>
        public void ListDatabaseCharacterSetsResourceNames()
        {
            // Snippet: ListDatabaseCharacterSets(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = OracleDatabaseClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> response = oracleDatabaseClient.ListDatabaseCharacterSets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DatabaseCharacterSet item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabaseCharacterSetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseCharacterSet> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseCharacterSet item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseCharacterSetsAsync</summary>
        public async Task ListDatabaseCharacterSetsResourceNamesAsync()
        {
            // Snippet: ListDatabaseCharacterSetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OracleDatabaseClient oracleDatabaseClient = await OracleDatabaseClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDatabaseCharacterSetsResponse, DatabaseCharacterSet> response = oracleDatabaseClient.ListDatabaseCharacterSetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DatabaseCharacterSet item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabaseCharacterSetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DatabaseCharacterSet item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DatabaseCharacterSet> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DatabaseCharacterSet item in singlePage)
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
