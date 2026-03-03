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
    using System.Threading.Tasks;
    using lro = Google.LongRunning;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReservationSlotsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetReservationSlotRequest, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = ReservationSlotsClient.Create();
            // Initialize request argument(s)
            GetReservationSlotRequest request = new GetReservationSlotRequest
            {
                Zone = "",
                Project = "",
                ReservationSlot = "",
                ParentName = "",
            };
            // Make the request
            ReservationSlotsGetResponse response = reservationSlotsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetReservationSlotRequest, CallSettings)
            // Additional: GetAsync(GetReservationSlotRequest, CancellationToken)
            // Create client
            ReservationSlotsClient reservationSlotsClient = await ReservationSlotsClient.CreateAsync();
            // Initialize request argument(s)
            GetReservationSlotRequest request = new GetReservationSlotRequest
            {
                Zone = "",
                Project = "",
                ReservationSlot = "",
                ParentName = "",
            };
            // Make the request
            ReservationSlotsGetResponse response = await reservationSlotsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, string, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = ReservationSlotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            string reservationSlot = "";
            // Make the request
            ReservationSlotsGetResponse response = reservationSlotsClient.Get(project, zone, parentName, reservationSlot);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, string, CancellationToken)
            // Create client
            ReservationSlotsClient reservationSlotsClient = await ReservationSlotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            string reservationSlot = "";
            // Make the request
            ReservationSlotsGetResponse response = await reservationSlotsClient.GetAsync(project, zone, parentName, reservationSlot);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListReservationSlotsRequest, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = ReservationSlotsClient.Create();
            // Initialize request argument(s)
            ListReservationSlotsRequest request = new ListReservationSlotsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ParentName = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ReservationSlotsListResponse, ReservationSlot> response = reservationSlotsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReservationSlot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationSlotsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSlot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSlot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSlot item in singlePage)
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
            // Snippet: ListAsync(ListReservationSlotsRequest, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = await ReservationSlotsClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationSlotsRequest request = new ListReservationSlotsRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ParentName = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ReservationSlotsListResponse, ReservationSlot> response = reservationSlotsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReservationSlot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReservationSlotsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSlot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSlot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSlot item in singlePage)
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
            // Snippet: List(string, string, string, string, int?, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = ReservationSlotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            // Make the request
            PagedEnumerable<ReservationSlotsListResponse, ReservationSlot> response = reservationSlotsClient.List(project, zone, parentName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReservationSlot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationSlotsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSlot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSlot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSlot item in singlePage)
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
            // Snippet: ListAsync(string, string, string, string, int?, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = await ReservationSlotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            // Make the request
            PagedAsyncEnumerable<ReservationSlotsListResponse, ReservationSlot> response = reservationSlotsClient.ListAsync(project, zone, parentName);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReservationSlot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ReservationSlotsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSlot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSlot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSlot item in singlePage)
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
            // Snippet: Update(UpdateReservationSlotRequest, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = ReservationSlotsClient.Create();
            // Initialize request argument(s)
            UpdateReservationSlotRequest request = new UpdateReservationSlotRequest
            {
                Zone = "",
                Project = "",
                ReservationSlot = "",
                ReservationSlotResource = new ReservationSlot(),
                ParentName = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = reservationSlotsClient.Update(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationSlotsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(UpdateReservationSlotRequest, CallSettings)
            // Additional: UpdateAsync(UpdateReservationSlotRequest, CancellationToken)
            // Create client
            ReservationSlotsClient reservationSlotsClient = await ReservationSlotsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReservationSlotRequest request = new UpdateReservationSlotRequest
            {
                Zone = "",
                Project = "",
                ReservationSlot = "",
                ReservationSlotResource = new ReservationSlot(),
                ParentName = "",
                UpdateMask = "",
            };
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationSlotsClient.UpdateAsync(request);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationSlotsClient.PollOnceUpdateAsync(operationName);
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
            // Snippet: Update(string, string, string, string, ReservationSlot, CallSettings)
            // Create client
            ReservationSlotsClient reservationSlotsClient = ReservationSlotsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            string reservationSlot = "";
            ReservationSlot reservationSlotResource = new ReservationSlot();
            // Make the request
            lro::Operation<Operation, Operation> response = reservationSlotsClient.Update(project, zone, parentName, reservationSlot, reservationSlotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = reservationSlotsClient.PollOnceUpdate(operationName);
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
            // Snippet: UpdateAsync(string, string, string, string, ReservationSlot, CallSettings)
            // Additional: UpdateAsync(string, string, string, string, ReservationSlot, CancellationToken)
            // Create client
            ReservationSlotsClient reservationSlotsClient = await ReservationSlotsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            string reservationSlot = "";
            ReservationSlot reservationSlotResource = new ReservationSlot();
            // Make the request
            lro::Operation<Operation, Operation> response = await reservationSlotsClient.UpdateAsync(project, zone, parentName, reservationSlot, reservationSlotResource);

            // Poll until the returned long-running operation is complete
            lro::Operation<Operation, Operation> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Operation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            lro::Operation<Operation, Operation> retrievedResponse = await reservationSlotsClient.PollOnceUpdateAsync(operationName);
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
