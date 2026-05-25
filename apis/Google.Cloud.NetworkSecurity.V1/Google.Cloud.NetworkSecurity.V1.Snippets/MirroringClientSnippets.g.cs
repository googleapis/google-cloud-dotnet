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
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedMirroringClientSnippets
    {
        /// <summary>Snippet for ListMirroringEndpointGroups</summary>
        public void ListMirroringEndpointGroupsRequestObject()
        {
            // Snippet: ListMirroringEndpointGroups(ListMirroringEndpointGroupsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            ListMirroringEndpointGroupsRequest request = new ListMirroringEndpointGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> response = mirroringClient.ListMirroringEndpointGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupsAsync</summary>
        public async Task ListMirroringEndpointGroupsRequestObjectAsync()
        {
            // Snippet: ListMirroringEndpointGroupsAsync(ListMirroringEndpointGroupsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            ListMirroringEndpointGroupsRequest request = new ListMirroringEndpointGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> response = mirroringClient.ListMirroringEndpointGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroups</summary>
        public void ListMirroringEndpointGroups()
        {
            // Snippet: ListMirroringEndpointGroups(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> response = mirroringClient.ListMirroringEndpointGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupsAsync</summary>
        public async Task ListMirroringEndpointGroupsAsync()
        {
            // Snippet: ListMirroringEndpointGroupsAsync(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> response = mirroringClient.ListMirroringEndpointGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroups</summary>
        public void ListMirroringEndpointGroupsResourceNames()
        {
            // Snippet: ListMirroringEndpointGroups(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> response = mirroringClient.ListMirroringEndpointGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupsAsync</summary>
        public async Task ListMirroringEndpointGroupsResourceNamesAsync()
        {
            // Snippet: ListMirroringEndpointGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMirroringEndpointGroupsResponse, MirroringEndpointGroup> response = mirroringClient.ListMirroringEndpointGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroup</summary>
        public void GetMirroringEndpointGroupRequestObject()
        {
            // Snippet: GetMirroringEndpointGroup(GetMirroringEndpointGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            GetMirroringEndpointGroupRequest request = new GetMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]"),
            };
            // Make the request
            MirroringEndpointGroup response = mirroringClient.GetMirroringEndpointGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAsync</summary>
        public async Task GetMirroringEndpointGroupRequestObjectAsync()
        {
            // Snippet: GetMirroringEndpointGroupAsync(GetMirroringEndpointGroupRequest, CallSettings)
            // Additional: GetMirroringEndpointGroupAsync(GetMirroringEndpointGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            GetMirroringEndpointGroupRequest request = new GetMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]"),
            };
            // Make the request
            MirroringEndpointGroup response = await mirroringClient.GetMirroringEndpointGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroup</summary>
        public void GetMirroringEndpointGroup()
        {
            // Snippet: GetMirroringEndpointGroup(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroups/[MIRRORING_ENDPOINT_GROUP]";
            // Make the request
            MirroringEndpointGroup response = mirroringClient.GetMirroringEndpointGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAsync</summary>
        public async Task GetMirroringEndpointGroupAsync()
        {
            // Snippet: GetMirroringEndpointGroupAsync(string, CallSettings)
            // Additional: GetMirroringEndpointGroupAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroups/[MIRRORING_ENDPOINT_GROUP]";
            // Make the request
            MirroringEndpointGroup response = await mirroringClient.GetMirroringEndpointGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroup</summary>
        public void GetMirroringEndpointGroupResourceNames()
        {
            // Snippet: GetMirroringEndpointGroup(MirroringEndpointGroupName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringEndpointGroupName name = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]");
            // Make the request
            MirroringEndpointGroup response = mirroringClient.GetMirroringEndpointGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAsync</summary>
        public async Task GetMirroringEndpointGroupResourceNamesAsync()
        {
            // Snippet: GetMirroringEndpointGroupAsync(MirroringEndpointGroupName, CallSettings)
            // Additional: GetMirroringEndpointGroupAsync(MirroringEndpointGroupName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringEndpointGroupName name = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]");
            // Make the request
            MirroringEndpointGroup response = await mirroringClient.GetMirroringEndpointGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroup</summary>
        public void CreateMirroringEndpointGroupRequestObject()
        {
            // Snippet: CreateMirroringEndpointGroup(CreateMirroringEndpointGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            CreateMirroringEndpointGroupRequest request = new CreateMirroringEndpointGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringEndpointGroupId = "",
                MirroringEndpointGroup = new MirroringEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = mirroringClient.CreateMirroringEndpointGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAsync</summary>
        public async Task CreateMirroringEndpointGroupRequestObjectAsync()
        {
            // Snippet: CreateMirroringEndpointGroupAsync(CreateMirroringEndpointGroupRequest, CallSettings)
            // Additional: CreateMirroringEndpointGroupAsync(CreateMirroringEndpointGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            CreateMirroringEndpointGroupRequest request = new CreateMirroringEndpointGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringEndpointGroupId = "",
                MirroringEndpointGroup = new MirroringEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = await mirroringClient.CreateMirroringEndpointGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroup</summary>
        public void CreateMirroringEndpointGroup()
        {
            // Snippet: CreateMirroringEndpointGroup(string, MirroringEndpointGroup, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringEndpointGroup mirroringEndpointGroup = new MirroringEndpointGroup();
            string mirroringEndpointGroupId = "";
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = mirroringClient.CreateMirroringEndpointGroup(parent, mirroringEndpointGroup, mirroringEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAsync</summary>
        public async Task CreateMirroringEndpointGroupAsync()
        {
            // Snippet: CreateMirroringEndpointGroupAsync(string, MirroringEndpointGroup, string, CallSettings)
            // Additional: CreateMirroringEndpointGroupAsync(string, MirroringEndpointGroup, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringEndpointGroup mirroringEndpointGroup = new MirroringEndpointGroup();
            string mirroringEndpointGroupId = "";
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = await mirroringClient.CreateMirroringEndpointGroupAsync(parent, mirroringEndpointGroup, mirroringEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroup</summary>
        public void CreateMirroringEndpointGroupResourceNames()
        {
            // Snippet: CreateMirroringEndpointGroup(LocationName, MirroringEndpointGroup, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringEndpointGroup mirroringEndpointGroup = new MirroringEndpointGroup();
            string mirroringEndpointGroupId = "";
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = mirroringClient.CreateMirroringEndpointGroup(parent, mirroringEndpointGroup, mirroringEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAsync</summary>
        public async Task CreateMirroringEndpointGroupResourceNamesAsync()
        {
            // Snippet: CreateMirroringEndpointGroupAsync(LocationName, MirroringEndpointGroup, string, CallSettings)
            // Additional: CreateMirroringEndpointGroupAsync(LocationName, MirroringEndpointGroup, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringEndpointGroup mirroringEndpointGroup = new MirroringEndpointGroup();
            string mirroringEndpointGroupId = "";
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = await mirroringClient.CreateMirroringEndpointGroupAsync(parent, mirroringEndpointGroup, mirroringEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroup</summary>
        public void UpdateMirroringEndpointGroupRequestObject()
        {
            // Snippet: UpdateMirroringEndpointGroup(UpdateMirroringEndpointGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            UpdateMirroringEndpointGroupRequest request = new UpdateMirroringEndpointGroupRequest
            {
                UpdateMask = new FieldMask(),
                MirroringEndpointGroup = new MirroringEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = mirroringClient.UpdateMirroringEndpointGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroupAsync</summary>
        public async Task UpdateMirroringEndpointGroupRequestObjectAsync()
        {
            // Snippet: UpdateMirroringEndpointGroupAsync(UpdateMirroringEndpointGroupRequest, CallSettings)
            // Additional: UpdateMirroringEndpointGroupAsync(UpdateMirroringEndpointGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMirroringEndpointGroupRequest request = new UpdateMirroringEndpointGroupRequest
            {
                UpdateMask = new FieldMask(),
                MirroringEndpointGroup = new MirroringEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = await mirroringClient.UpdateMirroringEndpointGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroup</summary>
        public void UpdateMirroringEndpointGroup()
        {
            // Snippet: UpdateMirroringEndpointGroup(MirroringEndpointGroup, FieldMask, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringEndpointGroup mirroringEndpointGroup = new MirroringEndpointGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = mirroringClient.UpdateMirroringEndpointGroup(mirroringEndpointGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroupAsync</summary>
        public async Task UpdateMirroringEndpointGroupAsync()
        {
            // Snippet: UpdateMirroringEndpointGroupAsync(MirroringEndpointGroup, FieldMask, CallSettings)
            // Additional: UpdateMirroringEndpointGroupAsync(MirroringEndpointGroup, FieldMask, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringEndpointGroup mirroringEndpointGroup = new MirroringEndpointGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringEndpointGroup, OperationMetadata> response = await mirroringClient.UpdateMirroringEndpointGroupAsync(mirroringEndpointGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroup</summary>
        public void DeleteMirroringEndpointGroupRequestObject()
        {
            // Snippet: DeleteMirroringEndpointGroup(DeleteMirroringEndpointGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            DeleteMirroringEndpointGroupRequest request = new DeleteMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringEndpointGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAsync</summary>
        public async Task DeleteMirroringEndpointGroupRequestObjectAsync()
        {
            // Snippet: DeleteMirroringEndpointGroupAsync(DeleteMirroringEndpointGroupRequest, CallSettings)
            // Additional: DeleteMirroringEndpointGroupAsync(DeleteMirroringEndpointGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMirroringEndpointGroupRequest request = new DeleteMirroringEndpointGroupRequest
            {
                MirroringEndpointGroupName = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringEndpointGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroup</summary>
        public void DeleteMirroringEndpointGroup()
        {
            // Snippet: DeleteMirroringEndpointGroup(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroups/[MIRRORING_ENDPOINT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringEndpointGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAsync</summary>
        public async Task DeleteMirroringEndpointGroupAsync()
        {
            // Snippet: DeleteMirroringEndpointGroupAsync(string, CallSettings)
            // Additional: DeleteMirroringEndpointGroupAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroups/[MIRRORING_ENDPOINT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringEndpointGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroup</summary>
        public void DeleteMirroringEndpointGroupResourceNames()
        {
            // Snippet: DeleteMirroringEndpointGroup(MirroringEndpointGroupName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringEndpointGroupName name = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringEndpointGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAsync</summary>
        public async Task DeleteMirroringEndpointGroupResourceNamesAsync()
        {
            // Snippet: DeleteMirroringEndpointGroupAsync(MirroringEndpointGroupName, CallSettings)
            // Additional: DeleteMirroringEndpointGroupAsync(MirroringEndpointGroupName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringEndpointGroupName name = MirroringEndpointGroupName.FromProjectLocationMirroringEndpointGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringEndpointGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupAssociations</summary>
        public void ListMirroringEndpointGroupAssociationsRequestObject()
        {
            // Snippet: ListMirroringEndpointGroupAssociations(ListMirroringEndpointGroupAssociationsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            ListMirroringEndpointGroupAssociationsRequest request = new ListMirroringEndpointGroupAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> response = mirroringClient.ListMirroringEndpointGroupAssociations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroupAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupAssociationsAsync</summary>
        public async Task ListMirroringEndpointGroupAssociationsRequestObjectAsync()
        {
            // Snippet: ListMirroringEndpointGroupAssociationsAsync(ListMirroringEndpointGroupAssociationsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            ListMirroringEndpointGroupAssociationsRequest request = new ListMirroringEndpointGroupAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> response = mirroringClient.ListMirroringEndpointGroupAssociationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroupAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupAssociations</summary>
        public void ListMirroringEndpointGroupAssociations()
        {
            // Snippet: ListMirroringEndpointGroupAssociations(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> response = mirroringClient.ListMirroringEndpointGroupAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroupAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupAssociationsAsync</summary>
        public async Task ListMirroringEndpointGroupAssociationsAsync()
        {
            // Snippet: ListMirroringEndpointGroupAssociationsAsync(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> response = mirroringClient.ListMirroringEndpointGroupAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroupAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupAssociations</summary>
        public void ListMirroringEndpointGroupAssociationsResourceNames()
        {
            // Snippet: ListMirroringEndpointGroupAssociations(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> response = mirroringClient.ListMirroringEndpointGroupAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroupAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringEndpointGroupAssociationsAsync</summary>
        public async Task ListMirroringEndpointGroupAssociationsResourceNamesAsync()
        {
            // Snippet: ListMirroringEndpointGroupAssociationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMirroringEndpointGroupAssociationsResponse, MirroringEndpointGroupAssociation> response = mirroringClient.ListMirroringEndpointGroupAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringEndpointGroupAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAssociation</summary>
        public void GetMirroringEndpointGroupAssociationRequestObject()
        {
            // Snippet: GetMirroringEndpointGroupAssociation(GetMirroringEndpointGroupAssociationRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            GetMirroringEndpointGroupAssociationRequest request = new GetMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]"),
            };
            // Make the request
            MirroringEndpointGroupAssociation response = mirroringClient.GetMirroringEndpointGroupAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAssociationAsync</summary>
        public async Task GetMirroringEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: GetMirroringEndpointGroupAssociationAsync(GetMirroringEndpointGroupAssociationRequest, CallSettings)
            // Additional: GetMirroringEndpointGroupAssociationAsync(GetMirroringEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            GetMirroringEndpointGroupAssociationRequest request = new GetMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]"),
            };
            // Make the request
            MirroringEndpointGroupAssociation response = await mirroringClient.GetMirroringEndpointGroupAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAssociation</summary>
        public void GetMirroringEndpointGroupAssociation()
        {
            // Snippet: GetMirroringEndpointGroupAssociation(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroupAssociations/[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            MirroringEndpointGroupAssociation response = mirroringClient.GetMirroringEndpointGroupAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAssociationAsync</summary>
        public async Task GetMirroringEndpointGroupAssociationAsync()
        {
            // Snippet: GetMirroringEndpointGroupAssociationAsync(string, CallSettings)
            // Additional: GetMirroringEndpointGroupAssociationAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroupAssociations/[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            MirroringEndpointGroupAssociation response = await mirroringClient.GetMirroringEndpointGroupAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAssociation</summary>
        public void GetMirroringEndpointGroupAssociationResourceNames()
        {
            // Snippet: GetMirroringEndpointGroupAssociation(MirroringEndpointGroupAssociationName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringEndpointGroupAssociationName name = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            MirroringEndpointGroupAssociation response = mirroringClient.GetMirroringEndpointGroupAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringEndpointGroupAssociationAsync</summary>
        public async Task GetMirroringEndpointGroupAssociationResourceNamesAsync()
        {
            // Snippet: GetMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName, CallSettings)
            // Additional: GetMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringEndpointGroupAssociationName name = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            MirroringEndpointGroupAssociation response = await mirroringClient.GetMirroringEndpointGroupAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAssociation</summary>
        public void CreateMirroringEndpointGroupAssociationRequestObject()
        {
            // Snippet: CreateMirroringEndpointGroupAssociation(CreateMirroringEndpointGroupAssociationRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            CreateMirroringEndpointGroupAssociationRequest request = new CreateMirroringEndpointGroupAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringEndpointGroupAssociationId = "",
                MirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = mirroringClient.CreateMirroringEndpointGroupAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAssociationAsync</summary>
        public async Task CreateMirroringEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: CreateMirroringEndpointGroupAssociationAsync(CreateMirroringEndpointGroupAssociationRequest, CallSettings)
            // Additional: CreateMirroringEndpointGroupAssociationAsync(CreateMirroringEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            CreateMirroringEndpointGroupAssociationRequest request = new CreateMirroringEndpointGroupAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringEndpointGroupAssociationId = "",
                MirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = await mirroringClient.CreateMirroringEndpointGroupAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAssociation</summary>
        public void CreateMirroringEndpointGroupAssociation()
        {
            // Snippet: CreateMirroringEndpointGroupAssociation(string, MirroringEndpointGroupAssociation, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation();
            string mirroringEndpointGroupAssociationId = "";
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = mirroringClient.CreateMirroringEndpointGroupAssociation(parent, mirroringEndpointGroupAssociation, mirroringEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAssociationAsync</summary>
        public async Task CreateMirroringEndpointGroupAssociationAsync()
        {
            // Snippet: CreateMirroringEndpointGroupAssociationAsync(string, MirroringEndpointGroupAssociation, string, CallSettings)
            // Additional: CreateMirroringEndpointGroupAssociationAsync(string, MirroringEndpointGroupAssociation, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation();
            string mirroringEndpointGroupAssociationId = "";
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = await mirroringClient.CreateMirroringEndpointGroupAssociationAsync(parent, mirroringEndpointGroupAssociation, mirroringEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAssociation</summary>
        public void CreateMirroringEndpointGroupAssociationResourceNames()
        {
            // Snippet: CreateMirroringEndpointGroupAssociation(LocationName, MirroringEndpointGroupAssociation, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation();
            string mirroringEndpointGroupAssociationId = "";
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = mirroringClient.CreateMirroringEndpointGroupAssociation(parent, mirroringEndpointGroupAssociation, mirroringEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringEndpointGroupAssociationAsync</summary>
        public async Task CreateMirroringEndpointGroupAssociationResourceNamesAsync()
        {
            // Snippet: CreateMirroringEndpointGroupAssociationAsync(LocationName, MirroringEndpointGroupAssociation, string, CallSettings)
            // Additional: CreateMirroringEndpointGroupAssociationAsync(LocationName, MirroringEndpointGroupAssociation, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation();
            string mirroringEndpointGroupAssociationId = "";
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = await mirroringClient.CreateMirroringEndpointGroupAssociationAsync(parent, mirroringEndpointGroupAssociation, mirroringEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroupAssociation</summary>
        public void UpdateMirroringEndpointGroupAssociationRequestObject()
        {
            // Snippet: UpdateMirroringEndpointGroupAssociation(UpdateMirroringEndpointGroupAssociationRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            UpdateMirroringEndpointGroupAssociationRequest request = new UpdateMirroringEndpointGroupAssociationRequest
            {
                UpdateMask = new FieldMask(),
                MirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = mirroringClient.UpdateMirroringEndpointGroupAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroupAssociationAsync</summary>
        public async Task UpdateMirroringEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: UpdateMirroringEndpointGroupAssociationAsync(UpdateMirroringEndpointGroupAssociationRequest, CallSettings)
            // Additional: UpdateMirroringEndpointGroupAssociationAsync(UpdateMirroringEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMirroringEndpointGroupAssociationRequest request = new UpdateMirroringEndpointGroupAssociationRequest
            {
                UpdateMask = new FieldMask(),
                MirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = await mirroringClient.UpdateMirroringEndpointGroupAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroupAssociation</summary>
        public void UpdateMirroringEndpointGroupAssociation()
        {
            // Snippet: UpdateMirroringEndpointGroupAssociation(MirroringEndpointGroupAssociation, FieldMask, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = mirroringClient.UpdateMirroringEndpointGroupAssociation(mirroringEndpointGroupAssociation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringEndpointGroupAssociationAsync</summary>
        public async Task UpdateMirroringEndpointGroupAssociationAsync()
        {
            // Snippet: UpdateMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociation, FieldMask, CallSettings)
            // Additional: UpdateMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociation, FieldMask, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringEndpointGroupAssociation mirroringEndpointGroupAssociation = new MirroringEndpointGroupAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> response = await mirroringClient.UpdateMirroringEndpointGroupAssociationAsync(mirroringEndpointGroupAssociation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringEndpointGroupAssociation, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAssociation</summary>
        public void DeleteMirroringEndpointGroupAssociationRequestObject()
        {
            // Snippet: DeleteMirroringEndpointGroupAssociation(DeleteMirroringEndpointGroupAssociationRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            DeleteMirroringEndpointGroupAssociationRequest request = new DeleteMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringEndpointGroupAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAssociationAsync</summary>
        public async Task DeleteMirroringEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: DeleteMirroringEndpointGroupAssociationAsync(DeleteMirroringEndpointGroupAssociationRequest, CallSettings)
            // Additional: DeleteMirroringEndpointGroupAssociationAsync(DeleteMirroringEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMirroringEndpointGroupAssociationRequest request = new DeleteMirroringEndpointGroupAssociationRequest
            {
                MirroringEndpointGroupAssociationName = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringEndpointGroupAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAssociation</summary>
        public void DeleteMirroringEndpointGroupAssociation()
        {
            // Snippet: DeleteMirroringEndpointGroupAssociation(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroupAssociations/[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringEndpointGroupAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAssociationAsync</summary>
        public async Task DeleteMirroringEndpointGroupAssociationAsync()
        {
            // Snippet: DeleteMirroringEndpointGroupAssociationAsync(string, CallSettings)
            // Additional: DeleteMirroringEndpointGroupAssociationAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringEndpointGroupAssociations/[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringEndpointGroupAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAssociation</summary>
        public void DeleteMirroringEndpointGroupAssociationResourceNames()
        {
            // Snippet: DeleteMirroringEndpointGroupAssociation(MirroringEndpointGroupAssociationName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringEndpointGroupAssociationName name = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringEndpointGroupAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringEndpointGroupAssociationAsync</summary>
        public async Task DeleteMirroringEndpointGroupAssociationResourceNamesAsync()
        {
            // Snippet: DeleteMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName, CallSettings)
            // Additional: DeleteMirroringEndpointGroupAssociationAsync(MirroringEndpointGroupAssociationName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringEndpointGroupAssociationName name = MirroringEndpointGroupAssociationName.FromProjectLocationMirroringEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[MIRRORING_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringEndpointGroupAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentGroups</summary>
        public void ListMirroringDeploymentGroupsRequestObject()
        {
            // Snippet: ListMirroringDeploymentGroups(ListMirroringDeploymentGroupsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            ListMirroringDeploymentGroupsRequest request = new ListMirroringDeploymentGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> response = mirroringClient.ListMirroringDeploymentGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentGroupsAsync</summary>
        public async Task ListMirroringDeploymentGroupsRequestObjectAsync()
        {
            // Snippet: ListMirroringDeploymentGroupsAsync(ListMirroringDeploymentGroupsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            ListMirroringDeploymentGroupsRequest request = new ListMirroringDeploymentGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> response = mirroringClient.ListMirroringDeploymentGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentGroups</summary>
        public void ListMirroringDeploymentGroups()
        {
            // Snippet: ListMirroringDeploymentGroups(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> response = mirroringClient.ListMirroringDeploymentGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentGroupsAsync</summary>
        public async Task ListMirroringDeploymentGroupsAsync()
        {
            // Snippet: ListMirroringDeploymentGroupsAsync(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> response = mirroringClient.ListMirroringDeploymentGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentGroups</summary>
        public void ListMirroringDeploymentGroupsResourceNames()
        {
            // Snippet: ListMirroringDeploymentGroups(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> response = mirroringClient.ListMirroringDeploymentGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentGroupsAsync</summary>
        public async Task ListMirroringDeploymentGroupsResourceNamesAsync()
        {
            // Snippet: ListMirroringDeploymentGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMirroringDeploymentGroupsResponse, MirroringDeploymentGroup> response = mirroringClient.ListMirroringDeploymentGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentGroup</summary>
        public void GetMirroringDeploymentGroupRequestObject()
        {
            // Snippet: GetMirroringDeploymentGroup(GetMirroringDeploymentGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            GetMirroringDeploymentGroupRequest request = new GetMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]"),
            };
            // Make the request
            MirroringDeploymentGroup response = mirroringClient.GetMirroringDeploymentGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentGroupAsync</summary>
        public async Task GetMirroringDeploymentGroupRequestObjectAsync()
        {
            // Snippet: GetMirroringDeploymentGroupAsync(GetMirroringDeploymentGroupRequest, CallSettings)
            // Additional: GetMirroringDeploymentGroupAsync(GetMirroringDeploymentGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            GetMirroringDeploymentGroupRequest request = new GetMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]"),
            };
            // Make the request
            MirroringDeploymentGroup response = await mirroringClient.GetMirroringDeploymentGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentGroup</summary>
        public void GetMirroringDeploymentGroup()
        {
            // Snippet: GetMirroringDeploymentGroup(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeploymentGroups/[MIRRORING_DEPLOYMENT_GROUP]";
            // Make the request
            MirroringDeploymentGroup response = mirroringClient.GetMirroringDeploymentGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentGroupAsync</summary>
        public async Task GetMirroringDeploymentGroupAsync()
        {
            // Snippet: GetMirroringDeploymentGroupAsync(string, CallSettings)
            // Additional: GetMirroringDeploymentGroupAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeploymentGroups/[MIRRORING_DEPLOYMENT_GROUP]";
            // Make the request
            MirroringDeploymentGroup response = await mirroringClient.GetMirroringDeploymentGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentGroup</summary>
        public void GetMirroringDeploymentGroupResourceNames()
        {
            // Snippet: GetMirroringDeploymentGroup(MirroringDeploymentGroupName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringDeploymentGroupName name = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]");
            // Make the request
            MirroringDeploymentGroup response = mirroringClient.GetMirroringDeploymentGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentGroupAsync</summary>
        public async Task GetMirroringDeploymentGroupResourceNamesAsync()
        {
            // Snippet: GetMirroringDeploymentGroupAsync(MirroringDeploymentGroupName, CallSettings)
            // Additional: GetMirroringDeploymentGroupAsync(MirroringDeploymentGroupName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringDeploymentGroupName name = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]");
            // Make the request
            MirroringDeploymentGroup response = await mirroringClient.GetMirroringDeploymentGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentGroup</summary>
        public void CreateMirroringDeploymentGroupRequestObject()
        {
            // Snippet: CreateMirroringDeploymentGroup(CreateMirroringDeploymentGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            CreateMirroringDeploymentGroupRequest request = new CreateMirroringDeploymentGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringDeploymentGroupId = "",
                MirroringDeploymentGroup = new MirroringDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = mirroringClient.CreateMirroringDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentGroupAsync</summary>
        public async Task CreateMirroringDeploymentGroupRequestObjectAsync()
        {
            // Snippet: CreateMirroringDeploymentGroupAsync(CreateMirroringDeploymentGroupRequest, CallSettings)
            // Additional: CreateMirroringDeploymentGroupAsync(CreateMirroringDeploymentGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            CreateMirroringDeploymentGroupRequest request = new CreateMirroringDeploymentGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringDeploymentGroupId = "",
                MirroringDeploymentGroup = new MirroringDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = await mirroringClient.CreateMirroringDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentGroup</summary>
        public void CreateMirroringDeploymentGroup()
        {
            // Snippet: CreateMirroringDeploymentGroup(string, MirroringDeploymentGroup, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringDeploymentGroup mirroringDeploymentGroup = new MirroringDeploymentGroup();
            string mirroringDeploymentGroupId = "";
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = mirroringClient.CreateMirroringDeploymentGroup(parent, mirroringDeploymentGroup, mirroringDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentGroupAsync</summary>
        public async Task CreateMirroringDeploymentGroupAsync()
        {
            // Snippet: CreateMirroringDeploymentGroupAsync(string, MirroringDeploymentGroup, string, CallSettings)
            // Additional: CreateMirroringDeploymentGroupAsync(string, MirroringDeploymentGroup, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringDeploymentGroup mirroringDeploymentGroup = new MirroringDeploymentGroup();
            string mirroringDeploymentGroupId = "";
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = await mirroringClient.CreateMirroringDeploymentGroupAsync(parent, mirroringDeploymentGroup, mirroringDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentGroup</summary>
        public void CreateMirroringDeploymentGroupResourceNames()
        {
            // Snippet: CreateMirroringDeploymentGroup(LocationName, MirroringDeploymentGroup, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringDeploymentGroup mirroringDeploymentGroup = new MirroringDeploymentGroup();
            string mirroringDeploymentGroupId = "";
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = mirroringClient.CreateMirroringDeploymentGroup(parent, mirroringDeploymentGroup, mirroringDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentGroupAsync</summary>
        public async Task CreateMirroringDeploymentGroupResourceNamesAsync()
        {
            // Snippet: CreateMirroringDeploymentGroupAsync(LocationName, MirroringDeploymentGroup, string, CallSettings)
            // Additional: CreateMirroringDeploymentGroupAsync(LocationName, MirroringDeploymentGroup, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringDeploymentGroup mirroringDeploymentGroup = new MirroringDeploymentGroup();
            string mirroringDeploymentGroupId = "";
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = await mirroringClient.CreateMirroringDeploymentGroupAsync(parent, mirroringDeploymentGroup, mirroringDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeploymentGroup</summary>
        public void UpdateMirroringDeploymentGroupRequestObject()
        {
            // Snippet: UpdateMirroringDeploymentGroup(UpdateMirroringDeploymentGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            UpdateMirroringDeploymentGroupRequest request = new UpdateMirroringDeploymentGroupRequest
            {
                UpdateMask = new FieldMask(),
                MirroringDeploymentGroup = new MirroringDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = mirroringClient.UpdateMirroringDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeploymentGroupAsync</summary>
        public async Task UpdateMirroringDeploymentGroupRequestObjectAsync()
        {
            // Snippet: UpdateMirroringDeploymentGroupAsync(UpdateMirroringDeploymentGroupRequest, CallSettings)
            // Additional: UpdateMirroringDeploymentGroupAsync(UpdateMirroringDeploymentGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMirroringDeploymentGroupRequest request = new UpdateMirroringDeploymentGroupRequest
            {
                UpdateMask = new FieldMask(),
                MirroringDeploymentGroup = new MirroringDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = await mirroringClient.UpdateMirroringDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeploymentGroup</summary>
        public void UpdateMirroringDeploymentGroup()
        {
            // Snippet: UpdateMirroringDeploymentGroup(MirroringDeploymentGroup, FieldMask, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringDeploymentGroup mirroringDeploymentGroup = new MirroringDeploymentGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = mirroringClient.UpdateMirroringDeploymentGroup(mirroringDeploymentGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeploymentGroupAsync</summary>
        public async Task UpdateMirroringDeploymentGroupAsync()
        {
            // Snippet: UpdateMirroringDeploymentGroupAsync(MirroringDeploymentGroup, FieldMask, CallSettings)
            // Additional: UpdateMirroringDeploymentGroupAsync(MirroringDeploymentGroup, FieldMask, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringDeploymentGroup mirroringDeploymentGroup = new MirroringDeploymentGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringDeploymentGroup, OperationMetadata> response = await mirroringClient.UpdateMirroringDeploymentGroupAsync(mirroringDeploymentGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeploymentGroup, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentGroup</summary>
        public void DeleteMirroringDeploymentGroupRequestObject()
        {
            // Snippet: DeleteMirroringDeploymentGroup(DeleteMirroringDeploymentGroupRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            DeleteMirroringDeploymentGroupRequest request = new DeleteMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentGroupAsync</summary>
        public async Task DeleteMirroringDeploymentGroupRequestObjectAsync()
        {
            // Snippet: DeleteMirroringDeploymentGroupAsync(DeleteMirroringDeploymentGroupRequest, CallSettings)
            // Additional: DeleteMirroringDeploymentGroupAsync(DeleteMirroringDeploymentGroupRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMirroringDeploymentGroupRequest request = new DeleteMirroringDeploymentGroupRequest
            {
                MirroringDeploymentGroupName = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentGroup</summary>
        public void DeleteMirroringDeploymentGroup()
        {
            // Snippet: DeleteMirroringDeploymentGroup(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeploymentGroups/[MIRRORING_DEPLOYMENT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentGroupAsync</summary>
        public async Task DeleteMirroringDeploymentGroupAsync()
        {
            // Snippet: DeleteMirroringDeploymentGroupAsync(string, CallSettings)
            // Additional: DeleteMirroringDeploymentGroupAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeploymentGroups/[MIRRORING_DEPLOYMENT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentGroup</summary>
        public void DeleteMirroringDeploymentGroupResourceNames()
        {
            // Snippet: DeleteMirroringDeploymentGroup(MirroringDeploymentGroupName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringDeploymentGroupName name = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentGroupAsync</summary>
        public async Task DeleteMirroringDeploymentGroupResourceNamesAsync()
        {
            // Snippet: DeleteMirroringDeploymentGroupAsync(MirroringDeploymentGroupName, CallSettings)
            // Additional: DeleteMirroringDeploymentGroupAsync(MirroringDeploymentGroupName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringDeploymentGroupName name = MirroringDeploymentGroupName.FromProjectLocationMirroringDeploymentGroup("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeployments</summary>
        public void ListMirroringDeploymentsRequestObject()
        {
            // Snippet: ListMirroringDeployments(ListMirroringDeploymentsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            ListMirroringDeploymentsRequest request = new ListMirroringDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> response = mirroringClient.ListMirroringDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentsAsync</summary>
        public async Task ListMirroringDeploymentsRequestObjectAsync()
        {
            // Snippet: ListMirroringDeploymentsAsync(ListMirroringDeploymentsRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            ListMirroringDeploymentsRequest request = new ListMirroringDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> response = mirroringClient.ListMirroringDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeployments</summary>
        public void ListMirroringDeployments()
        {
            // Snippet: ListMirroringDeployments(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> response = mirroringClient.ListMirroringDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentsAsync</summary>
        public async Task ListMirroringDeploymentsAsync()
        {
            // Snippet: ListMirroringDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> response = mirroringClient.ListMirroringDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeployments</summary>
        public void ListMirroringDeploymentsResourceNames()
        {
            // Snippet: ListMirroringDeployments(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> response = mirroringClient.ListMirroringDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (MirroringDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMirroringDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMirroringDeploymentsAsync</summary>
        public async Task ListMirroringDeploymentsResourceNamesAsync()
        {
            // Snippet: ListMirroringDeploymentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListMirroringDeploymentsResponse, MirroringDeployment> response = mirroringClient.ListMirroringDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (MirroringDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListMirroringDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (MirroringDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<MirroringDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (MirroringDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeployment</summary>
        public void GetMirroringDeploymentRequestObject()
        {
            // Snippet: GetMirroringDeployment(GetMirroringDeploymentRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            GetMirroringDeploymentRequest request = new GetMirroringDeploymentRequest
            {
                MirroringDeploymentName = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]"),
            };
            // Make the request
            MirroringDeployment response = mirroringClient.GetMirroringDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentAsync</summary>
        public async Task GetMirroringDeploymentRequestObjectAsync()
        {
            // Snippet: GetMirroringDeploymentAsync(GetMirroringDeploymentRequest, CallSettings)
            // Additional: GetMirroringDeploymentAsync(GetMirroringDeploymentRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            GetMirroringDeploymentRequest request = new GetMirroringDeploymentRequest
            {
                MirroringDeploymentName = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]"),
            };
            // Make the request
            MirroringDeployment response = await mirroringClient.GetMirroringDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeployment</summary>
        public void GetMirroringDeployment()
        {
            // Snippet: GetMirroringDeployment(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeployments/[MIRRORING_DEPLOYMENT]";
            // Make the request
            MirroringDeployment response = mirroringClient.GetMirroringDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentAsync</summary>
        public async Task GetMirroringDeploymentAsync()
        {
            // Snippet: GetMirroringDeploymentAsync(string, CallSettings)
            // Additional: GetMirroringDeploymentAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeployments/[MIRRORING_DEPLOYMENT]";
            // Make the request
            MirroringDeployment response = await mirroringClient.GetMirroringDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeployment</summary>
        public void GetMirroringDeploymentResourceNames()
        {
            // Snippet: GetMirroringDeployment(MirroringDeploymentName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringDeploymentName name = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]");
            // Make the request
            MirroringDeployment response = mirroringClient.GetMirroringDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetMirroringDeploymentAsync</summary>
        public async Task GetMirroringDeploymentResourceNamesAsync()
        {
            // Snippet: GetMirroringDeploymentAsync(MirroringDeploymentName, CallSettings)
            // Additional: GetMirroringDeploymentAsync(MirroringDeploymentName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringDeploymentName name = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]");
            // Make the request
            MirroringDeployment response = await mirroringClient.GetMirroringDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeployment</summary>
        public void CreateMirroringDeploymentRequestObject()
        {
            // Snippet: CreateMirroringDeployment(CreateMirroringDeploymentRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            CreateMirroringDeploymentRequest request = new CreateMirroringDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringDeploymentId = "",
                MirroringDeployment = new MirroringDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = mirroringClient.CreateMirroringDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentAsync</summary>
        public async Task CreateMirroringDeploymentRequestObjectAsync()
        {
            // Snippet: CreateMirroringDeploymentAsync(CreateMirroringDeploymentRequest, CallSettings)
            // Additional: CreateMirroringDeploymentAsync(CreateMirroringDeploymentRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            CreateMirroringDeploymentRequest request = new CreateMirroringDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                MirroringDeploymentId = "",
                MirroringDeployment = new MirroringDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = await mirroringClient.CreateMirroringDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeployment</summary>
        public void CreateMirroringDeployment()
        {
            // Snippet: CreateMirroringDeployment(string, MirroringDeployment, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringDeployment mirroringDeployment = new MirroringDeployment();
            string mirroringDeploymentId = "";
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = mirroringClient.CreateMirroringDeployment(parent, mirroringDeployment, mirroringDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentAsync</summary>
        public async Task CreateMirroringDeploymentAsync()
        {
            // Snippet: CreateMirroringDeploymentAsync(string, MirroringDeployment, string, CallSettings)
            // Additional: CreateMirroringDeploymentAsync(string, MirroringDeployment, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            MirroringDeployment mirroringDeployment = new MirroringDeployment();
            string mirroringDeploymentId = "";
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = await mirroringClient.CreateMirroringDeploymentAsync(parent, mirroringDeployment, mirroringDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeployment</summary>
        public void CreateMirroringDeploymentResourceNames()
        {
            // Snippet: CreateMirroringDeployment(LocationName, MirroringDeployment, string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringDeployment mirroringDeployment = new MirroringDeployment();
            string mirroringDeploymentId = "";
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = mirroringClient.CreateMirroringDeployment(parent, mirroringDeployment, mirroringDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = mirroringClient.PollOnceCreateMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMirroringDeploymentAsync</summary>
        public async Task CreateMirroringDeploymentResourceNamesAsync()
        {
            // Snippet: CreateMirroringDeploymentAsync(LocationName, MirroringDeployment, string, CallSettings)
            // Additional: CreateMirroringDeploymentAsync(LocationName, MirroringDeployment, string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            MirroringDeployment mirroringDeployment = new MirroringDeployment();
            string mirroringDeploymentId = "";
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = await mirroringClient.CreateMirroringDeploymentAsync(parent, mirroringDeployment, mirroringDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceCreateMirroringDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeployment</summary>
        public void UpdateMirroringDeploymentRequestObject()
        {
            // Snippet: UpdateMirroringDeployment(UpdateMirroringDeploymentRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            UpdateMirroringDeploymentRequest request = new UpdateMirroringDeploymentRequest
            {
                UpdateMask = new FieldMask(),
                MirroringDeployment = new MirroringDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = mirroringClient.UpdateMirroringDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeploymentAsync</summary>
        public async Task UpdateMirroringDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateMirroringDeploymentAsync(UpdateMirroringDeploymentRequest, CallSettings)
            // Additional: UpdateMirroringDeploymentAsync(UpdateMirroringDeploymentRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMirroringDeploymentRequest request = new UpdateMirroringDeploymentRequest
            {
                UpdateMask = new FieldMask(),
                MirroringDeployment = new MirroringDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = await mirroringClient.UpdateMirroringDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeployment</summary>
        public void UpdateMirroringDeployment()
        {
            // Snippet: UpdateMirroringDeployment(MirroringDeployment, FieldMask, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringDeployment mirroringDeployment = new MirroringDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = mirroringClient.UpdateMirroringDeployment(mirroringDeployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = mirroringClient.PollOnceUpdateMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateMirroringDeploymentAsync</summary>
        public async Task UpdateMirroringDeploymentAsync()
        {
            // Snippet: UpdateMirroringDeploymentAsync(MirroringDeployment, FieldMask, CallSettings)
            // Additional: UpdateMirroringDeploymentAsync(MirroringDeployment, FieldMask, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringDeployment mirroringDeployment = new MirroringDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<MirroringDeployment, OperationMetadata> response = await mirroringClient.UpdateMirroringDeploymentAsync(mirroringDeployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<MirroringDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            MirroringDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MirroringDeployment, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceUpdateMirroringDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MirroringDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeployment</summary>
        public void DeleteMirroringDeploymentRequestObject()
        {
            // Snippet: DeleteMirroringDeployment(DeleteMirroringDeploymentRequest, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            DeleteMirroringDeploymentRequest request = new DeleteMirroringDeploymentRequest
            {
                MirroringDeploymentName = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentAsync</summary>
        public async Task DeleteMirroringDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteMirroringDeploymentAsync(DeleteMirroringDeploymentRequest, CallSettings)
            // Additional: DeleteMirroringDeploymentAsync(DeleteMirroringDeploymentRequest, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMirroringDeploymentRequest request = new DeleteMirroringDeploymentRequest
            {
                MirroringDeploymentName = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeployment</summary>
        public void DeleteMirroringDeployment()
        {
            // Snippet: DeleteMirroringDeployment(string, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeployments/[MIRRORING_DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentAsync</summary>
        public async Task DeleteMirroringDeploymentAsync()
        {
            // Snippet: DeleteMirroringDeploymentAsync(string, CallSettings)
            // Additional: DeleteMirroringDeploymentAsync(string, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/mirroringDeployments/[MIRRORING_DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeployment</summary>
        public void DeleteMirroringDeploymentResourceNames()
        {
            // Snippet: DeleteMirroringDeployment(MirroringDeploymentName, CallSettings)
            // Create client
            MirroringClient mirroringClient = MirroringClient.Create();
            // Initialize request argument(s)
            MirroringDeploymentName name = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = mirroringClient.DeleteMirroringDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = mirroringClient.PollOnceDeleteMirroringDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteMirroringDeploymentAsync</summary>
        public async Task DeleteMirroringDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteMirroringDeploymentAsync(MirroringDeploymentName, CallSettings)
            // Additional: DeleteMirroringDeploymentAsync(MirroringDeploymentName, CancellationToken)
            // Create client
            MirroringClient mirroringClient = await MirroringClient.CreateAsync();
            // Initialize request argument(s)
            MirroringDeploymentName name = MirroringDeploymentName.FromProjectLocationMirroringDeployment("[PROJECT]", "[LOCATION]", "[MIRRORING_DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await mirroringClient.DeleteMirroringDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await mirroringClient.PollOnceDeleteMirroringDeploymentAsync(operationName);
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
