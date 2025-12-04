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
    public sealed class AllGeneratedFutureReservationsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListFutureReservationsRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            AggregatedListFutureReservationsRequest request = new AggregatedListFutureReservationsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<FutureReservationsAggregatedListResponse, KeyValuePair<string, FutureReservationsScopedList>> response = futureReservationsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, FutureReservationsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FutureReservationsAggregatedListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FutureReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FutureReservationsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FutureReservationsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListFutureReservationsRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListFutureReservationsRequest request = new AggregatedListFutureReservationsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<FutureReservationsAggregatedListResponse, KeyValuePair<string, FutureReservationsScopedList>> response = futureReservationsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, FutureReservationsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FutureReservationsAggregatedListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FutureReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FutureReservationsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FutureReservationsScopedList> item in singlePage)
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
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<FutureReservationsAggregatedListResponse, KeyValuePair<string, FutureReservationsScopedList>> response = futureReservationsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, FutureReservationsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FutureReservationsAggregatedListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FutureReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FutureReservationsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FutureReservationsScopedList> item in singlePage)
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
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<FutureReservationsAggregatedListResponse, KeyValuePair<string, FutureReservationsScopedList>> response = futureReservationsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, FutureReservationsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FutureReservationsAggregatedListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, FutureReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, FutureReservationsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, FutureReservationsScopedList> item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for Cancel</summary>
        public void CancelRequestObject()
        {
            // Snippet: Cancel(CancelFutureReservationRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            CancelFutureReservationRequest request = new CancelFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                FutureReservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Cancel(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceCancel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelAsync</summary>
        public async Task CancelRequestObjectAsync()
        {
            // Snippet: CancelAsync(CancelFutureReservationRequest, CallSettings)
            // Additional: CancelAsync(CancelFutureReservationRequest, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            CancelFutureReservationRequest request = new CancelFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                FutureReservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.CancelAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceCancelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Cancel</summary>
        public void Cancel()
        {
            // Snippet: Cancel(string, string, string, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Cancel(project, zone, futureReservation);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceCancel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CancelAsync</summary>
        public async Task CancelAsync()
        {
            // Snippet: CancelAsync(string, string, string, CallSettings)
            // Additional: CancelAsync(string, string, string, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.CancelAsync(project, zone, futureReservation);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceCancelAsync(operationName);
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
            // Snippet: Delete(DeleteFutureReservationRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            DeleteFutureReservationRequest request = new DeleteFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                FutureReservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteFutureReservationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteFutureReservationRequest, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteFutureReservationRequest request = new DeleteFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                FutureReservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceDeleteAsync(operationName);
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
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Delete(project, zone, futureReservation);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceDelete(operationName);
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
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.DeleteAsync(project, zone, futureReservation);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetFutureReservationRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            GetFutureReservationRequest request = new GetFutureReservationRequest
            {
                Zone = "",
                FutureReservation = "",
                Project = "",
            };
            // Make the request
            FutureReservation response = futureReservationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetFutureReservationRequest, CallSettings)
            // Additional: GetAsync(GetFutureReservationRequest, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            GetFutureReservationRequest request = new GetFutureReservationRequest
            {
                Zone = "",
                FutureReservation = "",
                Project = "",
            };
            // Make the request
            FutureReservation response = await futureReservationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            // Make the request
            FutureReservation response = futureReservationsClient.Get(project, zone, futureReservation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            // Make the request
            FutureReservation response = await futureReservationsClient.GetAsync(project, zone, futureReservation);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertFutureReservationRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            InsertFutureReservationRequest request = new InsertFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                FutureReservationResource = new FutureReservation(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertFutureReservationRequest, CallSettings)
            // Additional: InsertAsync(InsertFutureReservationRequest, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            InsertFutureReservationRequest request = new InsertFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                FutureReservationResource = new FutureReservation(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, FutureReservation, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            FutureReservation futureReservationResource = new FutureReservation();
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Insert(project, zone, futureReservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, FutureReservation, CallSettings)
            // Additional: InsertAsync(string, string, FutureReservation, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            FutureReservation futureReservationResource = new FutureReservation();
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.InsertAsync(project, zone, futureReservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListFutureReservationsRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            ListFutureReservationsRequest request = new ListFutureReservationsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<FutureReservationsListResponse, FutureReservation> response = futureReservationsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FutureReservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FutureReservationsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FutureReservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FutureReservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FutureReservation item in singlePage)
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
            // Snippet: ListAsync(ListFutureReservationsRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            ListFutureReservationsRequest request = new ListFutureReservationsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<FutureReservationsListResponse, FutureReservation> response = futureReservationsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FutureReservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FutureReservationsListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FutureReservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FutureReservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FutureReservation item in singlePage)
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
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<FutureReservationsListResponse, FutureReservation> response = futureReservationsClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (FutureReservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (FutureReservationsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FutureReservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FutureReservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FutureReservation item in singlePage)
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
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<FutureReservationsListResponse, FutureReservation> response = futureReservationsClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((FutureReservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((FutureReservationsListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (FutureReservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<FutureReservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (FutureReservation item in singlePage)
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
            // Snippet: Update(UpdateFutureReservationRequest, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            UpdateFutureReservationRequest request = new UpdateFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                FutureReservation = "",
                Project = "",
                FutureReservationResource = new FutureReservation(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateFutureReservationRequest, CallSettings)
            // Additional: UpdateAsync(UpdateFutureReservationRequest, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateFutureReservationRequest request = new UpdateFutureReservationRequest
            {
                Zone = "",
                RequestId = "",
                FutureReservation = "",
                Project = "",
                FutureReservationResource = new FutureReservation(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, FutureReservation, CallSettings)
            // Create client
            FutureReservationsClient futureReservationsClient = FutureReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            FutureReservation futureReservationResource = new FutureReservation();
            // Make the request
            lro::Operation<Operation, Operation> response = futureReservationsClient.Update(project, zone, futureReservation, futureReservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = futureReservationsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, FutureReservation, CallSettings)
            // Additional: UpdateAsync(string, string, string, FutureReservation, CancellationToken)
            // Create client
            FutureReservationsClient futureReservationsClient = await FutureReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string futureReservation = "";
            FutureReservation futureReservationResource = new FutureReservation();
            // Make the request
            lro::Operation<Operation, Operation> response = await futureReservationsClient.UpdateAsync(project, zone, futureReservation, futureReservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await futureReservationsClient.PollOnceUpdateAsync(operationName);
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
