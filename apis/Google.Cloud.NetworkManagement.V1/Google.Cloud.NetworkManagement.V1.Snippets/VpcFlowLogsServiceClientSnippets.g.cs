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
    using Google.Cloud.NetworkManagement.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedVpcFlowLogsServiceClientSnippets
    {
        /// <summary>Snippet for ListVpcFlowLogsConfigs</summary>
        public void ListVpcFlowLogsConfigsRequestObject()
        {
            // Snippet: ListVpcFlowLogsConfigs(ListVpcFlowLogsConfigsRequest, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            ListVpcFlowLogsConfigsRequest request = new ListVpcFlowLogsConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> response = vpcFlowLogsServiceClient.ListVpcFlowLogsConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VpcFlowLogsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVpcFlowLogsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpcFlowLogsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpcFlowLogsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpcFlowLogsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVpcFlowLogsConfigsAsync</summary>
        public async Task ListVpcFlowLogsConfigsRequestObjectAsync()
        {
            // Snippet: ListVpcFlowLogsConfigsAsync(ListVpcFlowLogsConfigsRequest, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListVpcFlowLogsConfigsRequest request = new ListVpcFlowLogsConfigsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> response = vpcFlowLogsServiceClient.ListVpcFlowLogsConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VpcFlowLogsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVpcFlowLogsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpcFlowLogsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpcFlowLogsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpcFlowLogsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVpcFlowLogsConfigs</summary>
        public void ListVpcFlowLogsConfigs()
        {
            // Snippet: ListVpcFlowLogsConfigs(string, string, int?, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> response = vpcFlowLogsServiceClient.ListVpcFlowLogsConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VpcFlowLogsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVpcFlowLogsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpcFlowLogsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpcFlowLogsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpcFlowLogsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVpcFlowLogsConfigsAsync</summary>
        public async Task ListVpcFlowLogsConfigsAsync()
        {
            // Snippet: ListVpcFlowLogsConfigsAsync(string, string, int?, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> response = vpcFlowLogsServiceClient.ListVpcFlowLogsConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VpcFlowLogsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVpcFlowLogsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpcFlowLogsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpcFlowLogsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpcFlowLogsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVpcFlowLogsConfigs</summary>
        public void ListVpcFlowLogsConfigsResourceNames()
        {
            // Snippet: ListVpcFlowLogsConfigs(LocationName, string, int?, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> response = vpcFlowLogsServiceClient.ListVpcFlowLogsConfigs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (VpcFlowLogsConfig item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListVpcFlowLogsConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpcFlowLogsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpcFlowLogsConfig> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpcFlowLogsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListVpcFlowLogsConfigsAsync</summary>
        public async Task ListVpcFlowLogsConfigsResourceNamesAsync()
        {
            // Snippet: ListVpcFlowLogsConfigsAsync(LocationName, string, int?, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListVpcFlowLogsConfigsResponse, VpcFlowLogsConfig> response = vpcFlowLogsServiceClient.ListVpcFlowLogsConfigsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((VpcFlowLogsConfig item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListVpcFlowLogsConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (VpcFlowLogsConfig item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<VpcFlowLogsConfig> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (VpcFlowLogsConfig item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetVpcFlowLogsConfig</summary>
        public void GetVpcFlowLogsConfigRequestObject()
        {
            // Snippet: GetVpcFlowLogsConfig(GetVpcFlowLogsConfigRequest, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            GetVpcFlowLogsConfigRequest request = new GetVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]"),
            };
            // Make the request
            VpcFlowLogsConfig response = vpcFlowLogsServiceClient.GetVpcFlowLogsConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetVpcFlowLogsConfigAsync</summary>
        public async Task GetVpcFlowLogsConfigRequestObjectAsync()
        {
            // Snippet: GetVpcFlowLogsConfigAsync(GetVpcFlowLogsConfigRequest, CallSettings)
            // Additional: GetVpcFlowLogsConfigAsync(GetVpcFlowLogsConfigRequest, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetVpcFlowLogsConfigRequest request = new GetVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]"),
            };
            // Make the request
            VpcFlowLogsConfig response = await vpcFlowLogsServiceClient.GetVpcFlowLogsConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetVpcFlowLogsConfig</summary>
        public void GetVpcFlowLogsConfig()
        {
            // Snippet: GetVpcFlowLogsConfig(string, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcFlowLogsConfigs/[VPC_FLOW_LOGS_CONFIG]";
            // Make the request
            VpcFlowLogsConfig response = vpcFlowLogsServiceClient.GetVpcFlowLogsConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetVpcFlowLogsConfigAsync</summary>
        public async Task GetVpcFlowLogsConfigAsync()
        {
            // Snippet: GetVpcFlowLogsConfigAsync(string, CallSettings)
            // Additional: GetVpcFlowLogsConfigAsync(string, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcFlowLogsConfigs/[VPC_FLOW_LOGS_CONFIG]";
            // Make the request
            VpcFlowLogsConfig response = await vpcFlowLogsServiceClient.GetVpcFlowLogsConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetVpcFlowLogsConfig</summary>
        public void GetVpcFlowLogsConfigResourceNames()
        {
            // Snippet: GetVpcFlowLogsConfig(VpcFlowLogsConfigName, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            VpcFlowLogsConfigName name = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]");
            // Make the request
            VpcFlowLogsConfig response = vpcFlowLogsServiceClient.GetVpcFlowLogsConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetVpcFlowLogsConfigAsync</summary>
        public async Task GetVpcFlowLogsConfigResourceNamesAsync()
        {
            // Snippet: GetVpcFlowLogsConfigAsync(VpcFlowLogsConfigName, CallSettings)
            // Additional: GetVpcFlowLogsConfigAsync(VpcFlowLogsConfigName, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            VpcFlowLogsConfigName name = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]");
            // Make the request
            VpcFlowLogsConfig response = await vpcFlowLogsServiceClient.GetVpcFlowLogsConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateVpcFlowLogsConfig</summary>
        public void CreateVpcFlowLogsConfigRequestObject()
        {
            // Snippet: CreateVpcFlowLogsConfig(CreateVpcFlowLogsConfigRequest, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            CreateVpcFlowLogsConfigRequest request = new CreateVpcFlowLogsConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VpcFlowLogsConfigIdAsVpcFlowLogsConfigName = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]"),
                VpcFlowLogsConfig = new VpcFlowLogsConfig(),
            };
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = vpcFlowLogsServiceClient.CreateVpcFlowLogsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceCreateVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVpcFlowLogsConfigAsync</summary>
        public async Task CreateVpcFlowLogsConfigRequestObjectAsync()
        {
            // Snippet: CreateVpcFlowLogsConfigAsync(CreateVpcFlowLogsConfigRequest, CallSettings)
            // Additional: CreateVpcFlowLogsConfigAsync(CreateVpcFlowLogsConfigRequest, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateVpcFlowLogsConfigRequest request = new CreateVpcFlowLogsConfigRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                VpcFlowLogsConfigIdAsVpcFlowLogsConfigName = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]"),
                VpcFlowLogsConfig = new VpcFlowLogsConfig(),
            };
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = await vpcFlowLogsServiceClient.CreateVpcFlowLogsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceCreateVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVpcFlowLogsConfig</summary>
        public void CreateVpcFlowLogsConfig()
        {
            // Snippet: CreateVpcFlowLogsConfig(string, VpcFlowLogsConfig, string, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            VpcFlowLogsConfig vpcFlowLogsConfig = new VpcFlowLogsConfig();
            string vpcFlowLogsConfigId = "projects/[PROJECT]/locations/[LOCATION]/vpcFlowLogsConfigs/[VPC_FLOW_LOGS_CONFIG]";
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = vpcFlowLogsServiceClient.CreateVpcFlowLogsConfig(parent, vpcFlowLogsConfig, vpcFlowLogsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceCreateVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVpcFlowLogsConfigAsync</summary>
        public async Task CreateVpcFlowLogsConfigAsync()
        {
            // Snippet: CreateVpcFlowLogsConfigAsync(string, VpcFlowLogsConfig, string, CallSettings)
            // Additional: CreateVpcFlowLogsConfigAsync(string, VpcFlowLogsConfig, string, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            VpcFlowLogsConfig vpcFlowLogsConfig = new VpcFlowLogsConfig();
            string vpcFlowLogsConfigId = "projects/[PROJECT]/locations/[LOCATION]/vpcFlowLogsConfigs/[VPC_FLOW_LOGS_CONFIG]";
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = await vpcFlowLogsServiceClient.CreateVpcFlowLogsConfigAsync(parent, vpcFlowLogsConfig, vpcFlowLogsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceCreateVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVpcFlowLogsConfig</summary>
        public void CreateVpcFlowLogsConfigResourceNames()
        {
            // Snippet: CreateVpcFlowLogsConfig(LocationName, VpcFlowLogsConfig, VpcFlowLogsConfigName, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            VpcFlowLogsConfig vpcFlowLogsConfig = new VpcFlowLogsConfig();
            VpcFlowLogsConfigName vpcFlowLogsConfigId = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]");
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = vpcFlowLogsServiceClient.CreateVpcFlowLogsConfig(parent, vpcFlowLogsConfig, vpcFlowLogsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceCreateVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateVpcFlowLogsConfigAsync</summary>
        public async Task CreateVpcFlowLogsConfigResourceNamesAsync()
        {
            // Snippet: CreateVpcFlowLogsConfigAsync(LocationName, VpcFlowLogsConfig, VpcFlowLogsConfigName, CallSettings)
            // Additional: CreateVpcFlowLogsConfigAsync(LocationName, VpcFlowLogsConfig, VpcFlowLogsConfigName, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            VpcFlowLogsConfig vpcFlowLogsConfig = new VpcFlowLogsConfig();
            VpcFlowLogsConfigName vpcFlowLogsConfigId = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]");
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = await vpcFlowLogsServiceClient.CreateVpcFlowLogsConfigAsync(parent, vpcFlowLogsConfig, vpcFlowLogsConfigId);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceCreateVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVpcFlowLogsConfig</summary>
        public void UpdateVpcFlowLogsConfigRequestObject()
        {
            // Snippet: UpdateVpcFlowLogsConfig(UpdateVpcFlowLogsConfigRequest, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            UpdateVpcFlowLogsConfigRequest request = new UpdateVpcFlowLogsConfigRequest
            {
                UpdateMask = new FieldMask(),
                VpcFlowLogsConfig = new VpcFlowLogsConfig(),
            };
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = vpcFlowLogsServiceClient.UpdateVpcFlowLogsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceUpdateVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVpcFlowLogsConfigAsync</summary>
        public async Task UpdateVpcFlowLogsConfigRequestObjectAsync()
        {
            // Snippet: UpdateVpcFlowLogsConfigAsync(UpdateVpcFlowLogsConfigRequest, CallSettings)
            // Additional: UpdateVpcFlowLogsConfigAsync(UpdateVpcFlowLogsConfigRequest, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateVpcFlowLogsConfigRequest request = new UpdateVpcFlowLogsConfigRequest
            {
                UpdateMask = new FieldMask(),
                VpcFlowLogsConfig = new VpcFlowLogsConfig(),
            };
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = await vpcFlowLogsServiceClient.UpdateVpcFlowLogsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceUpdateVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVpcFlowLogsConfig</summary>
        public void UpdateVpcFlowLogsConfig()
        {
            // Snippet: UpdateVpcFlowLogsConfig(VpcFlowLogsConfig, FieldMask, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            VpcFlowLogsConfig vpcFlowLogsConfig = new VpcFlowLogsConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = vpcFlowLogsServiceClient.UpdateVpcFlowLogsConfig(vpcFlowLogsConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceUpdateVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateVpcFlowLogsConfigAsync</summary>
        public async Task UpdateVpcFlowLogsConfigAsync()
        {
            // Snippet: UpdateVpcFlowLogsConfigAsync(VpcFlowLogsConfig, FieldMask, CallSettings)
            // Additional: UpdateVpcFlowLogsConfigAsync(VpcFlowLogsConfig, FieldMask, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            VpcFlowLogsConfig vpcFlowLogsConfig = new VpcFlowLogsConfig();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<VpcFlowLogsConfig, OperationMetadata> response = await vpcFlowLogsServiceClient.UpdateVpcFlowLogsConfigAsync(vpcFlowLogsConfig, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<VpcFlowLogsConfig, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            VpcFlowLogsConfig result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<VpcFlowLogsConfig, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceUpdateVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                VpcFlowLogsConfig retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVpcFlowLogsConfig</summary>
        public void DeleteVpcFlowLogsConfigRequestObject()
        {
            // Snippet: DeleteVpcFlowLogsConfig(DeleteVpcFlowLogsConfigRequest, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            DeleteVpcFlowLogsConfigRequest request = new DeleteVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = vpcFlowLogsServiceClient.DeleteVpcFlowLogsConfig(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceDeleteVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVpcFlowLogsConfigAsync</summary>
        public async Task DeleteVpcFlowLogsConfigRequestObjectAsync()
        {
            // Snippet: DeleteVpcFlowLogsConfigAsync(DeleteVpcFlowLogsConfigRequest, CallSettings)
            // Additional: DeleteVpcFlowLogsConfigAsync(DeleteVpcFlowLogsConfigRequest, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteVpcFlowLogsConfigRequest request = new DeleteVpcFlowLogsConfigRequest
            {
                VpcFlowLogsConfigName = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]"),
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await vpcFlowLogsServiceClient.DeleteVpcFlowLogsConfigAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceDeleteVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVpcFlowLogsConfig</summary>
        public void DeleteVpcFlowLogsConfig()
        {
            // Snippet: DeleteVpcFlowLogsConfig(string, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcFlowLogsConfigs/[VPC_FLOW_LOGS_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = vpcFlowLogsServiceClient.DeleteVpcFlowLogsConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceDeleteVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVpcFlowLogsConfigAsync</summary>
        public async Task DeleteVpcFlowLogsConfigAsync()
        {
            // Snippet: DeleteVpcFlowLogsConfigAsync(string, CallSettings)
            // Additional: DeleteVpcFlowLogsConfigAsync(string, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/vpcFlowLogsConfigs/[VPC_FLOW_LOGS_CONFIG]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await vpcFlowLogsServiceClient.DeleteVpcFlowLogsConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceDeleteVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVpcFlowLogsConfig</summary>
        public void DeleteVpcFlowLogsConfigResourceNames()
        {
            // Snippet: DeleteVpcFlowLogsConfig(VpcFlowLogsConfigName, CallSettings)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = VpcFlowLogsServiceClient.Create();
            // Initialize request argument(s)
            VpcFlowLogsConfigName name = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = vpcFlowLogsServiceClient.DeleteVpcFlowLogsConfig(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = vpcFlowLogsServiceClient.PollOnceDeleteVpcFlowLogsConfig(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteVpcFlowLogsConfigAsync</summary>
        public async Task DeleteVpcFlowLogsConfigResourceNamesAsync()
        {
            // Snippet: DeleteVpcFlowLogsConfigAsync(VpcFlowLogsConfigName, CallSettings)
            // Additional: DeleteVpcFlowLogsConfigAsync(VpcFlowLogsConfigName, CancellationToken)
            // Create client
            VpcFlowLogsServiceClient vpcFlowLogsServiceClient = await VpcFlowLogsServiceClient.CreateAsync();
            // Initialize request argument(s)
            VpcFlowLogsConfigName name = VpcFlowLogsConfigName.FromProjectLocationVpcFlowLogsConfig("[PROJECT]", "[LOCATION]", "[VPC_FLOW_LOGS_CONFIG]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await vpcFlowLogsServiceClient.DeleteVpcFlowLogsConfigAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await vpcFlowLogsServiceClient.PollOnceDeleteVpcFlowLogsConfigAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
