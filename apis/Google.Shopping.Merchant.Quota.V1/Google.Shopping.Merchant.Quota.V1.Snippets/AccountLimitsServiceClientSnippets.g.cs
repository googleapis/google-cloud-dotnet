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
    using Google.Shopping.Merchant.Quota.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccountLimitsServiceClientSnippets
    {
        /// <summary>Snippet for GetAccountLimit</summary>
        public void GetAccountLimitRequestObject()
        {
            // Snippet: GetAccountLimit(GetAccountLimitRequest, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = AccountLimitsServiceClient.Create();
            // Initialize request argument(s)
            GetAccountLimitRequest request = new GetAccountLimitRequest
            {
                AccountLimitName = AccountLimitName.FromAccountLimit("[ACCOUNT]", "[LIMIT]"),
            };
            // Make the request
            AccountLimit response = accountLimitsServiceClient.GetAccountLimit(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLimitAsync</summary>
        public async Task GetAccountLimitRequestObjectAsync()
        {
            // Snippet: GetAccountLimitAsync(GetAccountLimitRequest, CallSettings)
            // Additional: GetAccountLimitAsync(GetAccountLimitRequest, CancellationToken)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = await AccountLimitsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountLimitRequest request = new GetAccountLimitRequest
            {
                AccountLimitName = AccountLimitName.FromAccountLimit("[ACCOUNT]", "[LIMIT]"),
            };
            // Make the request
            AccountLimit response = await accountLimitsServiceClient.GetAccountLimitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLimit</summary>
        public void GetAccountLimit()
        {
            // Snippet: GetAccountLimit(string, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = AccountLimitsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/limits/[LIMIT]";
            // Make the request
            AccountLimit response = accountLimitsServiceClient.GetAccountLimit(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLimitAsync</summary>
        public async Task GetAccountLimitAsync()
        {
            // Snippet: GetAccountLimitAsync(string, CallSettings)
            // Additional: GetAccountLimitAsync(string, CancellationToken)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = await AccountLimitsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/limits/[LIMIT]";
            // Make the request
            AccountLimit response = await accountLimitsServiceClient.GetAccountLimitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLimit</summary>
        public void GetAccountLimitResourceNames()
        {
            // Snippet: GetAccountLimit(AccountLimitName, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = AccountLimitsServiceClient.Create();
            // Initialize request argument(s)
            AccountLimitName name = AccountLimitName.FromAccountLimit("[ACCOUNT]", "[LIMIT]");
            // Make the request
            AccountLimit response = accountLimitsServiceClient.GetAccountLimit(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountLimitAsync</summary>
        public async Task GetAccountLimitResourceNamesAsync()
        {
            // Snippet: GetAccountLimitAsync(AccountLimitName, CallSettings)
            // Additional: GetAccountLimitAsync(AccountLimitName, CancellationToken)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = await AccountLimitsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountLimitName name = AccountLimitName.FromAccountLimit("[ACCOUNT]", "[LIMIT]");
            // Make the request
            AccountLimit response = await accountLimitsServiceClient.GetAccountLimitAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAccountLimits</summary>
        public void ListAccountLimitsRequestObject()
        {
            // Snippet: ListAccountLimits(ListAccountLimitsRequest, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = AccountLimitsServiceClient.Create();
            // Initialize request argument(s)
            ListAccountLimitsRequest request = new ListAccountLimitsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAccountLimitsResponse, AccountLimit> response = accountLimitsServiceClient.ListAccountLimits(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountLimit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountLimitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLimit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLimit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLimit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLimitsAsync</summary>
        public async Task ListAccountLimitsRequestObjectAsync()
        {
            // Snippet: ListAccountLimitsAsync(ListAccountLimitsRequest, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = await AccountLimitsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountLimitsRequest request = new ListAccountLimitsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAccountLimitsResponse, AccountLimit> response = accountLimitsServiceClient.ListAccountLimitsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountLimit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountLimitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLimit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLimit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLimit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLimits</summary>
        public void ListAccountLimits()
        {
            // Snippet: ListAccountLimits(string, string, int?, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = AccountLimitsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListAccountLimitsResponse, AccountLimit> response = accountLimitsServiceClient.ListAccountLimits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountLimit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountLimitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLimit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLimit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLimit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLimitsAsync</summary>
        public async Task ListAccountLimitsAsync()
        {
            // Snippet: ListAccountLimitsAsync(string, string, int?, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = await AccountLimitsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListAccountLimitsResponse, AccountLimit> response = accountLimitsServiceClient.ListAccountLimitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountLimit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountLimitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLimit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLimit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLimit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLimits</summary>
        public void ListAccountLimitsResourceNames()
        {
            // Snippet: ListAccountLimits(AccountName, string, int?, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = AccountLimitsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListAccountLimitsResponse, AccountLimit> response = accountLimitsServiceClient.ListAccountLimits(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountLimit item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountLimitsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLimit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLimit> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLimit item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLimitsAsync</summary>
        public async Task ListAccountLimitsResourceNamesAsync()
        {
            // Snippet: ListAccountLimitsAsync(AccountName, string, int?, CallSettings)
            // Create client
            AccountLimitsServiceClient accountLimitsServiceClient = await AccountLimitsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListAccountLimitsResponse, AccountLimit> response = accountLimitsServiceClient.ListAccountLimitsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountLimit item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountLimitsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLimit item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLimit> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLimit item in singlePage)
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
