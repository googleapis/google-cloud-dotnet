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
    public sealed class AllGeneratedInterceptClientSnippets
    {
        /// <summary>Snippet for ListInterceptEndpointGroups</summary>
        public void ListInterceptEndpointGroupsRequestObject()
        {
            // Snippet: ListInterceptEndpointGroups(ListInterceptEndpointGroupsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            ListInterceptEndpointGroupsRequest request = new ListInterceptEndpointGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> response = interceptClient.ListInterceptEndpointGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupsAsync</summary>
        public async Task ListInterceptEndpointGroupsRequestObjectAsync()
        {
            // Snippet: ListInterceptEndpointGroupsAsync(ListInterceptEndpointGroupsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            ListInterceptEndpointGroupsRequest request = new ListInterceptEndpointGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> response = interceptClient.ListInterceptEndpointGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroups</summary>
        public void ListInterceptEndpointGroups()
        {
            // Snippet: ListInterceptEndpointGroups(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> response = interceptClient.ListInterceptEndpointGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupsAsync</summary>
        public async Task ListInterceptEndpointGroupsAsync()
        {
            // Snippet: ListInterceptEndpointGroupsAsync(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> response = interceptClient.ListInterceptEndpointGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroups</summary>
        public void ListInterceptEndpointGroupsResourceNames()
        {
            // Snippet: ListInterceptEndpointGroups(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> response = interceptClient.ListInterceptEndpointGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupsAsync</summary>
        public async Task ListInterceptEndpointGroupsResourceNamesAsync()
        {
            // Snippet: ListInterceptEndpointGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInterceptEndpointGroupsResponse, InterceptEndpointGroup> response = interceptClient.ListInterceptEndpointGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptEndpointGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptEndpointGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroup</summary>
        public void GetInterceptEndpointGroupRequestObject()
        {
            // Snippet: GetInterceptEndpointGroup(GetInterceptEndpointGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            GetInterceptEndpointGroupRequest request = new GetInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]"),
            };
            // Make the request
            InterceptEndpointGroup response = interceptClient.GetInterceptEndpointGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAsync</summary>
        public async Task GetInterceptEndpointGroupRequestObjectAsync()
        {
            // Snippet: GetInterceptEndpointGroupAsync(GetInterceptEndpointGroupRequest, CallSettings)
            // Additional: GetInterceptEndpointGroupAsync(GetInterceptEndpointGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            GetInterceptEndpointGroupRequest request = new GetInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]"),
            };
            // Make the request
            InterceptEndpointGroup response = await interceptClient.GetInterceptEndpointGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroup</summary>
        public void GetInterceptEndpointGroup()
        {
            // Snippet: GetInterceptEndpointGroup(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroups/[INTERCEPT_ENDPOINT_GROUP]";
            // Make the request
            InterceptEndpointGroup response = interceptClient.GetInterceptEndpointGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAsync</summary>
        public async Task GetInterceptEndpointGroupAsync()
        {
            // Snippet: GetInterceptEndpointGroupAsync(string, CallSettings)
            // Additional: GetInterceptEndpointGroupAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroups/[INTERCEPT_ENDPOINT_GROUP]";
            // Make the request
            InterceptEndpointGroup response = await interceptClient.GetInterceptEndpointGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroup</summary>
        public void GetInterceptEndpointGroupResourceNames()
        {
            // Snippet: GetInterceptEndpointGroup(InterceptEndpointGroupName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptEndpointGroupName name = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]");
            // Make the request
            InterceptEndpointGroup response = interceptClient.GetInterceptEndpointGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAsync</summary>
        public async Task GetInterceptEndpointGroupResourceNamesAsync()
        {
            // Snippet: GetInterceptEndpointGroupAsync(InterceptEndpointGroupName, CallSettings)
            // Additional: GetInterceptEndpointGroupAsync(InterceptEndpointGroupName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptEndpointGroupName name = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]");
            // Make the request
            InterceptEndpointGroup response = await interceptClient.GetInterceptEndpointGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroup</summary>
        public void CreateInterceptEndpointGroupRequestObject()
        {
            // Snippet: CreateInterceptEndpointGroup(CreateInterceptEndpointGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            CreateInterceptEndpointGroupRequest request = new CreateInterceptEndpointGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptEndpointGroupId = "",
                InterceptEndpointGroup = new InterceptEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = interceptClient.CreateInterceptEndpointGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAsync</summary>
        public async Task CreateInterceptEndpointGroupRequestObjectAsync()
        {
            // Snippet: CreateInterceptEndpointGroupAsync(CreateInterceptEndpointGroupRequest, CallSettings)
            // Additional: CreateInterceptEndpointGroupAsync(CreateInterceptEndpointGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            CreateInterceptEndpointGroupRequest request = new CreateInterceptEndpointGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptEndpointGroupId = "",
                InterceptEndpointGroup = new InterceptEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = await interceptClient.CreateInterceptEndpointGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroup</summary>
        public void CreateInterceptEndpointGroup()
        {
            // Snippet: CreateInterceptEndpointGroup(string, InterceptEndpointGroup, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptEndpointGroup interceptEndpointGroup = new InterceptEndpointGroup();
            string interceptEndpointGroupId = "";
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = interceptClient.CreateInterceptEndpointGroup(parent, interceptEndpointGroup, interceptEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAsync</summary>
        public async Task CreateInterceptEndpointGroupAsync()
        {
            // Snippet: CreateInterceptEndpointGroupAsync(string, InterceptEndpointGroup, string, CallSettings)
            // Additional: CreateInterceptEndpointGroupAsync(string, InterceptEndpointGroup, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptEndpointGroup interceptEndpointGroup = new InterceptEndpointGroup();
            string interceptEndpointGroupId = "";
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = await interceptClient.CreateInterceptEndpointGroupAsync(parent, interceptEndpointGroup, interceptEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroup</summary>
        public void CreateInterceptEndpointGroupResourceNames()
        {
            // Snippet: CreateInterceptEndpointGroup(LocationName, InterceptEndpointGroup, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptEndpointGroup interceptEndpointGroup = new InterceptEndpointGroup();
            string interceptEndpointGroupId = "";
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = interceptClient.CreateInterceptEndpointGroup(parent, interceptEndpointGroup, interceptEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAsync</summary>
        public async Task CreateInterceptEndpointGroupResourceNamesAsync()
        {
            // Snippet: CreateInterceptEndpointGroupAsync(LocationName, InterceptEndpointGroup, string, CallSettings)
            // Additional: CreateInterceptEndpointGroupAsync(LocationName, InterceptEndpointGroup, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptEndpointGroup interceptEndpointGroup = new InterceptEndpointGroup();
            string interceptEndpointGroupId = "";
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = await interceptClient.CreateInterceptEndpointGroupAsync(parent, interceptEndpointGroup, interceptEndpointGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroup</summary>
        public void UpdateInterceptEndpointGroupRequestObject()
        {
            // Snippet: UpdateInterceptEndpointGroup(UpdateInterceptEndpointGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            UpdateInterceptEndpointGroupRequest request = new UpdateInterceptEndpointGroupRequest
            {
                UpdateMask = new FieldMask(),
                InterceptEndpointGroup = new InterceptEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = interceptClient.UpdateInterceptEndpointGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroupAsync</summary>
        public async Task UpdateInterceptEndpointGroupRequestObjectAsync()
        {
            // Snippet: UpdateInterceptEndpointGroupAsync(UpdateInterceptEndpointGroupRequest, CallSettings)
            // Additional: UpdateInterceptEndpointGroupAsync(UpdateInterceptEndpointGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInterceptEndpointGroupRequest request = new UpdateInterceptEndpointGroupRequest
            {
                UpdateMask = new FieldMask(),
                InterceptEndpointGroup = new InterceptEndpointGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = await interceptClient.UpdateInterceptEndpointGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroup</summary>
        public void UpdateInterceptEndpointGroup()
        {
            // Snippet: UpdateInterceptEndpointGroup(InterceptEndpointGroup, FieldMask, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptEndpointGroup interceptEndpointGroup = new InterceptEndpointGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = interceptClient.UpdateInterceptEndpointGroup(interceptEndpointGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroupAsync</summary>
        public async Task UpdateInterceptEndpointGroupAsync()
        {
            // Snippet: UpdateInterceptEndpointGroupAsync(InterceptEndpointGroup, FieldMask, CallSettings)
            // Additional: UpdateInterceptEndpointGroupAsync(InterceptEndpointGroup, FieldMask, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptEndpointGroup interceptEndpointGroup = new InterceptEndpointGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptEndpointGroup, OperationMetadata> response = await interceptClient.UpdateInterceptEndpointGroupAsync(interceptEndpointGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroup</summary>
        public void DeleteInterceptEndpointGroupRequestObject()
        {
            // Snippet: DeleteInterceptEndpointGroup(DeleteInterceptEndpointGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            DeleteInterceptEndpointGroupRequest request = new DeleteInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptEndpointGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAsync</summary>
        public async Task DeleteInterceptEndpointGroupRequestObjectAsync()
        {
            // Snippet: DeleteInterceptEndpointGroupAsync(DeleteInterceptEndpointGroupRequest, CallSettings)
            // Additional: DeleteInterceptEndpointGroupAsync(DeleteInterceptEndpointGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterceptEndpointGroupRequest request = new DeleteInterceptEndpointGroupRequest
            {
                InterceptEndpointGroupName = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptEndpointGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroup</summary>
        public void DeleteInterceptEndpointGroup()
        {
            // Snippet: DeleteInterceptEndpointGroup(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroups/[INTERCEPT_ENDPOINT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptEndpointGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAsync</summary>
        public async Task DeleteInterceptEndpointGroupAsync()
        {
            // Snippet: DeleteInterceptEndpointGroupAsync(string, CallSettings)
            // Additional: DeleteInterceptEndpointGroupAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroups/[INTERCEPT_ENDPOINT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptEndpointGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroup</summary>
        public void DeleteInterceptEndpointGroupResourceNames()
        {
            // Snippet: DeleteInterceptEndpointGroup(InterceptEndpointGroupName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptEndpointGroupName name = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptEndpointGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptEndpointGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAsync</summary>
        public async Task DeleteInterceptEndpointGroupResourceNamesAsync()
        {
            // Snippet: DeleteInterceptEndpointGroupAsync(InterceptEndpointGroupName, CallSettings)
            // Additional: DeleteInterceptEndpointGroupAsync(InterceptEndpointGroupName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptEndpointGroupName name = InterceptEndpointGroupName.FromProjectLocationInterceptEndpointGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptEndpointGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptEndpointGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupAssociations</summary>
        public void ListInterceptEndpointGroupAssociationsRequestObject()
        {
            // Snippet: ListInterceptEndpointGroupAssociations(ListInterceptEndpointGroupAssociationsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            ListInterceptEndpointGroupAssociationsRequest request = new ListInterceptEndpointGroupAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> response = interceptClient.ListInterceptEndpointGroupAssociations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroupAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupAssociationsAsync</summary>
        public async Task ListInterceptEndpointGroupAssociationsRequestObjectAsync()
        {
            // Snippet: ListInterceptEndpointGroupAssociationsAsync(ListInterceptEndpointGroupAssociationsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            ListInterceptEndpointGroupAssociationsRequest request = new ListInterceptEndpointGroupAssociationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> response = interceptClient.ListInterceptEndpointGroupAssociationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroupAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupAssociations</summary>
        public void ListInterceptEndpointGroupAssociations()
        {
            // Snippet: ListInterceptEndpointGroupAssociations(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> response = interceptClient.ListInterceptEndpointGroupAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroupAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupAssociationsAsync</summary>
        public async Task ListInterceptEndpointGroupAssociationsAsync()
        {
            // Snippet: ListInterceptEndpointGroupAssociationsAsync(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> response = interceptClient.ListInterceptEndpointGroupAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroupAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupAssociations</summary>
        public void ListInterceptEndpointGroupAssociationsResourceNames()
        {
            // Snippet: ListInterceptEndpointGroupAssociations(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> response = interceptClient.ListInterceptEndpointGroupAssociations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroupAssociation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptEndpointGroupAssociationsAsync</summary>
        public async Task ListInterceptEndpointGroupAssociationsResourceNamesAsync()
        {
            // Snippet: ListInterceptEndpointGroupAssociationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInterceptEndpointGroupAssociationsResponse, InterceptEndpointGroupAssociation> response = interceptClient.ListInterceptEndpointGroupAssociationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptEndpointGroupAssociation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptEndpointGroupAssociationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptEndpointGroupAssociation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptEndpointGroupAssociation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptEndpointGroupAssociation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAssociation</summary>
        public void GetInterceptEndpointGroupAssociationRequestObject()
        {
            // Snippet: GetInterceptEndpointGroupAssociation(GetInterceptEndpointGroupAssociationRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            GetInterceptEndpointGroupAssociationRequest request = new GetInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]"),
            };
            // Make the request
            InterceptEndpointGroupAssociation response = interceptClient.GetInterceptEndpointGroupAssociation(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAssociationAsync</summary>
        public async Task GetInterceptEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: GetInterceptEndpointGroupAssociationAsync(GetInterceptEndpointGroupAssociationRequest, CallSettings)
            // Additional: GetInterceptEndpointGroupAssociationAsync(GetInterceptEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            GetInterceptEndpointGroupAssociationRequest request = new GetInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]"),
            };
            // Make the request
            InterceptEndpointGroupAssociation response = await interceptClient.GetInterceptEndpointGroupAssociationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAssociation</summary>
        public void GetInterceptEndpointGroupAssociation()
        {
            // Snippet: GetInterceptEndpointGroupAssociation(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroupAssociations/[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            InterceptEndpointGroupAssociation response = interceptClient.GetInterceptEndpointGroupAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAssociationAsync</summary>
        public async Task GetInterceptEndpointGroupAssociationAsync()
        {
            // Snippet: GetInterceptEndpointGroupAssociationAsync(string, CallSettings)
            // Additional: GetInterceptEndpointGroupAssociationAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroupAssociations/[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            InterceptEndpointGroupAssociation response = await interceptClient.GetInterceptEndpointGroupAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAssociation</summary>
        public void GetInterceptEndpointGroupAssociationResourceNames()
        {
            // Snippet: GetInterceptEndpointGroupAssociation(InterceptEndpointGroupAssociationName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptEndpointGroupAssociationName name = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            InterceptEndpointGroupAssociation response = interceptClient.GetInterceptEndpointGroupAssociation(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptEndpointGroupAssociationAsync</summary>
        public async Task GetInterceptEndpointGroupAssociationResourceNamesAsync()
        {
            // Snippet: GetInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName, CallSettings)
            // Additional: GetInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptEndpointGroupAssociationName name = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            InterceptEndpointGroupAssociation response = await interceptClient.GetInterceptEndpointGroupAssociationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAssociation</summary>
        public void CreateInterceptEndpointGroupAssociationRequestObject()
        {
            // Snippet: CreateInterceptEndpointGroupAssociation(CreateInterceptEndpointGroupAssociationRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            CreateInterceptEndpointGroupAssociationRequest request = new CreateInterceptEndpointGroupAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptEndpointGroupAssociationId = "",
                InterceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = interceptClient.CreateInterceptEndpointGroupAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAssociationAsync</summary>
        public async Task CreateInterceptEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: CreateInterceptEndpointGroupAssociationAsync(CreateInterceptEndpointGroupAssociationRequest, CallSettings)
            // Additional: CreateInterceptEndpointGroupAssociationAsync(CreateInterceptEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            CreateInterceptEndpointGroupAssociationRequest request = new CreateInterceptEndpointGroupAssociationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptEndpointGroupAssociationId = "",
                InterceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = await interceptClient.CreateInterceptEndpointGroupAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAssociation</summary>
        public void CreateInterceptEndpointGroupAssociation()
        {
            // Snippet: CreateInterceptEndpointGroupAssociation(string, InterceptEndpointGroupAssociation, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptEndpointGroupAssociation interceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation();
            string interceptEndpointGroupAssociationId = "";
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = interceptClient.CreateInterceptEndpointGroupAssociation(parent, interceptEndpointGroupAssociation, interceptEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAssociationAsync</summary>
        public async Task CreateInterceptEndpointGroupAssociationAsync()
        {
            // Snippet: CreateInterceptEndpointGroupAssociationAsync(string, InterceptEndpointGroupAssociation, string, CallSettings)
            // Additional: CreateInterceptEndpointGroupAssociationAsync(string, InterceptEndpointGroupAssociation, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptEndpointGroupAssociation interceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation();
            string interceptEndpointGroupAssociationId = "";
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = await interceptClient.CreateInterceptEndpointGroupAssociationAsync(parent, interceptEndpointGroupAssociation, interceptEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAssociation</summary>
        public void CreateInterceptEndpointGroupAssociationResourceNames()
        {
            // Snippet: CreateInterceptEndpointGroupAssociation(LocationName, InterceptEndpointGroupAssociation, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptEndpointGroupAssociation interceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation();
            string interceptEndpointGroupAssociationId = "";
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = interceptClient.CreateInterceptEndpointGroupAssociation(parent, interceptEndpointGroupAssociation, interceptEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptEndpointGroupAssociationAsync</summary>
        public async Task CreateInterceptEndpointGroupAssociationResourceNamesAsync()
        {
            // Snippet: CreateInterceptEndpointGroupAssociationAsync(LocationName, InterceptEndpointGroupAssociation, string, CallSettings)
            // Additional: CreateInterceptEndpointGroupAssociationAsync(LocationName, InterceptEndpointGroupAssociation, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptEndpointGroupAssociation interceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation();
            string interceptEndpointGroupAssociationId = "";
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = await interceptClient.CreateInterceptEndpointGroupAssociationAsync(parent, interceptEndpointGroupAssociation, interceptEndpointGroupAssociationId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroupAssociation</summary>
        public void UpdateInterceptEndpointGroupAssociationRequestObject()
        {
            // Snippet: UpdateInterceptEndpointGroupAssociation(UpdateInterceptEndpointGroupAssociationRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            UpdateInterceptEndpointGroupAssociationRequest request = new UpdateInterceptEndpointGroupAssociationRequest
            {
                UpdateMask = new FieldMask(),
                InterceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = interceptClient.UpdateInterceptEndpointGroupAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroupAssociationAsync</summary>
        public async Task UpdateInterceptEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: UpdateInterceptEndpointGroupAssociationAsync(UpdateInterceptEndpointGroupAssociationRequest, CallSettings)
            // Additional: UpdateInterceptEndpointGroupAssociationAsync(UpdateInterceptEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInterceptEndpointGroupAssociationRequest request = new UpdateInterceptEndpointGroupAssociationRequest
            {
                UpdateMask = new FieldMask(),
                InterceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = await interceptClient.UpdateInterceptEndpointGroupAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroupAssociation</summary>
        public void UpdateInterceptEndpointGroupAssociation()
        {
            // Snippet: UpdateInterceptEndpointGroupAssociation(InterceptEndpointGroupAssociation, FieldMask, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptEndpointGroupAssociation interceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = interceptClient.UpdateInterceptEndpointGroupAssociation(interceptEndpointGroupAssociation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptEndpointGroupAssociationAsync</summary>
        public async Task UpdateInterceptEndpointGroupAssociationAsync()
        {
            // Snippet: UpdateInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociation, FieldMask, CallSettings)
            // Additional: UpdateInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociation, FieldMask, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptEndpointGroupAssociation interceptEndpointGroupAssociation = new InterceptEndpointGroupAssociation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> response = await interceptClient.UpdateInterceptEndpointGroupAssociationAsync(interceptEndpointGroupAssociation, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptEndpointGroupAssociation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptEndpointGroupAssociation, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptEndpointGroupAssociation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAssociation</summary>
        public void DeleteInterceptEndpointGroupAssociationRequestObject()
        {
            // Snippet: DeleteInterceptEndpointGroupAssociation(DeleteInterceptEndpointGroupAssociationRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            DeleteInterceptEndpointGroupAssociationRequest request = new DeleteInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptEndpointGroupAssociation(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAssociationAsync</summary>
        public async Task DeleteInterceptEndpointGroupAssociationRequestObjectAsync()
        {
            // Snippet: DeleteInterceptEndpointGroupAssociationAsync(DeleteInterceptEndpointGroupAssociationRequest, CallSettings)
            // Additional: DeleteInterceptEndpointGroupAssociationAsync(DeleteInterceptEndpointGroupAssociationRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterceptEndpointGroupAssociationRequest request = new DeleteInterceptEndpointGroupAssociationRequest
            {
                InterceptEndpointGroupAssociationName = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptEndpointGroupAssociationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAssociation</summary>
        public void DeleteInterceptEndpointGroupAssociation()
        {
            // Snippet: DeleteInterceptEndpointGroupAssociation(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroupAssociations/[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptEndpointGroupAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAssociationAsync</summary>
        public async Task DeleteInterceptEndpointGroupAssociationAsync()
        {
            // Snippet: DeleteInterceptEndpointGroupAssociationAsync(string, CallSettings)
            // Additional: DeleteInterceptEndpointGroupAssociationAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptEndpointGroupAssociations/[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptEndpointGroupAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAssociation</summary>
        public void DeleteInterceptEndpointGroupAssociationResourceNames()
        {
            // Snippet: DeleteInterceptEndpointGroupAssociation(InterceptEndpointGroupAssociationName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptEndpointGroupAssociationName name = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptEndpointGroupAssociation(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptEndpointGroupAssociation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptEndpointGroupAssociationAsync</summary>
        public async Task DeleteInterceptEndpointGroupAssociationResourceNamesAsync()
        {
            // Snippet: DeleteInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName, CallSettings)
            // Additional: DeleteInterceptEndpointGroupAssociationAsync(InterceptEndpointGroupAssociationName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptEndpointGroupAssociationName name = InterceptEndpointGroupAssociationName.FromProjectLocationInterceptEndpointGroupAssociation("[PROJECT]", "[LOCATION]", "[INTERCEPT_ENDPOINT_GROUP_ASSOCIATION]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptEndpointGroupAssociationAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptEndpointGroupAssociationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentGroups</summary>
        public void ListInterceptDeploymentGroupsRequestObject()
        {
            // Snippet: ListInterceptDeploymentGroups(ListInterceptDeploymentGroupsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            ListInterceptDeploymentGroupsRequest request = new ListInterceptDeploymentGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> response = interceptClient.ListInterceptDeploymentGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentGroupsAsync</summary>
        public async Task ListInterceptDeploymentGroupsRequestObjectAsync()
        {
            // Snippet: ListInterceptDeploymentGroupsAsync(ListInterceptDeploymentGroupsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            ListInterceptDeploymentGroupsRequest request = new ListInterceptDeploymentGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> response = interceptClient.ListInterceptDeploymentGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentGroups</summary>
        public void ListInterceptDeploymentGroups()
        {
            // Snippet: ListInterceptDeploymentGroups(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> response = interceptClient.ListInterceptDeploymentGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentGroupsAsync</summary>
        public async Task ListInterceptDeploymentGroupsAsync()
        {
            // Snippet: ListInterceptDeploymentGroupsAsync(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> response = interceptClient.ListInterceptDeploymentGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentGroups</summary>
        public void ListInterceptDeploymentGroupsResourceNames()
        {
            // Snippet: ListInterceptDeploymentGroups(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> response = interceptClient.ListInterceptDeploymentGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeploymentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentGroupsAsync</summary>
        public async Task ListInterceptDeploymentGroupsResourceNamesAsync()
        {
            // Snippet: ListInterceptDeploymentGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInterceptDeploymentGroupsResponse, InterceptDeploymentGroup> response = interceptClient.ListInterceptDeploymentGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptDeploymentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptDeploymentGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeploymentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeploymentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeploymentGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentGroup</summary>
        public void GetInterceptDeploymentGroupRequestObject()
        {
            // Snippet: GetInterceptDeploymentGroup(GetInterceptDeploymentGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            GetInterceptDeploymentGroupRequest request = new GetInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]"),
            };
            // Make the request
            InterceptDeploymentGroup response = interceptClient.GetInterceptDeploymentGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentGroupAsync</summary>
        public async Task GetInterceptDeploymentGroupRequestObjectAsync()
        {
            // Snippet: GetInterceptDeploymentGroupAsync(GetInterceptDeploymentGroupRequest, CallSettings)
            // Additional: GetInterceptDeploymentGroupAsync(GetInterceptDeploymentGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            GetInterceptDeploymentGroupRequest request = new GetInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]"),
            };
            // Make the request
            InterceptDeploymentGroup response = await interceptClient.GetInterceptDeploymentGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentGroup</summary>
        public void GetInterceptDeploymentGroup()
        {
            // Snippet: GetInterceptDeploymentGroup(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeploymentGroups/[INTERCEPT_DEPLOYMENT_GROUP]";
            // Make the request
            InterceptDeploymentGroup response = interceptClient.GetInterceptDeploymentGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentGroupAsync</summary>
        public async Task GetInterceptDeploymentGroupAsync()
        {
            // Snippet: GetInterceptDeploymentGroupAsync(string, CallSettings)
            // Additional: GetInterceptDeploymentGroupAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeploymentGroups/[INTERCEPT_DEPLOYMENT_GROUP]";
            // Make the request
            InterceptDeploymentGroup response = await interceptClient.GetInterceptDeploymentGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentGroup</summary>
        public void GetInterceptDeploymentGroupResourceNames()
        {
            // Snippet: GetInterceptDeploymentGroup(InterceptDeploymentGroupName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptDeploymentGroupName name = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]");
            // Make the request
            InterceptDeploymentGroup response = interceptClient.GetInterceptDeploymentGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentGroupAsync</summary>
        public async Task GetInterceptDeploymentGroupResourceNamesAsync()
        {
            // Snippet: GetInterceptDeploymentGroupAsync(InterceptDeploymentGroupName, CallSettings)
            // Additional: GetInterceptDeploymentGroupAsync(InterceptDeploymentGroupName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptDeploymentGroupName name = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]");
            // Make the request
            InterceptDeploymentGroup response = await interceptClient.GetInterceptDeploymentGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentGroup</summary>
        public void CreateInterceptDeploymentGroupRequestObject()
        {
            // Snippet: CreateInterceptDeploymentGroup(CreateInterceptDeploymentGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            CreateInterceptDeploymentGroupRequest request = new CreateInterceptDeploymentGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptDeploymentGroupId = "",
                InterceptDeploymentGroup = new InterceptDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = interceptClient.CreateInterceptDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentGroupAsync</summary>
        public async Task CreateInterceptDeploymentGroupRequestObjectAsync()
        {
            // Snippet: CreateInterceptDeploymentGroupAsync(CreateInterceptDeploymentGroupRequest, CallSettings)
            // Additional: CreateInterceptDeploymentGroupAsync(CreateInterceptDeploymentGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            CreateInterceptDeploymentGroupRequest request = new CreateInterceptDeploymentGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptDeploymentGroupId = "",
                InterceptDeploymentGroup = new InterceptDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = await interceptClient.CreateInterceptDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentGroup</summary>
        public void CreateInterceptDeploymentGroup()
        {
            // Snippet: CreateInterceptDeploymentGroup(string, InterceptDeploymentGroup, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptDeploymentGroup interceptDeploymentGroup = new InterceptDeploymentGroup();
            string interceptDeploymentGroupId = "";
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = interceptClient.CreateInterceptDeploymentGroup(parent, interceptDeploymentGroup, interceptDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentGroupAsync</summary>
        public async Task CreateInterceptDeploymentGroupAsync()
        {
            // Snippet: CreateInterceptDeploymentGroupAsync(string, InterceptDeploymentGroup, string, CallSettings)
            // Additional: CreateInterceptDeploymentGroupAsync(string, InterceptDeploymentGroup, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptDeploymentGroup interceptDeploymentGroup = new InterceptDeploymentGroup();
            string interceptDeploymentGroupId = "";
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = await interceptClient.CreateInterceptDeploymentGroupAsync(parent, interceptDeploymentGroup, interceptDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentGroup</summary>
        public void CreateInterceptDeploymentGroupResourceNames()
        {
            // Snippet: CreateInterceptDeploymentGroup(LocationName, InterceptDeploymentGroup, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptDeploymentGroup interceptDeploymentGroup = new InterceptDeploymentGroup();
            string interceptDeploymentGroupId = "";
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = interceptClient.CreateInterceptDeploymentGroup(parent, interceptDeploymentGroup, interceptDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentGroupAsync</summary>
        public async Task CreateInterceptDeploymentGroupResourceNamesAsync()
        {
            // Snippet: CreateInterceptDeploymentGroupAsync(LocationName, InterceptDeploymentGroup, string, CallSettings)
            // Additional: CreateInterceptDeploymentGroupAsync(LocationName, InterceptDeploymentGroup, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptDeploymentGroup interceptDeploymentGroup = new InterceptDeploymentGroup();
            string interceptDeploymentGroupId = "";
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = await interceptClient.CreateInterceptDeploymentGroupAsync(parent, interceptDeploymentGroup, interceptDeploymentGroupId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeploymentGroup</summary>
        public void UpdateInterceptDeploymentGroupRequestObject()
        {
            // Snippet: UpdateInterceptDeploymentGroup(UpdateInterceptDeploymentGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            UpdateInterceptDeploymentGroupRequest request = new UpdateInterceptDeploymentGroupRequest
            {
                UpdateMask = new FieldMask(),
                InterceptDeploymentGroup = new InterceptDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = interceptClient.UpdateInterceptDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeploymentGroupAsync</summary>
        public async Task UpdateInterceptDeploymentGroupRequestObjectAsync()
        {
            // Snippet: UpdateInterceptDeploymentGroupAsync(UpdateInterceptDeploymentGroupRequest, CallSettings)
            // Additional: UpdateInterceptDeploymentGroupAsync(UpdateInterceptDeploymentGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInterceptDeploymentGroupRequest request = new UpdateInterceptDeploymentGroupRequest
            {
                UpdateMask = new FieldMask(),
                InterceptDeploymentGroup = new InterceptDeploymentGroup(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = await interceptClient.UpdateInterceptDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeploymentGroup</summary>
        public void UpdateInterceptDeploymentGroup()
        {
            // Snippet: UpdateInterceptDeploymentGroup(InterceptDeploymentGroup, FieldMask, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptDeploymentGroup interceptDeploymentGroup = new InterceptDeploymentGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = interceptClient.UpdateInterceptDeploymentGroup(interceptDeploymentGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeploymentGroupAsync</summary>
        public async Task UpdateInterceptDeploymentGroupAsync()
        {
            // Snippet: UpdateInterceptDeploymentGroupAsync(InterceptDeploymentGroup, FieldMask, CallSettings)
            // Additional: UpdateInterceptDeploymentGroupAsync(InterceptDeploymentGroup, FieldMask, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptDeploymentGroup interceptDeploymentGroup = new InterceptDeploymentGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptDeploymentGroup, OperationMetadata> response = await interceptClient.UpdateInterceptDeploymentGroupAsync(interceptDeploymentGroup, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeploymentGroup, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeploymentGroup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeploymentGroup, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeploymentGroup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentGroup</summary>
        public void DeleteInterceptDeploymentGroupRequestObject()
        {
            // Snippet: DeleteInterceptDeploymentGroup(DeleteInterceptDeploymentGroupRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            DeleteInterceptDeploymentGroupRequest request = new DeleteInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptDeploymentGroup(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentGroupAsync</summary>
        public async Task DeleteInterceptDeploymentGroupRequestObjectAsync()
        {
            // Snippet: DeleteInterceptDeploymentGroupAsync(DeleteInterceptDeploymentGroupRequest, CallSettings)
            // Additional: DeleteInterceptDeploymentGroupAsync(DeleteInterceptDeploymentGroupRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterceptDeploymentGroupRequest request = new DeleteInterceptDeploymentGroupRequest
            {
                InterceptDeploymentGroupName = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptDeploymentGroupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentGroup</summary>
        public void DeleteInterceptDeploymentGroup()
        {
            // Snippet: DeleteInterceptDeploymentGroup(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeploymentGroups/[INTERCEPT_DEPLOYMENT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentGroupAsync</summary>
        public async Task DeleteInterceptDeploymentGroupAsync()
        {
            // Snippet: DeleteInterceptDeploymentGroupAsync(string, CallSettings)
            // Additional: DeleteInterceptDeploymentGroupAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeploymentGroups/[INTERCEPT_DEPLOYMENT_GROUP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentGroup</summary>
        public void DeleteInterceptDeploymentGroupResourceNames()
        {
            // Snippet: DeleteInterceptDeploymentGroup(InterceptDeploymentGroupName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptDeploymentGroupName name = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptDeploymentGroup(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptDeploymentGroup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentGroupAsync</summary>
        public async Task DeleteInterceptDeploymentGroupResourceNamesAsync()
        {
            // Snippet: DeleteInterceptDeploymentGroupAsync(InterceptDeploymentGroupName, CallSettings)
            // Additional: DeleteInterceptDeploymentGroupAsync(InterceptDeploymentGroupName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptDeploymentGroupName name = InterceptDeploymentGroupName.FromProjectLocationInterceptDeploymentGroup("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT_GROUP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptDeploymentGroupAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptDeploymentGroupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeployments</summary>
        public void ListInterceptDeploymentsRequestObject()
        {
            // Snippet: ListInterceptDeployments(ListInterceptDeploymentsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            ListInterceptDeploymentsRequest request = new ListInterceptDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> response = interceptClient.ListInterceptDeployments(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentsAsync</summary>
        public async Task ListInterceptDeploymentsRequestObjectAsync()
        {
            // Snippet: ListInterceptDeploymentsAsync(ListInterceptDeploymentsRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            ListInterceptDeploymentsRequest request = new ListInterceptDeploymentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> response = interceptClient.ListInterceptDeploymentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeployments</summary>
        public void ListInterceptDeployments()
        {
            // Snippet: ListInterceptDeployments(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> response = interceptClient.ListInterceptDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentsAsync</summary>
        public async Task ListInterceptDeploymentsAsync()
        {
            // Snippet: ListInterceptDeploymentsAsync(string, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> response = interceptClient.ListInterceptDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeployments</summary>
        public void ListInterceptDeploymentsResourceNames()
        {
            // Snippet: ListInterceptDeployments(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> response = interceptClient.ListInterceptDeployments(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterceptDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListInterceptDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeployment> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInterceptDeploymentsAsync</summary>
        public async Task ListInterceptDeploymentsResourceNamesAsync()
        {
            // Snippet: ListInterceptDeploymentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListInterceptDeploymentsResponse, InterceptDeployment> response = interceptClient.ListInterceptDeploymentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (InterceptDeployment item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListInterceptDeploymentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterceptDeployment item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterceptDeployment> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterceptDeployment item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeployment</summary>
        public void GetInterceptDeploymentRequestObject()
        {
            // Snippet: GetInterceptDeployment(GetInterceptDeploymentRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            GetInterceptDeploymentRequest request = new GetInterceptDeploymentRequest
            {
                InterceptDeploymentName = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]"),
            };
            // Make the request
            InterceptDeployment response = interceptClient.GetInterceptDeployment(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentAsync</summary>
        public async Task GetInterceptDeploymentRequestObjectAsync()
        {
            // Snippet: GetInterceptDeploymentAsync(GetInterceptDeploymentRequest, CallSettings)
            // Additional: GetInterceptDeploymentAsync(GetInterceptDeploymentRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            GetInterceptDeploymentRequest request = new GetInterceptDeploymentRequest
            {
                InterceptDeploymentName = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]"),
            };
            // Make the request
            InterceptDeployment response = await interceptClient.GetInterceptDeploymentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeployment</summary>
        public void GetInterceptDeployment()
        {
            // Snippet: GetInterceptDeployment(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeployments/[INTERCEPT_DEPLOYMENT]";
            // Make the request
            InterceptDeployment response = interceptClient.GetInterceptDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentAsync</summary>
        public async Task GetInterceptDeploymentAsync()
        {
            // Snippet: GetInterceptDeploymentAsync(string, CallSettings)
            // Additional: GetInterceptDeploymentAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeployments/[INTERCEPT_DEPLOYMENT]";
            // Make the request
            InterceptDeployment response = await interceptClient.GetInterceptDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeployment</summary>
        public void GetInterceptDeploymentResourceNames()
        {
            // Snippet: GetInterceptDeployment(InterceptDeploymentName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptDeploymentName name = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]");
            // Make the request
            InterceptDeployment response = interceptClient.GetInterceptDeployment(name);
            // End snippet
        }

        /// <summary>Snippet for GetInterceptDeploymentAsync</summary>
        public async Task GetInterceptDeploymentResourceNamesAsync()
        {
            // Snippet: GetInterceptDeploymentAsync(InterceptDeploymentName, CallSettings)
            // Additional: GetInterceptDeploymentAsync(InterceptDeploymentName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptDeploymentName name = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]");
            // Make the request
            InterceptDeployment response = await interceptClient.GetInterceptDeploymentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeployment</summary>
        public void CreateInterceptDeploymentRequestObject()
        {
            // Snippet: CreateInterceptDeployment(CreateInterceptDeploymentRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            CreateInterceptDeploymentRequest request = new CreateInterceptDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptDeploymentId = "",
                InterceptDeployment = new InterceptDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = interceptClient.CreateInterceptDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentAsync</summary>
        public async Task CreateInterceptDeploymentRequestObjectAsync()
        {
            // Snippet: CreateInterceptDeploymentAsync(CreateInterceptDeploymentRequest, CallSettings)
            // Additional: CreateInterceptDeploymentAsync(CreateInterceptDeploymentRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            CreateInterceptDeploymentRequest request = new CreateInterceptDeploymentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                InterceptDeploymentId = "",
                InterceptDeployment = new InterceptDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = await interceptClient.CreateInterceptDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeployment</summary>
        public void CreateInterceptDeployment()
        {
            // Snippet: CreateInterceptDeployment(string, InterceptDeployment, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptDeployment interceptDeployment = new InterceptDeployment();
            string interceptDeploymentId = "";
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = interceptClient.CreateInterceptDeployment(parent, interceptDeployment, interceptDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentAsync</summary>
        public async Task CreateInterceptDeploymentAsync()
        {
            // Snippet: CreateInterceptDeploymentAsync(string, InterceptDeployment, string, CallSettings)
            // Additional: CreateInterceptDeploymentAsync(string, InterceptDeployment, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            InterceptDeployment interceptDeployment = new InterceptDeployment();
            string interceptDeploymentId = "";
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = await interceptClient.CreateInterceptDeploymentAsync(parent, interceptDeployment, interceptDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeployment</summary>
        public void CreateInterceptDeploymentResourceNames()
        {
            // Snippet: CreateInterceptDeployment(LocationName, InterceptDeployment, string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptDeployment interceptDeployment = new InterceptDeployment();
            string interceptDeploymentId = "";
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = interceptClient.CreateInterceptDeployment(parent, interceptDeployment, interceptDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = interceptClient.PollOnceCreateInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateInterceptDeploymentAsync</summary>
        public async Task CreateInterceptDeploymentResourceNamesAsync()
        {
            // Snippet: CreateInterceptDeploymentAsync(LocationName, InterceptDeployment, string, CallSettings)
            // Additional: CreateInterceptDeploymentAsync(LocationName, InterceptDeployment, string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            InterceptDeployment interceptDeployment = new InterceptDeployment();
            string interceptDeploymentId = "";
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = await interceptClient.CreateInterceptDeploymentAsync(parent, interceptDeployment, interceptDeploymentId);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = await interceptClient.PollOnceCreateInterceptDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeployment</summary>
        public void UpdateInterceptDeploymentRequestObject()
        {
            // Snippet: UpdateInterceptDeployment(UpdateInterceptDeploymentRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            UpdateInterceptDeploymentRequest request = new UpdateInterceptDeploymentRequest
            {
                UpdateMask = new FieldMask(),
                InterceptDeployment = new InterceptDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = interceptClient.UpdateInterceptDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeploymentAsync</summary>
        public async Task UpdateInterceptDeploymentRequestObjectAsync()
        {
            // Snippet: UpdateInterceptDeploymentAsync(UpdateInterceptDeploymentRequest, CallSettings)
            // Additional: UpdateInterceptDeploymentAsync(UpdateInterceptDeploymentRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            UpdateInterceptDeploymentRequest request = new UpdateInterceptDeploymentRequest
            {
                UpdateMask = new FieldMask(),
                InterceptDeployment = new InterceptDeployment(),
                RequestId = "",
            };
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = await interceptClient.UpdateInterceptDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeployment</summary>
        public void UpdateInterceptDeployment()
        {
            // Snippet: UpdateInterceptDeployment(InterceptDeployment, FieldMask, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptDeployment interceptDeployment = new InterceptDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = interceptClient.UpdateInterceptDeployment(interceptDeployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = interceptClient.PollOnceUpdateInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateInterceptDeploymentAsync</summary>
        public async Task UpdateInterceptDeploymentAsync()
        {
            // Snippet: UpdateInterceptDeploymentAsync(InterceptDeployment, FieldMask, CallSettings)
            // Additional: UpdateInterceptDeploymentAsync(InterceptDeployment, FieldMask, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptDeployment interceptDeployment = new InterceptDeployment();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<InterceptDeployment, OperationMetadata> response = await interceptClient.UpdateInterceptDeploymentAsync(interceptDeployment, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<InterceptDeployment, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            InterceptDeployment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<InterceptDeployment, OperationMetadata> retrievedResponse = await interceptClient.PollOnceUpdateInterceptDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                InterceptDeployment retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeployment</summary>
        public void DeleteInterceptDeploymentRequestObject()
        {
            // Snippet: DeleteInterceptDeployment(DeleteInterceptDeploymentRequest, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            DeleteInterceptDeploymentRequest request = new DeleteInterceptDeploymentRequest
            {
                InterceptDeploymentName = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptDeployment(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentAsync</summary>
        public async Task DeleteInterceptDeploymentRequestObjectAsync()
        {
            // Snippet: DeleteInterceptDeploymentAsync(DeleteInterceptDeploymentRequest, CallSettings)
            // Additional: DeleteInterceptDeploymentAsync(DeleteInterceptDeploymentRequest, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterceptDeploymentRequest request = new DeleteInterceptDeploymentRequest
            {
                InterceptDeploymentName = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptDeploymentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeployment</summary>
        public void DeleteInterceptDeployment()
        {
            // Snippet: DeleteInterceptDeployment(string, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeployments/[INTERCEPT_DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentAsync</summary>
        public async Task DeleteInterceptDeploymentAsync()
        {
            // Snippet: DeleteInterceptDeploymentAsync(string, CallSettings)
            // Additional: DeleteInterceptDeploymentAsync(string, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/interceptDeployments/[INTERCEPT_DEPLOYMENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptDeploymentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeployment</summary>
        public void DeleteInterceptDeploymentResourceNames()
        {
            // Snippet: DeleteInterceptDeployment(InterceptDeploymentName, CallSettings)
            // Create client
            InterceptClient interceptClient = InterceptClient.Create();
            // Initialize request argument(s)
            InterceptDeploymentName name = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = interceptClient.DeleteInterceptDeployment(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = interceptClient.PollOnceDeleteInterceptDeployment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteInterceptDeploymentAsync</summary>
        public async Task DeleteInterceptDeploymentResourceNamesAsync()
        {
            // Snippet: DeleteInterceptDeploymentAsync(InterceptDeploymentName, CallSettings)
            // Additional: DeleteInterceptDeploymentAsync(InterceptDeploymentName, CancellationToken)
            // Create client
            InterceptClient interceptClient = await InterceptClient.CreateAsync();
            // Initialize request argument(s)
            InterceptDeploymentName name = InterceptDeploymentName.FromProjectLocationInterceptDeployment("[PROJECT]", "[LOCATION]", "[INTERCEPT_DEPLOYMENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await interceptClient.DeleteInterceptDeploymentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await interceptClient.PollOnceDeleteInterceptDeploymentAsync(operationName);
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
