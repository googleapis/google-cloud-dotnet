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

namespace GoogleCSharpSnippets
{
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedChangeEventServiceClientSnippets
    {
        /// <summary>Snippet for GetChangeEvent</summary>
        public void GetChangeEventRequestObject()
        {
            // Snippet: GetChangeEvent(GetChangeEventRequest, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = ChangeEventServiceClient.Create();
            // Initialize request argument(s)
            GetChangeEventRequest request = new GetChangeEventRequest
            {
                ChangeEventName = ChangeEventName.FromNetworkCodeChangeEvent("[NETWORK_CODE]", "[CHANGE_EVENT]"),
            };
            // Make the request
            ChangeEvent response = changeEventServiceClient.GetChangeEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangeEventAsync</summary>
        public async Task GetChangeEventRequestObjectAsync()
        {
            // Snippet: GetChangeEventAsync(GetChangeEventRequest, CallSettings)
            // Additional: GetChangeEventAsync(GetChangeEventRequest, CancellationToken)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = await ChangeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetChangeEventRequest request = new GetChangeEventRequest
            {
                ChangeEventName = ChangeEventName.FromNetworkCodeChangeEvent("[NETWORK_CODE]", "[CHANGE_EVENT]"),
            };
            // Make the request
            ChangeEvent response = await changeEventServiceClient.GetChangeEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangeEvent</summary>
        public void GetChangeEvent()
        {
            // Snippet: GetChangeEvent(string, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = ChangeEventServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/changeEvents/[CHANGE_EVENT]";
            // Make the request
            ChangeEvent response = changeEventServiceClient.GetChangeEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangeEventAsync</summary>
        public async Task GetChangeEventAsync()
        {
            // Snippet: GetChangeEventAsync(string, CallSettings)
            // Additional: GetChangeEventAsync(string, CancellationToken)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = await ChangeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/changeEvents/[CHANGE_EVENT]";
            // Make the request
            ChangeEvent response = await changeEventServiceClient.GetChangeEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangeEvent</summary>
        public void GetChangeEventResourceNames()
        {
            // Snippet: GetChangeEvent(ChangeEventName, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = ChangeEventServiceClient.Create();
            // Initialize request argument(s)
            ChangeEventName name = ChangeEventName.FromNetworkCodeChangeEvent("[NETWORK_CODE]", "[CHANGE_EVENT]");
            // Make the request
            ChangeEvent response = changeEventServiceClient.GetChangeEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangeEventAsync</summary>
        public async Task GetChangeEventResourceNamesAsync()
        {
            // Snippet: GetChangeEventAsync(ChangeEventName, CallSettings)
            // Additional: GetChangeEventAsync(ChangeEventName, CancellationToken)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = await ChangeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChangeEventName name = ChangeEventName.FromNetworkCodeChangeEvent("[NETWORK_CODE]", "[CHANGE_EVENT]");
            // Make the request
            ChangeEvent response = await changeEventServiceClient.GetChangeEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListChangeEvents</summary>
        public void ListChangeEventsRequestObject()
        {
            // Snippet: ListChangeEvents(ListChangeEventsRequest, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = ChangeEventServiceClient.Create();
            // Initialize request argument(s)
            ListChangeEventsRequest request = new ListChangeEventsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListChangeEventsResponse, ChangeEvent> response = changeEventServiceClient.ListChangeEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChangeEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangeEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeEventsAsync</summary>
        public async Task ListChangeEventsRequestObjectAsync()
        {
            // Snippet: ListChangeEventsAsync(ListChangeEventsRequest, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = await ChangeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListChangeEventsRequest request = new ListChangeEventsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListChangeEventsResponse, ChangeEvent> response = changeEventServiceClient.ListChangeEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ChangeEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChangeEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeEvents</summary>
        public void ListChangeEvents()
        {
            // Snippet: ListChangeEvents(string, string, int?, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = ChangeEventServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListChangeEventsResponse, ChangeEvent> response = changeEventServiceClient.ListChangeEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChangeEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangeEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeEventsAsync</summary>
        public async Task ListChangeEventsAsync()
        {
            // Snippet: ListChangeEventsAsync(string, string, int?, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = await ChangeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListChangeEventsResponse, ChangeEvent> response = changeEventServiceClient.ListChangeEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ChangeEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChangeEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeEvents</summary>
        public void ListChangeEventsResourceNames()
        {
            // Snippet: ListChangeEvents(NetworkName, string, int?, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = ChangeEventServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListChangeEventsResponse, ChangeEvent> response = changeEventServiceClient.ListChangeEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ChangeEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangeEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangeEventsAsync</summary>
        public async Task ListChangeEventsResourceNamesAsync()
        {
            // Snippet: ListChangeEventsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ChangeEventServiceClient changeEventServiceClient = await ChangeEventServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListChangeEventsResponse, ChangeEvent> response = changeEventServiceClient.ListChangeEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ChangeEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListChangeEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ChangeEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ChangeEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ChangeEvent item in singlePage)
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
