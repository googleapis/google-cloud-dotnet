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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInterconnectGroupsClientSnippets
    {
        /// <summary>Snippet for CreateMembers</summary>
        public void CreateMembersRequestObject()
        {
            // Snippet: CreateMembers(CreateMembersInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            CreateMembersInterconnectGroupRequest request = new CreateMembersInterconnectGroupRequest
            {
                Project = "",
                InterconnectGroupsCreateMembersRequestResource = new InterconnectGroupsCreateMembersRequest(),
                InterconnectGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.CreateMembers(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOnceCreateMembers(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembersAsync</summary>
        public async Task CreateMembersRequestObjectAsync()
        {
            // Snippet: CreateMembersAsync(CreateMembersInterconnectGroupRequest, CallSettings)
            // Additional: CreateMembersAsync(CreateMembersInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            CreateMembersInterconnectGroupRequest request = new CreateMembersInterconnectGroupRequest
            {
                Project = "",
                InterconnectGroupsCreateMembersRequestResource = new InterconnectGroupsCreateMembersRequest(),
                InterconnectGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.CreateMembersAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOnceCreateMembersAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembers</summary>
        public void CreateMembers()
        {
            // Snippet: CreateMembers(string, string, InterconnectGroupsCreateMembersRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            InterconnectGroupsCreateMembersRequest interconnectGroupsCreateMembersRequestResource = new InterconnectGroupsCreateMembersRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.CreateMembers(project, interconnectGroup, interconnectGroupsCreateMembersRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOnceCreateMembers(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateMembersAsync</summary>
        public async Task CreateMembersAsync()
        {
            // Snippet: CreateMembersAsync(string, string, InterconnectGroupsCreateMembersRequest, CallSettings)
            // Additional: CreateMembersAsync(string, string, InterconnectGroupsCreateMembersRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            InterconnectGroupsCreateMembersRequest interconnectGroupsCreateMembersRequestResource = new InterconnectGroupsCreateMembersRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.CreateMembersAsync(project, interconnectGroup, interconnectGroupsCreateMembersRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOnceCreateMembersAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            DeleteInterconnectGroupRequest request = new DeleteInterconnectGroupRequest
            {
                RequestId = "",
                Project = "",
                InterconnectGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(DeleteInterconnectGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterconnectGroupRequest request = new DeleteInterconnectGroupRequest
            {
                RequestId = "",
                Project = "",
                InterconnectGroup = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void Delete()
        {
            // Snippet: Delete(string, string, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.Delete(project, interconnectGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOnceDelete(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteAsync()
        {
            // Snippet: DeleteAsync(string, string, CallSettings)
            // Additional: DeleteAsync(string, string, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.DeleteAsync(project, interconnectGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOnceDeleteAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            GetInterconnectGroupRequest request = new GetInterconnectGroupRequest
            {
                Project = "",
                InterconnectGroup = "",
            };
            // Make the request
            InterconnectGroup response = interconnectGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectGroupRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectGroupRequest request = new GetInterconnectGroupRequest
            {
                Project = "",
                InterconnectGroup = "",
            };
            // Make the request
            InterconnectGroup response = await interconnectGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            // Make the request
            InterconnectGroup response = interconnectGroupsClient.Get(project, interconnectGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            // Make the request
            InterconnectGroup response = await interconnectGroupsClient.GetAsync(project, interconnectGroup);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyInterconnectGroupRequest request = new GetIamPolicyInterconnectGroupRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = interconnectGroupsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyInterconnectGroupRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyInterconnectGroupRequest request = new GetIamPolicyInterconnectGroupRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await interconnectGroupsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = interconnectGroupsClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await interconnectGroupsClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatus</summary>
        public void GetOperationalStatusRequestObject()
        {
            // Snippet: GetOperationalStatus(GetOperationalStatusInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            GetOperationalStatusInterconnectGroupRequest request = new GetOperationalStatusInterconnectGroupRequest
            {
                Project = "",
                InterconnectGroup = "",
            };
            // Make the request
            InterconnectGroupsGetOperationalStatusResponse response = interconnectGroupsClient.GetOperationalStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatusAsync</summary>
        public async Task GetOperationalStatusRequestObjectAsync()
        {
            // Snippet: GetOperationalStatusAsync(GetOperationalStatusInterconnectGroupRequest, CallSettings)
            // Additional: GetOperationalStatusAsync(GetOperationalStatusInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetOperationalStatusInterconnectGroupRequest request = new GetOperationalStatusInterconnectGroupRequest
            {
                Project = "",
                InterconnectGroup = "",
            };
            // Make the request
            InterconnectGroupsGetOperationalStatusResponse response = await interconnectGroupsClient.GetOperationalStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatus</summary>
        public void GetOperationalStatus()
        {
            // Snippet: GetOperationalStatus(string, string, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            // Make the request
            InterconnectGroupsGetOperationalStatusResponse response = interconnectGroupsClient.GetOperationalStatus(project, interconnectGroup);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatusAsync</summary>
        public async Task GetOperationalStatusAsync()
        {
            // Snippet: GetOperationalStatusAsync(string, string, CallSettings)
            // Additional: GetOperationalStatusAsync(string, string, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            // Make the request
            InterconnectGroupsGetOperationalStatusResponse response = await interconnectGroupsClient.GetOperationalStatusAsync(project, interconnectGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            InsertInterconnectGroupRequest request = new InsertInterconnectGroupRequest
            {
                RequestId = "",
                InterconnectGroupResource = new InterconnectGroup(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(InsertInterconnectGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInterconnectGroupRequest request = new InsertInterconnectGroupRequest
            {
                RequestId = "",
                InterconnectGroupResource = new InterconnectGroup(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void Insert()
        {
            // Snippet: Insert(string, InterconnectGroup, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            InterconnectGroup interconnectGroupResource = new InterconnectGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.Insert(project, interconnectGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOnceInsert(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertAsync()
        {
            // Snippet: InsertAsync(string, InterconnectGroup, CallSettings)
            // Additional: InsertAsync(string, InterconnectGroup, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            InterconnectGroup interconnectGroupResource = new InterconnectGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.InsertAsync(project, interconnectGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOnceInsertAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInterconnectGroupsRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            ListInterconnectGroupsRequest request = new ListInterconnectGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InterconnectGroupsListResponse, InterconnectGroup> response = interconnectGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectGroupsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInterconnectGroupsRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectGroupsRequest request = new ListInterconnectGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InterconnectGroupsListResponse, InterconnectGroup> response = interconnectGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectGroupsListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InterconnectGroupsListResponse, InterconnectGroup> response = interconnectGroupsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectGroupsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InterconnectGroupsListResponse, InterconnectGroup> response = interconnectGroupsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectGroupsListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(PatchInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            PatchInterconnectGroupRequest request = new PatchInterconnectGroupRequest
            {
                RequestId = "",
                InterconnectGroupResource = new InterconnectGroup(),
                Project = "",
                InterconnectGroup = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(PatchInterconnectGroupRequest, CallSettings)
            // Additional: PatchAsync(PatchInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            PatchInterconnectGroupRequest request = new PatchInterconnectGroupRequest
            {
                RequestId = "",
                InterconnectGroupResource = new InterconnectGroup(),
                Project = "",
                InterconnectGroup = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void Patch()
        {
            // Snippet: Patch(string, string, InterconnectGroup, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            InterconnectGroup interconnectGroupResource = new InterconnectGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectGroupsClient.Patch(project, interconnectGroup, interconnectGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectGroupsClient.PollOncePatch(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchAsync()
        {
            // Snippet: PatchAsync(string, string, InterconnectGroup, CallSettings)
            // Additional: PatchAsync(string, string, InterconnectGroup, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectGroup = "";
            InterconnectGroup interconnectGroupResource = new InterconnectGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectGroupsClient.PatchAsync(project, interconnectGroup, interconnectGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectGroupsClient.PollOncePatchAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyInterconnectGroupRequest request = new SetIamPolicyInterconnectGroupRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = interconnectGroupsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyInterconnectGroupRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyInterconnectGroupRequest request = new SetIamPolicyInterconnectGroupRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await interconnectGroupsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = interconnectGroupsClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await interconnectGroupsClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsInterconnectGroupRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsInterconnectGroupRequest request = new TestIamPermissionsInterconnectGroupRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = interconnectGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsInterconnectGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsInterconnectGroupRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsInterconnectGroupRequest request = new TestIamPermissionsInterconnectGroupRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await interconnectGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = InterconnectGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = interconnectGroupsClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            InterconnectGroupsClient interconnectGroupsClient = await InterconnectGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await interconnectGroupsClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
