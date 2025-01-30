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
    using Google.Shopping.Css.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccountLabelsServiceClientSnippets
    {
        /// <summary>Snippet for ListAccountLabels</summary>
        public void ListAccountLabelsRequestObject()
        {
            // Snippet: ListAccountLabels(ListAccountLabelsRequest, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            ListAccountLabelsRequest request = new ListAccountLabelsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedEnumerable<ListAccountLabelsResponse, AccountLabel> response = accountLabelsServiceClient.ListAccountLabels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLabelsAsync</summary>
        public async Task ListAccountLabelsRequestObjectAsync()
        {
            // Snippet: ListAccountLabelsAsync(ListAccountLabelsRequest, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccountLabelsRequest request = new ListAccountLabelsRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAccountLabelsResponse, AccountLabel> response = accountLabelsServiceClient.ListAccountLabelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLabels</summary>
        public void ListAccountLabels()
        {
            // Snippet: ListAccountLabels(string, string, int?, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<ListAccountLabelsResponse, AccountLabel> response = accountLabelsServiceClient.ListAccountLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLabelsAsync</summary>
        public async Task ListAccountLabelsAsync()
        {
            // Snippet: ListAccountLabelsAsync(string, string, int?, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<ListAccountLabelsResponse, AccountLabel> response = accountLabelsServiceClient.ListAccountLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLabels</summary>
        public void ListAccountLabelsResourceNames()
        {
            // Snippet: ListAccountLabels(AccountName, string, int?, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedEnumerable<ListAccountLabelsResponse, AccountLabel> response = accountLabelsServiceClient.ListAccountLabels(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AccountLabel item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccountLabelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLabel> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccountLabelsAsync</summary>
        public async Task ListAccountLabelsResourceNamesAsync()
        {
            // Snippet: ListAccountLabelsAsync(AccountName, string, int?, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<ListAccountLabelsResponse, AccountLabel> response = accountLabelsServiceClient.ListAccountLabelsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AccountLabel item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccountLabelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AccountLabel item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AccountLabel> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AccountLabel item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLabel</summary>
        public void CreateAccountLabelRequestObject()
        {
            // Snippet: CreateAccountLabel(CreateAccountLabelRequest, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            CreateAccountLabelRequest request = new CreateAccountLabelRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                AccountLabel = new AccountLabel(),
            };
            // Make the request
            AccountLabel response = accountLabelsServiceClient.CreateAccountLabel(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLabelAsync</summary>
        public async Task CreateAccountLabelRequestObjectAsync()
        {
            // Snippet: CreateAccountLabelAsync(CreateAccountLabelRequest, CallSettings)
            // Additional: CreateAccountLabelAsync(CreateAccountLabelRequest, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAccountLabelRequest request = new CreateAccountLabelRequest
            {
                ParentAsAccountName = AccountName.FromAccount("[ACCOUNT]"),
                AccountLabel = new AccountLabel(),
            };
            // Make the request
            AccountLabel response = await accountLabelsServiceClient.CreateAccountLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLabel</summary>
        public void CreateAccountLabel()
        {
            // Snippet: CreateAccountLabel(string, AccountLabel, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            AccountLabel accountLabel = new AccountLabel();
            // Make the request
            AccountLabel response = accountLabelsServiceClient.CreateAccountLabel(parent, accountLabel);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLabelAsync</summary>
        public async Task CreateAccountLabelAsync()
        {
            // Snippet: CreateAccountLabelAsync(string, AccountLabel, CallSettings)
            // Additional: CreateAccountLabelAsync(string, AccountLabel, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accounts/[ACCOUNT]";
            AccountLabel accountLabel = new AccountLabel();
            // Make the request
            AccountLabel response = await accountLabelsServiceClient.CreateAccountLabelAsync(parent, accountLabel);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLabel</summary>
        public void CreateAccountLabelResourceNames()
        {
            // Snippet: CreateAccountLabel(AccountName, AccountLabel, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            AccountLabel accountLabel = new AccountLabel();
            // Make the request
            AccountLabel response = accountLabelsServiceClient.CreateAccountLabel(parent, accountLabel);
            // End snippet
        }

        /// <summary>Snippet for CreateAccountLabelAsync</summary>
        public async Task CreateAccountLabelResourceNamesAsync()
        {
            // Snippet: CreateAccountLabelAsync(AccountName, AccountLabel, CallSettings)
            // Additional: CreateAccountLabelAsync(AccountName, AccountLabel, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccount("[ACCOUNT]");
            AccountLabel accountLabel = new AccountLabel();
            // Make the request
            AccountLabel response = await accountLabelsServiceClient.CreateAccountLabelAsync(parent, accountLabel);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountLabel</summary>
        public void UpdateAccountLabelRequestObject()
        {
            // Snippet: UpdateAccountLabel(UpdateAccountLabelRequest, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            UpdateAccountLabelRequest request = new UpdateAccountLabelRequest
            {
                AccountLabel = new AccountLabel(),
            };
            // Make the request
            AccountLabel response = accountLabelsServiceClient.UpdateAccountLabel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountLabelAsync</summary>
        public async Task UpdateAccountLabelRequestObjectAsync()
        {
            // Snippet: UpdateAccountLabelAsync(UpdateAccountLabelRequest, CallSettings)
            // Additional: UpdateAccountLabelAsync(UpdateAccountLabelRequest, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccountLabelRequest request = new UpdateAccountLabelRequest
            {
                AccountLabel = new AccountLabel(),
            };
            // Make the request
            AccountLabel response = await accountLabelsServiceClient.UpdateAccountLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountLabel</summary>
        public void UpdateAccountLabel()
        {
            // Snippet: UpdateAccountLabel(AccountLabel, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            AccountLabel accountLabel = new AccountLabel();
            // Make the request
            AccountLabel response = accountLabelsServiceClient.UpdateAccountLabel(accountLabel);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccountLabelAsync</summary>
        public async Task UpdateAccountLabelAsync()
        {
            // Snippet: UpdateAccountLabelAsync(AccountLabel, CallSettings)
            // Additional: UpdateAccountLabelAsync(AccountLabel, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountLabel accountLabel = new AccountLabel();
            // Make the request
            AccountLabel response = await accountLabelsServiceClient.UpdateAccountLabelAsync(accountLabel);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountLabel</summary>
        public void DeleteAccountLabelRequestObject()
        {
            // Snippet: DeleteAccountLabel(DeleteAccountLabelRequest, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            DeleteAccountLabelRequest request = new DeleteAccountLabelRequest
            {
                AccountLabelName = AccountLabelName.FromAccountLabel("[ACCOUNT]", "[LABEL]"),
            };
            // Make the request
            accountLabelsServiceClient.DeleteAccountLabel(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountLabelAsync</summary>
        public async Task DeleteAccountLabelRequestObjectAsync()
        {
            // Snippet: DeleteAccountLabelAsync(DeleteAccountLabelRequest, CallSettings)
            // Additional: DeleteAccountLabelAsync(DeleteAccountLabelRequest, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccountLabelRequest request = new DeleteAccountLabelRequest
            {
                AccountLabelName = AccountLabelName.FromAccountLabel("[ACCOUNT]", "[LABEL]"),
            };
            // Make the request
            await accountLabelsServiceClient.DeleteAccountLabelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountLabel</summary>
        public void DeleteAccountLabel()
        {
            // Snippet: DeleteAccountLabel(string, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/labels/[LABEL]";
            // Make the request
            accountLabelsServiceClient.DeleteAccountLabel(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountLabelAsync</summary>
        public async Task DeleteAccountLabelAsync()
        {
            // Snippet: DeleteAccountLabelAsync(string, CallSettings)
            // Additional: DeleteAccountLabelAsync(string, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accounts/[ACCOUNT]/labels/[LABEL]";
            // Make the request
            await accountLabelsServiceClient.DeleteAccountLabelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountLabel</summary>
        public void DeleteAccountLabelResourceNames()
        {
            // Snippet: DeleteAccountLabel(AccountLabelName, CallSettings)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = AccountLabelsServiceClient.Create();
            // Initialize request argument(s)
            AccountLabelName name = AccountLabelName.FromAccountLabel("[ACCOUNT]", "[LABEL]");
            // Make the request
            accountLabelsServiceClient.DeleteAccountLabel(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccountLabelAsync</summary>
        public async Task DeleteAccountLabelResourceNamesAsync()
        {
            // Snippet: DeleteAccountLabelAsync(AccountLabelName, CallSettings)
            // Additional: DeleteAccountLabelAsync(AccountLabelName, CancellationToken)
            // Create client
            AccountLabelsServiceClient accountLabelsServiceClient = await AccountLabelsServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountLabelName name = AccountLabelName.FromAccountLabel("[ACCOUNT]", "[LABEL]");
            // Make the request
            await accountLabelsServiceClient.DeleteAccountLabelAsync(name);
            // End snippet
        }
    }
}
