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
    using Google.Cloud.Kms.V1;
    using Google.LongRunning;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedHsmManagementClientSnippets
    {
        /// <summary>Snippet for ListSingleTenantHsmInstances</summary>
        public void ListSingleTenantHsmInstancesRequestObject()
        {
            // Snippet: ListSingleTenantHsmInstances(ListSingleTenantHsmInstancesRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            ListSingleTenantHsmInstancesRequest request = new ListSingleTenantHsmInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> response = hsmManagementClient.ListSingleTenantHsmInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SingleTenantHsmInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSingleTenantHsmInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstancesAsync</summary>
        public async Task ListSingleTenantHsmInstancesRequestObjectAsync()
        {
            // Snippet: ListSingleTenantHsmInstancesAsync(ListSingleTenantHsmInstancesRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListSingleTenantHsmInstancesRequest request = new ListSingleTenantHsmInstancesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> response = hsmManagementClient.ListSingleTenantHsmInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SingleTenantHsmInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSingleTenantHsmInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstances</summary>
        public void ListSingleTenantHsmInstances()
        {
            // Snippet: ListSingleTenantHsmInstances(string, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> response = hsmManagementClient.ListSingleTenantHsmInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SingleTenantHsmInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSingleTenantHsmInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstancesAsync</summary>
        public async Task ListSingleTenantHsmInstancesAsync()
        {
            // Snippet: ListSingleTenantHsmInstancesAsync(string, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> response = hsmManagementClient.ListSingleTenantHsmInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SingleTenantHsmInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSingleTenantHsmInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstances</summary>
        public void ListSingleTenantHsmInstancesResourceNames()
        {
            // Snippet: ListSingleTenantHsmInstances(LocationName, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> response = hsmManagementClient.ListSingleTenantHsmInstances(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SingleTenantHsmInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSingleTenantHsmInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstance> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstancesAsync</summary>
        public async Task ListSingleTenantHsmInstancesResourceNamesAsync()
        {
            // Snippet: ListSingleTenantHsmInstancesAsync(LocationName, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSingleTenantHsmInstancesResponse, SingleTenantHsmInstance> response = hsmManagementClient.ListSingleTenantHsmInstancesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SingleTenantHsmInstance item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSingleTenantHsmInstancesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstance item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstance> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstance item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstance</summary>
        public void GetSingleTenantHsmInstanceRequestObject()
        {
            // Snippet: GetSingleTenantHsmInstance(GetSingleTenantHsmInstanceRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            GetSingleTenantHsmInstanceRequest request = new GetSingleTenantHsmInstanceRequest
            {
                SingleTenantHsmInstanceName = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]"),
            };
            // Make the request
            SingleTenantHsmInstance response = hsmManagementClient.GetSingleTenantHsmInstance(request);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceAsync</summary>
        public async Task GetSingleTenantHsmInstanceRequestObjectAsync()
        {
            // Snippet: GetSingleTenantHsmInstanceAsync(GetSingleTenantHsmInstanceRequest, CallSettings)
            // Additional: GetSingleTenantHsmInstanceAsync(GetSingleTenantHsmInstanceRequest, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetSingleTenantHsmInstanceRequest request = new GetSingleTenantHsmInstanceRequest
            {
                SingleTenantHsmInstanceName = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]"),
            };
            // Make the request
            SingleTenantHsmInstance response = await hsmManagementClient.GetSingleTenantHsmInstanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstance</summary>
        public void GetSingleTenantHsmInstance()
        {
            // Snippet: GetSingleTenantHsmInstance(string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]";
            // Make the request
            SingleTenantHsmInstance response = hsmManagementClient.GetSingleTenantHsmInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceAsync</summary>
        public async Task GetSingleTenantHsmInstanceAsync()
        {
            // Snippet: GetSingleTenantHsmInstanceAsync(string, CallSettings)
            // Additional: GetSingleTenantHsmInstanceAsync(string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]";
            // Make the request
            SingleTenantHsmInstance response = await hsmManagementClient.GetSingleTenantHsmInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstance</summary>
        public void GetSingleTenantHsmInstanceResourceNames()
        {
            // Snippet: GetSingleTenantHsmInstance(SingleTenantHsmInstanceName, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            SingleTenantHsmInstanceName name = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]");
            // Make the request
            SingleTenantHsmInstance response = hsmManagementClient.GetSingleTenantHsmInstance(name);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceAsync</summary>
        public async Task GetSingleTenantHsmInstanceResourceNamesAsync()
        {
            // Snippet: GetSingleTenantHsmInstanceAsync(SingleTenantHsmInstanceName, CallSettings)
            // Additional: GetSingleTenantHsmInstanceAsync(SingleTenantHsmInstanceName, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            SingleTenantHsmInstanceName name = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]");
            // Make the request
            SingleTenantHsmInstance response = await hsmManagementClient.GetSingleTenantHsmInstanceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstance</summary>
        public void CreateSingleTenantHsmInstanceRequestObject()
        {
            // Snippet: CreateSingleTenantHsmInstance(CreateSingleTenantHsmInstanceRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            CreateSingleTenantHsmInstanceRequest request = new CreateSingleTenantHsmInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SingleTenantHsmInstanceId = "",
                SingleTenantHsmInstance = new SingleTenantHsmInstance(),
            };
            // Make the request
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> response = hsmManagementClient.CreateSingleTenantHsmInstance(request);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SingleTenantHsmInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> retrievedResponse = hsmManagementClient.PollOnceCreateSingleTenantHsmInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceAsync</summary>
        public async Task CreateSingleTenantHsmInstanceRequestObjectAsync()
        {
            // Snippet: CreateSingleTenantHsmInstanceAsync(CreateSingleTenantHsmInstanceRequest, CallSettings)
            // Additional: CreateSingleTenantHsmInstanceAsync(CreateSingleTenantHsmInstanceRequest, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateSingleTenantHsmInstanceRequest request = new CreateSingleTenantHsmInstanceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SingleTenantHsmInstanceId = "",
                SingleTenantHsmInstance = new SingleTenantHsmInstance(),
            };
            // Make the request
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> response = await hsmManagementClient.CreateSingleTenantHsmInstanceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SingleTenantHsmInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> retrievedResponse = await hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstance</summary>
        public void CreateSingleTenantHsmInstance()
        {
            // Snippet: CreateSingleTenantHsmInstance(string, SingleTenantHsmInstance, string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SingleTenantHsmInstance singleTenantHsmInstance = new SingleTenantHsmInstance();
            string singleTenantHsmInstanceId = "";
            // Make the request
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> response = hsmManagementClient.CreateSingleTenantHsmInstance(parent, singleTenantHsmInstance, singleTenantHsmInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SingleTenantHsmInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> retrievedResponse = hsmManagementClient.PollOnceCreateSingleTenantHsmInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceAsync</summary>
        public async Task CreateSingleTenantHsmInstanceAsync()
        {
            // Snippet: CreateSingleTenantHsmInstanceAsync(string, SingleTenantHsmInstance, string, CallSettings)
            // Additional: CreateSingleTenantHsmInstanceAsync(string, SingleTenantHsmInstance, string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            SingleTenantHsmInstance singleTenantHsmInstance = new SingleTenantHsmInstance();
            string singleTenantHsmInstanceId = "";
            // Make the request
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> response = await hsmManagementClient.CreateSingleTenantHsmInstanceAsync(parent, singleTenantHsmInstance, singleTenantHsmInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SingleTenantHsmInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> retrievedResponse = await hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstance</summary>
        public void CreateSingleTenantHsmInstanceResourceNames()
        {
            // Snippet: CreateSingleTenantHsmInstance(LocationName, SingleTenantHsmInstance, string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SingleTenantHsmInstance singleTenantHsmInstance = new SingleTenantHsmInstance();
            string singleTenantHsmInstanceId = "";
            // Make the request
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> response = hsmManagementClient.CreateSingleTenantHsmInstance(parent, singleTenantHsmInstance, singleTenantHsmInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SingleTenantHsmInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> retrievedResponse = hsmManagementClient.PollOnceCreateSingleTenantHsmInstance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceAsync</summary>
        public async Task CreateSingleTenantHsmInstanceResourceNamesAsync()
        {
            // Snippet: CreateSingleTenantHsmInstanceAsync(LocationName, SingleTenantHsmInstance, string, CallSettings)
            // Additional: CreateSingleTenantHsmInstanceAsync(LocationName, SingleTenantHsmInstance, string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            SingleTenantHsmInstance singleTenantHsmInstance = new SingleTenantHsmInstance();
            string singleTenantHsmInstanceId = "";
            // Make the request
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> response = await hsmManagementClient.CreateSingleTenantHsmInstanceAsync(parent, singleTenantHsmInstance, singleTenantHsmInstanceId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SingleTenantHsmInstance result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstance, CreateSingleTenantHsmInstanceMetadata> retrievedResponse = await hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstance retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceProposal</summary>
        public void CreateSingleTenantHsmInstanceProposalRequestObject()
        {
            // Snippet: CreateSingleTenantHsmInstanceProposal(CreateSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            CreateSingleTenantHsmInstanceProposalRequest request = new CreateSingleTenantHsmInstanceProposalRequest
            {
                ParentAsSingleTenantHsmInstanceName = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]"),
                SingleTenantHsmInstanceProposalId = "",
                SingleTenantHsmInstanceProposal = new SingleTenantHsmInstanceProposal(),
            };
            // Make the request
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> response = hsmManagementClient.CreateSingleTenantHsmInstanceProposal(request);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SingleTenantHsmInstanceProposal result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> retrievedResponse = hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceProposal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstanceProposal retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceProposalAsync</summary>
        public async Task CreateSingleTenantHsmInstanceProposalRequestObjectAsync()
        {
            // Snippet: CreateSingleTenantHsmInstanceProposalAsync(CreateSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Additional: CreateSingleTenantHsmInstanceProposalAsync(CreateSingleTenantHsmInstanceProposalRequest, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            CreateSingleTenantHsmInstanceProposalRequest request = new CreateSingleTenantHsmInstanceProposalRequest
            {
                ParentAsSingleTenantHsmInstanceName = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]"),
                SingleTenantHsmInstanceProposalId = "",
                SingleTenantHsmInstanceProposal = new SingleTenantHsmInstanceProposal(),
            };
            // Make the request
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> response = await hsmManagementClient.CreateSingleTenantHsmInstanceProposalAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SingleTenantHsmInstanceProposal result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> retrievedResponse = await hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceProposalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstanceProposal retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceProposal</summary>
        public void CreateSingleTenantHsmInstanceProposal()
        {
            // Snippet: CreateSingleTenantHsmInstanceProposal(string, SingleTenantHsmInstanceProposal, string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]";
            SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal = new SingleTenantHsmInstanceProposal();
            string singleTenantHsmInstanceProposalId = "";
            // Make the request
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> response = hsmManagementClient.CreateSingleTenantHsmInstanceProposal(parent, singleTenantHsmInstanceProposal, singleTenantHsmInstanceProposalId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SingleTenantHsmInstanceProposal result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> retrievedResponse = hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceProposal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstanceProposal retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceProposalAsync</summary>
        public async Task CreateSingleTenantHsmInstanceProposalAsync()
        {
            // Snippet: CreateSingleTenantHsmInstanceProposalAsync(string, SingleTenantHsmInstanceProposal, string, CallSettings)
            // Additional: CreateSingleTenantHsmInstanceProposalAsync(string, SingleTenantHsmInstanceProposal, string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]";
            SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal = new SingleTenantHsmInstanceProposal();
            string singleTenantHsmInstanceProposalId = "";
            // Make the request
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> response = await hsmManagementClient.CreateSingleTenantHsmInstanceProposalAsync(parent, singleTenantHsmInstanceProposal, singleTenantHsmInstanceProposalId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SingleTenantHsmInstanceProposal result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> retrievedResponse = await hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceProposalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstanceProposal retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceProposal</summary>
        public void CreateSingleTenantHsmInstanceProposalResourceNames()
        {
            // Snippet: CreateSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceName, SingleTenantHsmInstanceProposal, string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            SingleTenantHsmInstanceName parent = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]");
            SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal = new SingleTenantHsmInstanceProposal();
            string singleTenantHsmInstanceProposalId = "";
            // Make the request
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> response = hsmManagementClient.CreateSingleTenantHsmInstanceProposal(parent, singleTenantHsmInstanceProposal, singleTenantHsmInstanceProposalId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SingleTenantHsmInstanceProposal result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> retrievedResponse = hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceProposal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstanceProposal retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSingleTenantHsmInstanceProposalAsync</summary>
        public async Task CreateSingleTenantHsmInstanceProposalResourceNamesAsync()
        {
            // Snippet: CreateSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceName, SingleTenantHsmInstanceProposal, string, CallSettings)
            // Additional: CreateSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceName, SingleTenantHsmInstanceProposal, string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            SingleTenantHsmInstanceName parent = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]");
            SingleTenantHsmInstanceProposal singleTenantHsmInstanceProposal = new SingleTenantHsmInstanceProposal();
            string singleTenantHsmInstanceProposalId = "";
            // Make the request
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> response = await hsmManagementClient.CreateSingleTenantHsmInstanceProposalAsync(parent, singleTenantHsmInstanceProposal, singleTenantHsmInstanceProposalId);

            // Poll until the returned long-running operation is complete
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SingleTenantHsmInstanceProposal result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SingleTenantHsmInstanceProposal, CreateSingleTenantHsmInstanceProposalMetadata> retrievedResponse = await hsmManagementClient.PollOnceCreateSingleTenantHsmInstanceProposalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SingleTenantHsmInstanceProposal retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ApproveSingleTenantHsmInstanceProposal</summary>
        public void ApproveSingleTenantHsmInstanceProposalRequestObject()
        {
            // Snippet: ApproveSingleTenantHsmInstanceProposal(ApproveSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            ApproveSingleTenantHsmInstanceProposalRequest request = new ApproveSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
                QuorumReply = new ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply(),
            };
            // Make the request
            ApproveSingleTenantHsmInstanceProposalResponse response = hsmManagementClient.ApproveSingleTenantHsmInstanceProposal(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveSingleTenantHsmInstanceProposalAsync</summary>
        public async Task ApproveSingleTenantHsmInstanceProposalRequestObjectAsync()
        {
            // Snippet: ApproveSingleTenantHsmInstanceProposalAsync(ApproveSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Additional: ApproveSingleTenantHsmInstanceProposalAsync(ApproveSingleTenantHsmInstanceProposalRequest, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            ApproveSingleTenantHsmInstanceProposalRequest request = new ApproveSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
                QuorumReply = new ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply(),
            };
            // Make the request
            ApproveSingleTenantHsmInstanceProposalResponse response = await hsmManagementClient.ApproveSingleTenantHsmInstanceProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveSingleTenantHsmInstanceProposal</summary>
        public void ApproveSingleTenantHsmInstanceProposal()
        {
            // Snippet: ApproveSingleTenantHsmInstanceProposal(string, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply = new ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply();
            // Make the request
            ApproveSingleTenantHsmInstanceProposalResponse response = hsmManagementClient.ApproveSingleTenantHsmInstanceProposal(name, quorumReply);
            // End snippet
        }

        /// <summary>Snippet for ApproveSingleTenantHsmInstanceProposalAsync</summary>
        public async Task ApproveSingleTenantHsmInstanceProposalAsync()
        {
            // Snippet: ApproveSingleTenantHsmInstanceProposalAsync(string, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply, CallSettings)
            // Additional: ApproveSingleTenantHsmInstanceProposalAsync(string, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply = new ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply();
            // Make the request
            ApproveSingleTenantHsmInstanceProposalResponse response = await hsmManagementClient.ApproveSingleTenantHsmInstanceProposalAsync(name, quorumReply);
            // End snippet
        }

        /// <summary>Snippet for ApproveSingleTenantHsmInstanceProposal</summary>
        public void ApproveSingleTenantHsmInstanceProposalResourceNames()
        {
            // Snippet: ApproveSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply = new ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply();
            // Make the request
            ApproveSingleTenantHsmInstanceProposalResponse response = hsmManagementClient.ApproveSingleTenantHsmInstanceProposal(name, quorumReply);
            // End snippet
        }

        /// <summary>Snippet for ApproveSingleTenantHsmInstanceProposalAsync</summary>
        public async Task ApproveSingleTenantHsmInstanceProposalResourceNamesAsync()
        {
            // Snippet: ApproveSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply, CallSettings)
            // Additional: ApproveSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply quorumReply = new ApproveSingleTenantHsmInstanceProposalRequest.Types.QuorumReply();
            // Make the request
            ApproveSingleTenantHsmInstanceProposalResponse response = await hsmManagementClient.ApproveSingleTenantHsmInstanceProposalAsync(name, quorumReply);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSingleTenantHsmInstanceProposal</summary>
        public void ExecuteSingleTenantHsmInstanceProposalRequestObject()
        {
            // Snippet: ExecuteSingleTenantHsmInstanceProposal(ExecuteSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            ExecuteSingleTenantHsmInstanceProposalRequest request = new ExecuteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
            };
            // Make the request
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> response = hsmManagementClient.ExecuteSingleTenantHsmInstanceProposal(request);

            // Poll until the returned long-running operation is complete
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExecuteSingleTenantHsmInstanceProposalResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> retrievedResponse = hsmManagementClient.PollOnceExecuteSingleTenantHsmInstanceProposal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecuteSingleTenantHsmInstanceProposalResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecuteSingleTenantHsmInstanceProposalAsync</summary>
        public async Task ExecuteSingleTenantHsmInstanceProposalRequestObjectAsync()
        {
            // Snippet: ExecuteSingleTenantHsmInstanceProposalAsync(ExecuteSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Additional: ExecuteSingleTenantHsmInstanceProposalAsync(ExecuteSingleTenantHsmInstanceProposalRequest, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteSingleTenantHsmInstanceProposalRequest request = new ExecuteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
            };
            // Make the request
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> response = await hsmManagementClient.ExecuteSingleTenantHsmInstanceProposalAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExecuteSingleTenantHsmInstanceProposalResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> retrievedResponse = await hsmManagementClient.PollOnceExecuteSingleTenantHsmInstanceProposalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecuteSingleTenantHsmInstanceProposalResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecuteSingleTenantHsmInstanceProposal</summary>
        public void ExecuteSingleTenantHsmInstanceProposal()
        {
            // Snippet: ExecuteSingleTenantHsmInstanceProposal(string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            // Make the request
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> response = hsmManagementClient.ExecuteSingleTenantHsmInstanceProposal(name);

            // Poll until the returned long-running operation is complete
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExecuteSingleTenantHsmInstanceProposalResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> retrievedResponse = hsmManagementClient.PollOnceExecuteSingleTenantHsmInstanceProposal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecuteSingleTenantHsmInstanceProposalResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecuteSingleTenantHsmInstanceProposalAsync</summary>
        public async Task ExecuteSingleTenantHsmInstanceProposalAsync()
        {
            // Snippet: ExecuteSingleTenantHsmInstanceProposalAsync(string, CallSettings)
            // Additional: ExecuteSingleTenantHsmInstanceProposalAsync(string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            // Make the request
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> response = await hsmManagementClient.ExecuteSingleTenantHsmInstanceProposalAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExecuteSingleTenantHsmInstanceProposalResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> retrievedResponse = await hsmManagementClient.PollOnceExecuteSingleTenantHsmInstanceProposalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecuteSingleTenantHsmInstanceProposalResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecuteSingleTenantHsmInstanceProposal</summary>
        public void ExecuteSingleTenantHsmInstanceProposalResourceNames()
        {
            // Snippet: ExecuteSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            // Make the request
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> response = hsmManagementClient.ExecuteSingleTenantHsmInstanceProposal(name);

            // Poll until the returned long-running operation is complete
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExecuteSingleTenantHsmInstanceProposalResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> retrievedResponse = hsmManagementClient.PollOnceExecuteSingleTenantHsmInstanceProposal(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecuteSingleTenantHsmInstanceProposalResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExecuteSingleTenantHsmInstanceProposalAsync</summary>
        public async Task ExecuteSingleTenantHsmInstanceProposalResourceNamesAsync()
        {
            // Snippet: ExecuteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, CallSettings)
            // Additional: ExecuteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            // Make the request
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> response = await hsmManagementClient.ExecuteSingleTenantHsmInstanceProposalAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExecuteSingleTenantHsmInstanceProposalResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExecuteSingleTenantHsmInstanceProposalResponse, ExecuteSingleTenantHsmInstanceProposalMetadata> retrievedResponse = await hsmManagementClient.PollOnceExecuteSingleTenantHsmInstanceProposalAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExecuteSingleTenantHsmInstanceProposalResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceProposal</summary>
        public void GetSingleTenantHsmInstanceProposalRequestObject()
        {
            // Snippet: GetSingleTenantHsmInstanceProposal(GetSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            GetSingleTenantHsmInstanceProposalRequest request = new GetSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
            };
            // Make the request
            SingleTenantHsmInstanceProposal response = hsmManagementClient.GetSingleTenantHsmInstanceProposal(request);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceProposalAsync</summary>
        public async Task GetSingleTenantHsmInstanceProposalRequestObjectAsync()
        {
            // Snippet: GetSingleTenantHsmInstanceProposalAsync(GetSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Additional: GetSingleTenantHsmInstanceProposalAsync(GetSingleTenantHsmInstanceProposalRequest, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            GetSingleTenantHsmInstanceProposalRequest request = new GetSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
            };
            // Make the request
            SingleTenantHsmInstanceProposal response = await hsmManagementClient.GetSingleTenantHsmInstanceProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceProposal</summary>
        public void GetSingleTenantHsmInstanceProposal()
        {
            // Snippet: GetSingleTenantHsmInstanceProposal(string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            // Make the request
            SingleTenantHsmInstanceProposal response = hsmManagementClient.GetSingleTenantHsmInstanceProposal(name);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceProposalAsync</summary>
        public async Task GetSingleTenantHsmInstanceProposalAsync()
        {
            // Snippet: GetSingleTenantHsmInstanceProposalAsync(string, CallSettings)
            // Additional: GetSingleTenantHsmInstanceProposalAsync(string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            // Make the request
            SingleTenantHsmInstanceProposal response = await hsmManagementClient.GetSingleTenantHsmInstanceProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceProposal</summary>
        public void GetSingleTenantHsmInstanceProposalResourceNames()
        {
            // Snippet: GetSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            // Make the request
            SingleTenantHsmInstanceProposal response = hsmManagementClient.GetSingleTenantHsmInstanceProposal(name);
            // End snippet
        }

        /// <summary>Snippet for GetSingleTenantHsmInstanceProposalAsync</summary>
        public async Task GetSingleTenantHsmInstanceProposalResourceNamesAsync()
        {
            // Snippet: GetSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, CallSettings)
            // Additional: GetSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            // Make the request
            SingleTenantHsmInstanceProposal response = await hsmManagementClient.GetSingleTenantHsmInstanceProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstanceProposals</summary>
        public void ListSingleTenantHsmInstanceProposalsRequestObject()
        {
            // Snippet: ListSingleTenantHsmInstanceProposals(ListSingleTenantHsmInstanceProposalsRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            ListSingleTenantHsmInstanceProposalsRequest request = new ListSingleTenantHsmInstanceProposalsRequest
            {
                ParentAsSingleTenantHsmInstanceName = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> response = hsmManagementClient.ListSingleTenantHsmInstanceProposals(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SingleTenantHsmInstanceProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSingleTenantHsmInstanceProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstanceProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstanceProposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstanceProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstanceProposalsAsync</summary>
        public async Task ListSingleTenantHsmInstanceProposalsRequestObjectAsync()
        {
            // Snippet: ListSingleTenantHsmInstanceProposalsAsync(ListSingleTenantHsmInstanceProposalsRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            ListSingleTenantHsmInstanceProposalsRequest request = new ListSingleTenantHsmInstanceProposalsRequest
            {
                ParentAsSingleTenantHsmInstanceName = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> response = hsmManagementClient.ListSingleTenantHsmInstanceProposalsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SingleTenantHsmInstanceProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSingleTenantHsmInstanceProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstanceProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstanceProposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstanceProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstanceProposals</summary>
        public void ListSingleTenantHsmInstanceProposals()
        {
            // Snippet: ListSingleTenantHsmInstanceProposals(string, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]";
            // Make the request
            PagedEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> response = hsmManagementClient.ListSingleTenantHsmInstanceProposals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SingleTenantHsmInstanceProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSingleTenantHsmInstanceProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstanceProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstanceProposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstanceProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstanceProposalsAsync</summary>
        public async Task ListSingleTenantHsmInstanceProposalsAsync()
        {
            // Snippet: ListSingleTenantHsmInstanceProposalsAsync(string, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> response = hsmManagementClient.ListSingleTenantHsmInstanceProposalsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SingleTenantHsmInstanceProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSingleTenantHsmInstanceProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstanceProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstanceProposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstanceProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstanceProposals</summary>
        public void ListSingleTenantHsmInstanceProposalsResourceNames()
        {
            // Snippet: ListSingleTenantHsmInstanceProposals(SingleTenantHsmInstanceName, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            SingleTenantHsmInstanceName parent = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]");
            // Make the request
            PagedEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> response = hsmManagementClient.ListSingleTenantHsmInstanceProposals(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SingleTenantHsmInstanceProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSingleTenantHsmInstanceProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstanceProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstanceProposal> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstanceProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSingleTenantHsmInstanceProposalsAsync</summary>
        public async Task ListSingleTenantHsmInstanceProposalsResourceNamesAsync()
        {
            // Snippet: ListSingleTenantHsmInstanceProposalsAsync(SingleTenantHsmInstanceName, string, int?, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            SingleTenantHsmInstanceName parent = SingleTenantHsmInstanceName.FromProjectLocationSingleTenantHsmInstance("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListSingleTenantHsmInstanceProposalsResponse, SingleTenantHsmInstanceProposal> response = hsmManagementClient.ListSingleTenantHsmInstanceProposalsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (SingleTenantHsmInstanceProposal item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListSingleTenantHsmInstanceProposalsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SingleTenantHsmInstanceProposal item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SingleTenantHsmInstanceProposal> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SingleTenantHsmInstanceProposal item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSingleTenantHsmInstanceProposal</summary>
        public void DeleteSingleTenantHsmInstanceProposalRequestObject()
        {
            // Snippet: DeleteSingleTenantHsmInstanceProposal(DeleteSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            DeleteSingleTenantHsmInstanceProposalRequest request = new DeleteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
            };
            // Make the request
            hsmManagementClient.DeleteSingleTenantHsmInstanceProposal(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSingleTenantHsmInstanceProposalAsync</summary>
        public async Task DeleteSingleTenantHsmInstanceProposalRequestObjectAsync()
        {
            // Snippet: DeleteSingleTenantHsmInstanceProposalAsync(DeleteSingleTenantHsmInstanceProposalRequest, CallSettings)
            // Additional: DeleteSingleTenantHsmInstanceProposalAsync(DeleteSingleTenantHsmInstanceProposalRequest, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSingleTenantHsmInstanceProposalRequest request = new DeleteSingleTenantHsmInstanceProposalRequest
            {
                SingleTenantHsmInstanceProposalName = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]"),
            };
            // Make the request
            await hsmManagementClient.DeleteSingleTenantHsmInstanceProposalAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSingleTenantHsmInstanceProposal</summary>
        public void DeleteSingleTenantHsmInstanceProposal()
        {
            // Snippet: DeleteSingleTenantHsmInstanceProposal(string, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            // Make the request
            hsmManagementClient.DeleteSingleTenantHsmInstanceProposal(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSingleTenantHsmInstanceProposalAsync</summary>
        public async Task DeleteSingleTenantHsmInstanceProposalAsync()
        {
            // Snippet: DeleteSingleTenantHsmInstanceProposalAsync(string, CallSettings)
            // Additional: DeleteSingleTenantHsmInstanceProposalAsync(string, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/singleTenantHsmInstances/[SINGLE_TENANT_HSM_INSTANCE]/proposals/[PROPOSAL]";
            // Make the request
            await hsmManagementClient.DeleteSingleTenantHsmInstanceProposalAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSingleTenantHsmInstanceProposal</summary>
        public void DeleteSingleTenantHsmInstanceProposalResourceNames()
        {
            // Snippet: DeleteSingleTenantHsmInstanceProposal(SingleTenantHsmInstanceProposalName, CallSettings)
            // Create client
            HsmManagementClient hsmManagementClient = HsmManagementClient.Create();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            // Make the request
            hsmManagementClient.DeleteSingleTenantHsmInstanceProposal(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSingleTenantHsmInstanceProposalAsync</summary>
        public async Task DeleteSingleTenantHsmInstanceProposalResourceNamesAsync()
        {
            // Snippet: DeleteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, CallSettings)
            // Additional: DeleteSingleTenantHsmInstanceProposalAsync(SingleTenantHsmInstanceProposalName, CancellationToken)
            // Create client
            HsmManagementClient hsmManagementClient = await HsmManagementClient.CreateAsync();
            // Initialize request argument(s)
            SingleTenantHsmInstanceProposalName name = SingleTenantHsmInstanceProposalName.FromProjectLocationSingleTenantHsmInstanceProposal("[PROJECT]", "[LOCATION]", "[SINGLE_TENANT_HSM_INSTANCE]", "[PROPOSAL]");
            // Make the request
            await hsmManagementClient.DeleteSingleTenantHsmInstanceProposalAsync(name);
            // End snippet
        }
    }
}
