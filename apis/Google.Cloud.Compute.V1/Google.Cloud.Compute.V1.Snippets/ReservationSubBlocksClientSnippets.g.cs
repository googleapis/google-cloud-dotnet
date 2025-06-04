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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReservationSubBlocksClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetReservationSubBlockRequest, CallSettings)
            // Create client
            ReservationSubBlocksClient reservationSubBlocksClient = ReservationSubBlocksClient.Create();
            // Initialize request argument(s)
            GetReservationSubBlockRequest request = new GetReservationSubBlockRequest
            {
                Zone = "",
                ReservationSubBlock = "",
                Project = "",
                ParentName = "",
            };
            // Make the request
            ReservationSubBlocksGetResponse response = reservationSubBlocksClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetReservationSubBlockRequest, CallSettings)
            // Additional: GetAsync(GetReservationSubBlockRequest, CancellationToken)
            // Create client
            ReservationSubBlocksClient reservationSubBlocksClient = await ReservationSubBlocksClient.CreateAsync();
            // Initialize request argument(s)
            GetReservationSubBlockRequest request = new GetReservationSubBlockRequest
            {
                Zone = "",
                ReservationSubBlock = "",
                Project = "",
                ParentName = "",
            };
            // Make the request
            ReservationSubBlocksGetResponse response = await reservationSubBlocksClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, string, string, CallSettings)
            // Create client
            ReservationSubBlocksClient reservationSubBlocksClient = ReservationSubBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            string reservationSubBlock = "";
            // Make the request
            ReservationSubBlocksGetResponse response = reservationSubBlocksClient.Get(project, zone, parentName, reservationSubBlock);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, string, string, CallSettings)
            // Additional: GetAsync(string, string, string, string, CancellationToken)
            // Create client
            ReservationSubBlocksClient reservationSubBlocksClient = await ReservationSubBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            string reservationSubBlock = "";
            // Make the request
            ReservationSubBlocksGetResponse response = await reservationSubBlocksClient.GetAsync(project, zone, parentName, reservationSubBlock);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListReservationSubBlocksRequest, CallSettings)
            // Create client
            ReservationSubBlocksClient reservationSubBlocksClient = ReservationSubBlocksClient.Create();
            // Initialize request argument(s)
            ListReservationSubBlocksRequest request = new ListReservationSubBlocksRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ParentName = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> response = reservationSubBlocksClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReservationSubBlock item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationSubBlocksListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSubBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSubBlock> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSubBlock item in singlePage)
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
            // Snippet: ListAsync(ListReservationSubBlocksRequest, CallSettings)
            // Create client
            ReservationSubBlocksClient reservationSubBlocksClient = await ReservationSubBlocksClient.CreateAsync();
            // Initialize request argument(s)
            ListReservationSubBlocksRequest request = new ListReservationSubBlocksRequest
            {
                Zone = "",
                OrderBy = "",
                Project = "",
                Filter = "",
                ParentName = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> response = reservationSubBlocksClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReservationSubBlock item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ReservationSubBlocksListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSubBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSubBlock> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSubBlock item in singlePage)
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
            ReservationSubBlocksClient reservationSubBlocksClient = ReservationSubBlocksClient.Create();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            // Make the request
            PagedEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> response = reservationSubBlocksClient.List(project, zone, parentName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReservationSubBlock item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ReservationSubBlocksListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSubBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSubBlock> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSubBlock item in singlePage)
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
            ReservationSubBlocksClient reservationSubBlocksClient = await ReservationSubBlocksClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string zone = "";
            string parentName = "";
            // Make the request
            PagedAsyncEnumerable<ReservationSubBlocksListResponse, ReservationSubBlock> response = reservationSubBlocksClient.ListAsync(project, zone, parentName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReservationSubBlock item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ReservationSubBlocksListResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReservationSubBlock item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReservationSubBlock> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReservationSubBlock item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
