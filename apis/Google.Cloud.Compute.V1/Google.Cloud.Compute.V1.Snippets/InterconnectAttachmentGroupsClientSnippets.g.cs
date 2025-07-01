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
    public sealed class AllGeneratedInterconnectAttachmentGroupsClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentGroupRequest request = new DeleteInterconnectAttachmentGroupRequest
            {
                RequestId = "",
                InterconnectAttachmentGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInterconnectAttachmentGroupRequest request = new DeleteInterconnectAttachmentGroupRequest
            {
                RequestId = "",
                InterconnectAttachmentGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentGroupsClient.PollOnceDeleteAsync(operationName);
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
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentGroupsClient.Delete(project, interconnectAttachmentGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentGroupsClient.PollOnceDelete(operationName);
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
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentGroupsClient.DeleteAsync(project, interconnectAttachmentGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentGroupsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            GetInterconnectAttachmentGroupRequest request = new GetInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroup = "",
                Project = "",
            };
            // Make the request
            InterconnectAttachmentGroup response = interconnectAttachmentGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectAttachmentGroupRequest request = new GetInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroup = "",
                Project = "",
            };
            // Make the request
            InterconnectAttachmentGroup response = await interconnectAttachmentGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            // Make the request
            InterconnectAttachmentGroup response = interconnectAttachmentGroupsClient.Get(project, interconnectAttachmentGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            // Make the request
            InterconnectAttachmentGroup response = await interconnectAttachmentGroupsClient.GetAsync(project, interconnectAttachmentGroup);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyInterconnectAttachmentGroupRequest request = new GetIamPolicyInterconnectAttachmentGroupRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = interconnectAttachmentGroupsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyInterconnectAttachmentGroupRequest request = new GetIamPolicyInterconnectAttachmentGroupRequest
            {
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await interconnectAttachmentGroupsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = interconnectAttachmentGroupsClient.GetIamPolicy(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            // Make the request
            Policy response = await interconnectAttachmentGroupsClient.GetIamPolicyAsync(project, resource);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatus</summary>
        public void GetOperationalStatusRequestObject()
        {
            // Snippet: GetOperationalStatus(GetOperationalStatusInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            GetOperationalStatusInterconnectAttachmentGroupRequest request = new GetOperationalStatusInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroup = "",
                Project = "",
            };
            // Make the request
            InterconnectAttachmentGroupsGetOperationalStatusResponse response = interconnectAttachmentGroupsClient.GetOperationalStatus(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatusAsync</summary>
        public async Task GetOperationalStatusRequestObjectAsync()
        {
            // Snippet: GetOperationalStatusAsync(GetOperationalStatusInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: GetOperationalStatusAsync(GetOperationalStatusInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetOperationalStatusInterconnectAttachmentGroupRequest request = new GetOperationalStatusInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroup = "",
                Project = "",
            };
            // Make the request
            InterconnectAttachmentGroupsGetOperationalStatusResponse response = await interconnectAttachmentGroupsClient.GetOperationalStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatus</summary>
        public void GetOperationalStatus()
        {
            // Snippet: GetOperationalStatus(string, string, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            // Make the request
            InterconnectAttachmentGroupsGetOperationalStatusResponse response = interconnectAttachmentGroupsClient.GetOperationalStatus(project, interconnectAttachmentGroup);
            // End snippet
        }

        /// <summary>Snippet for GetOperationalStatusAsync</summary>
        public async Task GetOperationalStatusAsync()
        {
            // Snippet: GetOperationalStatusAsync(string, string, CallSettings)
            // Additional: GetOperationalStatusAsync(string, string, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            // Make the request
            InterconnectAttachmentGroupsGetOperationalStatusResponse response = await interconnectAttachmentGroupsClient.GetOperationalStatusAsync(project, interconnectAttachmentGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            InsertInterconnectAttachmentGroupRequest request = new InsertInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroupResource = new InterconnectAttachmentGroup(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInterconnectAttachmentGroupRequest request = new InsertInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroupResource = new InterconnectAttachmentGroup(),
                RequestId = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, InterconnectAttachmentGroup, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            InterconnectAttachmentGroup interconnectAttachmentGroupResource = new InterconnectAttachmentGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentGroupsClient.Insert(project, interconnectAttachmentGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, InterconnectAttachmentGroup, CallSettings)
            // Additional: InsertAsync(string, InterconnectAttachmentGroup, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            InterconnectAttachmentGroup interconnectAttachmentGroupResource = new InterconnectAttachmentGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentGroupsClient.InsertAsync(project, interconnectAttachmentGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListInterconnectAttachmentGroupsRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            ListInterconnectAttachmentGroupsRequest request = new ListInterconnectAttachmentGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InterconnectAttachmentGroupsListResponse, InterconnectAttachmentGroup> response = interconnectAttachmentGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectAttachmentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectAttachmentGroupsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachmentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachmentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachmentGroup item in singlePage)
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
            // Snippet: ListAsync(ListInterconnectAttachmentGroupsRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectAttachmentGroupsRequest request = new ListInterconnectAttachmentGroupsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InterconnectAttachmentGroupsListResponse, InterconnectAttachmentGroup> response = interconnectAttachmentGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectAttachmentGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectAttachmentGroupsListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachmentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachmentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachmentGroup item in singlePage)
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
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InterconnectAttachmentGroupsListResponse, InterconnectAttachmentGroup> response = interconnectAttachmentGroupsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectAttachmentGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectAttachmentGroupsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachmentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachmentGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachmentGroup item in singlePage)
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
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InterconnectAttachmentGroupsListResponse, InterconnectAttachmentGroup> response = interconnectAttachmentGroupsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectAttachmentGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectAttachmentGroupsListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectAttachmentGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectAttachmentGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectAttachmentGroup item in singlePage)
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
            // Snippet: Patch(PatchInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            PatchInterconnectAttachmentGroupRequest request = new PatchInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroupResource = new InterconnectAttachmentGroup(),
                RequestId = "",
                InterconnectAttachmentGroup = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentGroupsClient.Patch(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentGroupsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(PatchInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: PatchAsync(PatchInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            PatchInterconnectAttachmentGroupRequest request = new PatchInterconnectAttachmentGroupRequest
            {
                InterconnectAttachmentGroupResource = new InterconnectAttachmentGroup(),
                RequestId = "",
                InterconnectAttachmentGroup = "",
                Project = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentGroupsClient.PatchAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentGroupsClient.PollOncePatchAsync(operationName);
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
            // Snippet: Patch(string, string, InterconnectAttachmentGroup, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            InterconnectAttachmentGroup interconnectAttachmentGroupResource = new InterconnectAttachmentGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = interconnectAttachmentGroupsClient.Patch(project, interconnectAttachmentGroup, interconnectAttachmentGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = interconnectAttachmentGroupsClient.PollOncePatch(operationName);
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
            // Snippet: PatchAsync(string, string, InterconnectAttachmentGroup, CallSettings)
            // Additional: PatchAsync(string, string, InterconnectAttachmentGroup, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectAttachmentGroup = "";
            InterconnectAttachmentGroup interconnectAttachmentGroupResource = new InterconnectAttachmentGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await interconnectAttachmentGroupsClient.PatchAsync(project, interconnectAttachmentGroup, interconnectAttachmentGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await interconnectAttachmentGroupsClient.PollOncePatchAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyInterconnectAttachmentGroupRequest request = new SetIamPolicyInterconnectAttachmentGroupRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = interconnectAttachmentGroupsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyInterconnectAttachmentGroupRequest request = new SetIamPolicyInterconnectAttachmentGroupRequest
            {
                Resource = "",
                Project = "",
                GlobalSetPolicyRequestResource = new GlobalSetPolicyRequest(),
            };
            // Make the request
            Policy response = await interconnectAttachmentGroupsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, GlobalSetPolicyRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = interconnectAttachmentGroupsClient.SetIamPolicy(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, GlobalSetPolicyRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            GlobalSetPolicyRequest globalSetPolicyRequestResource = new GlobalSetPolicyRequest();
            // Make the request
            Policy response = await interconnectAttachmentGroupsClient.SetIamPolicyAsync(project, resource, globalSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsInterconnectAttachmentGroupRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsInterconnectAttachmentGroupRequest request = new TestIamPermissionsInterconnectAttachmentGroupRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = interconnectAttachmentGroupsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsInterconnectAttachmentGroupRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsInterconnectAttachmentGroupRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsInterconnectAttachmentGroupRequest request = new TestIamPermissionsInterconnectAttachmentGroupRequest
            {
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await interconnectAttachmentGroupsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, TestPermissionsRequest, CallSettings)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = InterconnectAttachmentGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = interconnectAttachmentGroupsClient.TestIamPermissions(project, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            InterconnectAttachmentGroupsClient interconnectAttachmentGroupsClient = await InterconnectAttachmentGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await interconnectAttachmentGroupsClient.TestIamPermissionsAsync(project, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
