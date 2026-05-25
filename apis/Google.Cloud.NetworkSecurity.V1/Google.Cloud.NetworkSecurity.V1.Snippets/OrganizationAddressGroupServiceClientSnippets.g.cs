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
    using Google.Cloud.NetworkSecurity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedOrganizationAddressGroupServiceClientSnippets
    {
        /// <summary>Snippet for ListAddressGroups</summary>
        public void ListAddressGroupsRequestObject()
        {
            // Snippet: ListAddressGroups(ListAddressGroupsRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            ListAddressGroupsRequest request = new ListAddressGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ListAddressGroupsResponse, AddressGroup> response = organizationAddressGroupServiceClient.ListAddressGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AddressGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddressGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AddressGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AddressGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AddressGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupsAsync</summary>
        public async Task ListAddressGroupsRequestObjectAsync()
        {
            // Snippet: ListAddressGroupsAsync(ListAddressGroupsRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAddressGroupsRequest request = new ListAddressGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListAddressGroupsResponse, AddressGroup> response = organizationAddressGroupServiceClient.ListAddressGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AddressGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddressGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AddressGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AddressGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AddressGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroups</summary>
        public void ListAddressGroups()
        {
            // Snippet: ListAddressGroups(string, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAddressGroupsResponse, AddressGroup> response = organizationAddressGroupServiceClient.ListAddressGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AddressGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddressGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AddressGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AddressGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AddressGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupsAsync</summary>
        public async Task ListAddressGroupsAsync()
        {
            // Snippet: ListAddressGroupsAsync(string, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAddressGroupsResponse, AddressGroup> response = organizationAddressGroupServiceClient.ListAddressGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AddressGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddressGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AddressGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AddressGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AddressGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroups</summary>
        public void ListAddressGroupsResourceNames()
        {
            // Snippet: ListAddressGroups(LocationName, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAddressGroupsResponse, AddressGroup> response = organizationAddressGroupServiceClient.ListAddressGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AddressGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddressGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AddressGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AddressGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AddressGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupsAsync</summary>
        public async Task ListAddressGroupsResourceNamesAsync()
        {
            // Snippet: ListAddressGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAddressGroupsResponse, AddressGroup> response = organizationAddressGroupServiceClient.ListAddressGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AddressGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddressGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AddressGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AddressGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AddressGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAddressGroup</summary>
        public void GetAddressGroupRequestObject()
        {
            // Snippet: GetAddressGroup(GetAddressGroupRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            GetAddressGroupRequest request = new GetAddressGroupRequest
            {
                AddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
            };
            // Make the request
            AddressGroup response = organizationAddressGroupServiceClient.GetAddressGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetAddressGroupAsync</summary>
        public async Task GetAddressGroupRequestObjectAsync()
        {
            // Snippet: GetAddressGroupAsync(GetAddressGroupRequest, CallSettings)
            // Additional: GetAddressGroupAsync(GetAddressGroupRequest, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAddressGroupRequest request = new GetAddressGroupRequest
            {
                AddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
            };
            // Make the request
            AddressGroup response = await organizationAddressGroupServiceClient.GetAddressGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAddressGroup</summary>
        public void GetAddressGroup()
        {
            // Snippet: GetAddressGroup(string, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            AddressGroup response = organizationAddressGroupServiceClient.GetAddressGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetAddressGroupAsync</summary>
        public async Task GetAddressGroupAsync()
        {
            // Snippet: GetAddressGroupAsync(string, CallSettings)
            // Additional: GetAddressGroupAsync(string, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            AddressGroup response = await organizationAddressGroupServiceClient.GetAddressGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAddressGroup</summary>
        public void GetAddressGroupResourceNames()
        {
            // Snippet: GetAddressGroup(AddressGroupName, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddressGroupName name = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            AddressGroup response = organizationAddressGroupServiceClient.GetAddressGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetAddressGroupAsync</summary>
        public async Task GetAddressGroupResourceNamesAsync()
        {
            // Snippet: GetAddressGroupAsync(AddressGroupName, CallSettings)
            // Additional: GetAddressGroupAsync(AddressGroupName, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddressGroupName name = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            AddressGroup response = await organizationAddressGroupServiceClient.GetAddressGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroup</summary>
        public void CreateAddressGroupRequestObject()
        {
            // Snippet: CreateAddressGroup(CreateAddressGroupRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            CreateAddressGroupRequest request = new CreateAddressGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AddressGroupId = "",
                AddressGroup = new AddressGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.CreateAddressGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceCreateAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroupAsync</summary>
        public async Task CreateAddressGroupRequestObjectAsync()
        {
            // Snippet: CreateAddressGroupAsync(CreateAddressGroupRequest, CallSettings)
            // Additional: CreateAddressGroupAsync(CreateAddressGroupRequest, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAddressGroupRequest request = new CreateAddressGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AddressGroupId = "",
                AddressGroup = new AddressGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.CreateAddressGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceCreateAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroup</summary>
        public void CreateAddressGroup()
        {
            // Snippet: CreateAddressGroup(string, AddressGroup, string, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AddressGroup addressGroup = new AddressGroup();
            string addressGroupId = "";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.CreateAddressGroup(parent, addressGroup, addressGroupId);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceCreateAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroupAsync</summary>
        public async Task CreateAddressGroupAsync()
        {
            // Snippet: CreateAddressGroupAsync(string, AddressGroup, string, CallSettings)
            // Additional: CreateAddressGroupAsync(string, AddressGroup, string, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AddressGroup addressGroup = new AddressGroup();
            string addressGroupId = "";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.CreateAddressGroupAsync(parent, addressGroup, addressGroupId);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceCreateAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroup</summary>
        public void CreateAddressGroupResourceNames1()
        {
            // Snippet: CreateAddressGroup(LocationName, AddressGroup, string, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AddressGroup addressGroup = new AddressGroup();
            string addressGroupId = "";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.CreateAddressGroup(parent, addressGroup, addressGroupId);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceCreateAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroupAsync</summary>
        public async Task CreateAddressGroupResourceNames1Async()
        {
            // Snippet: CreateAddressGroupAsync(LocationName, AddressGroup, string, CallSettings)
            // Additional: CreateAddressGroupAsync(LocationName, AddressGroup, string, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AddressGroup addressGroup = new AddressGroup();
            string addressGroupId = "";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.CreateAddressGroupAsync(parent, addressGroup, addressGroupId);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceCreateAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroup</summary>
        public void CreateAddressGroupResourceNames2()
        {
            // Snippet: CreateAddressGroup(OrganizationLocationName, AddressGroup, string, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            AddressGroup addressGroup = new AddressGroup();
            string addressGroupId = "";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.CreateAddressGroup(parent, addressGroup, addressGroupId);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceCreateAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAddressGroupAsync</summary>
        public async Task CreateAddressGroupResourceNames2Async()
        {
            // Snippet: CreateAddressGroupAsync(OrganizationLocationName, AddressGroup, string, CallSettings)
            // Additional: CreateAddressGroupAsync(OrganizationLocationName, AddressGroup, string, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            AddressGroup addressGroup = new AddressGroup();
            string addressGroupId = "";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.CreateAddressGroupAsync(parent, addressGroup, addressGroupId);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceCreateAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAddressGroup</summary>
        public void UpdateAddressGroupRequestObject()
        {
            // Snippet: UpdateAddressGroup(UpdateAddressGroupRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            UpdateAddressGroupRequest request = new UpdateAddressGroupRequest
            {
                UpdateMask = new FieldMask(),
                AddressGroup = new AddressGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.UpdateAddressGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceUpdateAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAddressGroupAsync</summary>
        public async Task UpdateAddressGroupRequestObjectAsync()
        {
            // Snippet: UpdateAddressGroupAsync(UpdateAddressGroupRequest, CallSettings)
            // Additional: UpdateAddressGroupAsync(UpdateAddressGroupRequest, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAddressGroupRequest request = new UpdateAddressGroupRequest
            {
                UpdateMask = new FieldMask(),
                AddressGroup = new AddressGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.UpdateAddressGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceUpdateAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAddressGroup</summary>
        public void UpdateAddressGroup()
        {
            // Snippet: UpdateAddressGroup(AddressGroup, FieldMask, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddressGroup addressGroup = new AddressGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.UpdateAddressGroup(addressGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceUpdateAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAddressGroupAsync</summary>
        public async Task UpdateAddressGroupAsync()
        {
            // Snippet: UpdateAddressGroupAsync(AddressGroup, FieldMask, CallSettings)
            // Additional: UpdateAddressGroupAsync(AddressGroup, FieldMask, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddressGroup addressGroup = new AddressGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.UpdateAddressGroupAsync(addressGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceUpdateAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAddressGroupItems</summary>
        public void AddAddressGroupItemsRequestObject()
        {
            // Snippet: AddAddressGroupItems(AddAddressGroupItemsRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddAddressGroupItemsRequest request = new AddAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                Items = { "", },
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.AddAddressGroupItems(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceAddAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAddressGroupItemsAsync</summary>
        public async Task AddAddressGroupItemsRequestObjectAsync()
        {
            // Snippet: AddAddressGroupItemsAsync(AddAddressGroupItemsRequest, CallSettings)
            // Additional: AddAddressGroupItemsAsync(AddAddressGroupItemsRequest, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddAddressGroupItemsRequest request = new AddAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                Items = { "", },
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.AddAddressGroupItemsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceAddAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAddressGroupItems</summary>
        public void AddAddressGroupItems()
        {
            // Snippet: AddAddressGroupItems(string, IEnumerable<string>, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.AddAddressGroupItems(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceAddAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAddressGroupItemsAsync</summary>
        public async Task AddAddressGroupItemsAsync()
        {
            // Snippet: AddAddressGroupItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: AddAddressGroupItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.AddAddressGroupItemsAsync(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceAddAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAddressGroupItems</summary>
        public void AddAddressGroupItemsResourceNames()
        {
            // Snippet: AddAddressGroupItems(AddressGroupName, IEnumerable<string>, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.AddAddressGroupItems(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceAddAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddAddressGroupItemsAsync</summary>
        public async Task AddAddressGroupItemsResourceNamesAsync()
        {
            // Snippet: AddAddressGroupItemsAsync(AddressGroupName, IEnumerable<string>, CallSettings)
            // Additional: AddAddressGroupItemsAsync(AddressGroupName, IEnumerable<string>, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.AddAddressGroupItemsAsync(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceAddAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAddressGroupItems</summary>
        public void RemoveAddressGroupItemsRequestObject()
        {
            // Snippet: RemoveAddressGroupItems(RemoveAddressGroupItemsRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            RemoveAddressGroupItemsRequest request = new RemoveAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                Items = { "", },
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.RemoveAddressGroupItems(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceRemoveAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAddressGroupItemsAsync</summary>
        public async Task RemoveAddressGroupItemsRequestObjectAsync()
        {
            // Snippet: RemoveAddressGroupItemsAsync(RemoveAddressGroupItemsRequest, CallSettings)
            // Additional: RemoveAddressGroupItemsAsync(RemoveAddressGroupItemsRequest, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveAddressGroupItemsRequest request = new RemoveAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                Items = { "", },
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.RemoveAddressGroupItemsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceRemoveAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAddressGroupItems</summary>
        public void RemoveAddressGroupItems()
        {
            // Snippet: RemoveAddressGroupItems(string, IEnumerable<string>, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.RemoveAddressGroupItems(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceRemoveAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAddressGroupItemsAsync</summary>
        public async Task RemoveAddressGroupItemsAsync()
        {
            // Snippet: RemoveAddressGroupItemsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: RemoveAddressGroupItemsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.RemoveAddressGroupItemsAsync(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceRemoveAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAddressGroupItems</summary>
        public void RemoveAddressGroupItemsResourceNames()
        {
            // Snippet: RemoveAddressGroupItems(AddressGroupName, IEnumerable<string>, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.RemoveAddressGroupItems(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceRemoveAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveAddressGroupItemsAsync</summary>
        public async Task RemoveAddressGroupItemsResourceNamesAsync()
        {
            // Snippet: RemoveAddressGroupItemsAsync(AddressGroupName, IEnumerable<string>, CallSettings)
            // Additional: RemoveAddressGroupItemsAsync(AddressGroupName, IEnumerable<string>, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            IEnumerable<string> items = new string[] { "", };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.RemoveAddressGroupItemsAsync(addressGroup, items);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceRemoveAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneAddressGroupItems</summary>
        public void CloneAddressGroupItemsRequestObject()
        {
            // Snippet: CloneAddressGroupItems(CloneAddressGroupItemsRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            CloneAddressGroupItemsRequest request = new CloneAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                SourceAddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.CloneAddressGroupItems(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceCloneAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneAddressGroupItemsAsync</summary>
        public async Task CloneAddressGroupItemsRequestObjectAsync()
        {
            // Snippet: CloneAddressGroupItemsAsync(CloneAddressGroupItemsRequest, CallSettings)
            // Additional: CloneAddressGroupItemsAsync(CloneAddressGroupItemsRequest, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            CloneAddressGroupItemsRequest request = new CloneAddressGroupItemsRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                SourceAddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.CloneAddressGroupItemsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceCloneAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneAddressGroupItems</summary>
        public void CloneAddressGroupItems()
        {
            // Snippet: CloneAddressGroupItems(string, string, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            string sourceAddressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.CloneAddressGroupItems(addressGroup, sourceAddressGroup);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceCloneAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneAddressGroupItemsAsync</summary>
        public async Task CloneAddressGroupItemsAsync()
        {
            // Snippet: CloneAddressGroupItemsAsync(string, string, CallSettings)
            // Additional: CloneAddressGroupItemsAsync(string, string, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            string sourceAddressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.CloneAddressGroupItemsAsync(addressGroup, sourceAddressGroup);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceCloneAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneAddressGroupItems</summary>
        public void CloneAddressGroupItemsResourceNames()
        {
            // Snippet: CloneAddressGroupItems(AddressGroupName, AddressGroupName, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            AddressGroupName sourceAddressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = organizationAddressGroupServiceClient.CloneAddressGroupItems(addressGroup, sourceAddressGroup);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceCloneAddressGroupItems(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CloneAddressGroupItemsAsync</summary>
        public async Task CloneAddressGroupItemsResourceNamesAsync()
        {
            // Snippet: CloneAddressGroupItemsAsync(AddressGroupName, AddressGroupName, CallSettings)
            // Additional: CloneAddressGroupItemsAsync(AddressGroupName, AddressGroupName, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            AddressGroupName sourceAddressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            Operation<AddressGroup, OperationMetadata> response = await organizationAddressGroupServiceClient.CloneAddressGroupItemsAsync(addressGroup, sourceAddressGroup);

            // Poll until the returned long-running operation is complete
            Operation<AddressGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AddressGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AddressGroup, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceCloneAddressGroupItemsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AddressGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAddressGroup</summary>
        public void DeleteAddressGroupRequestObject()
        {
            // Snippet: DeleteAddressGroup(DeleteAddressGroupRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            DeleteAddressGroupRequest request = new DeleteAddressGroupRequest
            {
                AddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = organizationAddressGroupServiceClient.DeleteAddressGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceDeleteAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAddressGroupAsync</summary>
        public async Task DeleteAddressGroupRequestObjectAsync()
        {
            // Snippet: DeleteAddressGroupAsync(DeleteAddressGroupRequest, CallSettings)
            // Additional: DeleteAddressGroupAsync(DeleteAddressGroupRequest, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAddressGroupRequest request = new DeleteAddressGroupRequest
            {
                AddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await organizationAddressGroupServiceClient.DeleteAddressGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceDeleteAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAddressGroup</summary>
        public void DeleteAddressGroup()
        {
            // Snippet: DeleteAddressGroup(string, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = organizationAddressGroupServiceClient.DeleteAddressGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceDeleteAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAddressGroupAsync</summary>
        public async Task DeleteAddressGroupAsync()
        {
            // Snippet: DeleteAddressGroupAsync(string, CallSettings)
            // Additional: DeleteAddressGroupAsync(string, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await organizationAddressGroupServiceClient.DeleteAddressGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceDeleteAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAddressGroup</summary>
        public void DeleteAddressGroupResourceNames()
        {
            // Snippet: DeleteAddressGroup(AddressGroupName, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddressGroupName name = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = organizationAddressGroupServiceClient.DeleteAddressGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = organizationAddressGroupServiceClient.PollOnceDeleteAddressGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAddressGroupAsync</summary>
        public async Task DeleteAddressGroupResourceNamesAsync()
        {
            // Snippet: DeleteAddressGroupAsync(AddressGroupName, CallSettings)
            // Additional: DeleteAddressGroupAsync(AddressGroupName, CancellationToken)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddressGroupName name = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await organizationAddressGroupServiceClient.DeleteAddressGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await organizationAddressGroupServiceClient.PollOnceDeleteAddressGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupReferences</summary>
        public void ListAddressGroupReferencesRequestObject()
        {
            // Snippet: ListAddressGroupReferences(ListAddressGroupReferencesRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            ListAddressGroupReferencesRequest request = new ListAddressGroupReferencesRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
            };
            // Make the request
            PagedEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> response = organizationAddressGroupServiceClient.ListAddressGroupReferences(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddressGroupReferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAddressGroupReferencesResponse.Types.AddressGroupReference> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupReferencesAsync</summary>
        public async Task ListAddressGroupReferencesRequestObjectAsync()
        {
            // Snippet: ListAddressGroupReferencesAsync(ListAddressGroupReferencesRequest, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAddressGroupReferencesRequest request = new ListAddressGroupReferencesRequest
            {
                AddressGroupAsAddressGroupName = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> response = organizationAddressGroupServiceClient.ListAddressGroupReferencesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddressGroupReferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAddressGroupReferencesResponse.Types.AddressGroupReference> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupReferences</summary>
        public void ListAddressGroupReferences()
        {
            // Snippet: ListAddressGroupReferences(string, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            PagedEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> response = organizationAddressGroupServiceClient.ListAddressGroupReferences(addressGroup);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddressGroupReferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAddressGroupReferencesResponse.Types.AddressGroupReference> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupReferencesAsync</summary>
        public async Task ListAddressGroupReferencesAsync()
        {
            // Snippet: ListAddressGroupReferencesAsync(string, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            string addressGroup = "projects/[PROJECT]/locations/[LOCATION]/addressGroups/[ADDRESS_GROUP]";
            // Make the request
            PagedAsyncEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> response = organizationAddressGroupServiceClient.ListAddressGroupReferencesAsync(addressGroup);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddressGroupReferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAddressGroupReferencesResponse.Types.AddressGroupReference> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupReferences</summary>
        public void ListAddressGroupReferencesResourceNames()
        {
            // Snippet: ListAddressGroupReferences(AddressGroupName, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = OrganizationAddressGroupServiceClient.Create();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            PagedEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> response = organizationAddressGroupServiceClient.ListAddressGroupReferences(addressGroup);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAddressGroupReferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAddressGroupReferencesResponse.Types.AddressGroupReference> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAddressGroupReferencesAsync</summary>
        public async Task ListAddressGroupReferencesResourceNamesAsync()
        {
            // Snippet: ListAddressGroupReferencesAsync(AddressGroupName, string, int?, CallSettings)
            // Create client
            OrganizationAddressGroupServiceClient organizationAddressGroupServiceClient = await OrganizationAddressGroupServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddressGroupName addressGroup = AddressGroupName.FromProjectLocationAddressGroup("[PROJECT]", "[LOCATION]", "[ADDRESS_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListAddressGroupReferencesResponse, ListAddressGroupReferencesResponse.Types.AddressGroupReference> response = organizationAddressGroupServiceClient.ListAddressGroupReferencesAsync(addressGroup);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAddressGroupReferencesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ListAddressGroupReferencesResponse.Types.AddressGroupReference> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ListAddressGroupReferencesResponse.Types.AddressGroupReference item in singlePage)
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
