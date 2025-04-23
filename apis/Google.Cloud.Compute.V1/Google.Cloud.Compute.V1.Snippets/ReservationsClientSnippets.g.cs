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
    public sealed class AllGeneratedReservationsClientSnippets
    {
        /// <summary>Snippet for AggregatedList</summary>
        public void AggregatedListRequestObject()
        {
            // Snippet: AggregatedList(AggregatedListReservationsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            AggregatedListReservationsRequest request = new AggregatedListReservationsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ReservationAggregatedList, KeyValuePair<string, ReservationsScopedList>> response = reservationsClient.AggregatedList(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ReservationsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ReservationsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ReservationsScopedList> item in singlePage)
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
            // Snippet: AggregatedListAsync(AggregatedListReservationsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            AggregatedListReservationsRequest request = new AggregatedListReservationsRequest
            {
                OrderBy = "",
                Project = "",
                ServiceProjectNumber = 0L,
                Filter = "",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ReservationAggregatedList, KeyValuePair<string, ReservationsScopedList>> response = reservationsClient.AggregatedListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ReservationsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ReservationAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ReservationsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ReservationsScopedList> item in singlePage)
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
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<ReservationAggregatedList, KeyValuePair<string, ReservationsScopedList>> response = reservationsClient.AggregatedList(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (KeyValuePair<string, ReservationsScopedList> item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationAggregatedList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ReservationsScopedList>> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ReservationsScopedList> item in singlePage)
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
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<ReservationAggregatedList, KeyValuePair<string, ReservationsScopedList>> response = reservationsClient.AggregatedListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((KeyValuePair<string, ReservationsScopedList> item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ReservationAggregatedList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (KeyValuePair<string, ReservationsScopedList> item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<KeyValuePair<string, ReservationsScopedList>> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (KeyValuePair<string, ReservationsScopedList> item in singlePage)
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
            // Snippet: Delete(DeleteReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Delete(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceDelete(operationName);
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
            // Snippet: DeleteAsync(DeleteReservationRequest, CallSettings)
            // Additional: DeleteAsync(DeleteReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReservationRequest request = new DeleteReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.DeleteAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceDeleteAsync(operationName);
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
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Delete(project, zone, reservation);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceDelete(operationName);
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
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.DeleteAsync(project, zone, reservation);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceDeleteAsync(operationName);
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
            // Snippet: Get(GetReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                Zone = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            Reservation response = reservationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetReservationRequest, CallSettings)
            // Additional: GetAsync(GetReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            GetReservationRequest request = new GetReservationRequest
            {
                Zone = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            Reservation response = await reservationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            Reservation response = reservationsClient.Get(project, zone, reservation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            // Make the request
            Reservation response = await reservationsClient.GetAsync(project, zone, reservation);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            GetIamPolicyReservationRequest request = new GetIamPolicyReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = reservationsClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyReservationRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyReservationRequest request = new GetIamPolicyReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                OptionsRequestedPolicyVersion = 0,
            };
            // Make the request
            Policy response = await reservationsClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, string, string, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = reservationsClient.GetIamPolicy(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, string, string, CallSettings)
            // Additional: GetIamPolicyAsync(string, string, string, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            // Make the request
            Policy response = await reservationsClient.GetIamPolicyAsync(project, zone, resource);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(InsertReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            InsertReservationRequest request = new InsertReservationRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                ReservationResource = new Reservation(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Insert(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(InsertReservationRequest, CallSettings)
            // Additional: InsertAsync(InsertReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            InsertReservationRequest request = new InsertReservationRequest
            {
                Zone = "",
                RequestId = "",
                Project = "",
                ReservationResource = new Reservation(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.InsertAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: Insert(string, string, Reservation, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Reservation reservationResource = new Reservation();
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Insert(project, zone, reservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceInsert(operationName);
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
            // Snippet: InsertAsync(string, string, Reservation, CallSettings)
            // Additional: InsertAsync(string, string, Reservation, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            Reservation reservationResource = new Reservation();
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.InsertAsync(project, zone, reservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceInsertAsync(operationName);
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
            // Snippet: List(ListReservationsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ReservationList, Reservation> response = reservationsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
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
            // Snippet: ListAsync(ListReservationsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationsRequest request = new ListReservationsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ReservationList, Reservation> response = reservationsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ReservationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
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
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedEnumerable<ReservationList, Reservation> response = reservationsClient.List(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reservation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
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
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            // Make the request
            PagedAsyncEnumerable<ReservationList, Reservation> response = reservationsClient.ListAsync(project, zone);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reservation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ReservationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reservation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reservation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reservation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenance</summary>
        public void PerformMaintenanceRequestObject()
        {
            // Snippet: PerformMaintenance(PerformMaintenanceReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            PerformMaintenanceReservationRequest request = new PerformMaintenanceReservationRequest
            {
                Zone = "",
                ReservationsPerformMaintenanceRequestResource = new ReservationsPerformMaintenanceRequest(),
                RequestId = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.PerformMaintenance(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOncePerformMaintenance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenanceAsync</summary>
        public async Task PerformMaintenanceRequestObjectAsync()
        {
            // Snippet: PerformMaintenanceAsync(PerformMaintenanceReservationRequest, CallSettings)
            // Additional: PerformMaintenanceAsync(PerformMaintenanceReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            PerformMaintenanceReservationRequest request = new PerformMaintenanceReservationRequest
            {
                Zone = "",
                ReservationsPerformMaintenanceRequestResource = new ReservationsPerformMaintenanceRequest(),
                RequestId = "",
                Reservation = "",
                Project = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.PerformMaintenanceAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOncePerformMaintenanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenance</summary>
        public void PerformMaintenance()
        {
            // Snippet: PerformMaintenance(string, string, string, ReservationsPerformMaintenanceRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            ReservationsPerformMaintenanceRequest reservationsPerformMaintenanceRequestResource = new ReservationsPerformMaintenanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.PerformMaintenance(project, zone, reservation, reservationsPerformMaintenanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOncePerformMaintenance(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for PerformMaintenanceAsync</summary>
        public async Task PerformMaintenanceAsync()
        {
            // Snippet: PerformMaintenanceAsync(string, string, string, ReservationsPerformMaintenanceRequest, CallSettings)
            // Additional: PerformMaintenanceAsync(string, string, string, ReservationsPerformMaintenanceRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            ReservationsPerformMaintenanceRequest reservationsPerformMaintenanceRequestResource = new ReservationsPerformMaintenanceRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.PerformMaintenanceAsync(project, zone, reservation, reservationsPerformMaintenanceRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOncePerformMaintenanceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void ResizeRequestObject()
        {
            // Snippet: Resize(ResizeReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            ResizeReservationRequest request = new ResizeReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
                ReservationsResizeRequestResource = new ReservationsResizeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Resize(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeRequestObjectAsync()
        {
            // Snippet: ResizeAsync(ResizeReservationRequest, CallSettings)
            // Additional: ResizeAsync(ResizeReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            ResizeReservationRequest request = new ResizeReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Project = "",
                ReservationsResizeRequestResource = new ReservationsResizeRequest(),
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.ResizeAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceResizeAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for Resize</summary>
        public void Resize()
        {
            // Snippet: Resize(string, string, string, ReservationsResizeRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            ReservationsResizeRequest reservationsResizeRequestResource = new ReservationsResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Resize(project, zone, reservation, reservationsResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceResize(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Operation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ResizeAsync</summary>
        public async Task ResizeAsync()
        {
            // Snippet: ResizeAsync(string, string, string, ReservationsResizeRequest, CallSettings)
            // Additional: ResizeAsync(string, string, string, ReservationsResizeRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            ReservationsResizeRequest reservationsResizeRequestResource = new ReservationsResizeRequest();
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.ResizeAsync(project, zone, reservation, reservationsResizeRequestResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceResizeAsync(operationName);
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
            // Snippet: SetIamPolicy(SetIamPolicyReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            SetIamPolicyReservationRequest request = new SetIamPolicyReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = reservationsClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyReservationRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyReservationRequest request = new SetIamPolicyReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                ZoneSetPolicyRequestResource = new ZoneSetPolicyRequest(),
            };
            // Make the request
            Policy response = await reservationsClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = reservationsClient.SetIamPolicy(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(string, string, string, ZoneSetPolicyRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            ZoneSetPolicyRequest zoneSetPolicyRequestResource = new ZoneSetPolicyRequest();
            // Make the request
            Policy response = await reservationsClient.SetIamPolicyAsync(project, zone, resource, zoneSetPolicyRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsReservationRequest request = new TestIamPermissionsReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = reservationsClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsReservationRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsReservationRequest request = new TestIamPermissionsReservationRequest
            {
                Zone = "",
                Resource = "",
                Project = "",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            // Make the request
            TestPermissionsResponse response = await reservationsClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, string, string, TestPermissionsRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = reservationsClient.TestIamPermissions(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(string, string, string, TestPermissionsRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string resource = "";
            TestPermissionsRequest testPermissionsRequestResource = new TestPermissionsRequest();
            // Make the request
            TestPermissionsResponse response = await reservationsClient.TestIamPermissionsAsync(project, zone, resource, testPermissionsRequestResource);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(UpdateReservationRequest, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Paths = "",
                Project = "",
                ReservationResource = new Reservation(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateReservationRequest, CallSettings)
            // Additional: UpdateAsync(UpdateReservationRequest, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReservationRequest request = new UpdateReservationRequest
            {
                Zone = "",
                RequestId = "",
                Reservation = "",
                Paths = "",
                Project = "",
                ReservationResource = new Reservation(),
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, Reservation, CallSettings)
            // Create client
            ReservationsClient reservationsClient = ReservationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            Reservation reservationResource = new Reservation();
            // Make the request
            lro::Operation<Operation, Operation> response = reservationsClient.Update(project, zone, reservation, reservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, Reservation, CallSettings)
            // Additional: UpdateAsync(string, string, string, Reservation, CancellationToken)
            // Create client
            ReservationsClient reservationsClient = await ReservationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string reservation = "";
            Reservation reservationResource = new Reservation();
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationsClient.UpdateAsync(project, zone, reservation, reservationResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationsClient.PollOnceUpdateAsync(operationName);
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
