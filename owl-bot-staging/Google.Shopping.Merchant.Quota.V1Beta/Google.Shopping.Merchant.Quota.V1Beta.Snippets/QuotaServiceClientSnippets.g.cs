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

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Shopping.Merchant.Quota.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedQuotaServiceClientSnippets
    {
        /// <summary>Snippet for ListQuotaGroups</summary>
        public void ListQuotaGroupsRequestObject()
        {
            // Snippet: ListQuotaGroups(ListQuotaGroupsRequest, CallSettings)
            // Create client
            QuotaServiceClient quotaServiceClient = QuotaServiceClient.Create();
            // Initialize request argument(s)
            ListQuotaGroupsRequest request = new ListQuotaGroupsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListQuotaGroupsResponse, QuotaGroup> response = quotaServiceClient.ListQuotaGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaGroupsAsync</summary>
        public async Task ListQuotaGroupsRequestObjectAsync()
        {
            // Snippet: ListQuotaGroupsAsync(ListQuotaGroupsRequest, CallSettings)
            // Create client
            QuotaServiceClient quotaServiceClient = await QuotaServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListQuotaGroupsRequest request = new ListQuotaGroupsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListQuotaGroupsResponse, QuotaGroup> response = quotaServiceClient.ListQuotaGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaGroups</summary>
        public void ListQuotaGroups()
        {
            // Snippet: ListQuotaGroups(string, string, int?, CallSettings)
            // Create client
            QuotaServiceClient quotaServiceClient = QuotaServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListQuotaGroupsResponse, QuotaGroup> response = quotaServiceClient.ListQuotaGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaGroupsAsync</summary>
        public async Task ListQuotaGroupsAsync()
        {
            // Snippet: ListQuotaGroupsAsync(string, string, int?, CallSettings)
            // Create client
            QuotaServiceClient quotaServiceClient = await QuotaServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListQuotaGroupsResponse, QuotaGroup> response = quotaServiceClient.ListQuotaGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaGroups</summary>
        public void ListQuotaGroupsResourceNames()
        {
            // Snippet: ListQuotaGroups(AccountName, string, int?, CallSettings)
            // Create client
            QuotaServiceClient quotaServiceClient = QuotaServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListQuotaGroupsResponse, QuotaGroup> response = quotaServiceClient.ListQuotaGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (QuotaGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListQuotaGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListQuotaGroupsAsync</summary>
        public async Task ListQuotaGroupsResourceNamesAsync()
        {
            // Snippet: ListQuotaGroupsAsync(AccountName, string, int?, CallSettings)
            // Create client
            QuotaServiceClient quotaServiceClient = await QuotaServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListQuotaGroupsResponse, QuotaGroup> response = quotaServiceClient.ListQuotaGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((QuotaGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListQuotaGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (QuotaGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<QuotaGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (QuotaGroup item in singlePage)
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
