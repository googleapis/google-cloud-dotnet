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
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedStoragePoolsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListStoragePoolsRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            AggregatedListStoragePoolsRequest request = new AggregatedListStoragePoolsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<StoragePoolAggregatedList, KeyValuePair<string, StoragePoolsScopedList>> response = storagePoolsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, StoragePoolsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListStoragePoolsRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListStoragePoolsRequest request = new AggregatedListStoragePoolsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<StoragePoolAggregatedList, KeyValuePair<string, StoragePoolsScopedList>> response = storagePoolsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, StoragePoolsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolsScopedList> item in singlePage)
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
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<StoragePoolAggregatedList, KeyValuePair<string, StoragePoolsScopedList>> response = storagePoolsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, StoragePoolsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolsScopedList> item in singlePage)
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
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<StoragePoolAggregatedList, KeyValuePair<string, StoragePoolsScopedList>> response = storagePoolsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, StoragePoolsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, StoragePoolsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, StoragePoolsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, StoragePoolsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteStoragePoolRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            DeleteStoragePoolRequest request = new DeleteStoragePoolRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                StoragePool = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = storagePoolsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = storagePoolsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteStoragePoolRequest, CallSettings)
            // Additional: DeleteAsync(DeleteStoragePoolRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteStoragePoolRequest request = new DeleteStoragePoolRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                StoragePool = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await storagePoolsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await storagePoolsClient.PollOnceDeleteAsync(operationName);
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
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            // Make the request
            lro::Operation<Operation, Operation> response = storagePoolsClient.Delete(project, zone, storagePool);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = storagePoolsClient.PollOnceDelete(operationName);
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
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await storagePoolsClient.DeleteAsync(project, zone, storagePool);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await storagePoolsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetStoragePoolRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            GetStoragePoolRequest request = new GetStoragePoolRequest
            {
                Zone = "",
                Project = "",
                StoragePool = "",
            };
            // Make the request
            StoragePool response = storagePoolsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetStoragePoolRequest, CallSettings)
            // Additional: GetAsync(GetStoragePoolRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetStoragePoolRequest request = new GetStoragePoolRequest
            {
                Zone = "",
                Project = "",
                StoragePool = "",
            };
            // Make the request
            StoragePool response = await storagePoolsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            // Make the request
            StoragePool response = storagePoolsClient.Get(project, zone, storagePool);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            // Make the request
            StoragePool response = await storagePoolsClient.GetAsync(project, zone, storagePool);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyStoragePoolRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyStoragePoolRequest request = new GetIamPolicyStoragePoolRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = storagePoolsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyStoragePoolRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyStoragePoolRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyStoragePoolRequest request = new GetIamPolicyStoragePoolRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await storagePoolsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = storagePoolsClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await storagePoolsClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertStoragePoolRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            InsertStoragePoolRequest request = new InsertStoragePoolRequest
            {
                Zone = "",
                RequestId = "",
                StoragePoolResource = new StoragePool(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = storagePoolsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = storagePoolsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertStoragePoolRequest, CallSettings)
            // Additional: InsertAsync(InsertStoragePoolRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            InsertStoragePoolRequest request = new InsertStoragePoolRequest
            {
                Zone = "",
                RequestId = "",
                StoragePoolResource = new StoragePool(),
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await storagePoolsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await storagePoolsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, StoragePool, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            StoragePool storagePoolResource = new StoragePool();
            // Make the request
            lro::Operation<Operation, Operation> response = storagePoolsClient.Insert(project, zone, storagePoolResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = storagePoolsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, StoragePool, CallSettings)
            // Additional: InsertAsync(string, string, StoragePool, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            StoragePool storagePoolResource = new StoragePool();
            // Make the request
            lro::Operation<Operation, Operation> response = await storagePoolsClient.InsertAsync(project, zone, storagePoolResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await storagePoolsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListStoragePoolsRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<StoragePoolList, StoragePool> response = storagePoolsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
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
            // Snippet: ListAsync(ListStoragePoolsRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            ListStoragePoolsRequest request = new ListStoragePoolsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<StoragePoolList, StoragePool> response = storagePoolsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
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
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<StoragePoolList, StoragePool> response = storagePoolsClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
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
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<StoragePoolList, StoragePool> response = storagePoolsClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisks</summary>
        public void ListDisksRequestObject()
        {
            // Snippet: ListDisks(ListDisksStoragePoolsRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            ListDisksStoragePoolsRequest request = new ListDisksStoragePoolsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                StoragePool = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<StoragePoolListDisks, StoragePoolDisk> response = storagePoolsClient.ListDisks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePoolDisk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolListDisks page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolDisk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolDisk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolDisk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisksAsync</summary>
        public async Task ListDisksRequestObjectAsync()
        {
            // Snippet: ListDisksAsync(ListDisksStoragePoolsRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            ListDisksStoragePoolsRequest request = new ListDisksStoragePoolsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                StoragePool = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<StoragePoolListDisks, StoragePoolDisk> response = storagePoolsClient.ListDisksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePoolDisk item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolListDisks page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolDisk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolDisk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolDisk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisks</summary>
        public void ListDisks()
        {
            // Snippet: ListDisks(string, string, string, string, int?, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            // Make the request
            PagedEnumerable<StoragePoolListDisks, StoragePoolDisk> response = storagePoolsClient.ListDisks(project, zone, storagePool);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (StoragePoolDisk item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (StoragePoolListDisks page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolDisk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolDisk> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolDisk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDisksAsync</summary>
        public async Task ListDisksAsync()
        {
            // Snippet: ListDisksAsync(string, string, string, string, int?, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            // Make the request
            PagedAsyncEnumerable<StoragePoolListDisks, StoragePoolDisk> response = storagePoolsClient.ListDisksAsync(project, zone, storagePool);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((StoragePoolDisk item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((StoragePoolListDisks page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (StoragePoolDisk item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<StoragePoolDisk> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (StoragePoolDisk item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyStoragePoolRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyStoragePoolRequest request = new SetIamPolicyStoragePoolRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = storagePoolsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyStoragePoolRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyStoragePoolRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyStoragePoolRequest request = new SetIamPolicyStoragePoolRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = await storagePoolsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = storagePoolsClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await storagePoolsClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsStoragePoolRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsStoragePoolRequest request = new TestIamPermissionsStoragePoolRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = storagePoolsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsStoragePoolRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsStoragePoolRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsStoragePoolRequest request = new TestIamPermissionsStoragePoolRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await storagePoolsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = storagePoolsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await storagePoolsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateStoragePoolRequest, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            UpdateStoragePoolRequest request = new UpdateStoragePoolRequest
            {
                Zone = "",
                RequestId = "",
                StoragePoolResource = new StoragePool(),
                Project = "",
                StoragePool = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = storagePoolsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = storagePoolsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateStoragePoolRequest, CallSettings)
            // Additional: UpdateAsync(UpdateStoragePoolRequest, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateStoragePoolRequest request = new UpdateStoragePoolRequest
            {
                Zone = "",
                RequestId = "",
                StoragePoolResource = new StoragePool(),
                Project = "",
                StoragePool = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await storagePoolsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await storagePoolsClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, StoragePool, CallSettings)
            // Create client
            StoragePoolsClient storagePoolsClient = StoragePoolsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            StoragePool storagePoolResource = new StoragePool();
            // Make the request
            lro::Operation<Operation, Operation> response = storagePoolsClient.Update(project, zone, storagePool, storagePoolResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = storagePoolsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, StoragePool, CallSettings)
            // Additional: UpdateAsync(string, string, string, StoragePool, CancellationToken)
            // Create client
            StoragePoolsClient storagePoolsClient = await StoragePoolsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string storagePool = "";
            StoragePool storagePoolResource = new StoragePool();
            // Make the request
            lro::Operation<Operation, Operation> response = await storagePoolsClient.UpdateAsync(project, zone, storagePool, storagePoolResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await storagePoolsClient.PollOnceUpdateAsync(operationName);
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
