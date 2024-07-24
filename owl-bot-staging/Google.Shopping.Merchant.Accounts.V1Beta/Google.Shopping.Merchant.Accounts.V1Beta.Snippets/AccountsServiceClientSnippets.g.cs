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
    using Google.Protobuf.WellKnownTypes;
    using Google.Shopping.Merchant.Accounts.V1Beta;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccountsServiceClientSnippets
    {
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

        /// <summary>Snippet for CreateAndConfigureAccount</summary>
        public void CreateAndConfigureAccountRequestObject()
        {
            // Snippet: CreateAndConfigureAccount(CreateAndConfigureAccountRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            CreateAndConfigureAccountRequest request = new CreateAndConfigureAccountRequest
            {
                Account = new Account(),
                Users =
                {
                    new CreateUserRequest(),
                },
                AcceptTermsOfService = new CreateAndConfigureAccountRequest.Types.AcceptTermsOfService(),
                Service =
                {
                    new CreateAndConfigureAccountRequest.Types.AddAccountService(),
                },
            };
            // Make the request
            Account response = accountsServiceClient.CreateAndConfigureAccount(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAndConfigureAccountAsync</summary>
        public async Task CreateAndConfigureAccountRequestObjectAsync()
        {
            // Snippet: CreateAndConfigureAccountAsync(CreateAndConfigureAccountRequest, CallSettings)
            // Additional: CreateAndConfigureAccountAsync(CreateAndConfigureAccountRequest, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAndConfigureAccountRequest request = new CreateAndConfigureAccountRequest
            {
                Account = new Account(),
                Users =
                {
                    new CreateUserRequest(),
                },
                AcceptTermsOfService = new CreateAndConfigureAccountRequest.Types.AcceptTermsOfService(),
                Service =
                {
                    new CreateAndConfigureAccountRequest.Types.AddAccountService(),
                },
            };
            // Make the request
            Account response = await accountsServiceClient.CreateAndConfigureAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccount</summary>
        public void DeleteAccountRequestObject()
        {
            // Snippet: DeleteAccount(DeleteAccountRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            accountsServiceClient.DeleteAccount(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountAsync</summary>
        public async Task DeleteAccountRequestObjectAsync()
        {
            // Snippet: DeleteAccountAsync(DeleteAccountRequest, CallSettings)
            // Additional: DeleteAccountAsync(DeleteAccountRequest, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccountRequest request = new DeleteAccountRequest
            {
                AccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            await accountsServiceClient.DeleteAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccount</summary>
        public void DeleteAccount()
        {
            // Snippet: DeleteAccount(string, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            accountsServiceClient.DeleteAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountAsync</summary>
        public async Task DeleteAccountAsync()
        {
            // Snippet: DeleteAccountAsync(string, CallSettings)
            // Additional: DeleteAccountAsync(string, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]";
            // Make the request
            await accountsServiceClient.DeleteAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccount</summary>
        public void DeleteAccountResourceNames()
        {
            // Snippet: DeleteAccount(AccountName, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            accountsServiceClient.DeleteAccount(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountAsync</summary>
        public async Task DeleteAccountResourceNamesAsync()
        {
            // Snippet: DeleteAccountAsync(AccountName, CallSettings)
            // Additional: DeleteAccountAsync(AccountName, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName name = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            await accountsServiceClient.DeleteAccountAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccount</summary>
        public void UpdateAccountRequestObject()
        {
            // Snippet: UpdateAccount(UpdateAccountRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Account response = accountsServiceClient.UpdateAccount(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountAsync</summary>
        public async Task UpdateAccountRequestObjectAsync()
        {
            // Snippet: UpdateAccountAsync(UpdateAccountRequest, CallSettings)
            // Additional: UpdateAccountAsync(UpdateAccountRequest, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccountRequest request = new UpdateAccountRequest
            {
                Account = new Account(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Account response = await accountsServiceClient.UpdateAccountAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccount</summary>
        public void UpdateAccount()
        {
            // Snippet: UpdateAccount(Account, FieldMask, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            Account account = new Account();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Account response = accountsServiceClient.UpdateAccount(account, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountAsync</summary>
        public async Task UpdateAccountAsync()
        {
            // Snippet: UpdateAccountAsync(Account, FieldMask, CallSettings)
            // Additional: UpdateAccountAsync(Account, FieldMask, CancellationToken)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            Account account = new Account();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Account response = await accountsServiceClient.UpdateAccountAsync(account, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListAccounts</summary>
        public void ListAccountsRequestObject()
        {
            // Snippet: ListAccounts(ListAccountsRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            ListAccountsRequest request = new ListAccountsRequest { Filter = "", };
            // Make the request
            PagedEnumerable<ListAccountsResponse, Account> response = accountsServiceClient.ListAccounts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Account item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListAccountsAsync</summary>
        public async Task ListAccountsRequestObjectAsync()
        {
            // Snippet: ListAccountsAsync(ListAccountsRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountsRequest request = new ListAccountsRequest { Filter = "", };
            // Make the request
            PagedAsyncEnumerable<ListAccountsResponse, Account> response = accountsServiceClient.ListAccountsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Account item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountsResponse page) =>
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

        /// <summary>Snippet for ListSubAccounts</summary>
        public void ListSubAccountsRequestObject()
        {
            // Snippet: ListSubAccounts(ListSubAccountsRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            ListSubAccountsRequest request = new ListSubAccountsRequest
            {
                ProviderAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListSubAccountsResponse, Account> response = accountsServiceClient.ListSubAccounts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Account item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubAccountsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListSubAccountsAsync</summary>
        public async Task ListSubAccountsRequestObjectAsync()
        {
            // Snippet: ListSubAccountsAsync(ListSubAccountsRequest, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSubAccountsRequest request = new ListSubAccountsRequest
            {
                ProviderAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSubAccountsResponse, Account> response = accountsServiceClient.ListSubAccountsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Account item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubAccountsResponse page) =>
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

        /// <summary>Snippet for ListSubAccounts</summary>
        public void ListSubAccounts()
        {
            // Snippet: ListSubAccounts(string, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            string provider = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListSubAccountsResponse, Account> response = accountsServiceClient.ListSubAccounts(provider);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Account item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubAccountsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListSubAccountsAsync</summary>
        public async Task ListSubAccountsAsync()
        {
            // Snippet: ListSubAccountsAsync(string, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string provider = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListSubAccountsResponse, Account> response = accountsServiceClient.ListSubAccountsAsync(provider);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Account item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubAccountsResponse page) =>
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

        /// <summary>Snippet for ListSubAccounts</summary>
        public void ListSubAccountsResourceNames()
        {
            // Snippet: ListSubAccounts(AccountName, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = AccountsServiceClient.Create();
            // Initialize request argument(s)
            AccountName provider = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListSubAccountsResponse, Account> response = accountsServiceClient.ListSubAccounts(provider);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Account item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSubAccountsResponse page in response.AsRawResponses())
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

        /// <summary>Snippet for ListSubAccountsAsync</summary>
        public async Task ListSubAccountsResourceNamesAsync()
        {
            // Snippet: ListSubAccountsAsync(AccountName, string, int?, CallSettings)
            // Create client
            AccountsServiceClient accountsServiceClient = await AccountsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName provider = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListSubAccountsResponse, Account> response = accountsServiceClient.ListSubAccountsAsync(provider);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Account item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSubAccountsResponse page) =>
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
    }
}
