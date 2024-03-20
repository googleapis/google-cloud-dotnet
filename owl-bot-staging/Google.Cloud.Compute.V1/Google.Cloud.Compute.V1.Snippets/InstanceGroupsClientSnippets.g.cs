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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInstanceGroupsClientSnippets
    {
        /// <summary>Snippet for AddInstances</summary>
        public void AddInstancesRequestObject()
        {
            // Snippet: AddInstances(AddInstancesInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.AddInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceAddInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddInstancesAsync</summary>
        public async Task AddInstancesRequestObjectAsync()
        {
            // Snippet: AddInstancesAsync(AddInstancesInstanceGroupRequest, CallSettings)
            // Additional: AddInstancesAsync(AddInstancesInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AddInstancesInstanceGroupRequest request = new AddInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
                InstanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.AddInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceAddInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddInstances</summary>
        public void AddInstances()
        {
            // Snippet: AddInstances(string, string, string, InstanceGroupsAddInstancesRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsAddInstancesRequest instanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.AddInstances(project, zone, instanceGroup, instanceGroupsAddInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceAddInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AddInstancesAsync</summary>
        public async Task AddInstancesAsync()
        {
            // Snippet: AddInstancesAsync(string, string, string, InstanceGroupsAddInstancesRequest, CallSettings)
            // Additional: AddInstancesAsync(string, string, string, InstanceGroupsAddInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsAddInstancesRequest instanceGroupsAddInstancesRequestResource = new InstanceGroupsAddInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.AddInstancesAsync(project, zone, instanceGroup, instanceGroupsAddInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceAddInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupAggregatedList, KeyValuePair<string, InstanceGroupsScopedList>> response = instanceGroupsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InstanceGroupsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListInstanceGroupsRequest request = new AggregatedListInstanceGroupsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupAggregatedList, KeyValuePair<string, InstanceGroupsScopedList>> response = instanceGroupsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InstanceGroupsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupsScopedList> item in singlePage)
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
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InstanceGroupAggregatedList, KeyValuePair<string, InstanceGroupsScopedList>> response = instanceGroupsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InstanceGroupsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupsScopedList> item in singlePage)
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
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InstanceGroupAggregatedList, KeyValuePair<string, InstanceGroupsScopedList>> response = instanceGroupsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InstanceGroupsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstanceGroupsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstanceGroupsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstanceGroupsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteInstanceGroupRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstanceGroupRequest request = new DeleteInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Delete(string, string, string, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.Delete(project, zone, instanceGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(string, string, string, CallSettings)
            // Additional: DeleteAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.DeleteAsync(project, zone, instanceGroup);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = instanceGroupsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstanceGroupRequest, CallSettings)
            // Additional: GetAsync(GetInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            GetInstanceGroupRequest request = new GetInstanceGroupRequest
            {
                Zone = "",
                InstanceGroup = "",
                Project = "",
            };
            // Make the request
            InstanceGroup response = await instanceGroupsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = instanceGroupsClient.Get(project, zone, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            // Make the request
            InstanceGroup response = await instanceGroupsClient.GetAsync(project, zone, instanceGroup);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupResource = new InstanceGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertInstanceGroupRequest, CallSettings)
            // Additional: InsertAsync(InsertInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstanceGroupRequest request = new InsertInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstanceGroupResource = new InstanceGroup(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, InstanceGroup, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroup instanceGroupResource = new InstanceGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.Insert(project, zone, instanceGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, InstanceGroup, CallSettings)
            // Additional: InsertAsync(string, string, InstanceGroup, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstanceGroup instanceGroupResource = new InstanceGroup();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.InsertAsync(project, zone, instanceGroupResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupList, InstanceGroup> response = instanceGroupsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
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
            // Snippet: ListAsync(ListInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstanceGroupsRequest request = new ListInstanceGroupsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupList, InstanceGroup> response = instanceGroupsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
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
            // Snippet: List(string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<InstanceGroupList, InstanceGroup> response = instanceGroupsClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
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
            // Snippet: ListAsync(string, string, string, int?, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<InstanceGroupList, InstanceGroup> response = instanceGroupsClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstancesRequestObject()
        {
            // Snippet: ListInstances(ListInstancesInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "",
                InstanceGroup = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> response = instanceGroupsClient.ListInstances(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceWithNamedPorts item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupsListInstances page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesRequestObjectAsync()
        {
            // Snippet: ListInstancesAsync(ListInstancesInstanceGroupsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstancesInstanceGroupsRequest request = new ListInstancesInstanceGroupsRequest
            {
                Zone = "",
                InstanceGroup = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                InstanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest(),
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> response = instanceGroupsClient.ListInstancesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceWithNamedPorts item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupsListInstances page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstances</summary>
        public void ListInstances()
        {
            // Snippet: ListInstances(string, string, string, InstanceGroupsListInstancesRequest, string, int?, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsListInstancesRequest instanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest();
            // Make the request
            PagedEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> response = instanceGroupsClient.ListInstances(project, zone, instanceGroup, instanceGroupsListInstancesRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstanceWithNamedPorts item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstanceGroupsListInstances page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListInstancesAsync</summary>
        public async Task ListInstancesAsync()
        {
            // Snippet: ListInstancesAsync(string, string, string, InstanceGroupsListInstancesRequest, string, int?, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsListInstancesRequest instanceGroupsListInstancesRequestResource = new InstanceGroupsListInstancesRequest();
            // Make the request
            PagedAsyncEnumerable<InstanceGroupsListInstances, InstanceWithNamedPorts> response = instanceGroupsClient.ListInstancesAsync(project, zone, instanceGroup, instanceGroupsListInstancesRequestResource);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstanceWithNamedPorts item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstanceGroupsListInstances page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstanceWithNamedPorts item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstanceWithNamedPorts> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstanceWithNamedPorts item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RemoveInstances</summary>
        public void RemoveInstancesRequestObject()
        {
            // Snippet: RemoveInstances(RemoveInstancesInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.RemoveInstances(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceRemoveInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveInstancesAsync</summary>
        public async Task RemoveInstancesRequestObjectAsync()
        {
            // Snippet: RemoveInstancesAsync(RemoveInstancesInstanceGroupRequest, CallSettings)
            // Additional: RemoveInstancesAsync(RemoveInstancesInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            RemoveInstancesInstanceGroupRequest request = new RemoveInstancesInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
                InstanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.RemoveInstancesAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceRemoveInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveInstances</summary>
        public void RemoveInstances()
        {
            // Snippet: RemoveInstances(string, string, string, InstanceGroupsRemoveInstancesRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsRemoveInstancesRequest instanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.RemoveInstances(project, zone, instanceGroup, instanceGroupsRemoveInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceRemoveInstances(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RemoveInstancesAsync</summary>
        public async Task RemoveInstancesAsync()
        {
            // Snippet: RemoveInstancesAsync(string, string, string, InstanceGroupsRemoveInstancesRequest, CallSettings)
            // Additional: RemoveInstancesAsync(string, string, string, InstanceGroupsRemoveInstancesRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsRemoveInstancesRequest instanceGroupsRemoveInstancesRequestResource = new InstanceGroupsRemoveInstancesRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.RemoveInstancesAsync(project, zone, instanceGroup, instanceGroupsRemoveInstancesRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceRemoveInstancesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPortsRequestObject()
        {
            // Snippet: SetNamedPorts(SetNamedPortsInstanceGroupRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.SetNamedPorts(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceSetNamedPorts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsRequestObjectAsync()
        {
            // Snippet: SetNamedPortsAsync(SetNamedPortsInstanceGroupRequest, CallSettings)
            // Additional: SetNamedPortsAsync(SetNamedPortsInstanceGroupRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            SetNamedPortsInstanceGroupRequest request = new SetNamedPortsInstanceGroupRequest
            {
                Zone = "",
                RequestId = "",
                InstanceGroup = "",
                Project = "",
                InstanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.SetNamedPortsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceSetNamedPortsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNamedPorts</summary>
        public void SetNamedPorts()
        {
            // Snippet: SetNamedPorts(string, string, string, InstanceGroupsSetNamedPortsRequest, CallSettings)
            // Create client
            InstanceGroupsClient instanceGroupsClient = InstanceGroupsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsSetNamedPortsRequest instanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instanceGroupsClient.SetNamedPorts(project, zone, instanceGroup, instanceGroupsSetNamedPortsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instanceGroupsClient.PollOnceSetNamedPorts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetNamedPortsAsync</summary>
        public async Task SetNamedPortsAsync()
        {
            // Snippet: SetNamedPortsAsync(string, string, string, InstanceGroupsSetNamedPortsRequest, CallSettings)
            // Additional: SetNamedPortsAsync(string, string, string, InstanceGroupsSetNamedPortsRequest, CancellationToken)
            // Create client
            InstanceGroupsClient instanceGroupsClient = await InstanceGroupsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instanceGroup = "";
            InstanceGroupsSetNamedPortsRequest instanceGroupsSetNamedPortsRequestResource = new InstanceGroupsSetNamedPortsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instanceGroupsClient.SetNamedPortsAsync(project, zone, instanceGroup, instanceGroupsSetNamedPortsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instanceGroupsClient.PollOnceSetNamedPortsAsync(operationName);
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
