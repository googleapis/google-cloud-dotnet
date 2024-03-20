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
    using Google.Shopping.Css.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccountsServiceClientSnippets
    {
        /// <summary>Snippet for ListChildAccounts</summary>
        public void ListChildAccountsRequestObject()
        {
            // Snippet: ListChildAccounts(ListChildAccountsRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            ListChildAccountsRequest request = new ListChildAccountsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LabelId = 0L,
                FullName = "",
            };
            // Make the request
            PagedEnumerable<ListChildAccountsResponse, Account> response = accountsServiceClient.ListChildAccounts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Account item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChildAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Account item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Account> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Account item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildAccountsAsync</summary>
        public async Task ListChildAccountsRequestObjectAsync()
        {
            // Snippet: ListChildAccountsAsync(ListChildAccountsRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListChildAccountsRequest request = new ListChildAccountsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                LabelId = 0L,
                FullName = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListChildAccountsResponse, Account> response = accountsServiceClient.ListChildAccountsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Account item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChildAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Account item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Account> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Account item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildAccounts</summary>
        public void ListChildAccounts()
        {
            // Snippet: ListChildAccounts(string, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListChildAccountsResponse, Account> response = accountsServiceClient.ListChildAccounts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Account item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChildAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Account item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Account> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Account item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildAccountsAsync</summary>
        public async Task ListChildAccountsAsync()
        {
            // Snippet: ListChildAccountsAsync(string, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListChildAccountsResponse, Account> response = accountsServiceClient.ListChildAccountsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Account item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChildAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Account item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Account> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Account item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildAccounts</summary>
        public void ListChildAccountsResourceNames()
        {
            // Snippet: ListChildAccounts(AccountName, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListChildAccountsResponse, Account> response = accountsServiceClient.ListChildAccounts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Account item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChildAccountsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Account item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Account> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Account item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChildAccountsAsync</summary>
        public async Task ListChildAccountsResourceNamesAsync()
        {
            // Snippet: ListChildAccountsAsync(AccountName, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListChildAccountsResponse, Account> response = accountsServiceClient.ListChildAccountsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Account item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChildAccountsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Account item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Account> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Account item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAccount</summary>
        public void GetAccountRequestObject()
        {
            // Snippet: GetAccount(GetAccountRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Account response = accountsServiceClient.GetAccount(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountAsync</summary>
        public async Task GetAccountRequestObjectAsync()
        {
            // Snippet: GetAccountAsync(GetAccountRequest, CallSettings)
            // Additional: GetAccountAsync(GetAccountRequest, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountRequest request = new GetAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Account response = await accountsServiceClient.GetAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccount</summary>
        public void GetAccount()
        {
            // Snippet: GetAccount(string, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            Account response = accountsServiceClient.GetAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountAsync</summary>
        public async Task GetAccountAsync()
        {
            // Snippet: GetAccountAsync(string, CallSettings)
            // Additional: GetAccountAsync(string, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            Account response = await accountsServiceClient.GetAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccount</summary>
        public void GetAccountResourceNames()
        {
            // Snippet: GetAccount(AccountName, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            Account response = accountsServiceClient.GetAccount(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountAsync</summary>
        public async Task GetAccountResourceNamesAsync()
        {
            // Snippet: GetAccountAsync(AccountName, CallSettings)
            // Additional: GetAccountAsync(AccountName, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            Account response = await accountsServiceClient.GetAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabels</summary>
        public void UpdateLabelsRequestObject()
        {
            // Snippet: UpdateLabels(UpdateAccountLabelsRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            UpdateAccountLabelsRequest request = new UpdateAccountLabelsRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                LabelIds = { 0L, },
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Account response = accountsServiceClient.UpdateLabels(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabelsAsync</summary>
        public async Task UpdateLabelsRequestObjectAsync()
        {
            // Snippet: UpdateLabelsAsync(UpdateAccountLabelsRequest, CallSettings)
            // Additional: UpdateLabelsAsync(UpdateAccountLabelsRequest, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccountLabelsRequest request = new UpdateAccountLabelsRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
                LabelIds = { 0L, },
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            Account response = await accountsServiceClient.UpdateLabelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabels</summary>
        public void UpdateLabels()
        {
            // Snippet: UpdateLabels(string, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            Account response = accountsServiceClient.UpdateLabels(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabelsAsync</summary>
        public async Task UpdateLabelsAsync()
        {
            // Snippet: UpdateLabelsAsync(string, CallSettings)
            // Additional: UpdateLabelsAsync(string, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            Account response = await accountsServiceClient.UpdateLabelsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabels</summary>
        public void UpdateLabelsResourceNames()
        {
            // Snippet: UpdateLabels(AccountName, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            Account response = accountsServiceClient.UpdateLabels(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateLabelsAsync</summary>
        public async Task UpdateLabelsResourceNamesAsync()
        {
            // Snippet: UpdateLabelsAsync(AccountName, CallSettings)
            // Additional: UpdateLabelsAsync(AccountName, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            Account response = await accountsServiceClient.UpdateLabelsAsync(name);
            // End snippet
        }
    }
}
