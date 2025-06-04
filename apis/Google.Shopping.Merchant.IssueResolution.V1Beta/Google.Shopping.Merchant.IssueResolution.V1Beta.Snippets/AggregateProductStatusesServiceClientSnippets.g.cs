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
    using Google.Shopping.Merchant.IssueResolution.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAggregateProductStatusesServiceClientSnippets
    {
        /// <summary>Snippet for ListAggregateProductStatuses</summary>
        public void ListAggregateProductStatusesRequestObject()
        {
            // Snippet: ListAggregateProductStatuses(ListAggregateProductStatusesRequest, CallSettings)
            // Create client
            AggregateProductStatusesServiceClient aggregateProductStatusesServiceClient = AggregateProductStatusesServiceClient.Create();
            // Initialize request argument(s)
            ListAggregateProductStatusesRequest request = new ListAggregateProductStatusesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> response = aggregateProductStatusesServiceClient.ListAggregateProductStatuses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AggregateProductStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAggregateProductStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateProductStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateProductStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateProductStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAggregateProductStatusesAsync</summary>
        public async Task ListAggregateProductStatusesRequestObjectAsync()
        {
            // Snippet: ListAggregateProductStatusesAsync(ListAggregateProductStatusesRequest, CallSettings)
            // Create client
            AggregateProductStatusesServiceClient aggregateProductStatusesServiceClient = await AggregateProductStatusesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAggregateProductStatusesRequest request = new ListAggregateProductStatusesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> response = aggregateProductStatusesServiceClient.ListAggregateProductStatusesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AggregateProductStatus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAggregateProductStatusesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateProductStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateProductStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateProductStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAggregateProductStatuses</summary>
        public void ListAggregateProductStatuses()
        {
            // Snippet: ListAggregateProductStatuses(string, string, int?, CallSettings)
            // Create client
            AggregateProductStatusesServiceClient aggregateProductStatusesServiceClient = AggregateProductStatusesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> response = aggregateProductStatusesServiceClient.ListAggregateProductStatuses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AggregateProductStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAggregateProductStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateProductStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateProductStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateProductStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAggregateProductStatusesAsync</summary>
        public async Task ListAggregateProductStatusesAsync()
        {
            // Snippet: ListAggregateProductStatusesAsync(string, string, int?, CallSettings)
            // Create client
            AggregateProductStatusesServiceClient aggregateProductStatusesServiceClient = await AggregateProductStatusesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> response = aggregateProductStatusesServiceClient.ListAggregateProductStatusesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AggregateProductStatus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAggregateProductStatusesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateProductStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateProductStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateProductStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAggregateProductStatuses</summary>
        public void ListAggregateProductStatusesResourceNames()
        {
            // Snippet: ListAggregateProductStatuses(AccountName, string, int?, CallSettings)
            // Create client
            AggregateProductStatusesServiceClient aggregateProductStatusesServiceClient = AggregateProductStatusesServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> response = aggregateProductStatusesServiceClient.ListAggregateProductStatuses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AggregateProductStatus item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAggregateProductStatusesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateProductStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateProductStatus> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateProductStatus item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAggregateProductStatusesAsync</summary>
        public async Task ListAggregateProductStatusesResourceNamesAsync()
        {
            // Snippet: ListAggregateProductStatusesAsync(AccountName, string, int?, CallSettings)
            // Create client
            AggregateProductStatusesServiceClient aggregateProductStatusesServiceClient = await AggregateProductStatusesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListAggregateProductStatusesResponse, AggregateProductStatus> response = aggregateProductStatusesServiceClient.ListAggregateProductStatusesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AggregateProductStatus item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAggregateProductStatusesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AggregateProductStatus item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AggregateProductStatus> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AggregateProductStatus item in singlePage)
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
