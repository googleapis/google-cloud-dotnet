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
    public sealed class AllGeneratedInstantSnapshotsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListInstantSnapshotsRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            AggregatedListInstantSnapshotsRequest request = new AggregatedListInstantSnapshotsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstantSnapshotAggregatedList, KeyValuePair<string, InstantSnapshotsScopedList>> response = instantSnapshotsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstantSnapshotAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstantSnapshotsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListInstantSnapshotsRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListInstantSnapshotsRequest request = new AggregatedListInstantSnapshotsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstantSnapshotAggregatedList, KeyValuePair<string, InstantSnapshotsScopedList>> response = instantSnapshotsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InstantSnapshotsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstantSnapshotAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstantSnapshotsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in singlePage)
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
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InstantSnapshotAggregatedList, KeyValuePair<string, InstantSnapshotsScopedList>> response = instantSnapshotsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstantSnapshotAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstantSnapshotsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in singlePage)
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
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InstantSnapshotAggregatedList, KeyValuePair<string, InstantSnapshotsScopedList>> response = instantSnapshotsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, InstantSnapshotsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstantSnapshotAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, InstantSnapshotsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, InstantSnapshotsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteInstantSnapshotRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            DeleteInstantSnapshotRequest request = new DeleteInstantSnapshotRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteInstantSnapshotRequest, CallSettings)
            // Additional: DeleteAsync(DeleteInstantSnapshotRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteInstantSnapshotRequest request = new DeleteInstantSnapshotRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotsClient.PollOnceDeleteAsync(operationName);
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
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshot = "";
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotsClient.Delete(project, zone, instantSnapshot);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotsClient.PollOnceDelete(operationName);
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
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshot = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotsClient.DeleteAsync(project, zone, instantSnapshot);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetInstantSnapshotRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            GetInstantSnapshotRequest request = new GetInstantSnapshotRequest
            {
                Zone = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            InstantSnapshot response = instantSnapshotsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInstantSnapshotRequest, CallSettings)
            // Additional: GetAsync(GetInstantSnapshotRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetInstantSnapshotRequest request = new GetInstantSnapshotRequest
            {
                Zone = "",
                Project = "",
                InstantSnapshot = "",
            };
            // Make the request
            InstantSnapshot response = await instantSnapshotsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshot = "";
            // Make the request
            InstantSnapshot response = instantSnapshotsClient.Get(project, zone, instantSnapshot);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string instantSnapshot = "";
            // Make the request
            InstantSnapshot response = await instantSnapshotsClient.GetAsync(project, zone, instantSnapshot);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyInstantSnapshotRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyInstantSnapshotRequest request = new GetIamPolicyInstantSnapshotRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = instantSnapshotsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyInstantSnapshotRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyInstantSnapshotRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyInstantSnapshotRequest request = new GetIamPolicyInstantSnapshotRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await instantSnapshotsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = instantSnapshotsClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await instantSnapshotsClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertInstantSnapshotRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            InsertInstantSnapshotRequest request = new InsertInstantSnapshotRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstantSnapshotResource = new InstantSnapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertInstantSnapshotRequest, CallSettings)
            // Additional: InsertAsync(InsertInstantSnapshotRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            InsertInstantSnapshotRequest request = new InsertInstantSnapshotRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                InstantSnapshotResource = new InstantSnapshot(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, InstantSnapshot, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstantSnapshot instantSnapshotResource = new InstantSnapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotsClient.Insert(project, zone, instantSnapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, InstantSnapshot, CallSettings)
            // Additional: InsertAsync(string, string, InstantSnapshot, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            InstantSnapshot instantSnapshotResource = new InstantSnapshot();
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotsClient.InsertAsync(project, zone, instantSnapshotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListInstantSnapshotsRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            ListInstantSnapshotsRequest request = new ListInstantSnapshotsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InstantSnapshotList, InstantSnapshot> response = instantSnapshotsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstantSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstantSnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            // Snippet: ListAsync(ListInstantSnapshotsRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            ListInstantSnapshotsRequest request = new ListInstantSnapshotsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InstantSnapshotList, InstantSnapshot> response = instantSnapshotsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstantSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstantSnapshotList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<InstantSnapshotList, InstantSnapshot> response = instantSnapshotsClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InstantSnapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstantSnapshotList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<InstantSnapshotList, InstantSnapshot> response = instantSnapshotsClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InstantSnapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InstantSnapshotList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InstantSnapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InstantSnapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InstantSnapshot item in singlePage)
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
            // Snippet: SetIamPolicy(SetIamPolicyInstantSnapshotRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyInstantSnapshotRequest request = new SetIamPolicyInstantSnapshotRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = instantSnapshotsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyInstantSnapshotRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyInstantSnapshotRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyInstantSnapshotRequest request = new SetIamPolicyInstantSnapshotRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = await instantSnapshotsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = instantSnapshotsClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await instantSnapshotsClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabelsRequestObject()
        {
            // Snippet: SetLabels(SetLabelsInstantSnapshotRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            SetLabelsInstantSnapshotRequest request = new SetLabelsInstantSnapshotRequest
            {
                Zone = "",
                RequestId = "",
                Resource = "",
                Project = "",
                ZoneSetLabelsRequestResource = new ZoneSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotsClient.SetLabels(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotsClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsRequestObjectAsync()
        {
            // Snippet: SetLabelsAsync(SetLabelsInstantSnapshotRequest, CallSettings)
            // Additional: SetLabelsAsync(SetLabelsInstantSnapshotRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            SetLabelsInstantSnapshotRequest request = new SetLabelsInstantSnapshotRequest
            {
                Zone = "",
                RequestId = "",
                Resource = "",
                Project = "",
                ZoneSetLabelsRequestResource = new ZoneSetLabelsRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotsClient.SetLabelsAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotsClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabels</summary>
        public void SetLabels()
        {
            // Snippet: SetLabels(string, string, string, ZoneSetLabelsRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetLabelsRequest zoneSetLabelsRequestResource = new ZoneSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = instantSnapshotsClient.SetLabels(project, zone, resource, zoneSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = instantSnapshotsClient.PollOnceSetLabels(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SetLabelsAsync</summary>
        public async Task SetLabelsAsync()
        {
            // Snippet: SetLabelsAsync(string, string, string, ZoneSetLabelsRequest, CallSettings)
            // Additional: SetLabelsAsync(string, string, string, ZoneSetLabelsRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetLabelsRequest zoneSetLabelsRequestResource = new ZoneSetLabelsRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await instantSnapshotsClient.SetLabelsAsync(project, zone, resource, zoneSetLabelsRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await instantSnapshotsClient.PollOnceSetLabelsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsInstantSnapshotRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsInstantSnapshotRequest request = new TestIamPermissionsInstantSnapshotRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = instantSnapshotsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsInstantSnapshotRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsInstantSnapshotRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsInstantSnapshotRequest request = new TestIamPermissionsInstantSnapshotRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await instantSnapshotsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = InstantSnapshotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = instantSnapshotsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            InstantSnapshotsClient instantSnapshotsClient = await InstantSnapshotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await instantSnapshotsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }
    }
}
