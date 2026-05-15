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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedGlobalVmExtensionPoliciesClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListGlobalVmExtensionPoliciesRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            AggregatedListGlobalVmExtensionPoliciesRequest request = new AggregatedListGlobalVmExtensionPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<VmExtensionPolicyAggregatedListResponse, KeyValuePair<string, VmExtensionPoliciesScopedList>> response = globalVmExtensionPoliciesClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VmExtensionPolicyAggregatedListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VmExtensionPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListRequestObjectAsync()
        {
            // Snippet: AggregatedListAsync(AggregatedListGlobalVmExtensionPoliciesRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListGlobalVmExtensionPoliciesRequest request = new AggregatedListGlobalVmExtensionPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<VmExtensionPolicyAggregatedListResponse, KeyValuePair<string, VmExtensionPoliciesScopedList>> response = globalVmExtensionPoliciesClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (VmExtensionPolicyAggregatedListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VmExtensionPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedList()
        {
            // Snippet: AggregatedList(string, string, int?, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<VmExtensionPolicyAggregatedListResponse, KeyValuePair<string, VmExtensionPoliciesScopedList>> response = globalVmExtensionPoliciesClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (VmExtensionPolicyAggregatedListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VmExtensionPoliciesScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AggregatedListAsync</summary>
        public async Task AggregatedListAsync()
        {
            // Snippet: AggregatedListAsync(string, string, int?, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<VmExtensionPolicyAggregatedListResponse, KeyValuePair<string, VmExtensionPoliciesScopedList>> response = globalVmExtensionPoliciesClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (VmExtensionPolicyAggregatedListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, VmExtensionPoliciesScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, VmExtensionPoliciesScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(DeleteGlobalVmExtensionPolicyRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            DeleteGlobalVmExtensionPolicyRequest request = new DeleteGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = "",
                RequestId = "",
                GlobalVmExtensionPolicyRolloutOperationRolloutInputResource = new GlobalVmExtensionPolicyRolloutOperationRolloutInput(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalVmExtensionPoliciesClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalVmExtensionPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteGlobalVmExtensionPolicyRequest, CallSettings)
            // Additional: DeleteAsync(DeleteGlobalVmExtensionPolicyRequest, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteGlobalVmExtensionPolicyRequest request = new DeleteGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = "",
                RequestId = "",
                GlobalVmExtensionPolicyRolloutOperationRolloutInputResource = new GlobalVmExtensionPolicyRolloutOperationRolloutInput(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalVmExtensionPoliciesClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalVmExtensionPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, GlobalVmExtensionPolicyRolloutOperationRolloutInput, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string globalVmExtensionPolicy = "";
            GlobalVmExtensionPolicyRolloutOperationRolloutInput globalVmExtensionPolicyRolloutOperationRolloutInputResource = new GlobalVmExtensionPolicyRolloutOperationRolloutInput();
            // Make the request
            lro::Operation<Operation, Operation> response = globalVmExtensionPoliciesClient.Delete(project, globalVmExtensionPolicy, globalVmExtensionPolicyRolloutOperationRolloutInputResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalVmExtensionPoliciesClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, GlobalVmExtensionPolicyRolloutOperationRolloutInput, CallSettings)
            // Additional: DeleteAsync(string, string, GlobalVmExtensionPolicyRolloutOperationRolloutInput, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string globalVmExtensionPolicy = "";
            GlobalVmExtensionPolicyRolloutOperationRolloutInput globalVmExtensionPolicyRolloutOperationRolloutInputResource = new GlobalVmExtensionPolicyRolloutOperationRolloutInput();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalVmExtensionPoliciesClient.DeleteAsync(project, globalVmExtensionPolicy, globalVmExtensionPolicyRolloutOperationRolloutInputResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalVmExtensionPoliciesClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetGlobalVmExtensionPolicyRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            GetGlobalVmExtensionPolicyRequest request = new GetGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = "",
                Project = "",
            };
            // Make the request
            GlobalVmExtensionPolicy response = globalVmExtensionPoliciesClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetGlobalVmExtensionPolicyRequest, CallSettings)
            // Additional: GetAsync(GetGlobalVmExtensionPolicyRequest, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            GetGlobalVmExtensionPolicyRequest request = new GetGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = "",
                Project = "",
            };
            // Make the request
            GlobalVmExtensionPolicy response = await globalVmExtensionPoliciesClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string globalVmExtensionPolicy = "";
            // Make the request
            GlobalVmExtensionPolicy response = globalVmExtensionPoliciesClient.Get(project, globalVmExtensionPolicy);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string globalVmExtensionPolicy = "";
            // Make the request
            GlobalVmExtensionPolicy response = await globalVmExtensionPoliciesClient.GetAsync(project, globalVmExtensionPolicy);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertGlobalVmExtensionPolicyRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            InsertGlobalVmExtensionPolicyRequest request = new InsertGlobalVmExtensionPolicyRequest
            {
                RequestId = "",
                GlobalVmExtensionPolicyResource = new GlobalVmExtensionPolicy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalVmExtensionPoliciesClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalVmExtensionPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertGlobalVmExtensionPolicyRequest, CallSettings)
            // Additional: InsertAsync(InsertGlobalVmExtensionPolicyRequest, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            InsertGlobalVmExtensionPolicyRequest request = new InsertGlobalVmExtensionPolicyRequest
            {
                RequestId = "",
                GlobalVmExtensionPolicyResource = new GlobalVmExtensionPolicy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalVmExtensionPoliciesClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalVmExtensionPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, GlobalVmExtensionPolicy, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            GlobalVmExtensionPolicy globalVmExtensionPolicyResource = new GlobalVmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = globalVmExtensionPoliciesClient.Insert(project, globalVmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalVmExtensionPoliciesClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, GlobalVmExtensionPolicy, CallSettings)
            // Additional: InsertAsync(string, GlobalVmExtensionPolicy, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            GlobalVmExtensionPolicy globalVmExtensionPolicyResource = new GlobalVmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalVmExtensionPoliciesClient.InsertAsync(project, globalVmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalVmExtensionPoliciesClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListGlobalVmExtensionPoliciesRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            ListGlobalVmExtensionPoliciesRequest request = new ListGlobalVmExtensionPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> response = globalVmExtensionPoliciesClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GlobalVmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GlobalVmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlobalVmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlobalVmExtensionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlobalVmExtensionPolicy item in singlePage)
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
            // Snippet: ListAsync(ListGlobalVmExtensionPoliciesRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            ListGlobalVmExtensionPoliciesRequest request = new ListGlobalVmExtensionPoliciesRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> response = globalVmExtensionPoliciesClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GlobalVmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (GlobalVmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlobalVmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlobalVmExtensionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlobalVmExtensionPolicy item in singlePage)
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
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> response = globalVmExtensionPoliciesClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (GlobalVmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (GlobalVmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlobalVmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlobalVmExtensionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlobalVmExtensionPolicy item in singlePage)
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
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<GlobalVmExtensionPolicyList, GlobalVmExtensionPolicy> response = globalVmExtensionPoliciesClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (GlobalVmExtensionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (GlobalVmExtensionPolicyList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (GlobalVmExtensionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<GlobalVmExtensionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (GlobalVmExtensionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateGlobalVmExtensionPolicyRequest, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            UpdateGlobalVmExtensionPolicyRequest request = new UpdateGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = "",
                RequestId = "",
                GlobalVmExtensionPolicyResource = new GlobalVmExtensionPolicy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = globalVmExtensionPoliciesClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalVmExtensionPoliciesClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(UpdateGlobalVmExtensionPolicyRequest, CallSettings)
            // Additional: UpdateAsync(UpdateGlobalVmExtensionPolicyRequest, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateGlobalVmExtensionPolicyRequest request = new UpdateGlobalVmExtensionPolicyRequest
            {
                GlobalVmExtensionPolicy = "",
                RequestId = "",
                GlobalVmExtensionPolicyResource = new GlobalVmExtensionPolicy(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await globalVmExtensionPoliciesClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalVmExtensionPoliciesClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void Update()
        {
            // Snippet: Update(string, string, GlobalVmExtensionPolicy, CallSettings)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = GlobalVmExtensionPoliciesClient.Create();
            // Initialize request argument(s)
            string project = "";
            string globalVmExtensionPolicy = "";
            GlobalVmExtensionPolicy globalVmExtensionPolicyResource = new GlobalVmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = globalVmExtensionPoliciesClient.Update(project, globalVmExtensionPolicy, globalVmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = globalVmExtensionPoliciesClient.PollOnceUpdate(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateAsync()
        {
            // Snippet: UpdateAsync(string, string, GlobalVmExtensionPolicy, CallSettings)
            // Additional: UpdateAsync(string, string, GlobalVmExtensionPolicy, CancellationToken)
            // Create client
            GlobalVmExtensionPoliciesClient globalVmExtensionPoliciesClient = await GlobalVmExtensionPoliciesClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string globalVmExtensionPolicy = "";
            GlobalVmExtensionPolicy globalVmExtensionPolicyResource = new GlobalVmExtensionPolicy();
            // Make the request
            lro::Operation<Operation, Operation> response = await globalVmExtensionPoliciesClient.UpdateAsync(project, globalVmExtensionPolicy, globalVmExtensionPolicyResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await globalVmExtensionPoliciesClient.PollOnceUpdateAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
