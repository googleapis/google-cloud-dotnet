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
    public sealed class AllGeneratedAccountTaxServiceClientSnippets
    {
        /// <summary>Snippet for GetAccountTax</summary>
        public void GetAccountTaxRequestObject()
        {
            // Snippet: GetAccountTax(GetAccountTaxRequest, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            GetAccountTaxRequest request = new GetAccountTaxRequest
            {
                AccountTaxName = AccountTaxName.FromAccountTax("[ACCOUNT]", "[TAX]"),
            };
            // Make the request
            AccountTax response = accountTaxServiceClient.GetAccountTax(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountTaxAsync</summary>
        public async Task GetAccountTaxRequestObjectAsync()
        {
            // Snippet: GetAccountTaxAsync(GetAccountTaxRequest, CallSettings)
            // Additional: GetAccountTaxAsync(GetAccountTaxRequest, CancellationToken)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountTaxRequest request = new GetAccountTaxRequest
            {
                AccountTaxName = AccountTaxName.FromAccountTax("[ACCOUNT]", "[TAX]"),
            };
            // Make the request
            AccountTax response = await accountTaxServiceClient.GetAccountTaxAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountTax</summary>
        public void GetAccountTax()
        {
            // Snippet: GetAccountTax(string, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/accounttax/[TAX]";
            // Make the request
            AccountTax response = accountTaxServiceClient.GetAccountTax(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountTaxAsync</summary>
        public async Task GetAccountTaxAsync()
        {
            // Snippet: GetAccountTaxAsync(string, CallSettings)
            // Additional: GetAccountTaxAsync(string, CancellationToken)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/accounttax/[TAX]";
            // Make the request
            AccountTax response = await accountTaxServiceClient.GetAccountTaxAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountTax</summary>
        public void GetAccountTaxResourceNames()
        {
            // Snippet: GetAccountTax(AccountTaxName, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            AccountTaxName name = AccountTaxName.FromAccountTax("[ACCOUNT]", "[TAX]");
            // Make the request
            AccountTax response = accountTaxServiceClient.GetAccountTax(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountTaxAsync</summary>
        public async Task GetAccountTaxResourceNamesAsync()
        {
            // Snippet: GetAccountTaxAsync(AccountTaxName, CallSettings)
            // Additional: GetAccountTaxAsync(AccountTaxName, CancellationToken)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountTaxName name = AccountTaxName.FromAccountTax("[ACCOUNT]", "[TAX]");
            // Make the request
            AccountTax response = await accountTaxServiceClient.GetAccountTaxAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAccountTax</summary>
        public void ListAccountTaxRequestObject()
        {
            // Snippet: ListAccountTax(ListAccountTaxRequest, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            ListAccountTaxRequest request = new ListAccountTaxRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListAccountTaxResponse, AccountTax> response = accountTaxServiceClient.ListAccountTax(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountTax item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountTaxResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountTax item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountTax> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountTax item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountTaxAsync</summary>
        public async Task ListAccountTaxRequestObjectAsync()
        {
            // Snippet: ListAccountTaxAsync(ListAccountTaxRequest, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountTaxRequest request = new ListAccountTaxRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAccountTaxResponse, AccountTax> response = accountTaxServiceClient.ListAccountTaxAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountTax item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountTaxResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountTax item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountTax> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountTax item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountTax</summary>
        public void ListAccountTax()
        {
            // Snippet: ListAccountTax(string, string, int?, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListAccountTaxResponse, AccountTax> response = accountTaxServiceClient.ListAccountTax(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountTax item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountTaxResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountTax item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountTax> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountTax item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountTaxAsync</summary>
        public async Task ListAccountTaxAsync()
        {
            // Snippet: ListAccountTaxAsync(string, string, int?, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListAccountTaxResponse, AccountTax> response = accountTaxServiceClient.ListAccountTaxAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountTax item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountTaxResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountTax item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountTax> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountTax item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountTax</summary>
        public void ListAccountTaxResourceNames()
        {
            // Snippet: ListAccountTax(AccountName, string, int?, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListAccountTaxResponse, AccountTax> response = accountTaxServiceClient.ListAccountTax(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountTax item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountTaxResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountTax item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountTax> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountTax item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountTaxAsync</summary>
        public async Task ListAccountTaxResourceNamesAsync()
        {
            // Snippet: ListAccountTaxAsync(AccountName, string, int?, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListAccountTaxResponse, AccountTax> response = accountTaxServiceClient.ListAccountTaxAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountTax item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountTaxResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountTax item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountTax> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountTax item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountTax</summary>
        public void UpdateAccountTaxRequestObject()
        {
            // Snippet: UpdateAccountTax(UpdateAccountTaxRequest, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            UpdateAccountTaxRequest request = new UpdateAccountTaxRequest
            {
                AccountTax = new AccountTax(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AccountTax response = accountTaxServiceClient.UpdateAccountTax(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountTaxAsync</summary>
        public async Task UpdateAccountTaxRequestObjectAsync()
        {
            // Snippet: UpdateAccountTaxAsync(UpdateAccountTaxRequest, CallSettings)
            // Additional: UpdateAccountTaxAsync(UpdateAccountTaxRequest, CancellationToken)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccountTaxRequest request = new UpdateAccountTaxRequest
            {
                AccountTax = new AccountTax(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AccountTax response = await accountTaxServiceClient.UpdateAccountTaxAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountTax</summary>
        public void UpdateAccountTax1()
        {
            // Snippet: UpdateAccountTax(AccountTax, FieldMask, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            AccountTax accountTax = new AccountTax();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AccountTax response = accountTaxServiceClient.UpdateAccountTax(accountTax, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountTaxAsync</summary>
        public async Task UpdateAccountTax1Async()
        {
            // Snippet: UpdateAccountTaxAsync(AccountTax, FieldMask, CallSettings)
            // Additional: UpdateAccountTaxAsync(AccountTax, FieldMask, CancellationToken)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountTax accountTax = new AccountTax();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AccountTax response = await accountTaxServiceClient.UpdateAccountTaxAsync(accountTax, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountTax</summary>
        public void UpdateAccountTax2()
        {
            // Snippet: UpdateAccountTax(AccountTax, CallSettings)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = AccountTaxServiceClient.Create();
            // Initialize request argument(s)
            AccountTax accountTax = new AccountTax();
            // Make the request
            AccountTax response = accountTaxServiceClient.UpdateAccountTax(accountTax);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountTaxAsync</summary>
        public async Task UpdateAccountTax2Async()
        {
            // Snippet: UpdateAccountTaxAsync(AccountTax, CallSettings)
            // Additional: UpdateAccountTaxAsync(AccountTax, CancellationToken)
            // Create client
            AccountTaxServiceClient accountTaxServiceClient = await AccountTaxServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountTax accountTax = new AccountTax();
            // Make the request
            AccountTax response = await accountTaxServiceClient.UpdateAccountTaxAsync(accountTax);
            // End snippet
        }
    }
}
