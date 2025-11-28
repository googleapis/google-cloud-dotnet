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
    using Google.Shopping.Merchant.Accounts.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccountServicesServiceClientSnippets
    {
        /// <summary>Snippet for GetAccountService</summary>
        public void GetAccountServiceRequestObject()
        {
            // Snippet: GetAccountService(GetAccountServiceRequest, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            GetAccountServiceRequest request = new GetAccountServiceRequest
            {
                AccountServiceName = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]"),
            };
            // Make the request
            AccountService response = accountServicesServiceClient.GetAccountService(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountServiceAsync</summary>
        public async Task GetAccountServiceRequestObjectAsync()
        {
            // Snippet: GetAccountServiceAsync(GetAccountServiceRequest, CallSettings)
            // Additional: GetAccountServiceAsync(GetAccountServiceRequest, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAccountServiceRequest request = new GetAccountServiceRequest
            {
                AccountServiceName = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]"),
            };
            // Make the request
            AccountService response = await accountServicesServiceClient.GetAccountServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccountService</summary>
        public void GetAccountService()
        {
            // Snippet: GetAccountService(string, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/services/[SERVICE]";
            // Make the request
            AccountService response = accountServicesServiceClient.GetAccountService(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountServiceAsync</summary>
        public async Task GetAccountServiceAsync()
        {
            // Snippet: GetAccountServiceAsync(string, CallSettings)
            // Additional: GetAccountServiceAsync(string, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/services/[SERVICE]";
            // Make the request
            AccountService response = await accountServicesServiceClient.GetAccountServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountService</summary>
        public void GetAccountServiceResourceNames()
        {
            // Snippet: GetAccountService(AccountServiceName, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            AccountServiceName name = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]");
            // Make the request
            AccountService response = accountServicesServiceClient.GetAccountService(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccountServiceAsync</summary>
        public async Task GetAccountServiceResourceNamesAsync()
        {
            // Snippet: GetAccountServiceAsync(AccountServiceName, CallSettings)
            // Additional: GetAccountServiceAsync(AccountServiceName, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountServiceName name = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]");
            // Make the request
            AccountService response = await accountServicesServiceClient.GetAccountServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAccountServices</summary>
        public void ListAccountServicesRequestObject()
        {
            // Snippet: ListAccountServices(ListAccountServicesRequest, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            ListAccountServicesRequest request = new ListAccountServicesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListAccountServicesResponse, AccountService> response = accountServicesServiceClient.ListAccountServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountServicesAsync</summary>
        public async Task ListAccountServicesRequestObjectAsync()
        {
            // Snippet: ListAccountServicesAsync(ListAccountServicesRequest, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountServicesRequest request = new ListAccountServicesRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAccountServicesResponse, AccountService> response = accountServicesServiceClient.ListAccountServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountServices</summary>
        public void ListAccountServices()
        {
            // Snippet: ListAccountServices(string, string, int?, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListAccountServicesResponse, AccountService> response = accountServicesServiceClient.ListAccountServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountServicesAsync</summary>
        public async Task ListAccountServicesAsync()
        {
            // Snippet: ListAccountServicesAsync(string, string, int?, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListAccountServicesResponse, AccountService> response = accountServicesServiceClient.ListAccountServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountServices</summary>
        public void ListAccountServicesResourceNames()
        {
            // Snippet: ListAccountServices(AccountName, string, int?, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListAccountServicesResponse, AccountService> response = accountServicesServiceClient.ListAccountServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountServicesAsync</summary>
        public async Task ListAccountServicesResourceNamesAsync()
        {
            // Snippet: ListAccountServicesAsync(AccountName, string, int?, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListAccountServicesResponse, AccountService> response = accountServicesServiceClient.ListAccountServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ProposeAccountService</summary>
        public void ProposeAccountServiceRequestObject()
        {
            // Snippet: ProposeAccountService(ProposeAccountServiceRequest, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            ProposeAccountServiceRequest request = new ProposeAccountServiceRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Provider = "",
                AccountService = new AccountService(),
            };
            // Make the request
            AccountService response = accountServicesServiceClient.ProposeAccountService(request);
            // End snippet
        }

        /// <summary>Snippet for ProposeAccountServiceAsync</summary>
        public async Task ProposeAccountServiceRequestObjectAsync()
        {
            // Snippet: ProposeAccountServiceAsync(ProposeAccountServiceRequest, CallSettings)
            // Additional: ProposeAccountServiceAsync(ProposeAccountServiceRequest, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProposeAccountServiceRequest request = new ProposeAccountServiceRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                Provider = "",
                AccountService = new AccountService(),
            };
            // Make the request
            AccountService response = await accountServicesServiceClient.ProposeAccountServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ProposeAccountService</summary>
        public void ProposeAccountService()
        {
            // Snippet: ProposeAccountService(string, string, AccountService, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            string provider = "";
            AccountService accountService = new AccountService();
            // Make the request
            AccountService response = accountServicesServiceClient.ProposeAccountService(parent, provider, accountService);
            // End snippet
        }

        /// <summary>Snippet for ProposeAccountServiceAsync</summary>
        public async Task ProposeAccountServiceAsync()
        {
            // Snippet: ProposeAccountServiceAsync(string, string, AccountService, CallSettings)
            // Additional: ProposeAccountServiceAsync(string, string, AccountService, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            string provider = "";
            AccountService accountService = new AccountService();
            // Make the request
            AccountService response = await accountServicesServiceClient.ProposeAccountServiceAsync(parent, provider, accountService);
            // End snippet
        }

        /// <summary>Snippet for ProposeAccountService</summary>
        public void ProposeAccountServiceResourceNames()
        {
            // Snippet: ProposeAccountService(AccountName, string, AccountService, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            string provider = "";
            AccountService accountService = new AccountService();
            // Make the request
            AccountService response = accountServicesServiceClient.ProposeAccountService(parent, provider, accountService);
            // End snippet
        }

        /// <summary>Snippet for ProposeAccountServiceAsync</summary>
        public async Task ProposeAccountServiceResourceNamesAsync()
        {
            // Snippet: ProposeAccountServiceAsync(AccountName, string, AccountService, CallSettings)
            // Additional: ProposeAccountServiceAsync(AccountName, string, AccountService, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            string provider = "";
            AccountService accountService = new AccountService();
            // Make the request
            AccountService response = await accountServicesServiceClient.ProposeAccountServiceAsync(parent, provider, accountService);
            // End snippet
        }

        /// <summary>Snippet for ApproveAccountService</summary>
        public void ApproveAccountServiceRequestObject()
        {
            // Snippet: ApproveAccountService(ApproveAccountServiceRequest, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            ApproveAccountServiceRequest request = new ApproveAccountServiceRequest
            {
                AccountServiceName = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]"),
            };
            // Make the request
            AccountService response = accountServicesServiceClient.ApproveAccountService(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveAccountServiceAsync</summary>
        public async Task ApproveAccountServiceRequestObjectAsync()
        {
            // Snippet: ApproveAccountServiceAsync(ApproveAccountServiceRequest, CallSettings)
            // Additional: ApproveAccountServiceAsync(ApproveAccountServiceRequest, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApproveAccountServiceRequest request = new ApproveAccountServiceRequest
            {
                AccountServiceName = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]"),
            };
            // Make the request
            AccountService response = await accountServicesServiceClient.ApproveAccountServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveAccountService</summary>
        public void ApproveAccountService()
        {
            // Snippet: ApproveAccountService(string, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/services/[SERVICE]";
            // Make the request
            AccountService response = accountServicesServiceClient.ApproveAccountService(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveAccountServiceAsync</summary>
        public async Task ApproveAccountServiceAsync()
        {
            // Snippet: ApproveAccountServiceAsync(string, CallSettings)
            // Additional: ApproveAccountServiceAsync(string, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/services/[SERVICE]";
            // Make the request
            AccountService response = await accountServicesServiceClient.ApproveAccountServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveAccountService</summary>
        public void ApproveAccountServiceResourceNames()
        {
            // Snippet: ApproveAccountService(AccountServiceName, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            AccountServiceName name = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]");
            // Make the request
            AccountService response = accountServicesServiceClient.ApproveAccountService(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveAccountServiceAsync</summary>
        public async Task ApproveAccountServiceResourceNamesAsync()
        {
            // Snippet: ApproveAccountServiceAsync(AccountServiceName, CallSettings)
            // Additional: ApproveAccountServiceAsync(AccountServiceName, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountServiceName name = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]");
            // Make the request
            AccountService response = await accountServicesServiceClient.ApproveAccountServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RejectAccountService</summary>
        public void RejectAccountServiceRequestObject()
        {
            // Snippet: RejectAccountService(RejectAccountServiceRequest, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            RejectAccountServiceRequest request = new RejectAccountServiceRequest
            {
                AccountServiceName = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]"),
            };
            // Make the request
            accountServicesServiceClient.RejectAccountService(request);
            // End snippet
        }

        /// <summary>Snippet for RejectAccountServiceAsync</summary>
        public async Task RejectAccountServiceRequestObjectAsync()
        {
            // Snippet: RejectAccountServiceAsync(RejectAccountServiceRequest, CallSettings)
            // Additional: RejectAccountServiceAsync(RejectAccountServiceRequest, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            RejectAccountServiceRequest request = new RejectAccountServiceRequest
            {
                AccountServiceName = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]"),
            };
            // Make the request
            await accountServicesServiceClient.RejectAccountServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RejectAccountService</summary>
        public void RejectAccountService()
        {
            // Snippet: RejectAccountService(string, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/services/[SERVICE]";
            // Make the request
            accountServicesServiceClient.RejectAccountService(name);
            // End snippet
        }

        /// <summary>Snippet for RejectAccountServiceAsync</summary>
        public async Task RejectAccountServiceAsync()
        {
            // Snippet: RejectAccountServiceAsync(string, CallSettings)
            // Additional: RejectAccountServiceAsync(string, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/services/[SERVICE]";
            // Make the request
            await accountServicesServiceClient.RejectAccountServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RejectAccountService</summary>
        public void RejectAccountServiceResourceNames()
        {
            // Snippet: RejectAccountService(AccountServiceName, CallSettings)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = AccountServicesServiceClient.Create();
            // Initialize request argument(s)
            AccountServiceName name = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]");
            // Make the request
            accountServicesServiceClient.RejectAccountService(name);
            // End snippet
        }

        /// <summary>Snippet for RejectAccountServiceAsync</summary>
        public async Task RejectAccountServiceResourceNamesAsync()
        {
            // Snippet: RejectAccountServiceAsync(AccountServiceName, CallSettings)
            // Additional: RejectAccountServiceAsync(AccountServiceName, CancellationToken)
            // Create client
            AccountServicesServiceClient accountServicesServiceClient = await AccountServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountServiceName name = AccountServiceName.FromAccountService("[ACCOUNT]", "[SERVICE]");
            // Make the request
            await accountServicesServiceClient.RejectAccountServiceAsync(name);
            // End snippet
        }
    }
}
